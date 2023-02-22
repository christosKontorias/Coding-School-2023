using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.WinForms {
	public partial class MainMenuForm : Form {
		public MainMenuForm() {
			InitializeComponent();
		}

		private void btnCustomer_Click(object sender, EventArgs e) {
			CustomerForm customerForm = new CustomerForm();
			customerForm.ShowDialog();
		}

		private void btnItem_Click(object sender, EventArgs e) {
			ItemsForm itemsForm = new ItemsForm();
			itemsForm.ShowDialog();
		}
		private void btnTransactions_Click(object sender, EventArgs e) {
			TransactionsForm transactionsForm = new TransactionsForm();
			transactionsForm.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e) {
			this.Close();
		}

	}
}
