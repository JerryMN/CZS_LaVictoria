
namespace CZS_LaVictoria.ÓrdenesPage
{
    partial class OrdenCompraVerForm
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
            this.BuscarButton = new FontAwesome.Sharp.IconButton();
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.NumOrdenText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NumOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CondicionesLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.AreaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ProveedorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.FechaEntregaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaEntregaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ProveedorText = new System.Windows.Forms.TextBox();
            this.AreaText = new System.Windows.Forms.TextBox();
            this.CondicionesText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.AutoSize = true;
            this.BuscarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuscarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BuscarButton.IconColor = System.Drawing.Color.Black;
            this.BuscarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarButton.IconSize = 24;
            this.BuscarButton.Location = new System.Drawing.Point(13, 97);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(90, 31);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AllowEditing = false;
            this.DataGrid.AllowFiltering = true;
            this.DataGrid.AllowGrouping = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            this.DataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.DataGrid.Location = new System.Drawing.Point(0, 152);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ShowRowHeader = true;
            this.DataGrid.Size = new System.Drawing.Size(1276, 686);
            this.DataGrid.TabIndex = 7;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InEdit;
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            // 
            // NumOrdenText
            // 
            this.NumOrdenText.BeforeTouchSize = new System.Drawing.Size(150, 29);
            this.NumOrdenText.Location = new System.Drawing.Point(113, 47);
            this.NumOrdenText.MaxLength = 7;
            this.NumOrdenText.Name = "NumOrdenText";
            this.NumOrdenText.Size = new System.Drawing.Size(150, 29);
            this.NumOrdenText.TabIndex = 11;
            // 
            // NumOrdenLabel
            // 
            this.NumOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumOrdenLabel.Location = new System.Drawing.Point(13, 50);
            this.NumOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumOrdenLabel.Name = "NumOrdenLabel";
            this.NumOrdenLabel.Size = new System.Drawing.Size(82, 21);
            this.NumOrdenLabel.TabIndex = 10;
            this.NumOrdenLabel.Text = "No. orden:";
            // 
            // CondicionesLabel
            // 
            this.CondicionesLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CondicionesLabel.Location = new System.Drawing.Point(700, 100);
            this.CondicionesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CondicionesLabel.Name = "CondicionesLabel";
            this.CondicionesLabel.Size = new System.Drawing.Size(98, 21);
            this.CondicionesLabel.TabIndex = 33;
            this.CondicionesLabel.Text = "Condiciones:";
            // 
            // AreaLabel
            // 
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AreaLabel.Location = new System.Drawing.Point(700, 50);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(45, 21);
            this.AreaLabel.TabIndex = 32;
            this.AreaLabel.Text = "Área:";
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProveedorLabel.Location = new System.Drawing.Point(320, 50);
            this.ProveedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(85, 21);
            this.ProveedorLabel.TabIndex = 31;
            this.ProveedorLabel.Text = "Proveedor:";
            // 
            // FechaEntregaPicker
            // 
            this.FechaEntregaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaEntregaPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaEntregaPicker.Enabled = false;
            this.FechaEntregaPicker.Location = new System.Drawing.Point(420, 95);
            this.FechaEntregaPicker.Name = "FechaEntregaPicker";
            this.FechaEntregaPicker.Size = new System.Drawing.Size(150, 31);
            this.FechaEntregaPicker.TabIndex = 29;
            this.FechaEntregaPicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // FechaEntregaLabel
            // 
            this.FechaEntregaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FechaEntregaLabel.Location = new System.Drawing.Point(320, 100);
            this.FechaEntregaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaEntregaLabel.Name = "FechaEntregaLabel";
            this.FechaEntregaLabel.Size = new System.Drawing.Size(66, 21);
            this.FechaEntregaLabel.TabIndex = 28;
            this.FechaEntregaLabel.Text = "Entrega:";
            // 
            // ProveedorText
            // 
            this.ProveedorText.Enabled = false;
            this.ProveedorText.Location = new System.Drawing.Point(420, 47);
            this.ProveedorText.Name = "ProveedorText";
            this.ProveedorText.Size = new System.Drawing.Size(238, 29);
            this.ProveedorText.TabIndex = 36;
            // 
            // AreaText
            // 
            this.AreaText.Enabled = false;
            this.AreaText.Location = new System.Drawing.Point(800, 47);
            this.AreaText.Name = "AreaText";
            this.AreaText.Size = new System.Drawing.Size(220, 29);
            this.AreaText.TabIndex = 36;
            // 
            // CondicionesText
            // 
            this.CondicionesText.Enabled = false;
            this.CondicionesText.Location = new System.Drawing.Point(800, 97);
            this.CondicionesText.Name = "CondicionesText";
            this.CondicionesText.Size = new System.Drawing.Size(220, 29);
            this.CondicionesText.TabIndex = 36;
            // 
            // OrdenCompraVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.CondicionesText);
            this.Controls.Add(this.AreaText);
            this.Controls.Add(this.ProveedorText);
            this.Controls.Add(this.CondicionesLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.ProveedorLabel);
            this.Controls.Add(this.FechaEntregaPicker);
            this.Controls.Add(this.FechaEntregaLabel);
            this.Controls.Add(this.NumOrdenText);
            this.Controls.Add(this.NumOrdenLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DataGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdenCompraVerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckPurchaseOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BuscarButton;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt NumOrdenText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel NumOrdenLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CondicionesLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AreaLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel ProveedorLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaEntregaPicker;
        private Syncfusion.Windows.Forms.Tools.AutoLabel FechaEntregaLabel;
        private System.Windows.Forms.TextBox ProveedorText;
        private System.Windows.Forms.TextBox AreaText;
        private System.Windows.Forms.TextBox CondicionesText;
    }
}