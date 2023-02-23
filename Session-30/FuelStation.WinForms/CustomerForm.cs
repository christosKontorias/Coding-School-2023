using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Web.Shared.Customer;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Emit;

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
			GridView view = sender as GridView;
			string name = view.GetRowCellValue(e.RowHandle, colName).ToString();
			string surname = view.GetRowCellValue(e.RowHandle, colSurname).ToString();
			string cardNumber = view.GetRowCellValue(e.RowHandle, colCardNumber).ToString();
			// Name Cell
			if (name == null) {
				e.Valid = false;
				view.SetColumnError(colName, "Insert Valid Name");
			} else if (name == " ") {
				e.Valid = false;
				view.SetColumnError(colName, "Fill Name cell");
			}
			// Surname Cell
			if (surname == null) {
				e.Valid = false;
				view.SetColumnError(colSurname, "Insert Valid Surname");
			} else if (surname == " ") {
				e.Valid = false;
				view.SetColumnError(colSurname, "Fill Surname cell");
			}
			// CardNumber Cell
			if (cardNumber == null) {
				e.Valid = false;
				view.SetColumnError(colCardNumber, "Insert Valid Card Number");
			} else if (surname == " ") {
				e.Valid = false;
				view.SetColumnError(colCardNumber, "Fill Card Number cell");
			}

			if (e.Valid) {
				view.ClearColumnErrors();
			}
		}

		private void gridViewCustomers_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
			ColumnView view = sender as ColumnView;
			GridColumn column = (e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn;
			String cellVal = e.Value as String;
			if (column.FieldName == "Name") {
				// colName changed
				if (cellVal == null) {
					e.Valid = false;
					view.SetColumnError(colName, "Insert Valid Name");
				} else if (cellVal == " ") {
					e.Valid = false;
					view.SetColumnError(colName, "Fill Code Name");
				}
			} else if (column.FieldName == "Surname") {
				if (cellVal == null) {
					e.Valid = false;
					view.SetColumnError(colSurname, "Insert Valid Surname");
				} else if (cellVal == "") {
					e.Valid = false;
					view.SetColumnError(colSurname, "Fill Surname cell");
				}
			}
		}
	}
}