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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
			this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
			this.grvCustomers = new DevExpress.XtraGrid.GridControl();
			this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// grvCustomers
			// 
			this.grvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grvCustomers.Location = new System.Drawing.Point(0, 0);
			this.grvCustomers.MainView = this.gridViewCustomers;
			this.grvCustomers.Name = "grvCustomers";
			this.grvCustomers.Size = new System.Drawing.Size(800, 450);
			this.grvCustomers.TabIndex = 0;
			this.grvCustomers.UseEmbeddedNavigator = true;
			this.grvCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
			// 
			// gridViewCustomers
			// 
			this.gridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSurname,
            this.colCardNumber});
			this.gridViewCustomers.GridControl = this.grvCustomers;
			this.gridViewCustomers.Name = "gridViewCustomers";
			this.gridViewCustomers.OptionsView.ShowGroupPanel = false;
			this.gridViewCustomers.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewCustomers_ValidateRow);
			this.gridViewCustomers.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewCustomers_ValidatingEditor);
			// 
			// colName
			// 
			this.colName.Caption = "Name";
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			// 
			// colSurname
			// 
			this.colSurname.Caption = "Surname";
			this.colSurname.FieldName = "Surname";
			this.colSurname.Name = "colSurname";
			this.colSurname.Visible = true;
			this.colSurname.VisibleIndex = 1;
			// 
			// colCardNumber
			// 
			this.colCardNumber.Caption = "Card Number";
			this.colCardNumber.FieldName = "CardNumber";
			this.colCardNumber.Name = "colCardNumber";
			this.colCardNumber.Visible = true;
			this.colCardNumber.VisibleIndex = 2;
			// 
			// CustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grvCustomers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CustomerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customers";
			this.Load += new System.EventHandler(this.CustomerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private BindingSource bsCustomers;
		private DevExpress.XtraGrid.GridControl grvCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colSurname;
		private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
	}
}