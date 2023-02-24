using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Web.Shared.Customer;
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
			_= SetControlProperties();
		}

		private async Task SetControlProperties() {

			var customers = await GetCustomers();
			if (customers != null) {
				bsCustomers.DataSource = customers;
				grvCustomers.DataSource = bsCustomers;
			}
		}

		private async Task<List<CustomerListDto>> GetCustomers() {
			var response = await _httpClient.GetAsync("customer");
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<CustomerListDto>>(content);
			}
			return null;
		}

	}
}