
namespace CZS_LaVictoria.CuentasPage
{
    partial class PorPagarPagarForm
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
            this.NumOrdenText = new System.Windows.Forms.TextBox();
            this.NumOrdenLabel = new System.Windows.Forms.Label();
            this.FechaFacturaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaFacturaLabel = new System.Windows.Forms.Label();
            this.FacturaLabel = new System.Windows.Forms.Label();
            this.FacturaText = new System.Windows.Forms.TextBox();
            this.MontoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.PagadoLabel = new System.Windows.Forms.Label();
            this.PagadoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PendienteLabel = new System.Windows.Forms.Label();
            this.PendienteText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.NuevoLabel = new System.Windows.Forms.Label();
            this.NuevoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.NotasLabel = new System.Windows.Forms.Label();
            this.NotasText = new System.Windows.Forms.TextBox();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.FechaPagoLabel = new System.Windows.Forms.Label();
            this.FechaPagoPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(194, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Registrar Pago";
            // 
            // NumOrdenText
            // 
            this.NumOrdenText.Enabled = false;
            this.NumOrdenText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOrdenText.Location = new System.Drawing.Point(220, 147);
            this.NumOrdenText.Name = "NumOrdenText";
            this.NumOrdenText.ReadOnly = true;
            this.NumOrdenText.Size = new System.Drawing.Size(250, 29);
            this.NumOrdenText.TabIndex = 2;
            // 
            // NumOrdenLabel
            // 
            this.NumOrdenLabel.AutoSize = true;
            this.NumOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOrdenLabel.Location = new System.Drawing.Point(50, 150);
            this.NumOrdenLabel.Name = "NumOrdenLabel";
            this.NumOrdenLabel.Size = new System.Drawing.Size(96, 21);
            this.NumOrdenLabel.TabIndex = 1;
            this.NumOrdenLabel.Text = "Núm. Orden";
            // 
            // FechaFacturaPicker
            // 
            this.FechaFacturaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaFacturaPicker.Location = new System.Drawing.Point(220, 247);
            this.FechaFacturaPicker.Name = "FechaFacturaPicker";
            this.FechaFacturaPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaFacturaPicker.TabIndex = 6;
            // 
            // FechaFacturaLabel
            // 
            this.FechaFacturaLabel.AutoSize = true;
            this.FechaFacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFacturaLabel.Location = new System.Drawing.Point(50, 250);
            this.FechaFacturaLabel.Name = "FechaFacturaLabel";
            this.FechaFacturaLabel.Size = new System.Drawing.Size(125, 21);
            this.FechaFacturaLabel.TabIndex = 5;
            this.FechaFacturaLabel.Text = "Fecha de Factura";
            // 
            // FacturaLabel
            // 
            this.FacturaLabel.AutoSize = true;
            this.FacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaLabel.Location = new System.Drawing.Point(50, 200);
            this.FacturaLabel.Name = "FacturaLabel";
            this.FacturaLabel.Size = new System.Drawing.Size(60, 21);
            this.FacturaLabel.TabIndex = 3;
            this.FacturaLabel.Text = "Factura";
            // 
            // FacturaText
            // 
            this.FacturaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaText.Location = new System.Drawing.Point(220, 197);
            this.FacturaText.Name = "FacturaText";
            this.FacturaText.Size = new System.Drawing.Size(250, 29);
            this.FacturaText.TabIndex = 4;
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
            this.MontoText.TabIndex = 8;
            this.MontoText.Text = "$0.00";
            this.MontoText.WatermarkText = "Calculado automáticamente";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Location = new System.Drawing.Point(50, 300);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(111, 21);
            this.MontoLabel.TabIndex = 7;
            this.MontoLabel.Text = "Monto a Pagar";
            // 
            // PagadoLabel
            // 
            this.PagadoLabel.AutoSize = true;
            this.PagadoLabel.Location = new System.Drawing.Point(50, 350);
            this.PagadoLabel.Name = "PagadoLabel";
            this.PagadoLabel.Size = new System.Drawing.Size(111, 21);
            this.PagadoLabel.TabIndex = 9;
            this.PagadoLabel.Text = "Monto Pagado";
            // 
            // PagadoText
            // 
            this.PagadoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PagadoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagadoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PagadoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.PagadoText.Location = new System.Drawing.Point(220, 347);
            this.PagadoText.MinValue = 0D;
            this.PagadoText.Name = "PagadoText";
            this.PagadoText.Size = new System.Drawing.Size(250, 29);
            this.PagadoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PagadoText.TabIndex = 10;
            this.PagadoText.Text = "$0.00";
            this.PagadoText.WatermarkText = "Calculado automáticamente";
            // 
            // PendienteLabel
            // 
            this.PendienteLabel.AutoSize = true;
            this.PendienteLabel.Location = new System.Drawing.Point(50, 400);
            this.PendienteLabel.Name = "PendienteLabel";
            this.PendienteLabel.Size = new System.Drawing.Size(128, 21);
            this.PendienteLabel.TabIndex = 11;
            this.PendienteLabel.Text = "Monto Pendiente";
            // 
            // PendienteText
            // 
            this.PendienteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PendienteText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendienteText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PendienteText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.PendienteText.Location = new System.Drawing.Point(220, 397);
            this.PendienteText.MinValue = 0D;
            this.PendienteText.Name = "PendienteText";
            this.PendienteText.ReadOnly = true;
            this.PendienteText.Size = new System.Drawing.Size(250, 29);
            this.PendienteText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PendienteText.TabIndex = 12;
            this.PendienteText.Text = "$0.00";
            this.PendienteText.WatermarkText = "Calculado automáticamente";
            // 
            // NuevoLabel
            // 
            this.NuevoLabel.AutoSize = true;
            this.NuevoLabel.Location = new System.Drawing.Point(50, 450);
            this.NuevoLabel.Name = "NuevoLabel";
            this.NuevoLabel.Size = new System.Drawing.Size(101, 21);
            this.NuevoLabel.TabIndex = 13;
            this.NuevoLabel.Text = "Nuevo Pago*";
            // 
            // NuevoText
            // 
            this.NuevoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NuevoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NuevoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.NuevoText.Location = new System.Drawing.Point(220, 447);
            this.NuevoText.MinValue = 0D;
            this.NuevoText.Name = "NuevoText";
            this.NuevoText.Size = new System.Drawing.Size(250, 29);
            this.NuevoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NuevoText.TabIndex = 14;
            this.NuevoText.Text = "$0.00";
            this.NuevoText.WatermarkText = "Calculado automáticamente";
            // 
            // NotasLabel
            // 
            this.NotasLabel.AutoSize = true;
            this.NotasLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasLabel.Location = new System.Drawing.Point(550, 400);
            this.NotasLabel.Name = "NotasLabel";
            this.NotasLabel.Size = new System.Drawing.Size(51, 21);
            this.NotasLabel.TabIndex = 18;
            this.NotasLabel.Text = "Notas";
            // 
            // NotasText
            // 
            this.NotasText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasText.Location = new System.Drawing.Point(700, 400);
            this.NotasText.Multiline = true;
            this.NotasText.Name = "NotasText";
            this.NotasText.Size = new System.Drawing.Size(250, 76);
            this.NotasText.TabIndex = 19;
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
            this.MsgBox.TabIndex = 20;
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
            this.GuardarButton.Size = new System.Drawing.Size(78, 37);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 4000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // FechaPagoLabel
            // 
            this.FechaPagoLabel.AutoSize = true;
            this.FechaPagoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPagoLabel.Location = new System.Drawing.Point(550, 250);
            this.FechaPagoLabel.Name = "FechaPagoLabel";
            this.FechaPagoLabel.Size = new System.Drawing.Size(116, 21);
            this.FechaPagoLabel.TabIndex = 16;
            this.FechaPagoLabel.Text = "Fecha de Pago*";
            // 
            // FechaPagoPicker
            // 
            this.FechaPagoPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaPagoPicker.Location = new System.Drawing.Point(700, 250);
            this.FechaPagoPicker.Name = "FechaPagoPicker";
            this.FechaPagoPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaPagoPicker.TabIndex = 17;
            // 
            // PorPagarPagarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoText);
            this.Controls.Add(this.PendienteText);
            this.Controls.Add(this.PagadoText);
            this.Controls.Add(this.MontoText);
            this.Controls.Add(this.NuevoLabel);
            this.Controls.Add(this.PendienteLabel);
            this.Controls.Add(this.PagadoLabel);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.FechaPagoPicker);
            this.Controls.Add(this.FechaFacturaPicker);
            this.Controls.Add(this.FechaPagoLabel);
            this.Controls.Add(this.FechaFacturaLabel);
            this.Controls.Add(this.NotasText);
            this.Controls.Add(this.FacturaText);
            this.Controls.Add(this.NumOrdenText);
            this.Controls.Add(this.NotasLabel);
            this.Controls.Add(this.FacturaLabel);
            this.Controls.Add(this.NumOrdenLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PorPagarPagarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.TextBox NumOrdenText;
        private System.Windows.Forms.Label NumOrdenLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaFacturaPicker;
        private System.Windows.Forms.Label FechaFacturaLabel;
        private System.Windows.Forms.Label FacturaLabel;
        private System.Windows.Forms.TextBox FacturaText;
        private Syncfusion.WinForms.Input.SfNumericTextBox MontoText;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.Label PagadoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox PagadoText;
        private System.Windows.Forms.Label PendienteLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox PendienteText;
        private System.Windows.Forms.Label NuevoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox NuevoText;
        private System.Windows.Forms.Label NotasLabel;
        private System.Windows.Forms.TextBox NotasText;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Label FechaPagoLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPagoPicker;
    }
}