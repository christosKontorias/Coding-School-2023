namespace FuelStation.WinForms {
	partial class MainMenuForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnCustomer = new System.Windows.Forms.Button();
			this.btnItem = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnTransactions = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCustomer
			// 
			this.btnCustomer.Location = new System.Drawing.Point(346, 122);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(96, 40);
			this.btnCustomer.TabIndex = 0;
			this.btnCustomer.Text = "Customers";
			this.btnCustomer.UseVisualStyleBackColor = true;
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			// 
			// btnItem
			// 
			this.btnItem.Location = new System.Drawing.Point(346, 168);
			this.btnItem.Name = "btnItem";
			this.btnItem.Size = new System.Drawing.Size(96, 40);
			this.btnItem.TabIndex = 1;
			this.btnItem.Text = "Items";
			this.btnItem.UseVisualStyleBackColor = true;
			this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(346, 260);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(96, 40);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnTransactions
			// 
			this.btnTransactions.Location = new System.Drawing.Point(346, 214);
			this.btnTransactions.Name = "btnTransactions";
			this.btnTransactions.Size = new System.Drawing.Size(96, 40);
			this.btnTransactions.TabIndex = 3;
			this.btnTransactions.Text = "Transactions";
			this.btnTransactions.UseVisualStyleBackColor = true;
			this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
			// 
			// MainMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTransactions);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnItem);
			this.Controls.Add(this.btnCustomer);
			this.Name = "MainMenuForm";
			this.Text = "Fuel Station";
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnCustomer;
		private Button btnItem;
		private Button btnExit;
		private Button btnTransactions;
	}
}