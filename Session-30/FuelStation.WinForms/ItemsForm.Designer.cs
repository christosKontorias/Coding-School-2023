namespace FuelStation.WinForms {
	partial class ItemsForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
			this.grvItems = new DevExpress.XtraGrid.GridControl();
			this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bsItems = new System.Windows.Forms.BindingSource(this.components);
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
			this.SuspendLayout();
			// 
			// grvItems
			// 
			this.grvItems.Location = new System.Drawing.Point(12, 59);
			this.grvItems.MainView = this.gridViewItems;
			this.grvItems.Name = "grvItems";
			this.grvItems.Size = new System.Drawing.Size(776, 301);
			this.grvItems.TabIndex = 0;
			this.grvItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
			// 
			// gridViewItems
			// 
			this.gridViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colPrice,
            this.colCost});
			this.gridViewItems.GridControl = this.grvItems;
			this.gridViewItems.Name = "gridViewItems";
			this.gridViewItems.OptionsView.ShowGroupPanel = false;
			// 
			// colCode
			// 
			this.colCode.Caption = "Code";
			this.colCode.FieldName = "Code";
			this.colCode.Name = "colCode";
			this.colCode.Visible = true;
			this.colCode.VisibleIndex = 0;
			// 
			// colDescription
			// 
			this.colDescription.Caption = "Description";
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 1;
			// 
			// colItemType
			// 
			this.colItemType.Caption = "Item Type";
			this.colItemType.FieldName = "ItemType";
			this.colItemType.Name = "colItemType";
			this.colItemType.Visible = true;
			this.colItemType.VisibleIndex = 2;
			// 
			// colPrice
			// 
			this.colPrice.Caption = "Price";
			this.colPrice.FieldName = "Price";
			this.colPrice.Name = "colPrice";
			this.colPrice.Visible = true;
			this.colPrice.VisibleIndex = 3;
			// 
			// colCost
			// 
			this.colCost.Caption = "Cost";
			this.colCost.FieldName = "Cost";
			this.colCost.Name = "colCost";
			this.colCost.Visible = true;
			this.colCost.VisibleIndex = 4;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnCreate.FlatAppearance.BorderSize = 0;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCreate.Location = new System.Drawing.Point(115, 400);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(110, 40);
			this.btnCreate.TabIndex = 1;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			this.btnCreate.MouseEnter += new System.EventHandler(this.btnCreate_MouseEnter);
			this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.Location = new System.Drawing.Point(231, 400);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(110, 40);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
			this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(310, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 47);
			this.label1.TabIndex = 3;
			this.label1.Text = "Items List";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.Location = new System.Drawing.Point(347, 400);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 40);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
			this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnUpdate.Location = new System.Drawing.Point(463, 400);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(110, 40);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
			this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.Location = new System.Drawing.Point(579, 400);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(110, 40);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
			// 
			// ItemsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.grvItems);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ItemsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Items";
			this.Load += new System.EventHandler(this.ItemsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grvItems;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
		private BindingSource bsItems;
		private Button btnCreate;
		private Button btnSave;
		private Label label1;
		private Button btnDelete;
		private Button btnUpdate;
		private DevExpress.XtraGrid.Columns.GridColumn colCode;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colItemType;
		private DevExpress.XtraGrid.Columns.GridColumn colPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colCost;
		private Button btnClose;
	}
}