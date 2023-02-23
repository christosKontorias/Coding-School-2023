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
	public partial class LogInForm : Form {
		public LogInForm() {
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			Hide();
			if (txtUsername.Text == "manager" && txtPassword.Text == "manager") {
				MainMenuForm mainMenuForm = new MainMenuForm(txtUsername.Text);
				mainMenuForm.ShowDialog();
			} else if (txtUsername.Text == "cashier" && txtPassword.Text == "cashier") {
				MainMenuForm mainMenuForm = new MainMenuForm(txtUsername.Text);
				mainMenuForm.ShowDialog();
			} else if (txtUsername.Text == "staff" && txtPassword.Text == "staff") {
				MainMenuForm mainMenuForm = new MainMenuForm(txtUsername.Text);
				mainMenuForm.ShowDialog();
			} else {
				MessageBox.Show("Invalid Username or Password!");
			}
			txtUsername.Clear();
			txtPassword.Clear();
			Show();
		}

		private void btnExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnLogin_MouseEnter(object sender, EventArgs e) {
			btnLogin.BackColor = Color.FromArgb(201, 71, 71);
			btnLogin.ForeColor = Color.White;
			btnLogin.FlatAppearance.BorderColor = Color.Black;
			btnLogin.FlatAppearance.BorderSize = 1;
		}

		private void btnLogin_MouseLeave(object sender, EventArgs e) {
			btnLogin.BackColor = Color.FromArgb(221, 221, 221);
			btnLogin.ForeColor = Color.Black;
			btnLogin.FlatAppearance.BorderSize = 0;
		}

		private void btnExit_MouseEnter(object sender, EventArgs e) {
			btnExit.BackColor = Color.FromArgb(201, 71, 71);
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
