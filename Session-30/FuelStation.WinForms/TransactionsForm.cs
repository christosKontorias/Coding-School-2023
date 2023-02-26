using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.UI;
using DevExpress.XtraScheduler.Outlook.Interop;
using DevExpress.XtraSpreadsheet.TileLayout;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Client.Authentication;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Employee;
using FuelStation.Web.Shared.Item;
using FuelStation.Web.Shared.Transaction;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace FuelStation.WinForms {
    public partial class TransactionsForm : Form {

        private readonly HttpClient _httpClient;
        private readonly List<Item> _items = new();
        public TransactionsForm() {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7136/");

        }

        private async void TransactionsForm_Load(object sender, EventArgs e) {
            SetControlProperties();
        }



        private async Task SetControlProperties() {
            try {
                using (var httpClient = new HttpClient()) {
                    var transactions = await GetTransactions();
                    var _items = await GetItems();

					if (transactions != null) {
                        bsTransactions.DataSource = transactions;
						
						bsTransactionLines.DataSource = bsTransactions;
						bsTransactionLines.DataMember = "TransactionLines";

						grdTransactions.DataSource = bsTransactions;
						grdTransactionLine.DataSource = bsTransactionLines;

                        bsItems.DataSource = _items;
                        repItems.DataSource = bsItems;
                        repItems.ValueMember = "ItemId";
                        repItems.DisplayMember = "Code";
					} else {
                        MessageBox.Show("Failed to retrieve transactions from server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Display Transaction
        private async Task<List<TransactionListDto>> GetTransactions() {
            var response = await _httpClient.GetFromJsonAsync<List<TransactionListDto>>("transaction");
            return response;
        }

		//Display Items
		private async Task<List<ItemListDto>> GetItems() {
			var response = await _httpClient.GetFromJsonAsync<List<ItemListDto>>("item");
			return response;
		}


		//Buttons
		private void btnCreate_Click(object sender, EventArgs e) {
            bsTransactions.Add(new TransactionListDto());
        }
        private void btnSave_Click(object sender, EventArgs e) {
            //OnSave();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            //OnDelete();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            SetControlProperties();
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
