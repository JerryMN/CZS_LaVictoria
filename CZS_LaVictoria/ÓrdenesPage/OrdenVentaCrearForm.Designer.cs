

namespace CZS_LaVictoria.ÓrdenesPage
{
    partial class OrdenVentaCrearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenVentaCrearForm));
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.AreaCombo = new System.Windows.Forms.ComboBox();
            this.AreaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.FechaOrdenPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.NumOrdenText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NumOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ClienteCombo = new System.Windows.Forms.ComboBox();
            this.ClienteLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.TransporteCombo = new System.Windows.Forms.ComboBox();
            this.PuestoCombo = new System.Windows.Forms.ComboBox();
            this.TransporteLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.PuestoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ProductosGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new DevExpress.XtraEditors.SimpleButton();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.NotasButton = new DevExpress.XtraEditors.SimpleButton();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).BeginInit();
            this.ProductosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.AreaCombo);
            this.DatosGroupBox.Controls.Add(this.AreaLabel);
            this.DatosGroupBox.Controls.Add(this.FechaOrdenPicker);
            this.DatosGroupBox.Controls.Add(this.FechaOrdenLabel);
            this.DatosGroupBox.Controls.Add(this.NumOrdenText);
            this.DatosGroupBox.Controls.Add(this.NumOrdenLabel);
            this.DatosGroupBox.Controls.Add(this.ClienteCombo);
            this.DatosGroupBox.Controls.Add(this.ClienteLabel);
            this.DatosGroupBox.Controls.Add(this.TransporteCombo);
            this.DatosGroupBox.Controls.Add(this.PuestoCombo);
            this.DatosGroupBox.Controls.Add(this.TransporteLabel);
            this.DatosGroupBox.Controls.Add(this.PuestoLabel);
            this.DatosGroupBox.Location = new System.Drawing.Point(50, 100);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(1176, 183);
            this.DatosGroupBox.TabIndex = 1;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // AreaCombo
            // 
            this.AreaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaCombo.FormattingEnabled = true;
            this.AreaCombo.Location = new System.Drawing.Point(450, 87);
            this.AreaCombo.Name = "AreaCombo";
            this.AreaCombo.Size = new System.Drawing.Size(200, 29);
            this.AreaCombo.TabIndex = 9;
            this.AreaCombo.SelectedIndexChanged += new System.EventHandler(this.AreaCombo_SelectedIndexChanged);
            // 
            // AreaLabel
            // 
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AreaLabel.Location = new System.Drawing.Point(350, 90);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(45, 21);
            this.AreaLabel.TabIndex = 8;
            this.AreaLabel.Text = "Área:";
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
            // ClienteCombo
            // 
            this.ClienteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteCombo.FormattingEnabled = true;
            this.ClienteCombo.Location = new System.Drawing.Point(450, 37);
            this.ClienteCombo.Name = "ClienteCombo";
            this.ClienteCombo.Size = new System.Drawing.Size(200, 29);
            this.ClienteCombo.TabIndex = 3;
            this.ClienteCombo.SelectedIndexChanged += new System.EventHandler(this.ClienteCombo_SelectedIndexChanged);
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ClienteLabel.Location = new System.Drawing.Point(350, 40);
            this.ClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(61, 21);
            this.ClienteLabel.TabIndex = 2;
            this.ClienteLabel.Text = "Cliente:";
            // 
            // TransporteCombo
            // 
            this.TransporteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransporteCombo.FormattingEnabled = true;
            this.TransporteCombo.Location = new System.Drawing.Point(830, 37);
            this.TransporteCombo.Name = "TransporteCombo";
            this.TransporteCombo.Size = new System.Drawing.Size(200, 29);
            this.TransporteCombo.TabIndex = 5;
            // 
            // PuestoCombo
            // 
            this.PuestoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PuestoCombo.FormattingEnabled = true;
            this.PuestoCombo.Location = new System.Drawing.Point(830, 92);
            this.PuestoCombo.Name = "PuestoCombo";
            this.PuestoCombo.Size = new System.Drawing.Size(200, 29);
            this.PuestoCombo.TabIndex = 11;
            // 
            // TransporteLabel
            // 
            this.TransporteLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TransporteLabel.Location = new System.Drawing.Point(730, 40);
            this.TransporteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransporteLabel.Name = "TransporteLabel";
            this.TransporteLabel.Size = new System.Drawing.Size(87, 21);
            this.TransporteLabel.TabIndex = 4;
            this.TransporteLabel.Text = "Transporte:";
            // 
            // PuestoLabel
            // 
            this.PuestoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PuestoLabel.Location = new System.Drawing.Point(730, 95);
            this.PuestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PuestoLabel.Name = "PuestoLabel";
            this.PuestoLabel.Size = new System.Drawing.Size(81, 21);
            this.PuestoLabel.TabIndex = 10;
            this.PuestoLabel.Text = "Puesto en:";
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
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(206, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Orden de Venta";
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
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
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
            // OrdenVentaCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.NotasButton);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.ProductosGroupBox);
            this.Controls.Add(this.DatosGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdenVentaCrearForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SellingOrderForm";
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).EndInit();
            this.ProductosGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.GroupBox ProductosGroupBox;
        private System.Windows.Forms.ComboBox PuestoCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel TransporteLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel PuestoLabel;
        private System.Windows.Forms.ComboBox ClienteCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel ClienteLabel;
        private System.Windows.Forms.ComboBox TransporteCombo;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaOrdenPicker;
        private Syncfusion.Windows.Forms.Tools.AutoLabel FechaOrdenLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt NumOrdenText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel NumOrdenLabel;
        private System.Windows.Forms.ComboBox AreaCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AreaLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private FontAwesome.Sharp.IconButton MsgBox;
        private DevExpress.XtraEditors.SimpleButton GuardarButton;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private DevExpress.XtraEditors.SimpleButton NotasButton;
    }
}