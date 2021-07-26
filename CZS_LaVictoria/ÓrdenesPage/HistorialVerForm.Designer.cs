
namespace CZS_LaVictoria.ÓrdenesPage
{
    partial class HistorialVerForm
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
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.CompraButton = new System.Windows.Forms.RadioButton();
            this.VentaButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AllowEditing = false;
            this.DataGrid.AllowFiltering = true;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            this.DataGrid.Location = new System.Drawing.Point(0, 52);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ShowGroupDropArea = true;
            this.DataGrid.Size = new System.Drawing.Size(1276, 786);
            this.DataGrid.TabIndex = 4;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            // 
            // CompraButton
            // 
            this.CompraButton.AutoSize = true;
            this.CompraButton.Location = new System.Drawing.Point(12, 12);
            this.CompraButton.Name = "CompraButton";
            this.CompraButton.Size = new System.Drawing.Size(114, 25);
            this.CompraButton.TabIndex = 5;
            this.CompraButton.TabStop = true;
            this.CompraButton.Text = "Recepciones";
            this.CompraButton.UseVisualStyleBackColor = true;
            this.CompraButton.CheckedChanged += new System.EventHandler(this.RadioChanged);
            // 
            // VentaButton
            // 
            this.VentaButton.AutoSize = true;
            this.VentaButton.Location = new System.Drawing.Point(132, 12);
            this.VentaButton.Name = "VentaButton";
            this.VentaButton.Size = new System.Drawing.Size(88, 25);
            this.VentaButton.TabIndex = 5;
            this.VentaButton.TabStop = true;
            this.VentaButton.Text = "Entregas";
            this.VentaButton.UseVisualStyleBackColor = true;
            this.VentaButton.CheckedChanged += new System.EventHandler(this.RadioChanged);
            // 
            // HistorialVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.VentaButton);
            this.Controls.Add(this.CompraButton);
            this.Controls.Add(this.DataGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistorialVerForm";
            this.Text = "HistorialVerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private System.Windows.Forms.RadioButton CompraButton;
        private System.Windows.Forms.RadioButton VentaButton;
    }
}