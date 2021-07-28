
namespace CZS_LaVictoria.CuentasPage
{
    partial class GastosFijosForm
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
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.MontoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.ConceptoText = new System.Windows.Forms.TextBox();
            this.ConceptoLabel = new System.Windows.Forms.Label();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.BorrarButton = new FontAwesome.Sharp.IconButton();
            this.EditarButton = new FontAwesome.Sharp.IconButton();
            this.DataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(255, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Registrar Gasto Fijo";
            // 
            // MontoText
            // 
            this.MontoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MontoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MontoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.MontoText.Location = new System.Drawing.Point(200, 197);
            this.MontoText.MinValue = 0D;
            this.MontoText.Name = "MontoText";
            this.MontoText.Size = new System.Drawing.Size(300, 29);
            this.MontoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MontoText.TabIndex = 4;
            this.MontoText.Text = "$0.00";
            this.MontoText.WatermarkText = "Calculado automáticamente";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Location = new System.Drawing.Point(50, 200);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(63, 21);
            this.MontoLabel.TabIndex = 3;
            this.MontoLabel.Text = "Monto*";
            // 
            // ConceptoText
            // 
            this.ConceptoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConceptoText.Location = new System.Drawing.Point(200, 147);
            this.ConceptoText.Name = "ConceptoText";
            this.ConceptoText.Size = new System.Drawing.Size(300, 29);
            this.ConceptoText.TabIndex = 2;
            // 
            // ConceptoLabel
            // 
            this.ConceptoLabel.AutoSize = true;
            this.ConceptoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConceptoLabel.Location = new System.Drawing.Point(50, 150);
            this.ConceptoLabel.Name = "ConceptoLabel";
            this.ConceptoLabel.Size = new System.Drawing.Size(83, 21);
            this.ConceptoLabel.TabIndex = 1;
            this.ConceptoLabel.Text = "Concepto*";
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
            this.MsgBox.Location = new System.Drawing.Point(80, 300);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 8;
            this.MsgBox.TabStop = false;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(422, 250);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 37);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
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
            this.BorrarButton.Location = new System.Drawing.Point(725, 145);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(88, 31);
            this.BorrarButton.TabIndex = 7;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
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
            this.EditarButton.Location = new System.Drawing.Point(600, 145);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(84, 31);
            this.EditarButton.TabIndex = 6;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AccessibleName = "Table";
            this.DataGrid.AllowEditing = false;
            this.DataGrid.AllowFiltering = true;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.Location = new System.Drawing.Point(600, 197);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ShowGroupDropArea = true;
            this.DataGrid.Size = new System.Drawing.Size(500, 500);
            this.DataGrid.TabIndex = 9;
            this.DataGrid.Text = "sfDataGrid1";
            this.DataGrid.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.DataGrid_AutoGeneratingColumn);
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // GastosFijosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.MontoText);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.ConceptoText);
            this.Controls.Add(this.ConceptoLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GastosFijosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastosFijosForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox MontoText;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox ConceptoText;
        private System.Windows.Forms.Label ConceptoLabel;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private FontAwesome.Sharp.IconButton BorrarButton;
        private FontAwesome.Sharp.IconButton EditarButton;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DataGrid;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}