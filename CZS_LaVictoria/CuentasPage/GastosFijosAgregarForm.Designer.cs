
namespace CZS_LaVictoria.CuentasPage
{
    partial class GastosFijosAgregarForm
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
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.FechaFacturaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaFacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(268, 37);
            this.SubtitleLabel.TabIndex = 19;
            this.SubtitleLabel.Text = "Agregar Gastos Fijos";
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AllowEditing = false;
            this.DataGrid.AllowFiltering = true;
            this.DataGrid.AllowGrouping = false;
            this.DataGrid.Location = new System.Drawing.Point(50, 100);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.DataGrid.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Multiple;
            this.DataGrid.Size = new System.Drawing.Size(500, 459);
            this.DataGrid.TabIndex = 114;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(472, 620);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 37);
            this.GuardarButton.TabIndex = 115;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // FechaFacturaPicker
            // 
            this.FechaFacturaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaFacturaPicker.Location = new System.Drawing.Point(102, 577);
            this.FechaFacturaPicker.Name = "FechaFacturaPicker";
            this.FechaFacturaPicker.Size = new System.Drawing.Size(140, 33);
            this.FechaFacturaPicker.TabIndex = 117;
            // 
            // FechaFacturaLabel
            // 
            this.FechaFacturaLabel.AutoSize = true;
            this.FechaFacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFacturaLabel.Location = new System.Drawing.Point(46, 580);
            this.FechaFacturaLabel.Name = "FechaFacturaLabel";
            this.FechaFacturaLabel.Size = new System.Drawing.Size(50, 21);
            this.FechaFacturaLabel.TabIndex = 116;
            this.FechaFacturaLabel.Text = "Fecha";
            // 
            // GastosFijosAgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 711);
            this.Controls.Add(this.FechaFacturaPicker);
            this.Controls.Add(this.FechaFacturaLabel);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GastosFijosAgregarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Gastos Fijos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaFacturaPicker;
        private System.Windows.Forms.Label FechaFacturaLabel;
    }
}