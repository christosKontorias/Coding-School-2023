using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Model;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Item;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text;

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
				grvCustomers.DataSource = bsCustomers;
			}
		}
		//Display Customers 
		private async Task<List<CustomerListDto>> GetCustomers() {
			var response = await _httpClient.GetAsync("customer");
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<CustomerListDto>>(content);
			}
			return null;
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

		}
	}
}