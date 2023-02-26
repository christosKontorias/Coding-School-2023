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
			this.btnClose = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.grdTransactions = new DevExpress.XtraGrid.GridControl();
			this.gridViewTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.grdTransactionLine = new DevExpress.XtraGrid.GridControl();
			this.gridViewTransactionLine = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransactionLineTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransactionLineTransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repItem = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
			this.bsItems = new System.Windows.Forms.BindingSource(this.components);
			this.colTransactionLineItem = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactionLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(380, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 47);
			this.label1.TabIndex = 6;
			this.label1.Text = "Transaction";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.Location = new System.Drawing.Point(699, 285);
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
			this.btnUpdate.Location = new System.Drawing.Point(699, 239);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(110, 40);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
			this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.Location = new System.Drawing.Point(699, 193);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 40);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
			this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.Location = new System.Drawing.Point(699, 147);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(110, 40);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
			this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnCreate.FlatAppearance.BorderSize = 0;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCreate.Location = new System.Drawing.Point(699, 101);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(110, 40);
			this.btnCreate.TabIndex = 10;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			this.btnCreate.MouseEnter += new System.EventHandler(this.btnCreate_MouseEnter);
			this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
			// 
			// grdTransactions
			// 
			this.grdTransactions.Location = new System.Drawing.Point(12, 120);
			this.grdTransactions.MainView = this.gridViewTransactions;
			this.grdTransactions.Name = "grdTransactions";
			this.grdTransactions.Size = new System.Drawing.Size(652, 200);
			this.grdTransactions.TabIndex = 17;
			this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactions});
			// 
			// gridViewTransactions
			// 
			this.gridViewTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionID,
            this.colDate,
            this.colPaymentMethod,
            this.colTotalValue,
            this.colCustomerID,
            this.colEmployeeID});
			this.gridViewTransactions.GridControl = this.grdTransactions;
			this.gridViewTransactions.Name = "gridViewTransactions";
			this.gridViewTransactions.OptionsView.ShowGroupPanel = false;
			// 
			// colTransactionID
			// 
			this.colTransactionID.Caption = "Transaction ID";
			this.colTransactionID.FieldName = "TransactionId";
			this.colTransactionID.Name = "colTransactionID";
			// 
			// colDate
			// 
			this.colDate.Caption = "Date";
			this.colDate.FieldName = "Date";
			this.colDate.Name = "colDate";
			this.colDate.Visible = true;
			this.colDate.VisibleIndex = 0;
			// 
			// colPaymentMethod
			// 
			this.colPaymentMethod.Caption = "Payment Method";
			this.colPaymentMethod.FieldName = "PaymentMethod";
			this.colPaymentMethod.Name = "colPaymentMethod";
			this.colPaymentMethod.Visible = true;
			this.colPaymentMethod.VisibleIndex = 1;
			// 
			// colTotalValue
			// 
			this.colTotalValue.Caption = "Total Value";
			this.colTotalValue.FieldName = "TotalValue";
			this.colTotalValue.Name = "colTotalValue";
			this.colTotalValue.Visible = true;
			this.colTotalValue.VisibleIndex = 2;
			// 
			// colCustomerID
			// 
			this.colCustomerID.Caption = "Customer ID";
			this.colCustomerID.FieldName = "CustomerId";
			this.colCustomerID.Name = "colCustomerID";
			this.colCustomerID.Visible = true;
			this.colCustomerID.VisibleIndex = 3;
			// 
			// colEmployeeID
			// 
			this.colEmployeeID.Caption = "Employee ID";
			this.colEmployeeID.FieldName = "EmployeeId";
			this.colEmployeeID.Name = "colEmployeeID";
			this.colEmployeeID.Visible = true;
			this.colEmployeeID.VisibleIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(362, 342);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 47);
			this.label3.TabIndex = 18;
			this.label3.Text = "Transaction Lines";
			// 
			// grdTransactionLine
			// 
			this.grdTransactionLine.Location = new System.Drawing.Point(12, 405);
			this.grdTransactionLine.MainView = this.gridViewTransactionLine;
			this.grdTransactionLine.Name = "grdTransactionLine";
			this.grdTransactionLine.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItems});
			this.grdTransactionLine.Size = new System.Drawing.Size(719, 200);
			this.grdTransactionLine.TabIndex = 19;
			this.grdTransactionLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLine});
			// 
			// gridViewTransactionLine
			// 
			this.gridViewTransactionLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantity,
            this.colItemPrice,
            this.colValue,
            this.colDiscountPercent,
            this.colTransactionLineTotalValue,
            this.colTransactionLineTransactionId,
            this.repItem});
			this.gridViewTransactionLine.GridControl = this.grdTransactionLine;
			this.gridViewTransactionLine.Name = "gridViewTransactionLine";
			this.gridViewTransactionLine.OptionsView.ShowGroupPanel = false;
			// 
			// colQuantity
			// 
			this.colQuantity.Caption = "Quantity";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 0;
			// 
			// colItemPrice
			// 
			this.colItemPrice.Caption = "Item Price";
			this.colItemPrice.FieldName = "ItemPrice";
			this.colItemPrice.Name = "colItemPrice";
			this.colItemPrice.Visible = true;
			this.colItemPrice.VisibleIndex = 1;
			// 
			// colValue
			// 
			this.colValue.Caption = "Net Value";
			this.colValue.FieldName = "NetValue";
			this.colValue.Name = "colValue";
			this.colValue.Visible = true;
			this.colValue.VisibleIndex = 2;
			// 
			// colDiscountPercent
			// 
			this.colDiscountPercent.Caption = "Discount Percent";
			this.colDiscountPercent.FieldName = "DiscountPercent";
			this.colDiscountPercent.Name = "colDiscountPercent";
			this.colDiscountPercent.Visible = true;
			this.colDiscountPercent.VisibleIndex = 3;
			// 
			// colTransactionLineTotalValue
			// 
			this.colTransactionLineTotalValue.Caption = "Total Value";
			this.colTransactionLineTotalValue.FieldName = "TotalValue";
			this.colTransactionLineTotalValue.Name = "colTransactionLineTotalValue";
			this.colTransactionLineTotalValue.Visible = true;
			this.colTransactionLineTotalValue.VisibleIndex = 4;
			// 
			// colTransactionLineTransactionId
			// 
			this.colTransactionLineTransactionId.Caption = "Transaction ID";
			this.colTransactionLineTransactionId.FieldName = "TransactionId";
			this.colTransactionLineTransactionId.Name = "colTransactionLineTransactionId";
			// 
			// repItem
			// 
			this.repItem.Caption = "Item";
			this.repItem.ColumnEdit = this.repItems;
			this.repItem.FieldName = "ItemId";
			this.repItem.Name = "repItem";
			this.repItem.Visible = true;
			this.repItem.VisibleIndex = 5;
			// 
			// repItems
			// 
			this.repItems.AutoHeight = false;
			this.repItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repItems.Name = "repItems";
			// 
			// colTransactionLineItem
			// 
			this.colTransactionLineItem.Caption = "Item";
			this.colTransactionLineItem.FieldName = "ItemId";
			this.colTransactionLineItem.Name = "colTransactionLineItem";
			// 
			// TransactionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 680);
			this.Controls.Add(this.grdTransactionLine);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.grdTransactions);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TransactionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transactions";
			this.Load += new System.EventHandler(this.TransactionsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactionLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private Button btnClose;
		private Button btnUpdate;
		private Button btnDelete;
		private Button btnSave;
		private Button btnCreate;
		private DevExpress.XtraGrid.GridControl grdTransactions;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactions;
		private BindingSource bsTransactions;
		private DevExpress.XtraGrid.Columns.GridColumn colDate;
		private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethod;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
		private Label label3;
		private DevExpress.XtraGrid.GridControl grdTransactionLine;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactionLine;
		private BindingSource bsTransactionLines;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
		private BindingSource bsItems;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItems;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colValue;
		private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTotalValue;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTransactionId;
		private DevExpress.XtraGrid.Columns.GridColumn repItem;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItem;
	}
}