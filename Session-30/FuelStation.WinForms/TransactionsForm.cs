using FuelStation.EF.Repositories;
using FuelStation.Web.Server.Controllers;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Employee;
using FuelStation.Web.Shared.Item;
using FuelStation.Web.Shared.Transaction;
using FuelStation.Web.Shared.TransactionLine;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.WinForms {
	public partial class TransactionsForm : Form {

		private readonly HttpClient _httpClient;
		//private readonly TransactionRepo _transactionRepo;

		public TransactionsForm() {
			InitializeComponent();
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("https://localhost:7136/");
			//_transactionRepo = new TransactionRepo();

		}
		private void TransactionsForm_Load(object sender, EventArgs e) {
			SetControlProperties();
		}

		private async void SetControlProperties() {
			//var transactions = _transactionRepo.GetAll();
			//grvTransaction.DataSource = transactions;


		}

		//Display Transaction
		//private async Task<List<TransactionListDto>> GetAllTransactions() {
		//	var response = await _httpClient.GetAsync("transaction");
		//	if (response.IsSuccessStatusCode) {
		//		var content = await response.Content.ReadAsStringAsync();
		//		return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
		//	}
		//	return null;
		//}


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
