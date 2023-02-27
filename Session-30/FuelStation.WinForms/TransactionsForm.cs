using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Employee;
using FuelStation.Web.Shared.Item;
using FuelStation.Web.Shared.Transaction;
using FuelStation.Web.Shared.TransactionLine;
using System.Data;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.WinForms {
	public partial class TransactionsForm : Form {

        private readonly HttpClient _httpClient;
		private readonly List<CustomerListDto> _customers;
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
					var _customers = await GetCustomers();
					var _employees = await GetEmployees();
                    var _items = await GetItems();


					if (transactions != null) {
						bsTransactions.DataSource = transactions;

						bsTransactionLines.DataSource = bsTransactions;
						bsTransactionLines.DataMember = "TransactionLines";

						grdTransactions.DataSource = bsTransactions;
						grdTransactionLine.DataSource = bsTransactionLines;

						//Customers
						bsCustomers.DataSource = _customers;
						repCustomers.DataSource = bsCustomers;
						repCustomers.ValueMember = "Id";
						repCustomers.DisplayMember = "CardNumber";

						//Customers
						bsEmployees.DataSource = _employees;
						repEmployees.DataSource = bsEmployees;
						repEmployees.ValueMember = "Id";
						repEmployees.DisplayMember = "Surname";

						//Items
						bsItems.DataSource = _items;
						repItems.DataSource = bsItems;
						repItems.ValueMember = "Id";
						repItems.DisplayMember = "ItemType";

						//Total Value
						repTotalValue.DataSource = bsTransactionLines;
						repTotalValue.ValueMember = "TotalValue";
						repTotalValue.DisplayMember = "TotalValue";


					} else {
                        MessageBox.Show("Failed to retrieve transactions from server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		//Search CardNumber
		private void txtSearchCardNumber_TextChanged(object sender, EventArgs e) {

		}
	


        //Display Transaction
        private async Task<List<TransactionListDto>> GetTransactions() {
            var response = await _httpClient.GetFromJsonAsync<List<TransactionListDto>>("transaction");
            return response;
        }

		//Display Customers
		private async Task<List<CustomerListDto>> GetCustomers() {
			var response = await _httpClient.GetFromJsonAsync<List<CustomerListDto>>("customer");
			return response;
		}

		//Display Employess
		private async Task<List<EmployeeListDto>> GetEmployees() {
			var response = await _httpClient.GetFromJsonAsync<List<EmployeeListDto>>("employee");
			return response;
		}

		//Display Items
		private async Task<List<ItemListDto>> GetItems() {
			var response = await _httpClient.GetFromJsonAsync<List<ItemListDto>>("item");
			return response;
		}

		// Transaction Save
		private async Task OnSave() {
			HttpResponseMessage response = null;
			TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;

			// Check if the total value is greater than 50 Euros

				if (transaction.TotalValue > 50) {
					transaction.PaymentMethod = PaymentMethod.Cash;
				}


			//Save Transaction
			if (transaction.Id == 0) {
				response = await _httpClient.PostAsJsonAsync("transaction", transaction);
			} else {
				response = await _httpClient.PutAsJsonAsync("transaction", transaction);
			}

			if (response.IsSuccessStatusCode) {
				MessageBox.Show("Transaction saved successfully!");
			} else {
				MessageBox.Show("Error saving transaction.");
			}
		}

		// Transaction Delete
		private async Task OnDelete() {
			HttpResponseMessage response = null;
			TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;
			if (transaction.Id != null) {
				response = await _httpClient.DeleteAsync($"transaction/{transaction.Id}");
				if (response.IsSuccessStatusCode) {
					bsTransactions.RemoveCurrent();
					MessageBox.Show("Transaction Deleted Successfully!");
				} else {
					MessageBox.Show("Error deleting transaction.");
				}
			}
		}

		//Transaction Buttons
		private void btnTransactionCreate_Click(object sender, EventArgs e) {
			bsTransactions.Add(new TransactionListDto());
		}
		private void btnTransactionSave_Click(object sender, EventArgs e) {
			OnSave();
		}

		private void btnTransactionDelete_Click(object sender, EventArgs e) {
			OnDelete();
		}


		// TransactionLine Save
		private async Task OnTransactionLineSave() {
			HttpResponseMessage response = null;
			TransactionLineEditDto transactionLine = (TransactionLineEditDto)bsTransactionLines.Current;
			if (transactionLine.Id == 0) {
				response = await _httpClient.PostAsJsonAsync("transactionLine", transactionLine);
			} else {
				response = await _httpClient.PutAsJsonAsync("transactionLine", transactionLine);
			}

			if (response.IsSuccessStatusCode) {
				MessageBox.Show("Transaction Line saved successfully.");
			} else {
				MessageBox.Show("Error saving transaction Line.");
			}
		}

		// TransactionLine Delete
		private async Task OnTransactionLineDelete() {
			HttpResponseMessage response = null;
			TransactionLineEditDto transactionLine = (TransactionLineEditDto)bsTransactionLines.Current;
			if (transactionLine.Id != null) {
				response = await _httpClient.DeleteAsync($"transactionLine/{transactionLine.Id}");
				if (response.IsSuccessStatusCode) {
					bsTransactionLines.RemoveCurrent();
					MessageBox.Show("Transaction Line saved successfully.");
				} else {
					MessageBox.Show("Error saving transaction Line.");
				}
			}
		}
		//TransactionLine Buttons
		private void btnTransactionLineCreate_Click(object sender, EventArgs e) {
			bsTransactionLines.Add(new TransactionLineListDto());
		}

		private void btnTransactionLineSave_Click(object sender, EventArgs e) {
			OnTransactionLineSave();
		}

		private void btnTransactionLineDelete_Click(object sender, EventArgs e) {
			OnTransactionLineDelete();   
		}

		//Update Close Buttons
		private void btnTransactionUpdate_Click(object sender, EventArgs e) {
			SetControlProperties();
			MessageBox.Show("Transactions Updated Successfully!");
		}

		private void btnTransactionClose_Click(object sender, EventArgs e) {
            this.Close();
		}

		//Calculations
		private decimal CalculateNetValue(TransactionLineListDto transactionLine) {
			return transactionLine.Quantity * transactionLine.ItemPrice;
		}

		private decimal CalculateDiscountValue(TransactionLineListDto transactionLine) {
			return transactionLine.NetValue * (transactionLine.DiscountPercent / 100);
		}

		private decimal CalculateTotalValue(TransactionLineListDto transactionLine) {
			return transactionLine.NetValue - transactionLine.DiscountValue;
		}

		//Update TransactionLine Rows Calculations 
		private void gridViewTransactionLine_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {

			//Pick the Item Price of Selected Item
			if (e.Column.FieldName == "ItemId") {
				int itemId = Convert.ToInt32(e.Value);
				Item selectedItem = bsItems.List.OfType<Item>().FirstOrDefault(x => x.Id == itemId);
				if (selectedItem != null) {
					gridViewTransactionLine.SetRowCellValue(e.RowHandle, "ItemPrice", selectedItem.Price);
				}
			}

			if (e.Column.FieldName == "Quantity" || e.Column.FieldName == "ItemPrice" || e.Column.FieldName == "DiscountPercent") {
				TransactionLineListDto transactionLine = (TransactionLineListDto)gridViewTransactionLine.GetRow(e.RowHandle);

				decimal netValue = CalculateNetValue(transactionLine);
				decimal discountValue = CalculateDiscountValue(transactionLine);
				decimal totalValue = CalculateTotalValue(transactionLine);

				gridViewTransactionLine.SetRowCellValue(e.RowHandle, "NetValue", netValue);
				gridViewTransactionLine.SetRowCellValue(e.RowHandle, "DiscountValue", discountValue);
				gridViewTransactionLine.SetRowCellValue(e.RowHandle, "TotalValue", totalValue);

				decimal totalTransactionValue = 0;
				for (int i = 0; i < gridViewTransactionLine.RowCount; i++) {
					TransactionLineListDto currentTransactionLine = (TransactionLineListDto)gridViewTransactionLine.GetRow(i);
					totalTransactionValue += currentTransactionLine.TotalValue;
				}
				gridViewTransactions.SetRowCellValue(0, "TotalValue", totalTransactionValue);
			}
		}






		//Customize Buttons
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

		private void btnTransactionCreate_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactionCreate);
		}
		private void btnTransactionCreate_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactionCreate);
		}

		private void btnTransactionSave_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactionSave);
		}

		private void btnTransactionSave_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactionSave);
		}

		private void btnTransactionDelete_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactionDelete);
		}

		private void btnTransactionDelete_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactionDelete);
		}

		private void btnTransactionUpdate_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactionUpdate);
		}

		private void btnTransactionUpdate_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactionUpdate);
		}

		private void btnTransactionClose_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactionClose);
		}

		private void btnTransactionClose_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactionClose);
		}

		private void btnTransactionLineCreate_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactionLineCreate);
		}

		private void btnTransactionLineCreate_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactionLineCreate);
		}

		private void btnTransactionLineSave_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactionLineSave);
		}

		private void btnTransactionLineSave_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactionLineSave);
		}

		private void btnTransactionLineDelete_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactionLineDelete);

		}

		private void btnTransactionLineDelete_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactionLineDelete);
		}
	}
}
