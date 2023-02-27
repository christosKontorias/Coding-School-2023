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
			this.btnTransactionClose = new System.Windows.Forms.Button();
			this.btnTransactionUpdate = new System.Windows.Forms.Button();
			this.btnTransactionDelete = new System.Windows.Forms.Button();
			this.btnTransactionSave = new System.Windows.Forms.Button();
			this.btnTransactionCreate = new System.Windows.Forms.Button();
			this.grdTransactions = new DevExpress.XtraGrid.GridControl();
			this.gridViewTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repTotalValue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.grdTransactionLine = new DevExpress.XtraGrid.GridControl();
			this.gridViewTransactionLine = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransactionLineTransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItems = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransactionLineTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
			this.bsItems = new System.Windows.Forms.BindingSource(this.components);
			this.colTransactionLineItem = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
			this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
			this.btnTransactionLineDelete = new System.Windows.Forms.Button();
			this.btnTransactionLineSave = new System.Windows.Forms.Button();
			this.btnTransactionLineCreate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSearchCardNumber = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repTotalValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactionLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(381, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 47);
			this.label1.TabIndex = 6;
			this.label1.Text = "Transaction";
			// 
			// btnTransactionClose
			// 
			this.btnTransactionClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactionClose.FlatAppearance.BorderSize = 0;
			this.btnTransactionClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactionClose.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactionClose.Location = new System.Drawing.Point(815, 628);
			this.btnTransactionClose.Name = "btnTransactionClose";
			this.btnTransactionClose.Size = new System.Drawing.Size(100, 40);
			this.btnTransactionClose.TabIndex = 14;
			this.btnTransactionClose.Text = "Close";
			this.btnTransactionClose.UseVisualStyleBackColor = false;
			this.btnTransactionClose.Click += new System.EventHandler(this.btnTransactionClose_Click);
			this.btnTransactionClose.MouseEnter += new System.EventHandler(this.btnTransactionClose_MouseEnter);
			this.btnTransactionClose.MouseLeave += new System.EventHandler(this.btnTransactionClose_MouseLeave);
			// 
			// btnTransactionUpdate
			// 
			this.btnTransactionUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactionUpdate.FlatAppearance.BorderSize = 0;
			this.btnTransactionUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactionUpdate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactionUpdate.Location = new System.Drawing.Point(709, 628);
			this.btnTransactionUpdate.Name = "btnTransactionUpdate";
			this.btnTransactionUpdate.Size = new System.Drawing.Size(100, 40);
			this.btnTransactionUpdate.TabIndex = 13;
			this.btnTransactionUpdate.Text = "Update";
			this.btnTransactionUpdate.UseVisualStyleBackColor = false;
			this.btnTransactionUpdate.Click += new System.EventHandler(this.btnTransactionUpdate_Click);
			this.btnTransactionUpdate.MouseEnter += new System.EventHandler(this.btnTransactionUpdate_MouseEnter);
			this.btnTransactionUpdate.MouseLeave += new System.EventHandler(this.btnTransactionUpdate_MouseLeave);
			// 
			// btnTransactionDelete
			// 
			this.btnTransactionDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactionDelete.FlatAppearance.BorderSize = 0;
			this.btnTransactionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactionDelete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactionDelete.Location = new System.Drawing.Point(796, 269);
			this.btnTransactionDelete.Name = "btnTransactionDelete";
			this.btnTransactionDelete.Size = new System.Drawing.Size(100, 40);
			this.btnTransactionDelete.TabIndex = 12;
			this.btnTransactionDelete.Text = "Delete";
			this.btnTransactionDelete.UseVisualStyleBackColor = false;
			this.btnTransactionDelete.Click += new System.EventHandler(this.btnTransactionDelete_Click);
			this.btnTransactionDelete.MouseEnter += new System.EventHandler(this.btnTransactionDelete_MouseEnter);
			this.btnTransactionDelete.MouseLeave += new System.EventHandler(this.btnTransactionDelete_MouseLeave);
			// 
			// btnTransactionSave
			// 
			this.btnTransactionSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactionSave.FlatAppearance.BorderSize = 0;
			this.btnTransactionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactionSave.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactionSave.Location = new System.Drawing.Point(796, 223);
			this.btnTransactionSave.Name = "btnTransactionSave";
			this.btnTransactionSave.Size = new System.Drawing.Size(100, 40);
			this.btnTransactionSave.TabIndex = 11;
			this.btnTransactionSave.Text = "Save";
			this.btnTransactionSave.UseVisualStyleBackColor = false;
			this.btnTransactionSave.Click += new System.EventHandler(this.btnTransactionSave_Click);
			this.btnTransactionSave.MouseEnter += new System.EventHandler(this.btnTransactionSave_MouseEnter);
			this.btnTransactionSave.MouseLeave += new System.EventHandler(this.btnTransactionSave_MouseLeave);
			// 
			// btnTransactionCreate
			// 
			this.btnTransactionCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactionCreate.FlatAppearance.BorderSize = 0;
			this.btnTransactionCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactionCreate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactionCreate.Location = new System.Drawing.Point(796, 177);
			this.btnTransactionCreate.Name = "btnTransactionCreate";
			this.btnTransactionCreate.Size = new System.Drawing.Size(100, 40);
			this.btnTransactionCreate.TabIndex = 10;
			this.btnTransactionCreate.Text = "Create";
			this.btnTransactionCreate.UseVisualStyleBackColor = false;
			this.btnTransactionCreate.Click += new System.EventHandler(this.btnTransactionCreate_Click);
			this.btnTransactionCreate.MouseEnter += new System.EventHandler(this.btnTransactionCreate_MouseEnter);
			this.btnTransactionCreate.MouseLeave += new System.EventHandler(this.btnTransactionCreate_MouseLeave);
			// 
			// grdTransactions
			// 
			this.grdTransactions.Location = new System.Drawing.Point(12, 139);
			this.grdTransactions.MainView = this.gridViewTransactions;
			this.grdTransactions.Name = "grdTransactions";
			this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCustomers,
            this.repEmployees,
            this.repTotalValue});
			this.grdTransactions.Size = new System.Drawing.Size(735, 200);
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
            this.colCustomerId,
            this.colEmployeeId});
			this.gridViewTransactions.GridControl = this.grdTransactions;
			this.gridViewTransactions.Name = "gridViewTransactions";
			this.gridViewTransactions.OptionsDetail.EnableMasterViewMode = false;
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
			this.colTotalValue.ColumnEdit = this.repTotalValue;
			this.colTotalValue.FieldName = "TotalValue";
			this.colTotalValue.Name = "colTotalValue";
			this.colTotalValue.OptionsColumn.AllowEdit = false;
			this.colTotalValue.Visible = true;
			this.colTotalValue.VisibleIndex = 2;
			// 
			// repTotalValue
			// 
			this.repTotalValue.AutoHeight = false;
			this.repTotalValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repTotalValue.Name = "repTotalValue";
			// 
			// colCustomerId
			// 
			this.colCustomerId.Caption = "Customer";
			this.colCustomerId.ColumnEdit = this.repCustomers;
			this.colCustomerId.FieldName = "CustomerId";
			this.colCustomerId.Name = "colCustomerId";
			this.colCustomerId.Visible = true;
			this.colCustomerId.VisibleIndex = 3;
			// 
			// repCustomers
			// 
			this.repCustomers.AutoHeight = false;
			this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCustomers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardNumber", "Card Number")});
			this.repCustomers.Name = "repCustomers";
			// 
			// colEmployeeId
			// 
			this.colEmployeeId.Caption = "Employee";
			this.colEmployeeId.ColumnEdit = this.repEmployees;
			this.colEmployeeId.FieldName = "EmployeeId";
			this.colEmployeeId.Name = "colEmployeeId";
			this.colEmployeeId.Visible = true;
			this.colEmployeeId.VisibleIndex = 4;
			// 
			// repEmployees
			// 
			this.repEmployees.AutoHeight = false;
			this.repEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repEmployees.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname")});
			this.repEmployees.Name = "repEmployees";
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
			this.grdTransactionLine.Size = new System.Drawing.Size(735, 200);
			this.grdTransactionLine.TabIndex = 19;
			this.grdTransactionLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLine});
			// 
			// gridViewTransactionLine
			// 
			this.gridViewTransactionLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTransactionLineTransactionId,
            this.colItems,
            this.colQuantity,
            this.colItemPrice,
            this.colValue,
            this.colDiscountPercent,
            this.colDiscountValue,
            this.colTransactionLineTotalValue});
			this.gridViewTransactionLine.GridControl = this.grdTransactionLine;
			this.gridViewTransactionLine.Name = "gridViewTransactionLine";
			this.gridViewTransactionLine.OptionsView.ShowGroupPanel = false;
			this.gridViewTransactionLine.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewTransactionLine_CellValueChanged);
			// 
			// colId
			// 
			this.colId.Caption = "TransactionLine ID";
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			// 
			// colTransactionLineTransactionId
			// 
			this.colTransactionLineTransactionId.Caption = "TransactionId";
			this.colTransactionLineTransactionId.FieldName = "TransactionId";
			this.colTransactionLineTransactionId.Name = "colTransactionLineTransactionId";
			this.colTransactionLineTransactionId.Visible = true;
			this.colTransactionLineTransactionId.VisibleIndex = 1;
			// 
			// colItems
			// 
			this.colItems.Caption = "Item";
			this.colItems.ColumnEdit = this.repItems;
			this.colItems.FieldName = "ItemId";
			this.colItems.Name = "colItems";
			this.colItems.Visible = true;
			this.colItems.VisibleIndex = 2;
			// 
			// repItems
			// 
			this.repItems.AutoHeight = false;
			this.repItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemType", "ItemType")});
			this.repItems.Name = "repItems";
			// 
			// colQuantity
			// 
			this.colQuantity.Caption = "Quantity";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 3;
			// 
			// colItemPrice
			// 
			this.colItemPrice.Caption = "Item Price";
			this.colItemPrice.FieldName = "ItemPrice";
			this.colItemPrice.Name = "colItemPrice";
			this.colItemPrice.Visible = true;
			this.colItemPrice.VisibleIndex = 4;
			// 
			// colValue
			// 
			this.colValue.Caption = "Net Value";
			this.colValue.FieldName = "NetValue";
			this.colValue.Name = "colValue";
			this.colValue.OptionsColumn.AllowEdit = false;
			this.colValue.Visible = true;
			this.colValue.VisibleIndex = 5;
			// 
			// colDiscountPercent
			// 
			this.colDiscountPercent.Caption = "Discount Percent";
			this.colDiscountPercent.FieldName = "DiscountPercent";
			this.colDiscountPercent.Name = "colDiscountPercent";
			this.colDiscountPercent.Visible = true;
			this.colDiscountPercent.VisibleIndex = 6;
			// 
			// colDiscountValue
			// 
			this.colDiscountValue.Caption = "Discount Value";
			this.colDiscountValue.FieldName = "DiscountValue";
			this.colDiscountValue.Name = "colDiscountValue";
			this.colDiscountValue.OptionsColumn.AllowEdit = false;
			this.colDiscountValue.Visible = true;
			this.colDiscountValue.VisibleIndex = 7;
			// 
			// colTransactionLineTotalValue
			// 
			this.colTransactionLineTotalValue.Caption = "Total Value";
			this.colTransactionLineTotalValue.FieldName = "TotalValue";
			this.colTransactionLineTotalValue.Name = "colTransactionLineTotalValue";
			this.colTransactionLineTotalValue.OptionsColumn.AllowEdit = false;
			this.colTransactionLineTotalValue.Visible = true;
			this.colTransactionLineTotalValue.VisibleIndex = 8;
			// 
			// colTransactionLineItem
			// 
			this.colTransactionLineItem.Caption = "Item";
			this.colTransactionLineItem.FieldName = "ItemId";
			this.colTransactionLineItem.Name = "colTransactionLineItem";
			// 
			// btnTransactionLineDelete
			// 
			this.btnTransactionLineDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactionLineDelete.FlatAppearance.BorderSize = 0;
			this.btnTransactionLineDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactionLineDelete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactionLineDelete.Location = new System.Drawing.Point(796, 523);
			this.btnTransactionLineDelete.Name = "btnTransactionLineDelete";
			this.btnTransactionLineDelete.Size = new System.Drawing.Size(100, 40);
			this.btnTransactionLineDelete.TabIndex = 22;
			this.btnTransactionLineDelete.Text = "Delete";
			this.btnTransactionLineDelete.UseVisualStyleBackColor = false;
			this.btnTransactionLineDelete.Click += new System.EventHandler(this.btnTransactionLineDelete_Click);
			this.btnTransactionLineDelete.MouseEnter += new System.EventHandler(this.btnTransactionLineDelete_MouseEnter);
			this.btnTransactionLineDelete.MouseLeave += new System.EventHandler(this.btnTransactionLineDelete_MouseLeave);
			// 
			// btnTransactionLineSave
			// 
			this.btnTransactionLineSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactionLineSave.FlatAppearance.BorderSize = 0;
			this.btnTransactionLineSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactionLineSave.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactionLineSave.Location = new System.Drawing.Point(796, 477);
			this.btnTransactionLineSave.Name = "btnTransactionLineSave";
			this.btnTransactionLineSave.Size = new System.Drawing.Size(100, 40);
			this.btnTransactionLineSave.TabIndex = 21;
			this.btnTransactionLineSave.Text = "Save";
			this.btnTransactionLineSave.UseVisualStyleBackColor = false;
			this.btnTransactionLineSave.Click += new System.EventHandler(this.btnTransactionLineSave_Click);
			this.btnTransactionLineSave.MouseEnter += new System.EventHandler(this.btnTransactionLineSave_MouseEnter);
			this.btnTransactionLineSave.MouseLeave += new System.EventHandler(this.btnTransactionLineSave_MouseLeave);
			// 
			// btnTransactionLineCreate
			// 
			this.btnTransactionLineCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnTransactionLineCreate.FlatAppearance.BorderSize = 0;
			this.btnTransactionLineCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransactionLineCreate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnTransactionLineCreate.Location = new System.Drawing.Point(796, 431);
			this.btnTransactionLineCreate.Name = "btnTransactionLineCreate";
			this.btnTransactionLineCreate.Size = new System.Drawing.Size(100, 40);
			this.btnTransactionLineCreate.TabIndex = 20;
			this.btnTransactionLineCreate.Text = "Create";
			this.btnTransactionLineCreate.UseVisualStyleBackColor = false;
			this.btnTransactionLineCreate.Click += new System.EventHandler(this.btnTransactionLineCreate_Click);
			this.btnTransactionLineCreate.MouseEnter += new System.EventHandler(this.btnTransactionLineCreate_MouseEnter);
			this.btnTransactionLineCreate.MouseLeave += new System.EventHandler(this.btnTransactionLineCreate_MouseLeave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 35);
			this.label2.TabIndex = 23;
			this.label2.Text = "Card Number :";
			// 
			// txtSearchCardNumber
			// 
			this.txtSearchCardNumber.Location = new System.Drawing.Point(184, 15);
			this.txtSearchCardNumber.Name = "txtSearchCardNumber";
			this.txtSearchCardNumber.Size = new System.Drawing.Size(100, 23);
			this.txtSearchCardNumber.TabIndex = 24;
			this.txtSearchCardNumber.TextChanged += new System.EventHandler(this.txtSearchCardNumber_TextChanged);
			// 
			// TransactionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 680);
			this.Controls.Add(this.txtSearchCardNumber);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTransactionLineDelete);
			this.Controls.Add(this.btnTransactionLineSave);
			this.Controls.Add(this.btnTransactionLineCreate);
			this.Controls.Add(this.grdTransactionLine);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.grdTransactions);
			this.Controls.Add(this.btnTransactionClose);
			this.Controls.Add(this.btnTransactionUpdate);
			this.Controls.Add(this.btnTransactionDelete);
			this.Controls.Add(this.btnTransactionSave);
			this.Controls.Add(this.btnTransactionCreate);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TransactionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transactions";
			this.Load += new System.EventHandler(this.TransactionsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repTotalValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactionLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private Button btnTransactionClose;
		private Button btnTransactionUpdate;
		private Button btnTransactionDelete;
		private Button btnTransactionSave;
		private Button btnTransactionCreate;
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
		private BindingSource bsItems;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItems;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colValue;
		private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTotalValue;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItem;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCustomers;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repEmployees;
		private BindingSource bsCustomers;
		private BindingSource bsEmployees;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
		private Button btnTransactionLineDelete;
		private Button btnTransactionLineSave;
		private Button btnTransactionLineCreate;
		private DevExpress.XtraGrid.Columns.GridColumn colDiscountValue;
		private Label label2;
		private TextBox txtSearchCardNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colItems;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTransactionId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTotalValue;
	}
}