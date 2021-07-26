
namespace CZS_LaVictoria.AlgodónPage
{
    partial class RegistrarTorceduraForm
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
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CantidadSalidaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.EntradaLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.TurnoText = new System.Windows.Forms.NumericUpDown();
            this.FechaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.OperadorCombo = new System.Windows.Forms.ComboBox();
            this.MaquinaLabel = new System.Windows.Forms.Label();
            this.OperadorLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.CantidadSalidaUnidad = new System.Windows.Forms.Label();
            this.MáquinaCombo = new System.Windows.Forms.ComboBox();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).BeginInit();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(283, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Registro de Torcedura";
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(922, 200);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 35);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CantidadSalidaText
            // 
            this.CantidadSalidaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadSalidaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadSalidaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadSalidaText.HideTrailingZeros = true;
            this.CantidadSalidaText.Location = new System.Drawing.Point(750, 147);
            this.CantidadSalidaText.MinValue = 0D;
            this.CantidadSalidaText.Name = "CantidadSalidaText";
            this.CantidadSalidaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadSalidaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadSalidaText.TabIndex = 12;
            this.CantidadSalidaText.Text = "0";
            this.CantidadSalidaText.WatermarkText = "Ingresa la cantidad";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(75, 21);
            this.SalidaLabel.TabIndex = 11;
            this.SalidaLabel.Text = "Carretes*";
            // 
            // ArrowButton
            // 
            this.ArrowButton.FlatAppearance.BorderSize = 0;
            this.ArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArrowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowButton.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.ArrowButton.IconColor = System.Drawing.Color.Black;
            this.ArrowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ArrowButton.Location = new System.Drawing.Point(500, 200);
            this.ArrowButton.Name = "ArrowButton";
            this.ArrowButton.Size = new System.Drawing.Size(44, 36);
            this.ArrowButton.TabIndex = 13;
            this.ArrowButton.TabStop = false;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // EntradaLabel
            // 
            this.EntradaLabel.AutoSize = true;
            this.EntradaLabel.Location = new System.Drawing.Point(50, 300);
            this.EntradaLabel.Name = "EntradaLabel";
            this.EntradaLabel.Size = new System.Drawing.Size(45, 21);
            this.EntradaLabel.TabIndex = 8;
            this.EntradaLabel.Text = "Hilo*";
            // 
            // CantidadEntradaText
            // 
            this.CantidadEntradaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadEntradaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEntradaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadEntradaText.Location = new System.Drawing.Point(200, 297);
            this.CantidadEntradaText.MinValue = 0D;
            this.CantidadEntradaText.Name = "CantidadEntradaText";
            this.CantidadEntradaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadEntradaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadEntradaText.TabIndex = 9;
            this.CantidadEntradaText.WatermarkText = "Ingresa la cantidad";
            // 
            // TurnoText
            // 
            this.TurnoText.Location = new System.Drawing.Point(330, 247);
            this.TurnoText.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.TurnoText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TurnoText.Name = "TurnoText";
            this.TurnoText.Size = new System.Drawing.Size(120, 29);
            this.TurnoText.TabIndex = 7;
            this.TurnoText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FechaPicker
            // 
            this.FechaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaPicker.Location = new System.Drawing.Point(200, 147);
            this.FechaPicker.Name = "FechaPicker";
            this.FechaPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaPicker.TabIndex = 1;
            // 
            // OperadorCombo
            // 
            this.OperadorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperadorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorCombo.FormattingEnabled = true;
            this.OperadorCombo.Location = new System.Drawing.Point(200, 197);
            this.OperadorCombo.Name = "OperadorCombo";
            this.OperadorCombo.Size = new System.Drawing.Size(250, 29);
            this.OperadorCombo.TabIndex = 4;
            // 
            // MaquinaLabel
            // 
            this.MaquinaLabel.AutoSize = true;
            this.MaquinaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaquinaLabel.Location = new System.Drawing.Point(50, 250);
            this.MaquinaLabel.Name = "MaquinaLabel";
            this.MaquinaLabel.Size = new System.Drawing.Size(140, 21);
            this.MaquinaLabel.TabIndex = 5;
            this.MaquinaLabel.Text = "Máquina* / Turno*";
            // 
            // OperadorLabel
            // 
            this.OperadorLabel.AutoSize = true;
            this.OperadorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorLabel.Location = new System.Drawing.Point(50, 200);
            this.OperadorLabel.Name = "OperadorLabel";
            this.OperadorLabel.Size = new System.Drawing.Size(84, 21);
            this.OperadorLabel.TabIndex = 3;
            this.OperadorLabel.Text = "Operador*";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(50, 150);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(151, 21);
            this.FechaLabel.TabIndex = 2;
            this.FechaLabel.Text = "Fecha de operación*";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // CantidadSalidaUnidad
            // 
            this.CantidadSalidaUnidad.AutoSize = true;
            this.CantidadSalidaUnidad.Location = new System.Drawing.Point(456, 300);
            this.CantidadSalidaUnidad.Name = "CantidadSalidaUnidad";
            this.CantidadSalidaUnidad.Size = new System.Drawing.Size(27, 21);
            this.CantidadSalidaUnidad.TabIndex = 10;
            this.CantidadSalidaUnidad.Text = "kg";
            // 
            // MáquinaCombo
            // 
            this.MáquinaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MáquinaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MáquinaCombo.FormattingEnabled = true;
            this.MáquinaCombo.Location = new System.Drawing.Point(200, 247);
            this.MáquinaCombo.Name = "MáquinaCombo";
            this.MáquinaCombo.Size = new System.Drawing.Size(124, 29);
            this.MáquinaCombo.TabIndex = 6;
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
            this.MsgBox.Location = new System.Drawing.Point(580, 250);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 15;
            this.MsgBox.TabStop = false;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // RegistrarTorceduraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.MáquinaCombo);
            this.Controls.Add(this.CantidadSalidaUnidad);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CantidadSalidaText);
            this.Controls.Add(this.SalidaLabel);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.EntradaLabel);
            this.Controls.Add(this.CantidadEntradaText);
            this.Controls.Add(this.TurnoText);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.OperadorCombo);
            this.Controls.Add(this.MaquinaLabel);
            this.Controls.Add(this.OperadorLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarTorceduraForm";
            this.Text = "RegistrarTorceduraForm";
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadSalidaText;
        private System.Windows.Forms.Label SalidaLabel;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.Label EntradaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadEntradaText;
        private System.Windows.Forms.NumericUpDown TurnoText;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPicker;
        private System.Windows.Forms.ComboBox OperadorCombo;
        private System.Windows.Forms.Label MaquinaLabel;
        private System.Windows.Forms.Label OperadorLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Label CantidadSalidaUnidad;
        private System.Windows.Forms.ComboBox MáquinaCombo;
        private FontAwesome.Sharp.IconButton MsgBox;
    }
}