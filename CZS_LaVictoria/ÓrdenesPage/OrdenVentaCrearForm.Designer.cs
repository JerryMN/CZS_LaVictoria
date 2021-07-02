
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
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.AreaCombo = new System.Windows.Forms.ComboBox();
            this.AreaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.FechaOrdenPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaEntregaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaEntregaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.FechaOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.NumOrdenText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NumOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ClienteCombo = new System.Windows.Forms.ComboBox();
            this.ClienteLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.TransporteCombo = new System.Windows.Forms.ComboBox();
            this.PuestoCombo = new System.Windows.Forms.ComboBox();
            this.PresentaciónCombo = new System.Windows.Forms.ComboBox();
            this.TransporteLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.PuestoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.PresentaciónLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ProductosGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.RevisarButton = new FontAwesome.Sharp.IconButton();
            this.NotasButton = new FontAwesome.Sharp.IconButton();
            this.SubtitleLabel = new System.Windows.Forms.Label();
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
            this.DatosGroupBox.Controls.Add(this.FechaEntregaPicker);
            this.DatosGroupBox.Controls.Add(this.FechaEntregaLabel);
            this.DatosGroupBox.Controls.Add(this.FechaOrdenLabel);
            this.DatosGroupBox.Controls.Add(this.NumOrdenText);
            this.DatosGroupBox.Controls.Add(this.NumOrdenLabel);
            this.DatosGroupBox.Controls.Add(this.ClienteCombo);
            this.DatosGroupBox.Controls.Add(this.ClienteLabel);
            this.DatosGroupBox.Controls.Add(this.TransporteCombo);
            this.DatosGroupBox.Controls.Add(this.PuestoCombo);
            this.DatosGroupBox.Controls.Add(this.PresentaciónCombo);
            this.DatosGroupBox.Controls.Add(this.TransporteLabel);
            this.DatosGroupBox.Controls.Add(this.PuestoLabel);
            this.DatosGroupBox.Controls.Add(this.PresentaciónLabel);
            this.DatosGroupBox.Location = new System.Drawing.Point(50, 150);
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
            this.AreaCombo.TabIndex = 45;
            this.AreaCombo.SelectedIndexChanged += new System.EventHandler(this.AreaCombo_SelectedIndexChanged);
            // 
            // AreaLabel
            // 
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AreaLabel.Location = new System.Drawing.Point(350, 90);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(45, 21);
            this.AreaLabel.TabIndex = 44;
            this.AreaLabel.Text = "Área:";
            // 
            // FechaOrdenPicker
            // 
            this.FechaOrdenPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaOrdenPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaOrdenPicker.Location = new System.Drawing.Point(130, 85);
            this.FechaOrdenPicker.Name = "FechaOrdenPicker";
            this.FechaOrdenPicker.Size = new System.Drawing.Size(150, 31);
            this.FechaOrdenPicker.TabIndex = 43;
            // 
            // FechaEntregaPicker
            // 
            this.FechaEntregaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaEntregaPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaEntregaPicker.Location = new System.Drawing.Point(130, 135);
            this.FechaEntregaPicker.Name = "FechaEntregaPicker";
            this.FechaEntregaPicker.Size = new System.Drawing.Size(150, 31);
            this.FechaEntregaPicker.TabIndex = 42;
            // 
            // FechaEntregaLabel
            // 
            this.FechaEntregaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FechaEntregaLabel.Location = new System.Drawing.Point(30, 140);
            this.FechaEntregaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaEntregaLabel.Name = "FechaEntregaLabel";
            this.FechaEntregaLabel.Size = new System.Drawing.Size(66, 21);
            this.FechaEntregaLabel.TabIndex = 41;
            this.FechaEntregaLabel.Text = "Entrega:";
            // 
            // FechaOrdenLabel
            // 
            this.FechaOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FechaOrdenLabel.Location = new System.Drawing.Point(30, 90);
            this.FechaOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaOrdenLabel.Name = "FechaOrdenLabel";
            this.FechaOrdenLabel.Size = new System.Drawing.Size(74, 21);
            this.FechaOrdenLabel.TabIndex = 40;
            this.FechaOrdenLabel.Text = "Creación:";
            // 
            // NumOrdenText
            // 
            this.NumOrdenText.BeforeTouchSize = new System.Drawing.Size(150, 29);
            this.NumOrdenText.Location = new System.Drawing.Point(130, 37);
            this.NumOrdenText.Name = "NumOrdenText";
            this.NumOrdenText.ReadOnly = true;
            this.NumOrdenText.Size = new System.Drawing.Size(150, 29);
            this.NumOrdenText.TabIndex = 39;
            // 
            // NumOrdenLabel
            // 
            this.NumOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumOrdenLabel.Location = new System.Drawing.Point(30, 40);
            this.NumOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumOrdenLabel.Name = "NumOrdenLabel";
            this.NumOrdenLabel.Size = new System.Drawing.Size(82, 21);
            this.NumOrdenLabel.TabIndex = 38;
            this.NumOrdenLabel.Text = "No. orden:";
            // 
            // ClienteCombo
            // 
            this.ClienteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteCombo.FormattingEnabled = true;
            this.ClienteCombo.Location = new System.Drawing.Point(450, 37);
            this.ClienteCombo.Name = "ClienteCombo";
            this.ClienteCombo.Size = new System.Drawing.Size(200, 29);
            this.ClienteCombo.TabIndex = 31;
            this.ClienteCombo.SelectedIndexChanged += new System.EventHandler(this.ClienteCombo_SelectedIndexChanged);
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ClienteLabel.Location = new System.Drawing.Point(350, 40);
            this.ClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(61, 21);
            this.ClienteLabel.TabIndex = 30;
            this.ClienteLabel.Text = "Cliente:";
            // 
            // TransporteCombo
            // 
            this.TransporteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransporteCombo.FormattingEnabled = true;
            this.TransporteCombo.Location = new System.Drawing.Point(830, 37);
            this.TransporteCombo.Name = "TransporteCombo";
            this.TransporteCombo.Size = new System.Drawing.Size(200, 29);
            this.TransporteCombo.TabIndex = 29;
            // 
            // PuestoCombo
            // 
            this.PuestoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PuestoCombo.FormattingEnabled = true;
            this.PuestoCombo.Location = new System.Drawing.Point(830, 137);
            this.PuestoCombo.Name = "PuestoCombo";
            this.PuestoCombo.Size = new System.Drawing.Size(200, 29);
            this.PuestoCombo.TabIndex = 28;
            // 
            // PresentaciónCombo
            // 
            this.PresentaciónCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PresentaciónCombo.FormattingEnabled = true;
            this.PresentaciónCombo.Location = new System.Drawing.Point(830, 87);
            this.PresentaciónCombo.Name = "PresentaciónCombo";
            this.PresentaciónCombo.Size = new System.Drawing.Size(200, 29);
            this.PresentaciónCombo.TabIndex = 27;
            // 
            // TransporteLabel
            // 
            this.TransporteLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TransporteLabel.Location = new System.Drawing.Point(730, 40);
            this.TransporteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransporteLabel.Name = "TransporteLabel";
            this.TransporteLabel.Size = new System.Drawing.Size(87, 21);
            this.TransporteLabel.TabIndex = 24;
            this.TransporteLabel.Text = "Transporte:";
            // 
            // PuestoLabel
            // 
            this.PuestoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PuestoLabel.Location = new System.Drawing.Point(730, 140);
            this.PuestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PuestoLabel.Name = "PuestoLabel";
            this.PuestoLabel.Size = new System.Drawing.Size(81, 21);
            this.PuestoLabel.TabIndex = 23;
            this.PuestoLabel.Text = "Puesto en:";
            // 
            // PresentaciónLabel
            // 
            this.PresentaciónLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PresentaciónLabel.Location = new System.Drawing.Point(730, 90);
            this.PresentaciónLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PresentaciónLabel.Name = "PresentaciónLabel";
            this.PresentaciónLabel.Size = new System.Drawing.Size(102, 21);
            this.PresentaciónLabel.TabIndex = 22;
            this.PresentaciónLabel.Text = "Presentación:";
            // 
            // ProductosGroupBox
            // 
            this.ProductosGroupBox.Controls.Add(this.DataGrid);
            this.ProductosGroupBox.Location = new System.Drawing.Point(50, 350);
            this.ProductosGroupBox.Name = "ProductosGroupBox";
            this.ProductosGroupBox.Size = new System.Drawing.Size(1176, 350);
            this.ProductosGroupBox.TabIndex = 2;
            this.ProductosGroupBox.TabStop = false;
            this.ProductosGroupBox.Text = "Productos";
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AddNewRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedBottom;
            this.DataGrid.AddNewRowText = "Nueva línea";
            this.DataGrid.AllowDeleting = true;
            this.DataGrid.AllowGrouping = false;
            this.DataGrid.AllowSorting = false;
            this.DataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.DataGrid.Location = new System.Drawing.Point(3, 25);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(1170, 322);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
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
            this.RevisarButton.TabIndex = 8;
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
            this.NotasButton.TabIndex = 9;
            this.NotasButton.Text = "Notas";
            this.NotasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NotasButton.UseVisualStyleBackColor = true;
            this.NotasButton.Click += new System.EventHandler(this.NotasButton_Click);
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 50);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(206, 37);
            this.SubtitleLabel.TabIndex = 30;
            this.SubtitleLabel.Text = "Orden de Venta";
            // 
            // SaleOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.NotasButton);
            this.Controls.Add(this.ProductosGroupBox);
            this.Controls.Add(this.RevisarButton);
            this.Controls.Add(this.DatosGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaleOrderForm";
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
        private FontAwesome.Sharp.IconButton RevisarButton;
        private System.Windows.Forms.ComboBox PuestoCombo;
        private System.Windows.Forms.ComboBox PresentaciónCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel TransporteLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel PuestoLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel PresentaciónLabel;
        private System.Windows.Forms.ComboBox ClienteCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel ClienteLabel;
        private System.Windows.Forms.ComboBox TransporteCombo;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaOrdenPicker;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaEntregaPicker;
        private Syncfusion.Windows.Forms.Tools.AutoLabel FechaEntregaLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel FechaOrdenLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt NumOrdenText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel NumOrdenLabel;
        private FontAwesome.Sharp.IconButton NotasButton;
        private System.Windows.Forms.ComboBox AreaCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AreaLabel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private System.Windows.Forms.Label SubtitleLabel;
    }
}