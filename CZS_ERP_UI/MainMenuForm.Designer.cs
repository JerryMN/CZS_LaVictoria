
namespace CZS_ERP_UI
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.RibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.CreatePOButton = new DevExpress.XtraBars.BarButtonItem();
            this.CreateSOButton = new DevExpress.XtraBars.BarButtonItem();
            this.CreateProviderButton = new DevExpress.XtraBars.BarButtonItem();
            this.ViewProvidersButton = new DevExpress.XtraBars.BarButtonItem();
            this.CreateMaterialButton = new DevExpress.XtraBars.BarButtonItem();
            this.StartPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PurchaseOrderGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SalesOrderGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DatosPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ProvidersDataGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ChildPanel = new DevExpress.XtraEditors.PanelControl();
            this.ViewPOButton = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonControl
            // 
            this.RibbonControl.ExpandCollapseItem.Id = 0;
            this.RibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl.ExpandCollapseItem,
            this.RibbonControl.SearchEditItem,
            this.CreatePOButton,
            this.CreateSOButton,
            this.CreateProviderButton,
            this.ViewProvidersButton,
            this.CreateMaterialButton,
            this.ViewPOButton});
            this.RibbonControl.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl.MaxItemId = 7;
            this.RibbonControl.Name = "RibbonControl";
            this.RibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.StartPage,
            this.DatosPage});
            this.RibbonControl.Size = new System.Drawing.Size(1278, 158);
            // 
            // CreatePOButton
            // 
            this.CreatePOButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.CreatePOButton.Caption = "Crear";
            this.CreatePOButton.Id = 1;
            this.CreatePOButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CreatePOButton.ImageOptions.Image")));
            this.CreatePOButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CreatePOButton.ImageOptions.LargeImage")));
            this.CreatePOButton.Name = "CreatePOButton";
            this.CreatePOButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.CreatePOButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CreatePOButton_ItemClick);
            // 
            // CreateSOButton
            // 
            this.CreateSOButton.Caption = "Crear";
            this.CreateSOButton.Hint = "Crear una nueva orden de venta";
            this.CreateSOButton.Id = 2;
            this.CreateSOButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CreateSOButton.ImageOptions.Image")));
            this.CreateSOButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CreateSOButton.ImageOptions.LargeImage")));
            this.CreateSOButton.Name = "CreateSOButton";
            this.CreateSOButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.CreateSOButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CreateSOButton_ItemClick);
            // 
            // CreateProviderButton
            // 
            this.CreateProviderButton.Caption = "Crear Proveedor";
            this.CreateProviderButton.Id = 3;
            this.CreateProviderButton.Name = "CreateProviderButton";
            this.CreateProviderButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CreateProviderButton_ItemClick);
            // 
            // ViewProvidersButton
            // 
            this.ViewProvidersButton.Caption = "Ver / Editar";
            this.ViewProvidersButton.Id = 4;
            this.ViewProvidersButton.Name = "ViewProvidersButton";
            this.ViewProvidersButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ViewProvidersButton_ItemClick);
            // 
            // CreateMaterialButton
            // 
            this.CreateMaterialButton.Caption = "Crear Material";
            this.CreateMaterialButton.Id = 5;
            this.CreateMaterialButton.Name = "CreateMaterialButton";
            this.CreateMaterialButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CreateMaterialButton_ItemClick);
            // 
            // StartPage
            // 
            this.StartPage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPage.Appearance.Options.UseFont = true;
            this.StartPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PurchaseOrderGroup,
            this.SalesOrderGroup});
            this.StartPage.Name = "StartPage";
            this.StartPage.Text = "Inicio";
            // 
            // PurchaseOrderGroup
            // 
            this.PurchaseOrderGroup.AllowTextClipping = false;
            this.PurchaseOrderGroup.ItemLinks.Add(this.CreatePOButton);
            this.PurchaseOrderGroup.ItemLinks.Add(this.ViewPOButton);
            this.PurchaseOrderGroup.Name = "PurchaseOrderGroup";
            this.PurchaseOrderGroup.Text = "Órdenes de Compra";
            // 
            // SalesOrderGroup
            // 
            this.SalesOrderGroup.AllowTextClipping = false;
            this.SalesOrderGroup.ItemLinks.Add(this.CreateSOButton);
            this.SalesOrderGroup.Name = "SalesOrderGroup";
            this.SalesOrderGroup.Text = "Órdenes de Venta";
            // 
            // DatosPage
            // 
            this.DatosPage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosPage.Appearance.Options.UseFont = true;
            this.DatosPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ProvidersDataGroup});
            this.DatosPage.Name = "DatosPage";
            this.DatosPage.Text = "Datos";
            // 
            // ProvidersDataGroup
            // 
            this.ProvidersDataGroup.ItemLinks.Add(this.CreateProviderButton);
            this.ProvidersDataGroup.ItemLinks.Add(this.ViewProvidersButton);
            this.ProvidersDataGroup.ItemLinks.Add(this.CreateMaterialButton);
            this.ProvidersDataGroup.Name = "ProvidersDataGroup";
            this.ProvidersDataGroup.Text = "Proveedores";
            // 
            // ChildPanel
            // 
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(0, 158);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(1278, 841);
            this.ChildPanel.TabIndex = 1;
            // 
            // ViewPOButton
            // 
            this.ViewPOButton.Caption = "Consultar";
            this.ViewPOButton.Id = 6;
            this.ViewPOButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ViewPOButton.ImageOptions.SvgImage")));
            this.ViewPOButton.Name = "ViewPOButton";
            this.ViewPOButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 999);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.RibbonControl);
            this.IconOptions.Image = global::CZS_ERP_UI.Properties.Resources.newicon1;
            this.Name = "MainMenuForm";
            this.Ribbon = this.RibbonControl;
            this.Text = "CZ Systems";
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage StartPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PurchaseOrderGroup;
        private DevExpress.XtraBars.BarButtonItem CreatePOButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SalesOrderGroup;
        private DevExpress.XtraBars.BarButtonItem CreateSOButton;
        private DevExpress.XtraBars.BarButtonItem CreateProviderButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage DatosPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ProvidersDataGroup;
        private DevExpress.XtraBars.BarButtonItem ViewProvidersButton;
        private DevExpress.XtraBars.BarButtonItem CreateMaterialButton;
        private DevExpress.XtraEditors.PanelControl ChildPanel;
        private DevExpress.XtraBars.BarButtonItem ViewPOButton;
    }
}

