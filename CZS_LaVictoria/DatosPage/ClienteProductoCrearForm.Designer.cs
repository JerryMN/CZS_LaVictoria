
namespace CZS_LaVictoria.DatosPage
{
    partial class ClienteProductoCrearForm
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
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.AreaCombo = new System.Windows.Forms.ComboBox();
            this.PrecioUnitarioText = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.PrecioUnitarioLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.ProductoInternoLabel = new System.Windows.Forms.Label();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.ProductoInternoCombo = new System.Windows.Forms.ComboBox();
            this.ClienteCombo = new System.Windows.Forms.ComboBox();
            this.ClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUnitarioText)).BeginInit();
            this.SuspendLayout();
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
            this.MsgBox.Location = new System.Drawing.Point(50, 450);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 150);
            this.MsgBox.TabIndex = 10;
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
            this.GuardarButton.Location = new System.Drawing.Point(392, 400);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 31);
            this.GuardarButton.TabIndex = 9;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // AreaCombo
            // 
            this.AreaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaCombo.FormattingEnabled = true;
            this.AreaCombo.Location = new System.Drawing.Point(220, 347);
            this.AreaCombo.Name = "AreaCombo";
            this.AreaCombo.Size = new System.Drawing.Size(250, 29);
            this.AreaCombo.TabIndex = 8;
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
            this.PrecioUnitarioText.Location = new System.Drawing.Point(220, 297);
            this.PrecioUnitarioText.Name = "PrecioUnitarioText";
            this.PrecioUnitarioText.Size = new System.Drawing.Size(250, 29);
            this.PrecioUnitarioText.TabIndex = 6;
            this.PrecioUnitarioText.Text = "$0.00";
            // 
            // PrecioUnitarioLabel
            // 
            this.PrecioUnitarioLabel.AutoSize = true;
            this.PrecioUnitarioLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitarioLabel.Location = new System.Drawing.Point(50, 300);
            this.PrecioUnitarioLabel.Name = "PrecioUnitarioLabel";
            this.PrecioUnitarioLabel.Size = new System.Drawing.Size(120, 21);
            this.PrecioUnitarioLabel.TabIndex = 5;
            this.PrecioUnitarioLabel.Text = "Precio Unitario*";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLabel.Location = new System.Drawing.Point(50, 350);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(102, 21);
            this.AreaLabel.TabIndex = 7;
            this.AreaLabel.Text = "Área Interna*";
            // 
            // ProductoInternoLabel
            // 
            this.ProductoInternoLabel.AutoSize = true;
            this.ProductoInternoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoInternoLabel.Location = new System.Drawing.Point(50, 250);
            this.ProductoInternoLabel.Name = "ProductoInternoLabel";
            this.ProductoInternoLabel.Size = new System.Drawing.Size(134, 21);
            this.ProductoInternoLabel.TabIndex = 3;
            this.ProductoInternoLabel.Text = "Producto Interno*";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(355, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Crear Producto para Cliente";
            // 
            // ProductoInternoCombo
            // 
            this.ProductoInternoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductoInternoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductoInternoCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoInternoCombo.FormattingEnabled = true;
            this.ProductoInternoCombo.Location = new System.Drawing.Point(220, 247);
            this.ProductoInternoCombo.Name = "ProductoInternoCombo";
            this.ProductoInternoCombo.Size = new System.Drawing.Size(250, 29);
            this.ProductoInternoCombo.TabIndex = 11;
            // 
            // ClienteCombo
            // 
            this.ClienteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteCombo.FormattingEnabled = true;
            this.ClienteCombo.Location = new System.Drawing.Point(220, 147);
            this.ClienteCombo.Name = "ClienteCombo";
            this.ClienteCombo.Size = new System.Drawing.Size(250, 29);
            this.ClienteCombo.TabIndex = 13;
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(50, 150);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(65, 21);
            this.ClienteLabel.TabIndex = 12;
            this.ClienteLabel.Text = "Cliente*";
            // 
            // ClienteProductoCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.ClienteCombo);
            this.Controls.Add(this.ClienteLabel);
            this.Controls.Add(this.ProductoInternoCombo);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.AreaCombo);
            this.Controls.Add(this.PrecioUnitarioText);
            this.Controls.Add(this.PrecioUnitarioLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.ProductoInternoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClienteProductoCrearForm";
            this.Text = "ClienteProductoCrearForm";
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUnitarioText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ComboBox AreaCombo;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox PrecioUnitarioText;
        private System.Windows.Forms.Label PrecioUnitarioLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label ProductoInternoLabel;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.ComboBox ProductoInternoCombo;
        private System.Windows.Forms.ComboBox ClienteCombo;
        private System.Windows.Forms.Label ClienteLabel;
    }
}