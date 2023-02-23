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
			btnCustomer.BackColor = Color.FromArgb(208, 171, 171);
			btnCustomer.ForeColor = Color.White;
			btnCustomer.FlatAppearance.BorderColor = Color.Black;
			btnCustomer.FlatAppearance.BorderSize = 2;
		}

		private void btnCustomer_MouseLeave(object sender, EventArgs e) {
			btnCustomer.BackColor = Color.FromArgb(221, 221, 221);
			btnCustomer.ForeColor = Color.Black;
			btnCustomer.FlatAppearance.BorderSize = 0;
		}

		private void btnItem_MouseEnter(object sender, EventArgs e) {
			btnItem.BackColor = Color.FromArgb(208, 171, 171);
			btnItem.ForeColor = Color.White;
			btnItem.FlatAppearance.BorderColor = Color.Black;
			btnItem.FlatAppearance.BorderSize = 2;
		}

		private void btnItem_MouseLeave(object sender, EventArgs e) {
			btnItem.BackColor = Color.FromArgb(221, 221, 221);
			btnItem.ForeColor = Color.Black;
			btnItem.FlatAppearance.BorderSize = 0;
		}

		private void btnTransactions_MouseEnter(object sender, EventArgs e) {
			btnTransactions.BackColor = Color.FromArgb(208, 171, 171);
			btnTransactions.ForeColor = Color.White;
			btnTransactions.FlatAppearance.BorderColor = Color.Black;
			btnTransactions.FlatAppearance.BorderSize = 1;
		}

		private void btnTransactions_MouseLeave(object sender, EventArgs e) {
			btnTransactions.BackColor = Color.FromArgb(221, 221, 221);
			btnTransactions.ForeColor = Color.Black;
			btnTransactions.FlatAppearance.BorderSize = 0;
		}

		private void btnExit_MouseEnter(object sender, EventArgs e) {
			btnExit.BackColor = Color.FromArgb(208, 171, 171);
			btnExit.ForeColor = Color.White;
			btnExit.FlatAppearance.BorderColor = Color.Black;
			btnExit.FlatAppearance.BorderSize = 2;
		}

		private void btnExit_MouseLeave(object sender, EventArgs e) {
			btnExit.BackColor = Color.FromArgb(221, 221, 221);
			btnExit.ForeColor = Color.Black;
			btnExit.FlatAppearance.BorderSize = 0;
		}
	}
}
