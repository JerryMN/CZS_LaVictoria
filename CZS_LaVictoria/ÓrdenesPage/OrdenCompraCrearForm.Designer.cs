
namespace CZS_LaVictoria.ÓrdenesPage
{
    partial class OrdenCompraCrearForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenCompraCrearForm));
            this.ProductosGroupBox = new System.Windows.Forms.GroupBox();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.purchaseOrderLineModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colCantidadOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadEntregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.TeléfonoText = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.CondicionesCombo = new System.Windows.Forms.ComboBox();
            this.AreaCombo = new System.Windows.Forms.ComboBox();
            this.CondicionesLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.AreaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.AtenciónLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CorreoText = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.AtencionText = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CorreoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.TeléfonoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ProveedorCombo = new System.Windows.Forms.ComboBox();
            this.ProveedorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.FechaOrdenPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaEntregaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaEntregaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.FechaOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.NumOrdenText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NumOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.RevisarButton = new FontAwesome.Sharp.IconButton();
            this.NotasButton = new FontAwesome.Sharp.IconButton();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.ProductosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLineModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosGroupBox
            // 
            this.ProductosGroupBox.Controls.Add(this.GridControl);
            this.ProductosGroupBox.Location = new System.Drawing.Point(50, 350);
            this.ProductosGroupBox.Name = "ProductosGroupBox";
            this.ProductosGroupBox.Size = new System.Drawing.Size(1176, 350);
            this.ProductosGroupBox.TabIndex = 5;
            this.ProductosGroupBox.TabStop = false;
            this.ProductosGroupBox.Text = "Productos";
            // 
            // GridControl
            // 
            this.GridControl.DataSource = this.purchaseOrderLineModelBindingSource;
            this.GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl.Location = new System.Drawing.Point(3, 25);
            this.GridControl.MainView = this.GridView;
            this.GridControl.Name = "GridControl";
            this.GridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemCheckEdit1});
            this.GridControl.Size = new System.Drawing.Size(1170, 322);
            this.GridControl.TabIndex = 1;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView});
            // 
            // purchaseOrderLineModelBindingSource
            // 
            this.purchaseOrderLineModelBindingSource.DataSource = typeof(CZS_LaVictoria_Library.Models.PurchaseOrderLineModel);
            // 
            // GridView
            // 
            this.GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumLinea,
            this.colProducto,
            this.colCantidadOrden,
            this.colCantidadEntregada,
            this.colCantidadPendiente,
            this.colPrecioUnitario,
            this.colIva,
            this.colSubtotal});
            this.GridView.GridControl = this.GridControl;
            this.GridView.Name = "GridView";
            this.GridView.NewItemRowText = "Nueva línea";
            this.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.GridView.OptionsCustomization.AllowFilter = false;
            this.GridView.OptionsCustomization.AllowGroup = false;
            this.GridView.OptionsCustomization.AllowSort = false;
            this.GridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.GridView.OptionsView.ShowGroupPanel = false;
            this.GridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSubtotal, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.GridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GridView_InitNewRow);
            this.GridView.HiddenEditor += new System.EventHandler(this.GridView_HiddenEditor);
            this.GridView.ShownEditor += new System.EventHandler(this.GridView_ShownEditor);
            this.GridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridView_CellValueChanging);
            // 
            // colNumLinea
            // 
            this.colNumLinea.FieldName = "NumLinea";
            this.colNumLinea.Name = "colNumLinea";
            this.colNumLinea.OptionsColumn.AllowEdit = false;
            this.colNumLinea.OptionsColumn.ReadOnly = true;
            this.colNumLinea.Visible = true;
            this.colNumLinea.VisibleIndex = 0;
            this.colNumLinea.Width = 69;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.ColumnEdit = this.repositoryItemComboBox1;
            this.colProducto.FieldName = "Producto";
            this.colProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colProducto.ImageOptions.Image")));
            this.colProducto.ImageOptions.SvgImageSize = new System.Drawing.Size(10, 10);
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 98;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colCantidadOrden
            // 
            this.colCantidadOrden.FieldName = "CantidadOrden";
            this.colCantidadOrden.Name = "colCantidadOrden";
            this.colCantidadOrden.Visible = true;
            this.colCantidadOrden.VisibleIndex = 2;
            this.colCantidadOrden.Width = 98;
            // 
            // colCantidadEntregada
            // 
            this.colCantidadEntregada.FieldName = "CantidadEntregada";
            this.colCantidadEntregada.Name = "colCantidadEntregada";
            // 
            // colCantidadPendiente
            // 
            this.colCantidadPendiente.FieldName = "CantidadPendiente";
            this.colCantidadPendiente.Name = "colCantidadPendiente";
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.DisplayFormat.FormatString = "$#,##.00";
            this.colPrecioUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioUnitario.FieldName = "PrecioUnitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 3;
            this.colPrecioUnitario.Width = 98;
            // 
            // colIva
            // 
            this.colIva.Caption = "IVA";
            this.colIva.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIva.FieldName = "Iva";
            this.colIva.Name = "colIva";
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 4;
            this.colIva.Width = 98;
            // 
            // colSubtotal
            // 
            this.colSubtotal.DisplayFormat.FormatString = "$#,##.00";
            this.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 5;
            this.colSubtotal.Width = 105;
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.TeléfonoText);
            this.DatosGroupBox.Controls.Add(this.CondicionesCombo);
            this.DatosGroupBox.Controls.Add(this.AreaCombo);
            this.DatosGroupBox.Controls.Add(this.CondicionesLabel);
            this.DatosGroupBox.Controls.Add(this.AreaLabel);
            this.DatosGroupBox.Controls.Add(this.AtenciónLabel);
            this.DatosGroupBox.Controls.Add(this.CorreoText);
            this.DatosGroupBox.Controls.Add(this.AtencionText);
            this.DatosGroupBox.Controls.Add(this.CorreoLabel);
            this.DatosGroupBox.Controls.Add(this.TeléfonoLabel);
            this.DatosGroupBox.Controls.Add(this.ProveedorCombo);
            this.DatosGroupBox.Controls.Add(this.ProveedorLabel);
            this.DatosGroupBox.Controls.Add(this.FechaOrdenPicker);
            this.DatosGroupBox.Controls.Add(this.FechaEntregaPicker);
            this.DatosGroupBox.Controls.Add(this.FechaEntregaLabel);
            this.DatosGroupBox.Controls.Add(this.FechaOrdenLabel);
            this.DatosGroupBox.Controls.Add(this.NumOrdenText);
            this.DatosGroupBox.Controls.Add(this.NumOrdenLabel);
            this.DatosGroupBox.Location = new System.Drawing.Point(50, 150);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(1176, 183);
            this.DatosGroupBox.TabIndex = 4;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // TeléfonoText
            // 
            this.TeléfonoText.BackColor = System.Drawing.SystemColors.Control;
            this.TeléfonoText.BeforeTouchSize = new System.Drawing.Size(150, 29);
            this.TeléfonoText.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.TeléfonoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeléfonoText.Location = new System.Drawing.Point(450, 90);
            this.TeléfonoText.Mask = "(###) ### ####";
            this.TeléfonoText.MaxLength = 14;
            this.TeléfonoText.Name = "TeléfonoText";
            this.TeléfonoText.ReadOnly = true;
            this.TeléfonoText.Size = new System.Drawing.Size(190, 22);
            this.TeléfonoText.TabIndex = 27;
            // 
            // CondicionesCombo
            // 
            this.CondicionesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CondicionesCombo.FormattingEnabled = true;
            this.CondicionesCombo.Location = new System.Drawing.Point(830, 137);
            this.CondicionesCombo.Name = "CondicionesCombo";
            this.CondicionesCombo.Size = new System.Drawing.Size(202, 29);
            this.CondicionesCombo.TabIndex = 26;
            // 
            // AreaCombo
            // 
            this.AreaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaCombo.FormattingEnabled = true;
            this.AreaCombo.Location = new System.Drawing.Point(830, 87);
            this.AreaCombo.Name = "AreaCombo";
            this.AreaCombo.Size = new System.Drawing.Size(202, 29);
            this.AreaCombo.TabIndex = 25;
            this.AreaCombo.SelectedIndexChanged += new System.EventHandler(this.AreaCombo_SelectedIndexChanged);
            // 
            // CondicionesLabel
            // 
            this.CondicionesLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CondicionesLabel.Location = new System.Drawing.Point(730, 140);
            this.CondicionesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CondicionesLabel.Name = "CondicionesLabel";
            this.CondicionesLabel.Size = new System.Drawing.Size(98, 21);
            this.CondicionesLabel.TabIndex = 24;
            this.CondicionesLabel.Text = "Condiciones:";
            // 
            // AreaLabel
            // 
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AreaLabel.Location = new System.Drawing.Point(730, 90);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(45, 21);
            this.AreaLabel.TabIndex = 23;
            this.AreaLabel.Text = "Área:";
            // 
            // AtenciónLabel
            // 
            this.AtenciónLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AtenciónLabel.Location = new System.Drawing.Point(730, 40);
            this.AtenciónLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AtenciónLabel.Name = "AtenciónLabel";
            this.AtenciónLabel.Size = new System.Drawing.Size(74, 21);
            this.AtenciónLabel.TabIndex = 21;
            this.AtenciónLabel.Text = "Atención:";
            // 
            // CorreoText
            // 
            this.CorreoText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CorreoText.Location = new System.Drawing.Point(450, 140);
            this.CorreoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CorreoText.Name = "CorreoText";
            this.CorreoText.Size = new System.Drawing.Size(190, 21);
            this.CorreoText.TabIndex = 20;
            this.CorreoText.Text = "Selecciona un proveedor...";
            // 
            // AtencionText
            // 
            this.AtencionText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AtencionText.Location = new System.Drawing.Point(830, 40);
            this.AtencionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AtencionText.Name = "AtencionText";
            this.AtencionText.Size = new System.Drawing.Size(190, 21);
            this.AtencionText.TabIndex = 19;
            this.AtencionText.Text = "Selecciona un proveedor...";
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CorreoLabel.Location = new System.Drawing.Point(350, 140);
            this.CorreoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(61, 21);
            this.CorreoLabel.TabIndex = 18;
            this.CorreoLabel.Text = "Correo:";
            // 
            // TeléfonoLabel
            // 
            this.TeléfonoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TeléfonoLabel.Location = new System.Drawing.Point(350, 90);
            this.TeléfonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeléfonoLabel.Name = "TeléfonoLabel";
            this.TeléfonoLabel.Size = new System.Drawing.Size(71, 21);
            this.TeléfonoLabel.TabIndex = 17;
            this.TeléfonoLabel.Text = "Teléfono:";
            // 
            // ProveedorCombo
            // 
            this.ProveedorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedorCombo.FormattingEnabled = true;
            this.ProveedorCombo.Location = new System.Drawing.Point(450, 37);
            this.ProveedorCombo.Name = "ProveedorCombo";
            this.ProveedorCombo.Size = new System.Drawing.Size(200, 29);
            this.ProveedorCombo.TabIndex = 16;
            this.ProveedorCombo.SelectedIndexChanged += new System.EventHandler(this.ProveedorCombo_SelectedIndexChanged);
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProveedorLabel.Location = new System.Drawing.Point(350, 40);
            this.ProveedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(85, 21);
            this.ProveedorLabel.TabIndex = 15;
            this.ProveedorLabel.Text = "Proveedor:";
            // 
            // FechaOrdenPicker
            // 
            this.FechaOrdenPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaOrdenPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaOrdenPicker.Location = new System.Drawing.Point(130, 85);
            this.FechaOrdenPicker.Name = "FechaOrdenPicker";
            this.FechaOrdenPicker.Size = new System.Drawing.Size(150, 31);
            this.FechaOrdenPicker.TabIndex = 14;
            // 
            // FechaEntregaPicker
            // 
            this.FechaEntregaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaEntregaPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaEntregaPicker.Location = new System.Drawing.Point(130, 135);
            this.FechaEntregaPicker.Name = "FechaEntregaPicker";
            this.FechaEntregaPicker.Size = new System.Drawing.Size(150, 31);
            this.FechaEntregaPicker.TabIndex = 13;
            // 
            // FechaEntregaLabel
            // 
            this.FechaEntregaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FechaEntregaLabel.Location = new System.Drawing.Point(30, 140);
            this.FechaEntregaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaEntregaLabel.Name = "FechaEntregaLabel";
            this.FechaEntregaLabel.Size = new System.Drawing.Size(66, 21);
            this.FechaEntregaLabel.TabIndex = 12;
            this.FechaEntregaLabel.Text = "Entrega:";
            // 
            // FechaOrdenLabel
            // 
            this.FechaOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FechaOrdenLabel.Location = new System.Drawing.Point(30, 90);
            this.FechaOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaOrdenLabel.Name = "FechaOrdenLabel";
            this.FechaOrdenLabel.Size = new System.Drawing.Size(74, 21);
            this.FechaOrdenLabel.TabIndex = 10;
            this.FechaOrdenLabel.Text = "Creación:";
            // 
            // NumOrdenText
            // 
            this.NumOrdenText.BeforeTouchSize = new System.Drawing.Size(150, 29);
            this.NumOrdenText.Location = new System.Drawing.Point(130, 37);
            this.NumOrdenText.Name = "NumOrdenText";
            this.NumOrdenText.ReadOnly = true;
            this.NumOrdenText.Size = new System.Drawing.Size(150, 29);
            this.NumOrdenText.TabIndex = 9;
            // 
            // NumOrdenLabel
            // 
            this.NumOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumOrdenLabel.Location = new System.Drawing.Point(30, 40);
            this.NumOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumOrdenLabel.Name = "NumOrdenLabel";
            this.NumOrdenLabel.Size = new System.Drawing.Size(82, 21);
            this.NumOrdenLabel.TabIndex = 8;
            this.NumOrdenLabel.Text = "No. orden:";
            // 
            // RevisarButton
            // 
            this.RevisarButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RevisarButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.RevisarButton.IconColor = System.Drawing.Color.Black;
            this.RevisarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RevisarButton.Location = new System.Drawing.Point(50, 710);
            this.RevisarButton.Name = "RevisarButton";
            this.RevisarButton.Size = new System.Drawing.Size(119, 35);
            this.RevisarButton.TabIndex = 6;
            this.RevisarButton.Text = "Revisar orden";
            this.RevisarButton.UseVisualStyleBackColor = true;
            // 
            // NotasButton
            // 
            this.NotasButton.AutoSize = true;
            this.NotasButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NotasButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.NotasButton.IconColor = System.Drawing.Color.Black;
            this.NotasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NotasButton.IconSize = 25;
            this.NotasButton.Location = new System.Drawing.Point(200, 710);
            this.NotasButton.Name = "NotasButton";
            this.NotasButton.Size = new System.Drawing.Size(86, 35);
            this.NotasButton.TabIndex = 7;
            this.NotasButton.Text = "Notas";
            this.NotasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NotasButton.UseVisualStyleBackColor = true;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 50);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(234, 37);
            this.SubtitleLabel.TabIndex = 29;
            this.SubtitleLabel.Text = "Orden de Compra";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // OrdenCompraCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.NotasButton);
            this.Controls.Add(this.RevisarButton);
            this.Controls.Add(this.ProductosGroupBox);
            this.Controls.Add(this.DatosGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdenCompraCrearForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PurchasingOrderForm";
            this.ProductosGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLineModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductosGroupBox;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private FontAwesome.Sharp.IconButton RevisarButton;
        private FontAwesome.Sharp.IconButton NotasButton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel NumOrdenLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CorreoText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CorreoLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel TeléfonoLabel;
        private System.Windows.Forms.ComboBox ProveedorCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel ProveedorLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaOrdenPicker;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaEntregaPicker;
        private Syncfusion.Windows.Forms.Tools.AutoLabel FechaEntregaLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel FechaOrdenLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt NumOrdenText;
        private System.Windows.Forms.ComboBox CondicionesCombo;
        private System.Windows.Forms.ComboBox AreaCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CondicionesLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AreaLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AtenciónLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AtencionText;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox TeléfonoText;
        private System.Windows.Forms.Label SubtitleLabel;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView;
        private System.Windows.Forms.BindingSource purchaseOrderLineModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadEntregada;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}