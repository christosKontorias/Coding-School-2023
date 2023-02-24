using FuelStation.Web.Shared.Item;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;

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

		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		//Customize Buttons
		private void btnCreate_MouseEnter(object sender, EventArgs e) {
			btnCreate.BackColor = Color.FromArgb(208, 171, 171);
			btnCreate.ForeColor = Color.White;
			btnCreate.FlatAppearance.BorderColor = Color.Black;
			btnCreate.FlatAppearance.BorderSize = 2;
		}

		private void btnCreate_MouseLeave(object sender, EventArgs e) {
			btnCreate.BackColor = Color.FromArgb(221, 221, 221);
			btnCreate.ForeColor = Color.Black;
			btnCreate.FlatAppearance.BorderSize = 0;
		}

		private void btnSave_MouseEnter(object sender, EventArgs e) {
			btnSave.BackColor = Color.FromArgb(208, 171, 171);
			btnSave.ForeColor = Color.White;
			btnSave.FlatAppearance.BorderColor = Color.Black;
			btnSave.FlatAppearance.BorderSize = 2;
		}

		private void btnSave_MouseLeave(object sender, EventArgs e) {
			btnSave.BackColor = Color.FromArgb(221, 221, 221);
			btnSave.ForeColor = Color.Black;
			btnSave.FlatAppearance.BorderSize = 0;
		}

		private void btnDelete_MouseEnter(object sender, EventArgs e) {
			btnDelete.BackColor = Color.FromArgb(208, 171, 171);
			btnDelete.ForeColor = Color.White;
			btnDelete.FlatAppearance.BorderColor = Color.Black;
			btnDelete.FlatAppearance.BorderSize = 2;
		}

		private void btnDelete_MouseLeave(object sender, EventArgs e) {
			btnDelete.BackColor = Color.FromArgb(221, 221, 221);
			btnDelete.ForeColor = Color.Black;
			btnDelete.FlatAppearance.BorderSize = 0;
		}

		private void btnUpdate_MouseEnter(object sender, EventArgs e) {
			btnUpdate.BackColor = Color.FromArgb(208, 171, 171);
			btnUpdate.ForeColor = Color.White;
			btnUpdate.FlatAppearance.BorderColor = Color.Black;
			btnUpdate.FlatAppearance.BorderSize = 2;
		}

		private void btnUpdate_MouseLeave(object sender, EventArgs e) {
			btnUpdate.BackColor = Color.FromArgb(221, 221, 221);
			btnUpdate.ForeColor = Color.Black;
			btnUpdate.FlatAppearance.BorderSize = 0;
		}

		private void btnClose_MouseEnter(object sender, EventArgs e) {
			btnClose.BackColor = Color.FromArgb(208, 171, 171);
			btnClose.ForeColor = Color.White;
			btnClose.FlatAppearance.BorderColor = Color.Black;
			btnClose.FlatAppearance.BorderSize = 2;
		}

		private void btnClose_MouseLeave(object sender, EventArgs e) {
			btnClose.BackColor = Color.FromArgb(221, 221, 221);
			btnClose.ForeColor = Color.Black;
			btnClose.FlatAppearance.BorderSize = 0;
		}
	}
}
