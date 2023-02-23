using FuelStation.Web.Shared.Customer;
using Newtonsoft.Json;
using System.Net.Http;

namespace FuelStation.WinForms {
	public partial class CustomerForm : Form {

		private readonly HttpClient _client;

		public CustomerForm() {
			InitializeComponent();
			_client = new HttpClient();
			_client.BaseAddress = new Uri("https://localhost:7136/");
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

		private async Task<List<CustomerListDto>> GetCustomers() {
			var response = await _client.GetAsync("customer");
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<CustomerListDto>>(content);
			}
			return null;
		}

		private void gridViewCustomers_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {

		}

		private void gridViewCustomers_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {

		}
	}
}