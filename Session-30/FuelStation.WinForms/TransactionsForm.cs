using DevExpress.XtraSpreadsheet.TileLayout;
using FuelStation.Web.Shared.Item;
using FuelStation.Web.Shared.Transaction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.WinForms {
	public partial class TransactionsForm : Form {

		private readonly HttpClient _httpClient;

		public TransactionsForm() {
			InitializeComponent();
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("https://localhost:7136/");
		}
		private void TransactionsForm_Load(object sender, EventArgs e) {
			SetControlProperties();
		}

		private async void SetControlProperties() {
			var transactions = await GetTransactions();
			if (transactions != null) {
				bsTransaction.DataSource = transactions;
				grvTransaction.DataSource = bsTransaction;
			}

			//var transactionLines = await GetTransactionLines();
			//if (transactionLines != null) {
			//	bsTransactionLine.DataSource = transactionLines;
			//	grvTransactionLine.DataSource = bsTransactionLine;
			//}

		}

		//Display Transaction
		private async Task<List<TransactionListDto>> GetTransactions() {
			var response = await _httpClient.GetAsync("transaction");
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
			}
			return null;
		}

		//Display TransactionLine
		//private async Task<List<TransactionListDto>> GetTransactionLines() {
		//	var response = await _httpClient.GetAsync("transactionLine");
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
