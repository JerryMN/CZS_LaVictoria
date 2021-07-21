
namespace CZS_LaVictoria.CuentasPage
{
    partial class PorCobrarAgregarForm
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
            this.CobradoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MontoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CobradoLabel = new System.Windows.Forms.Label();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.FechaFacturaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaFacturaLabel = new System.Windows.Forms.Label();
            this.NotasText = new System.Windows.Forms.TextBox();
            this.ClienteText = new System.Windows.Forms.TextBox();
            this.FacturaText = new System.Windows.Forms.TextBox();
            this.NotasLabel = new System.Windows.Forms.Label();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.FacturaLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
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
            this.MsgBox.Location = new System.Drawing.Point(50, 550);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 127;
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
            this.GuardarButton.Size = new System.Drawing.Size(78, 37);
            this.GuardarButton.TabIndex = 126;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CobradoText
            // 
            this.CobradoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CobradoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobradoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CobradoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.CobradoText.Location = new System.Drawing.Point(220, 347);
            this.CobradoText.MinValue = 0D;
            this.CobradoText.Name = "CobradoText";
            this.CobradoText.Size = new System.Drawing.Size(250, 29);
            this.CobradoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CobradoText.TabIndex = 125;
            this.CobradoText.Text = "$0.00";
            this.CobradoText.WatermarkText = "Calculado automáticamente";
            // 
            // MontoText
            // 
            this.MontoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MontoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MontoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.MontoText.Location = new System.Drawing.Point(220, 297);
            this.MontoText.MinValue = 0D;
            this.MontoText.Name = "MontoText";
            this.MontoText.Size = new System.Drawing.Size(250, 29);
            this.MontoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MontoText.TabIndex = 124;
            this.MontoText.Text = "$0.00";
            this.MontoText.WatermarkText = "Calculado automáticamente";
            // 
            // CobradoLabel
            // 
            this.CobradoLabel.AutoSize = true;
            this.CobradoLabel.Location = new System.Drawing.Point(50, 350);
            this.CobradoLabel.Name = "CobradoLabel";
            this.CobradoLabel.Size = new System.Drawing.Size(120, 21);
            this.CobradoLabel.TabIndex = 122;
            this.CobradoLabel.Text = "Monto Cobrado";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Location = new System.Drawing.Point(50, 300);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(110, 21);
            this.MontoLabel.TabIndex = 123;
            this.MontoLabel.Text = "Monto Factura";
            // 
            // FechaFacturaPicker
            // 
            this.FechaFacturaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaFacturaPicker.Location = new System.Drawing.Point(220, 197);
            this.FechaFacturaPicker.Name = "FechaFacturaPicker";
            this.FechaFacturaPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaFacturaPicker.TabIndex = 120;
            // 
            // FechaFacturaLabel
            // 
            this.FechaFacturaLabel.AutoSize = true;
            this.FechaFacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFacturaLabel.Location = new System.Drawing.Point(50, 200);
            this.FechaFacturaLabel.Name = "FechaFacturaLabel";
            this.FechaFacturaLabel.Size = new System.Drawing.Size(123, 21);
            this.FechaFacturaLabel.TabIndex = 118;
            this.FechaFacturaLabel.Text = "Fecha de factura";
            // 
            // NotasText
            // 
            this.NotasText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasText.Location = new System.Drawing.Point(220, 397);
            this.NotasText.Multiline = true;
            this.NotasText.Name = "NotasText";
            this.NotasText.Size = new System.Drawing.Size(250, 76);
            this.NotasText.TabIndex = 117;
            // 
            // ClienteText
            // 
            this.ClienteText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteText.Location = new System.Drawing.Point(220, 247);
            this.ClienteText.Name = "ClienteText";
            this.ClienteText.Size = new System.Drawing.Size(250, 29);
            this.ClienteText.TabIndex = 116;
            // 
            // FacturaText
            // 
            this.FacturaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaText.Location = new System.Drawing.Point(220, 147);
            this.FacturaText.Name = "FacturaText";
            this.FacturaText.Size = new System.Drawing.Size(250, 29);
            this.FacturaText.TabIndex = 115;
            // 
            // NotasLabel
            // 
            this.NotasLabel.AutoSize = true;
            this.NotasLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasLabel.Location = new System.Drawing.Point(50, 400);
            this.NotasLabel.Name = "NotasLabel";
            this.NotasLabel.Size = new System.Drawing.Size(51, 21);
            this.NotasLabel.TabIndex = 114;
            this.NotasLabel.Text = "Notas";
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(50, 250);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(58, 21);
            this.ClienteLabel.TabIndex = 111;
            this.ClienteLabel.Text = "Cliente";
            // 
            // FacturaLabel
            // 
            this.FacturaLabel.AutoSize = true;
            this.FacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaLabel.Location = new System.Drawing.Point(50, 150);
            this.FacturaLabel.Name = "FacturaLabel";
            this.FacturaLabel.Size = new System.Drawing.Size(60, 21);
            this.FacturaLabel.TabIndex = 113;
            this.FacturaLabel.Text = "Factura";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(374, 37);
            this.SubtitleLabel.TabIndex = 110;
            this.SubtitleLabel.Text = "Agregar Cobro Manualmente";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // PorCobrarAgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 839);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CobradoText);
            this.Controls.Add(this.MontoText);
            this.Controls.Add(this.CobradoLabel);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.FechaFacturaPicker);
            this.Controls.Add(this.FechaFacturaLabel);
            this.Controls.Add(this.NotasText);
            this.Controls.Add(this.ClienteText);
            this.Controls.Add(this.FacturaText);
            this.Controls.Add(this.NotasLabel);
            this.Controls.Add(this.ClienteLabel);
            this.Controls.Add(this.FacturaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PorCobrarAgregarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cobro Manualmente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox CobradoText;
        private Syncfusion.WinForms.Input.SfNumericTextBox MontoText;
        private System.Windows.Forms.Label CobradoLabel;
        private System.Windows.Forms.Label MontoLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaFacturaPicker;
        private System.Windows.Forms.Label FechaFacturaLabel;
        private System.Windows.Forms.TextBox NotasText;
        private System.Windows.Forms.TextBox ClienteText;
        private System.Windows.Forms.TextBox FacturaText;
        private System.Windows.Forms.Label NotasLabel;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.Label FacturaLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}