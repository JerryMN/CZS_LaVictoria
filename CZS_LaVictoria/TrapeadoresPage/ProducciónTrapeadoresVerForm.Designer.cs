
namespace CZS_LaVictoria.TrapeadoresPage
{
    partial class ProducciónTrapeadoresVerForm
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
            this.BuscarButton = new FontAwesome.Sharp.IconButton();
            this.HastaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdePicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.TodosCheck = new System.Windows.Forms.CheckBox();
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
            this.DataGrid.Location = new System.Drawing.Point(0, 75);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ShowGroupDropArea = true;
            this.DataGrid.Size = new System.Drawing.Size(1276, 764);
            this.DataGrid.TabIndex = 33;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            // 
            // BuscarButton
            // 
            this.BuscarButton.AutoSize = true;
            this.BuscarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuscarButton.Enabled = false;
            this.BuscarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BuscarButton.IconColor = System.Drawing.Color.Black;
            this.BuscarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarButton.IconSize = 24;
            this.BuscarButton.Location = new System.Drawing.Point(675, 21);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(90, 31);
            this.BuscarButton.TabIndex = 39;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // HastaPicker
            // 
            this.HastaPicker.AllowValueChangeOnMouseWheel = true;
            this.HastaPicker.Enabled = false;
            this.HastaPicker.Location = new System.Drawing.Point(505, 20);
            this.HastaPicker.Name = "HastaPicker";
            this.HastaPicker.Size = new System.Drawing.Size(137, 33);
            this.HastaPicker.TabIndex = 38;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaLabel.Location = new System.Drawing.Point(450, 25);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(49, 21);
            this.HastaLabel.TabIndex = 37;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdePicker
            // 
            this.DesdePicker.AllowValueChangeOnMouseWheel = true;
            this.DesdePicker.Enabled = false;
            this.DesdePicker.Location = new System.Drawing.Point(259, 20);
            this.DesdePicker.Name = "DesdePicker";
            this.DesdePicker.Size = new System.Drawing.Size(137, 33);
            this.DesdePicker.TabIndex = 36;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeLabel.Location = new System.Drawing.Point(200, 25);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(53, 21);
            this.DesdeLabel.TabIndex = 35;
            this.DesdeLabel.Text = "Desde";
            // 
            // TodosCheck
            // 
            this.TodosCheck.AutoSize = true;
            this.TodosCheck.Checked = true;
            this.TodosCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TodosCheck.Location = new System.Drawing.Point(25, 25);
            this.TodosCheck.Name = "TodosCheck";
            this.TodosCheck.Size = new System.Drawing.Size(121, 25);
            this.TodosCheck.TabIndex = 34;
            this.TodosCheck.Text = "Mostrar Todo";
            this.TodosCheck.UseVisualStyleBackColor = true;
            this.TodosCheck.CheckedChanged += new System.EventHandler(this.TodosCheck_CheckedChanged);
            // 
            // ProducciónTrapeadoresVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.HastaPicker);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdePicker);
            this.Controls.Add(this.DesdeLabel);
            this.Controls.Add(this.TodosCheck);
            this.Controls.Add(this.DataGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProducciónTrapeadoresVerForm";
            this.Text = "ProducciónTrapeadoresVerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private FontAwesome.Sharp.IconButton BuscarButton;
        private Syncfusion.WinForms.Input.SfDateTimeEdit HastaPicker;
        private System.Windows.Forms.Label HastaLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit DesdePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.CheckBox TodosCheck;
    }
}