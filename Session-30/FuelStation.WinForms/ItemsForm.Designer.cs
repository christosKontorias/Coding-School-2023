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
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
			this.SuspendLayout();
			// 
			// grvItems
			// 
			this.grvItems.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grvItems.Location = new System.Drawing.Point(0, 190);
			this.grvItems.MainView = this.gridViewItems;
			this.grvItems.Name = "grvItems";
			this.grvItems.Size = new System.Drawing.Size(800, 260);
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
			this.btnCreate.Location = new System.Drawing.Point(104, 145);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 1;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(244, 145);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(366, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Items List";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(366, 145);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(474, 145);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// ItemsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.grvItems);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ItemsForm";
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
	}
}