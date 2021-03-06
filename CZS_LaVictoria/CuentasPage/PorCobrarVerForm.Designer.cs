
namespace CZS_LaVictoria.CuentasPage
{
    partial class PorCobrarVerForm
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
            this.AgregarButton = new FontAwesome.Sharp.IconButton();
            this.RegistrarButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AllowEditing = false;
            this.DataGrid.AllowFiltering = true;
            this.DataGrid.AllowResizingColumns = true;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.DataGrid.Location = new System.Drawing.Point(0, 75);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ShowGroupDropArea = true;
            this.DataGrid.Size = new System.Drawing.Size(1276, 763);
            this.DataGrid.TabIndex = 9;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InEdit;
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            // 
            // AgregarButton
            // 
            this.AgregarButton.AutoSize = true;
            this.AgregarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AgregarButton.IconColor = System.Drawing.Color.Black;
            this.AgregarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarButton.IconSize = 24;
            this.AgregarButton.Location = new System.Drawing.Point(185, 22);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(150, 31);
            this.AgregarButton.TabIndex = 17;
            this.AgregarButton.Text = "Agregar Nuevo";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.AutoSize = true;
            this.RegistrarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegistrarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarButton.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.RegistrarButton.IconColor = System.Drawing.Color.Green;
            this.RegistrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegistrarButton.IconSize = 24;
            this.RegistrarButton.Location = new System.Drawing.Point(25, 22);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(154, 31);
            this.RegistrarButton.TabIndex = 18;
            this.RegistrarButton.Text = "Registrar Cobro";
            this.RegistrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // PorCobrarVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.DataGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PorCobrarVerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PorCobrarVerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private FontAwesome.Sharp.IconButton AgregarButton;
        private FontAwesome.Sharp.IconButton RegistrarButton;
    }
}