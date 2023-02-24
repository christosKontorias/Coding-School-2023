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
			txtPassword.PasswordChar= '*';
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
		private void btnExit_Click_1(object sender, EventArgs e) {
			this.Close();
		}

		private void btnLogin_MouseEnter(object sender, EventArgs e) {
			CustomizeButtonOnMouseEnter(btnLogin);
		}

		private void btnLogin_MouseLeave(object sender, EventArgs e) {
			CustomizeButtonOnMouseLeave(btnLogin);
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
