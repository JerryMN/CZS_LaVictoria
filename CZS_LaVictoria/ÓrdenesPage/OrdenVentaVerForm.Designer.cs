
namespace CZS_LaVictoria.ÓrdenesPage
{
    partial class OrdenVentaVerForm
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
            this.PendientesCheck = new System.Windows.Forms.CheckBox();
            this.NumOrdenText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NumOrdenLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CancelarButton = new FontAwesome.Sharp.IconButton();
            this.EntregarButton = new FontAwesome.Sharp.IconButton();
            this.BuscarButton = new FontAwesome.Sharp.IconButton();
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PendientesCheck
            // 
            this.PendientesCheck.AutoSize = true;
            this.PendientesCheck.Location = new System.Drawing.Point(375, 25);
            this.PendientesCheck.Name = "PendientesCheck";
            this.PendientesCheck.Size = new System.Drawing.Size(140, 25);
            this.PendientesCheck.TabIndex = 19;
            this.PendientesCheck.Text = "Sólo pendientes";
            this.PendientesCheck.UseVisualStyleBackColor = true;
            // 
            // NumOrdenText
            // 
            this.NumOrdenText.BeforeTouchSize = new System.Drawing.Size(150, 29);
            this.NumOrdenText.Location = new System.Drawing.Point(113, 22);
            this.NumOrdenText.MaxLength = 7;
            this.NumOrdenText.Name = "NumOrdenText";
            this.NumOrdenText.Size = new System.Drawing.Size(150, 29);
            this.NumOrdenText.TabIndex = 18;
            // 
            // NumOrdenLabel
            // 
            this.NumOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumOrdenLabel.Location = new System.Drawing.Point(13, 25);
            this.NumOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumOrdenLabel.Name = "NumOrdenLabel";
            this.NumOrdenLabel.Size = new System.Drawing.Size(82, 21);
            this.NumOrdenLabel.TabIndex = 17;
            this.NumOrdenLabel.Text = "No. orden:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.AutoSize = true;
            this.CancelarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarButton.IconColor = System.Drawing.Color.DarkRed;
            this.CancelarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarButton.IconSize = 24;
            this.CancelarButton.Location = new System.Drawing.Point(700, 22);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(145, 31);
            this.CancelarButton.TabIndex = 14;
            this.CancelarButton.Text = "Cancelar Línea";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EntregarButton
            // 
            this.EntregarButton.AutoSize = true;
            this.EntregarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EntregarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntregarButton.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.EntregarButton.IconColor = System.Drawing.Color.Green;
            this.EntregarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EntregarButton.IconSize = 24;
            this.EntregarButton.Location = new System.Drawing.Point(550, 22);
            this.EntregarButton.Name = "EntregarButton";
            this.EntregarButton.Size = new System.Drawing.Size(144, 31);
            this.EntregarButton.TabIndex = 15;
            this.EntregarButton.Text = "Entregar Línea";
            this.EntregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EntregarButton.UseVisualStyleBackColor = true;
            this.EntregarButton.Click += new System.EventHandler(this.EntregarButton_Click);
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
            this.BuscarButton.Location = new System.Drawing.Point(275, 21);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(90, 31);
            this.BuscarButton.TabIndex = 16;
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
            this.DataGrid.AllowResizingColumns = true;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.DataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.DataGrid.Location = new System.Drawing.Point(0, 75);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ShowGroupDropArea = true;
            this.DataGrid.Size = new System.Drawing.Size(1276, 763);
            this.DataGrid.TabIndex = 20;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InEdit;
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            // 
            // OrdenVentaVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.PendientesCheck);
            this.Controls.Add(this.NumOrdenText);
            this.Controls.Add(this.NumOrdenLabel);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EntregarButton);
            this.Controls.Add(this.BuscarButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdenVentaVerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckSellingOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumOrdenText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PendientesCheck;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt NumOrdenText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel NumOrdenLabel;
        private FontAwesome.Sharp.IconButton CancelarButton;
        private FontAwesome.Sharp.IconButton EntregarButton;
        private FontAwesome.Sharp.IconButton BuscarButton;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
    }
}