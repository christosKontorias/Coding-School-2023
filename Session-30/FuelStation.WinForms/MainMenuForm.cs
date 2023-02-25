using FuelStation.Web.Shared.Customer;
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

		string username;
		public MainMenuForm(string username) {
			InitializeComponent();
			this.username = username;
		}
		private void MainMenuForm_Load(object sender, EventArgs e) {
			if (username == "cashier") {
				btnItem.Hide();
			} else if (username == "staff") {
				btnCustomer.Hide();
				btnTransactions.Hide();
			}
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

		private void btnCustomer_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnCustomer);
		}

		private void btnCustomer_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnCustomer);
		}

		private void btnItem_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnItem);
		}

		private void btnItem_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnItem);
		}

		private void btnTransactions_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnTransactions);
		}

		private void btnTransactions_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnTransactions);
		}

		private void btnExit_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnExit);
		}

		private void btnExit_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnExit);
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
