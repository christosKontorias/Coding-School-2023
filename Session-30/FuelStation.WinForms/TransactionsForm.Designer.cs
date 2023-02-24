namespace FuelStation.WinForms {
	partial class TransactionsForm {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.grvTransaction = new DevExpress.XtraGrid.GridControl();
			this.gridViewTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.grvTransactionLine = new DevExpress.XtraGrid.GridControl();
			this.gridViewTransactionLine = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
			this.bsTransactionLine = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransaction)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactionLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(301, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 47);
			this.label1.TabIndex = 6;
			this.label1.Text = "Transaction";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(271, 292);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(249, 47);
			this.label2.TabIndex = 7;
			this.label2.Text = "Transaction Line";
			// 
			// grvTransaction
			// 
			this.grvTransaction.Location = new System.Drawing.Point(12, 59);
			this.grvTransaction.MainView = this.gridViewTransaction;
			this.grvTransaction.Name = "grvTransaction";
			this.grvTransaction.Size = new System.Drawing.Size(780, 230);
			this.grvTransaction.TabIndex = 8;
			this.grvTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransaction});
			// 
			// gridViewTransaction
			// 
			this.gridViewTransaction.GridControl = this.grvTransaction;
			this.gridViewTransaction.Name = "gridViewTransaction";
			this.gridViewTransaction.OptionsView.ShowGroupPanel = false;
			// 
			// grvTransactionLine
			// 
			this.grvTransactionLine.Location = new System.Drawing.Point(12, 342);
			this.grvTransactionLine.MainView = this.gridViewTransactionLine;
			this.grvTransactionLine.Name = "grvTransactionLine";
			this.grvTransactionLine.Size = new System.Drawing.Size(780, 230);
			this.grvTransactionLine.TabIndex = 9;
			this.grvTransactionLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLine});
			// 
			// gridViewTransactionLine
			// 
			this.gridViewTransactionLine.GridControl = this.grvTransactionLine;
			this.gridViewTransactionLine.Name = "gridViewTransactionLine";
			this.gridViewTransactionLine.OptionsView.ShowGroupPanel = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.Location = new System.Drawing.Point(575, 598);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(110, 40);
			this.btnClose.TabIndex = 14;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnUpdate.Location = new System.Drawing.Point(459, 598);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(110, 40);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
			this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.Location = new System.Drawing.Point(343, 598);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 40);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
			this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.Location = new System.Drawing.Point(227, 598);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(110, 40);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
			this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnCreate.FlatAppearance.BorderSize = 0;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCreate.Location = new System.Drawing.Point(111, 598);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(110, 40);
			this.btnCreate.TabIndex = 10;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.MouseEnter += new System.EventHandler(this.btnCreate_MouseEnter);
			this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
			// 
			// TransactionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 680);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.grvTransactionLine);
			this.Controls.Add(this.grvTransaction);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TransactionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transactions";
			this.Load += new System.EventHandler(this.TransactionsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransaction)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactionLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactionLine)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private Button btnClose;
		private Button btnUpdate;
		private Button btnDelete;
		private Button btnSave;
		private Button btnCreate;
		private DevExpress.XtraGrid.GridControl grvTransaction;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransaction;
		private DevExpress.XtraGrid.GridControl grvTransactionLine;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactionLine;
		private BindingSource bsTransaction;
		private BindingSource bsTransactionLine;
	}
}