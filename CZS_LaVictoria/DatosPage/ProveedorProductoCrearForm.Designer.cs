
namespace CZS_LaVictoria.DatosPage
{
    partial class ProveedorProductoCrearForm
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
            this.ProveedorLabel = new System.Windows.Forms.Label();
            this.MaterialProveedorLabel = new System.Windows.Forms.Label();
            this.MaterialInternoLabel = new System.Windows.Forms.Label();
            this.PrecioUnitarioLabel = new System.Windows.Forms.Label();
            this.MaterialProveedorText = new System.Windows.Forms.TextBox();
            this.PrecioUnitarioText = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.ProveedorCombo = new System.Windows.Forms.ComboBox();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.AreaLabel = new System.Windows.Forms.Label();
            this.AreaCombo = new System.Windows.Forms.ComboBox();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.CategoríaLabel = new System.Windows.Forms.Label();
            this.CategoríaCombo = new System.Windows.Forms.ComboBox();
            this.MaterialInternoCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUnitarioText)).BeginInit();
            this.SuspendLayout();
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.AutoSize = true;
            this.ProveedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorLabel.Location = new System.Drawing.Point(50, 150);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(89, 21);
            this.ProveedorLabel.TabIndex = 1;
            this.ProveedorLabel.Text = "Proveedor*";
            // 
            // MaterialProveedorLabel
            // 
            this.MaterialProveedorLabel.AutoSize = true;
            this.MaterialProveedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialProveedorLabel.Location = new System.Drawing.Point(50, 250);
            this.MaterialProveedorLabel.Name = "MaterialProveedorLabel";
            this.MaterialProveedorLabel.Size = new System.Drawing.Size(150, 21);
            this.MaterialProveedorLabel.TabIndex = 3;
            this.MaterialProveedorLabel.Text = "Material Proveedor*";
            // 
            // MaterialInternoLabel
            // 
            this.MaterialInternoLabel.AutoSize = true;
            this.MaterialInternoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialInternoLabel.Location = new System.Drawing.Point(50, 300);
            this.MaterialInternoLabel.Name = "MaterialInternoLabel";
            this.MaterialInternoLabel.Size = new System.Drawing.Size(128, 21);
            this.MaterialInternoLabel.TabIndex = 5;
            this.MaterialInternoLabel.Text = "Material Interno*";
            // 
            // PrecioUnitarioLabel
            // 
            this.PrecioUnitarioLabel.AutoSize = true;
            this.PrecioUnitarioLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitarioLabel.Location = new System.Drawing.Point(50, 350);
            this.PrecioUnitarioLabel.Name = "PrecioUnitarioLabel";
            this.PrecioUnitarioLabel.Size = new System.Drawing.Size(120, 21);
            this.PrecioUnitarioLabel.TabIndex = 7;
            this.PrecioUnitarioLabel.Text = "Precio Unitario*";
            // 
            // MaterialProveedorText
            // 
            this.MaterialProveedorText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialProveedorText.Location = new System.Drawing.Point(220, 247);
            this.MaterialProveedorText.Name = "MaterialProveedorText";
            this.MaterialProveedorText.Size = new System.Drawing.Size(250, 29);
            this.MaterialProveedorText.TabIndex = 4;
            // 
            // PrecioUnitarioText
            // 
            this.PrecioUnitarioText.BeforeTouchSize = new System.Drawing.Size(250, 29);
            this.PrecioUnitarioText.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.PrecioUnitarioText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitarioText.Location = new System.Drawing.Point(220, 347);
            this.PrecioUnitarioText.Name = "PrecioUnitarioText";
            this.PrecioUnitarioText.Size = new System.Drawing.Size(250, 29);
            this.PrecioUnitarioText.TabIndex = 8;
            this.PrecioUnitarioText.Text = "$0.00";
            // 
            // ProveedorCombo
            // 
            this.ProveedorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorCombo.FormattingEnabled = true;
            this.ProveedorCombo.Location = new System.Drawing.Point(220, 147);
            this.ProveedorCombo.Name = "ProveedorCombo";
            this.ProveedorCombo.Size = new System.Drawing.Size(250, 29);
            this.ProveedorCombo.TabIndex = 2;
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
            this.MsgBox.Location = new System.Drawing.Point(50, 550);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 150);
            this.MsgBox.TabIndex = 14;
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
            this.GuardarButton.Location = new System.Drawing.Point(392, 500);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 31);
            this.GuardarButton.TabIndex = 13;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLabel.Location = new System.Drawing.Point(50, 400);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(102, 21);
            this.AreaLabel.TabIndex = 9;
            this.AreaLabel.Text = "Área Interna*";
            // 
            // AreaCombo
            // 
            this.AreaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaCombo.FormattingEnabled = true;
            this.AreaCombo.Location = new System.Drawing.Point(220, 397);
            this.AreaCombo.Name = "AreaCombo";
            this.AreaCombo.Size = new System.Drawing.Size(250, 29);
            this.AreaCombo.TabIndex = 10;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(360, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Crear Material de Proveedor";
            // 
            // CategoríaLabel
            // 
            this.CategoríaLabel.AutoSize = true;
            this.CategoríaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoríaLabel.Location = new System.Drawing.Point(50, 450);
            this.CategoríaLabel.Name = "CategoríaLabel";
            this.CategoríaLabel.Size = new System.Drawing.Size(84, 21);
            this.CategoríaLabel.TabIndex = 11;
            this.CategoríaLabel.Text = "Categoría*";
            // 
            // CategoríaCombo
            // 
            this.CategoríaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoríaCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoríaCombo.FormattingEnabled = true;
            this.CategoríaCombo.Location = new System.Drawing.Point(220, 447);
            this.CategoríaCombo.Name = "CategoríaCombo";
            this.CategoríaCombo.Size = new System.Drawing.Size(250, 29);
            this.CategoríaCombo.TabIndex = 12;
            // 
            // MaterialInternoCombo
            // 
            this.MaterialInternoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MaterialInternoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MaterialInternoCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialInternoCombo.FormattingEnabled = true;
            this.MaterialInternoCombo.Location = new System.Drawing.Point(220, 297);
            this.MaterialInternoCombo.Name = "MaterialInternoCombo";
            this.MaterialInternoCombo.Size = new System.Drawing.Size(250, 29);
            this.MaterialInternoCombo.TabIndex = 2;
            // 
            // ProveedorProductoCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CategoríaCombo);
            this.Controls.Add(this.AreaCombo);
            this.Controls.Add(this.MaterialInternoCombo);
            this.Controls.Add(this.ProveedorCombo);
            this.Controls.Add(this.PrecioUnitarioText);
            this.Controls.Add(this.MaterialProveedorText);
            this.Controls.Add(this.CategoríaLabel);
            this.Controls.Add(this.PrecioUnitarioLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.MaterialInternoLabel);
            this.Controls.Add(this.MaterialProveedorLabel);
            this.Controls.Add(this.ProveedorLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProveedorProductoCrearForm";
            this.Text = "CrearProductoProveedorForm";
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUnitarioText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProveedorLabel;
        private System.Windows.Forms.Label MaterialProveedorLabel;
        private System.Windows.Forms.Label MaterialInternoLabel;
        private System.Windows.Forms.Label PrecioUnitarioLabel;
        private System.Windows.Forms.TextBox MaterialProveedorText;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox PrecioUnitarioText;
        private System.Windows.Forms.ComboBox ProveedorCombo;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.ComboBox AreaCombo;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label CategoríaLabel;
        private System.Windows.Forms.ComboBox CategoríaCombo;
        private System.Windows.Forms.ComboBox MaterialInternoCombo;
    }
}