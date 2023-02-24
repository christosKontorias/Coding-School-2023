using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Item;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;

namespace FuelStation.WinForms {
	public partial class ItemsForm : Form {

		private readonly HttpClient _httpClient;

		public ItemsForm() {
			InitializeComponent();
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("https://localhost:7136/");
		}

		private void ItemsForm_Load(object sender, EventArgs e) {
			SetControlProperties();
		}
		
		private async void SetControlProperties() {
			var items = await GetItems();
			if (items != null) {
				bsItems.DataSource = items;
				grvItems.DataSource = bsItems;
			}
		}

		//Display Items
		private async Task<List<ItemListDto>> GetItems() {
			var response = await _httpClient.GetAsync("item");
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
			}
			return null;
		}

		//Save
		private async Task OnSave() {
			HttpResponseMessage response = null;
			ItemListDto item = (ItemListDto)bsItems.Current;
			if (item.Id == 0) {
				response = await _httpClient.PostAsJsonAsync("item", item);
			} else {
				response = await _httpClient.PutAsJsonAsync("item", item);
			}

			if (response.IsSuccessStatusCode) {
				MessageBox.Show("Item saved successfully!");
			} else {
				MessageBox.Show("Error saving item.");
			}
		}

		//Delete
		private async Task OnDelete() {
			HttpResponseMessage response = null;
			ItemListDto item = (ItemListDto)bsItems.Current;
			if (item.Id != null) {
				response = await _httpClient.DeleteAsync($"item/{item.Id}");
				if (response.IsSuccessStatusCode) {
					bsItems.RemoveCurrent();
					MessageBox.Show("Item Deleted Successfully!");
				} else {
					MessageBox.Show("Error deleting item.");
				}
			}
		}

		private void btnCreate_Click(object sender, EventArgs e) {
			bsItems.Add(new ItemListDto());
		}

		private void btnSave_Click(object sender, EventArgs e) {
			OnSave();
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			OnDelete();
		}

		private void btnUpdate_Click(object sender, EventArgs e) {
			SetControlProperties();
		}

	}
}
