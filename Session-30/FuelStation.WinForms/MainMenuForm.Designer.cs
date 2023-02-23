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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
			this.btnCustomer = new System.Windows.Forms.Button();
			this.btnItem = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnTransactions = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCustomer
			// 
			this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnCustomer.FlatAppearance.BorderSize = 0;
			this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomer.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCustomer.Location = new System.Drawing.Point(59, 335);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(110, 40);
			this.btnCustomer.TabIndex = 0;
			this.btnCustomer.Text = "Customers";
			this.btnCustomer.UseVisualStyleBackColor = false;
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			this.btnCustomer.MouseEnter += new System.EventHandler(this.btnCustomer_MouseEnter);
			this.btnCustomer.MouseLeave += new System.EventHandler(this.btnCustomer_MouseLeave);
			// 
			// btnItem
			// 
			this.btnItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnItem.FlatAppearance.BorderSize = 0;
			this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnItem.Location = new System.Drawing.Point(175, 335);
			this.btnItem.Name = "btnItem";
			this.btnItem.Size = new System.Drawing.Size(110, 40);
			this.btnItem.TabIndex = 1;
			this.btnItem.Text = "Items";
			this.btnItem.UseVisualStyleBackColor = false;
			this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
			this.btnItem.MouseEnter += new System.EventHandler(this.btnItem_MouseEnter);
			this.btnItem.MouseLeave += new System.EventHandler(this.btnItem_MouseLeave);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit.Location = new System.Drawing.Point(175, 381);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(110, 40);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
			this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
			// 
			// btnTransactions
			// 
			this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactions.FlatAppearance.BorderSize = 0;
			this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactions.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactions.Location = new System.Drawing.Point(291, 335);
			this.btnTransactions.Name = "btnTransactions";
			this.btnTransactions.Size = new System.Drawing.Size(110, 40);
			this.btnTransactions.TabIndex = 3;
			this.btnTransactions.Text = "Transactions";
			this.btnTransactions.UseVisualStyleBackColor = false;
			this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
			this.btnTransactions.MouseEnter += new System.EventHandler(this.btnTransactions_MouseEnter);
			this.btnTransactions.MouseLeave += new System.EventHandler(this.btnTransactions_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(80, 59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 250);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(101, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 47);
			this.label1.TabIndex = 5;
			this.label1.Text = "Fuel Station Menu";
			// 
			// MainMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(468, 447);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnTransactions);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnItem);
			this.Controls.Add(this.btnCustomer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainMenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fuel Station Menu";
			this.Load += new System.EventHandler(this.MainMenuForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnCustomer;
		private Button btnItem;
		private Button btnExit;
		private Button btnTransactions;
		private PictureBox pictureBox1;
		private Label label1;
	}
}