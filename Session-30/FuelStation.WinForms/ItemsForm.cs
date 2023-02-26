using FuelStation.Model;
using FuelStation.Web.Shared.Customer;
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
				grdItems.DataSource = bsItems;
			}
		}

		//Display Items
		private async Task<List<ItemListDto>> GetItems() {
			var response = await _httpClient.GetFromJsonAsync<List<ItemListDto>>("item");
			return response;
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
            MessageBox.Show("Items Updated Successfully!");
        }

        private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		//Customize Buttons
		private void btnCreate_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnCreate);
		}

		private void btnCreate_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnCreate);
		}

		private void btnSave_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnSave);
		}

		private void btnSave_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnSave);
		}

		private void btnDelete_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnDelete);
		}

		private void btnDelete_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnDelete);
		}

		private void btnUpdate_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnUpdate);
		}

		private void btnUpdate_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnUpdate);
		}

		private void btnClose_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnClose);
		}

		private void btnClose_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnClose);
		}

		private void CustomizeButtonOnMouseEnter(Button button) {
			button.BackColor = Color.FromArgb(208, 171, 171);
			button.ForeColor = Color.White;
			button.FlatAppearance.BorderColor = Color.Black;
			button.FlatAppearance.BorderSize = 2;
		}

		private void CustomizeButtonOnMouseLeave(Button button) {
			button.BackColor = Color.FromArgb(221, 221, 221);
			button.ForeColor = Color.Black;
			button.FlatAppearance.BorderSize = 0;
		}
	}
}
