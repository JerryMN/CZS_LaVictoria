
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
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.CondicionesCombo = new System.Windows.Forms.ComboBox();
            this.AreaCombo = new System.Windows.Forms.ComboBox();
            this.CondicionesLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.AreaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ProveedorCombo = new System.Windows.Forms.ComboBox();
            this.ProveedorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.FechaOrdenPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.NumOrdenText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NumOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.GuardarButton = new DevExpress.XtraEditors.SimpleButton();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.purchaseOrderLineModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotasButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLineModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosGroupBox
            // 
            this.ProductosGroupBox.Controls.Add(this.DataGrid);
            this.ProductosGroupBox.Location = new System.Drawing.Point(50, 300);
            this.ProductosGroupBox.Name = "ProductosGroupBox";
            this.ProductosGroupBox.Size = new System.Drawing.Size(1176, 300);
            this.ProductosGroupBox.TabIndex = 2;
            this.ProductosGroupBox.TabStop = false;
            this.ProductosGroupBox.Text = "Productos";
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AddNewRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Bottom;
            this.DataGrid.AddNewRowText = "Da click para agregar una nueva línea";
            this.DataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.DataGrid.LiveDataUpdateMode = Syncfusion.Data.LiveDataUpdateMode.AllowDataShaping;
            this.DataGrid.Location = new System.Drawing.Point(3, 25);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.NewItemPlaceholderPosition = Syncfusion.Data.NewItemPlaceholderPosition.AtEnd;
            this.DataGrid.Size = new System.Drawing.Size(1170, 272);
            this.DataGrid.Style.AddNewRowStyle.BackColor = System.Drawing.Color.Maroon;
            this.DataGrid.Style.AddNewRowStyle.TextColor = System.Drawing.Color.White;
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            this.DataGrid.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.DataGrid_CurrentCellEndEdit);
            this.DataGrid.AddNewRowInitiating += new Syncfusion.WinForms.DataGrid.Events.AddNewRowInitiatingEventHandler(this.DataGrid_AddNewRowInitiating);
            this.DataGrid.CellCheckBoxClick += new Syncfusion.WinForms.DataGrid.Events.CellCheckBoxClickEventHandler(this.DataGrid_CellCheckBoxClick);
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.CondicionesCombo);
            this.DatosGroupBox.Controls.Add(this.AreaCombo);
            this.DatosGroupBox.Controls.Add(this.CondicionesLabel);
            this.DatosGroupBox.Controls.Add(this.AreaLabel);
            this.DatosGroupBox.Controls.Add(this.ProveedorCombo);
            this.DatosGroupBox.Controls.Add(this.ProveedorLabel);
            this.DatosGroupBox.Controls.Add(this.FechaOrdenPicker);
            this.DatosGroupBox.Controls.Add(this.FechaOrdenLabel);
            this.DatosGroupBox.Controls.Add(this.NumOrdenText);
            this.DatosGroupBox.Controls.Add(this.NumOrdenLabel);
            this.DatosGroupBox.Location = new System.Drawing.Point(50, 100);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(1176, 183);
            this.DatosGroupBox.TabIndex = 1;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // CondicionesCombo
            // 
            this.CondicionesCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CondicionesCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CondicionesCombo.FormattingEnabled = true;
            this.CondicionesCombo.Location = new System.Drawing.Point(830, 87);
            this.CondicionesCombo.Name = "CondicionesCombo";
            this.CondicionesCombo.Size = new System.Drawing.Size(202, 29);
            this.CondicionesCombo.TabIndex = 9;
            // 
            // AreaCombo
            // 
            this.AreaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaCombo.FormattingEnabled = true;
            this.AreaCombo.Location = new System.Drawing.Point(450, 37);
            this.AreaCombo.Name = "AreaCombo";
            this.AreaCombo.Size = new System.Drawing.Size(202, 29);
            this.AreaCombo.TabIndex = 3;
            this.AreaCombo.SelectedIndexChanged += new System.EventHandler(this.AreaCombo_SelectedIndexChanged);
            // 
            // CondicionesLabel
            // 
            this.CondicionesLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CondicionesLabel.Location = new System.Drawing.Point(730, 90);
            this.CondicionesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CondicionesLabel.Name = "CondicionesLabel";
            this.CondicionesLabel.Size = new System.Drawing.Size(98, 21);
            this.CondicionesLabel.TabIndex = 8;
            this.CondicionesLabel.Text = "Condiciones:";
            // 
            // AreaLabel
            // 
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AreaLabel.Location = new System.Drawing.Point(350, 40);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(45, 21);
            this.AreaLabel.TabIndex = 2;
            this.AreaLabel.Text = "Área:";
            // 
            // ProveedorCombo
            // 
            this.ProveedorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedorCombo.FormattingEnabled = true;
            this.ProveedorCombo.Location = new System.Drawing.Point(830, 37);
            this.ProveedorCombo.Name = "ProveedorCombo";
            this.ProveedorCombo.Size = new System.Drawing.Size(200, 29);
            this.ProveedorCombo.TabIndex = 5;
            this.ProveedorCombo.SelectedIndexChanged += new System.EventHandler(this.ProveedorCombo_SelectedIndexChanged);
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProveedorLabel.Location = new System.Drawing.Point(730, 40);
            this.ProveedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(85, 21);
            this.ProveedorLabel.TabIndex = 4;
            this.ProveedorLabel.Text = "Proveedor:";
            // 
            // FechaOrdenPicker
            // 
            this.FechaOrdenPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaOrdenPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaOrdenPicker.Location = new System.Drawing.Point(130, 85);
            this.FechaOrdenPicker.Name = "FechaOrdenPicker";
            this.FechaOrdenPicker.Size = new System.Drawing.Size(150, 31);
            this.FechaOrdenPicker.TabIndex = 7;
            this.FechaOrdenPicker.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.FechaOrdenPicker_ValueChanged);
            // 
            // FechaOrdenLabel
            // 
            this.FechaOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FechaOrdenLabel.Location = new System.Drawing.Point(30, 90);
            this.FechaOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaOrdenLabel.Name = "FechaOrdenLabel";
            this.FechaOrdenLabel.Size = new System.Drawing.Size(74, 21);
            this.FechaOrdenLabel.TabIndex = 6;
            this.FechaOrdenLabel.Text = "Creación:";
            // 
            // NumOrdenText
            // 
            this.NumOrdenText.BeforeTouchSize = new System.Drawing.Size(150, 29);
            this.NumOrdenText.Location = new System.Drawing.Point(130, 37);
            this.NumOrdenText.Name = "NumOrdenText";
            this.NumOrdenText.ReadOnly = true;
            this.NumOrdenText.Size = new System.Drawing.Size(150, 29);
            this.NumOrdenText.TabIndex = 1;
            this.NumOrdenText.TabStop = false;
            this.NumOrdenText.Text = "2100000";
            // 
            // NumOrdenLabel
            // 
            this.NumOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumOrdenLabel.Location = new System.Drawing.Point(30, 40);
            this.NumOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumOrdenLabel.Name = "NumOrdenLabel";
            this.NumOrdenLabel.Size = new System.Drawing.Size(82, 21);
            this.NumOrdenLabel.TabIndex = 0;
            this.NumOrdenLabel.Text = "No. orden:";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(234, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Orden de Compra";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Appearance.Options.UseFont = true;
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GuardarButton.ImageOptions.SvgImage")));
            this.GuardarButton.Location = new System.Drawing.Point(180, 625);
            this.GuardarButton.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.GuardarButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.GuardarButton.Size = new System.Drawing.Size(99, 36);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MsgBox
            // 
            this.MsgBox.FlatAppearance.BorderSize = 0;
            this.MsgBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.MsgBox.IconColor = System.Drawing.Color.DarkRed;
            this.MsgBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MsgBox.IconSize = 32;
            this.MsgBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.Location = new System.Drawing.Point(806, 625);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 157);
            this.MsgBox.TabIndex = 5;
            this.MsgBox.TabStop = false;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // purchaseOrderLineModelBindingSource
            // 
            this.purchaseOrderLineModelBindingSource.DataSource = typeof(CZS_LaVictoria_Library.Models.OrdenCompraLíneaModel);
            // 
            // NotasButton
            // 
            this.NotasButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasButton.Appearance.Options.UseFont = true;
            this.NotasButton.AutoSize = true;
            this.NotasButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NotasButton.ImageOptions.SvgImage")));
            this.NotasButton.Location = new System.Drawing.Point(50, 625);
            this.NotasButton.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.NotasButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.NotasButton.Name = "NotasButton";
            this.NotasButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.NotasButton.Size = new System.Drawing.Size(83, 36);
            this.NotasButton.TabIndex = 3;
            this.NotasButton.Text = "Notas";
            this.NotasButton.Click += new System.EventHandler(this.NotasButton_Click);
            // 
            // OrdenCompraCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.NotasButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.SubtitleLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderLineModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductosGroupBox;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel NumOrdenLabel;
        private System.Windows.Forms.ComboBox ProveedorCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel ProveedorLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaOrdenPicker;
        private Syncfusion.Windows.Forms.Tools.AutoLabel FechaOrdenLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt NumOrdenText;
        private System.Windows.Forms.ComboBox CondicionesCombo;
        private System.Windows.Forms.ComboBox AreaCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CondicionesLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AreaLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.BindingSource purchaseOrderLineModelBindingSource;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private DevExpress.XtraEditors.SimpleButton GuardarButton;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private DevExpress.XtraEditors.SimpleButton NotasButton;
    }
}