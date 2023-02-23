namespace FuelStation.WinForms {
	partial class CustomerForm {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
			this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerID,
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerCardNumber});
			this.dataGridView1.Location = new System.Drawing.Point(258, 86);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(442, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// colCustomerID
			// 
			this.colCustomerID.DataPropertyName = "CustomerID";
			this.colCustomerID.HeaderText = "CustomerID";
			this.colCustomerID.Name = "colCustomerID";
			this.colCustomerID.Visible = false;
			// 
			// colCustomerName
			// 
			this.colCustomerName.DataPropertyName = "Name";
			this.colCustomerName.HeaderText = "Name";
			this.colCustomerName.Name = "colCustomerName";
			// 
			// colCustomerSurname
			// 
			this.colCustomerSurname.DataPropertyName = "Surname";
			this.colCustomerSurname.HeaderText = "Surname";
			this.colCustomerSurname.Name = "colCustomerSurname";
			// 
			// colCustomerCardNumber
			// 
			this.colCustomerCardNumber.DataPropertyName = "CardNumber";
			this.colCustomerCardNumber.HeaderText = "CardNumber";
			this.colCustomerCardNumber.Name = "colCustomerCardNumber";
			// 
			// CustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CustomerForm";
			this.Text = "Customers";
			this.Load += new System.EventHandler(this.CustomerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridView1;
		private BindingSource bsCustomers;
		private DataGridViewTextBoxColumn colCustomerID;
		private DataGridViewTextBoxColumn colCustomerName;
		private DataGridViewTextBoxColumn colCustomerSurname;
		private DataGridViewTextBoxColumn colCustomerCardNumber;
	}
}