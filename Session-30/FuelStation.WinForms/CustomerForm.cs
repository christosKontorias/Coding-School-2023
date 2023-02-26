using FuelStation.Web.Shared.Customer;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.WinForms {
	public partial class CustomerForm : Form {

		private readonly HttpClient _httpClient;

		public CustomerForm() {
			InitializeComponent();
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("https://localhost:7136/");
		}

		private void CustomerForm_Load(object sender, EventArgs e) {
			SetControlProperties();
		}

		private async Task SetControlProperties() {
			var customers = await GetCustomers();
			if (customers != null) {
				bsCustomers.DataSource = customers;
				grdCustomers.DataSource = bsCustomers;
			}
		}
		//Display Customers 
		private async Task<List<CustomerListDto>> GetCustomers() {
			var response = await _httpClient.GetFromJsonAsync<List<CustomerListDto>>("customer");
			return response;
		}

		//Save
		private async Task OnSave() {
			HttpResponseMessage response = null;
			CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
			if (customer.Id == 0) {
				response = await _httpClient.PostAsJsonAsync("customer", customer);
			} else {
				response = await _httpClient.PutAsJsonAsync("customer", customer);
			}

			if (response.IsSuccessStatusCode) {
				MessageBox.Show("Customer saved successfully!");
			} else {
				MessageBox.Show("Error saving customer.");
			}
		}

		//Delete
		private async Task OnDelete() {
			HttpResponseMessage response = null;
			CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
			if (customer.Id != null) {
				response = await _httpClient.DeleteAsync($"customer/{customer.Id}");
				if (response.IsSuccessStatusCode) {
					bsCustomers.RemoveCurrent();
					MessageBox.Show("Customer Deleted Successfully!");
				} else {
					MessageBox.Show("Error deleting customer.");
				}
			}
		}

		private void btnCreate_Click(object sender, EventArgs e) {
			bsCustomers.Add(new CustomerListDto());
		}

		private void btnSave_Click(object sender, EventArgs e) {
			OnSave();
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			OnDelete();
		}

		private void btnUpdate_Click(object sender, EventArgs e) {
			SetControlProperties();
            MessageBox.Show("Customers Updated Successfully!");
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