
namespace CZS_LaVictoria.DatosPage
{
    partial class ProveedorVerForm
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
            this.EditarButton = new FontAwesome.Sharp.IconButton();
            this.BorrarButton = new FontAwesome.Sharp.IconButton();
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EditarButton
            // 
            this.EditarButton.AutoSize = true;
            this.EditarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditarButton.IconColor = System.Drawing.Color.Black;
            this.EditarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarButton.IconSize = 24;
            this.EditarButton.Location = new System.Drawing.Point(12, 12);
            this.EditarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(84, 31);
            this.EditarButton.TabIndex = 0;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.AutoSize = true;
            this.BorrarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BorrarButton.IconColor = System.Drawing.Color.Black;
            this.BorrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarButton.IconSize = 24;
            this.BorrarButton.Location = new System.Drawing.Point(125, 12);
            this.BorrarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(88, 31);
            this.BorrarButton.TabIndex = 1;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AllowEditing = false;
            this.DataGrid.AllowFiltering = true;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.Location = new System.Drawing.Point(0, 50);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ShowGroupDropArea = true;
            this.DataGrid.Size = new System.Drawing.Size(1276, 789);
            this.DataGrid.TabIndex = 2;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            // 
            // ProveedorVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.EditarButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProveedorVerForm";
            this.Text = "VerProveedoresForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton EditarButton;
        private FontAwesome.Sharp.IconButton BorrarButton;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
    }
}