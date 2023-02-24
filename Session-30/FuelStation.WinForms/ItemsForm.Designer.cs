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
			this.bsItems = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
			this.SuspendLayout();
			// 
			// grvItems
			// 
			this.grvItems.Location = new System.Drawing.Point(40, 74);
			this.grvItems.MainView = this.gridViewItems;
			this.grvItems.Name = "grvItems";
			this.grvItems.Size = new System.Drawing.Size(400, 200);
			this.grvItems.TabIndex = 0;
			this.grvItems.UseEmbeddedNavigator = true;
			this.grvItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
			// 
			// gridViewItems
			// 
			this.gridViewItems.GridControl = this.grvItems;
			this.gridViewItems.Name = "gridViewItems";
			this.gridViewItems.OptionsView.ShowGroupPanel = false;
			// 
			// ItemsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grvItems);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ItemsForm";
			this.Text = "Items";
			this.Load += new System.EventHandler(this.ItemsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grvItems;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
		private BindingSource bsItems;
	}
}