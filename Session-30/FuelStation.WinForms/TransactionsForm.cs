using DevExpress.XtraSpreadsheet.TileLayout;
using FuelStation.Model;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Item;
using FuelStation.Web.Shared.Transaction;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace FuelStation.WinForms {
	public partial class TransactionsForm : Form {

		private readonly HttpClient _httpClient;


		public TransactionsForm() {
			InitializeComponent();
			_httpClient = new HttpClient();

		}
		private async void TransactionsForm_Load(object sender, EventArgs e) {
			var transactions = await GetTransactions();
			bsTransactions.DataSource = transactions.ToList();
		}


		private async Task<IEnumerable<TransactionListDto>> GetTransactions() {
		 await _httpClient.GetAsync("https://localhost:7136/transaction");
			var transactions = await _httpClient.GetFromJsonAsync<List<TransactionListDto>>("transaction");
			return transactions;
		}




		private void btnCreate_Click(object sender, EventArgs e) {
			bsTransactions.Add(new TransactionListDto());
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
