
namespace CZS_LaVictoria.PlásticosPage
{
    partial class RegistrarMolidoForm
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
            this.EntradaLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaLabel = new System.Windows.Forms.Label();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.CantidadSalidaLabel = new System.Windows.Forms.Label();
            this.EntradaCombo = new System.Windows.Forms.ComboBox();
            this.SalidaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadEntradaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CantidadSalidaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MermaLabel = new System.Windows.Forms.Label();
            this.MermaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.FechaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.OperadorCombo = new System.Windows.Forms.ComboBox();
            this.MaquinaText = new System.Windows.Forms.NumericUpDown();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.OperadorLabel = new System.Windows.Forms.Label();
            this.MaquinaLabel = new System.Windows.Forms.Label();
            this.TurnoText = new System.Windows.Forms.NumericUpDown();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).BeginInit();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(221, 32);
            this.SubtitleLabel.TabIndex = 31;
            this.SubtitleLabel.Text = "Registro de Molido";
            // 
            // EntradaLabel
            // 
            this.EntradaLabel.AutoSize = true;
            this.EntradaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaLabel.Location = new System.Drawing.Point(50, 300);
            this.EntradaLabel.Name = "EntradaLabel";
            this.EntradaLabel.Size = new System.Drawing.Size(67, 21);
            this.EntradaLabel.TabIndex = 32;
            this.EntradaLabel.Text = "Material";
            // 
            // CantidadEntradaLabel
            // 
            this.CantidadEntradaLabel.AutoSize = true;
            this.CantidadEntradaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEntradaLabel.Location = new System.Drawing.Point(50, 350);
            this.CantidadEntradaLabel.Name = "CantidadEntradaLabel";
            this.CantidadEntradaLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadEntradaLabel.TabIndex = 32;
            this.CantidadEntradaLabel.Text = "Cantidad";
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
            this.ArrowButton.TabIndex = 33;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(67, 21);
            this.SalidaLabel.TabIndex = 32;
            this.SalidaLabel.Text = "Material";
            // 
            // CantidadSalidaLabel
            // 
            this.CantidadSalidaLabel.AutoSize = true;
            this.CantidadSalidaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadSalidaLabel.Location = new System.Drawing.Point(600, 200);
            this.CantidadSalidaLabel.Name = "CantidadSalidaLabel";
            this.CantidadSalidaLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadSalidaLabel.TabIndex = 32;
            this.CantidadSalidaLabel.Text = "Cantidad";
            // 
            // EntradaCombo
            // 
            this.EntradaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntradaCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaCombo.FormattingEnabled = true;
            this.EntradaCombo.Location = new System.Drawing.Point(200, 297);
            this.EntradaCombo.Name = "EntradaCombo";
            this.EntradaCombo.Size = new System.Drawing.Size(250, 29);
            this.EntradaCombo.TabIndex = 34;
            this.EntradaCombo.SelectedIndexChanged += new System.EventHandler(this.EntradaCombo_SelectedIndexChanged);
            // 
            // SalidaCombo
            // 
            this.SalidaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SalidaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SalidaCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalidaCombo.FormattingEnabled = true;
            this.SalidaCombo.Location = new System.Drawing.Point(720, 147);
            this.SalidaCombo.Name = "SalidaCombo";
            this.SalidaCombo.Size = new System.Drawing.Size(250, 29);
            this.SalidaCombo.TabIndex = 34;
            this.SalidaCombo.SelectedIndexChanged += new System.EventHandler(this.SalidaCombo_SelectedIndexChanged);
            // 
            // CantidadEntradaText
            // 
            this.CantidadEntradaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadEntradaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEntradaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadEntradaText.Location = new System.Drawing.Point(200, 347);
            this.CantidadEntradaText.MinValue = 0D;
            this.CantidadEntradaText.Name = "CantidadEntradaText";
            this.CantidadEntradaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadEntradaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadEntradaText.TabIndex = 35;
            this.CantidadEntradaText.WatermarkText = "Ingresa la cantidad";
            this.CantidadEntradaText.TextChanged += new System.EventHandler(this.CantidadText_TextChanged);
            // 
            // CantidadSalidaText
            // 
            this.CantidadSalidaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadSalidaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadSalidaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadSalidaText.Location = new System.Drawing.Point(720, 197);
            this.CantidadSalidaText.MinValue = 0D;
            this.CantidadSalidaText.Name = "CantidadSalidaText";
            this.CantidadSalidaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadSalidaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadSalidaText.TabIndex = 35;
            this.CantidadSalidaText.WatermarkText = "Ingresa la cantidad";
            this.CantidadSalidaText.TextChanged += new System.EventHandler(this.CantidadText_TextChanged);
            // 
            // MermaLabel
            // 
            this.MermaLabel.AutoSize = true;
            this.MermaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaLabel.Location = new System.Drawing.Point(600, 250);
            this.MermaLabel.Name = "MermaLabel";
            this.MermaLabel.Size = new System.Drawing.Size(60, 21);
            this.MermaLabel.TabIndex = 32;
            this.MermaLabel.Text = "Merma";
            // 
            // MermaText
            // 
            this.MermaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MermaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MermaText.Location = new System.Drawing.Point(720, 247);
            this.MermaText.MinValue = 0D;
            this.MermaText.Name = "MermaText";
            this.MermaText.ReadOnly = true;
            this.MermaText.Size = new System.Drawing.Size(250, 29);
            this.MermaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MermaText.TabIndex = 35;
            this.MermaText.WatermarkText = "Calculado automáticamente";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // FechaPicker
            // 
            this.FechaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaPicker.Location = new System.Drawing.Point(200, 147);
            this.FechaPicker.Name = "FechaPicker";
            this.FechaPicker.Size = new System.Drawing.Size(250, 31);
            this.FechaPicker.TabIndex = 38;
            // 
            // OperadorCombo
            // 
            this.OperadorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperadorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorCombo.FormattingEnabled = true;
            this.OperadorCombo.Location = new System.Drawing.Point(200, 197);
            this.OperadorCombo.Name = "OperadorCombo";
            this.OperadorCombo.Size = new System.Drawing.Size(250, 29);
            this.OperadorCombo.TabIndex = 34;
            this.OperadorCombo.SelectedIndexChanged += new System.EventHandler(this.EntradaCombo_SelectedIndexChanged);
            // 
            // MaquinaText
            // 
            this.MaquinaText.Location = new System.Drawing.Point(200, 247);
            this.MaquinaText.Name = "MaquinaText";
            this.MaquinaText.Size = new System.Drawing.Size(120, 29);
            this.MaquinaText.TabIndex = 39;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(50, 150);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(144, 21);
            this.FechaLabel.TabIndex = 32;
            this.FechaLabel.Text = "Fecha de operación";
            // 
            // OperadorLabel
            // 
            this.OperadorLabel.AutoSize = true;
            this.OperadorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorLabel.Location = new System.Drawing.Point(50, 200);
            this.OperadorLabel.Name = "OperadorLabel";
            this.OperadorLabel.Size = new System.Drawing.Size(77, 21);
            this.OperadorLabel.TabIndex = 32;
            this.OperadorLabel.Text = "Operador";
            // 
            // MaquinaLabel
            // 
            this.MaquinaLabel.AutoSize = true;
            this.MaquinaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaquinaLabel.Location = new System.Drawing.Point(50, 250);
            this.MaquinaLabel.Name = "MaquinaLabel";
            this.MaquinaLabel.Size = new System.Drawing.Size(126, 21);
            this.MaquinaLabel.TabIndex = 32;
            this.MaquinaLabel.Text = "Máquina / Turno";
            // 
            // TurnoText
            // 
            this.TurnoText.Location = new System.Drawing.Point(330, 247);
            this.TurnoText.Name = "TurnoText";
            this.TurnoText.Size = new System.Drawing.Size(120, 29);
            this.TurnoText.TabIndex = 39;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(892, 300);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 35);
            this.GuardarButton.TabIndex = 36;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
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
            this.MsgBox.Location = new System.Drawing.Point(550, 350);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 37;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // RegistrarMolidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.TurnoText);
            this.Controls.Add(this.MaquinaText);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.MermaText);
            this.Controls.Add(this.CantidadSalidaText);
            this.Controls.Add(this.CantidadEntradaText);
            this.Controls.Add(this.SalidaCombo);
            this.Controls.Add(this.OperadorCombo);
            this.Controls.Add(this.EntradaCombo);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.MermaLabel);
            this.Controls.Add(this.CantidadSalidaLabel);
            this.Controls.Add(this.CantidadEntradaLabel);
            this.Controls.Add(this.SalidaLabel);
            this.Controls.Add(this.MaquinaLabel);
            this.Controls.Add(this.OperadorLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.EntradaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarMolidoForm";
            this.Text = "RegistrarMolidoButton";
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label EntradaLabel;
        private System.Windows.Forms.Label CantidadEntradaLabel;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.Label SalidaLabel;
        private System.Windows.Forms.Label CantidadSalidaLabel;
        private System.Windows.Forms.ComboBox EntradaCombo;
        private System.Windows.Forms.ComboBox SalidaCombo;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadEntradaText;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadSalidaText;
        private System.Windows.Forms.Label MermaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaText;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPicker;
        private System.Windows.Forms.ComboBox OperadorCombo;
        private System.Windows.Forms.NumericUpDown MaquinaText;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label OperadorLabel;
        private System.Windows.Forms.Label MaquinaLabel;
        private System.Windows.Forms.NumericUpDown TurnoText;
        private System.Windows.Forms.Button GuardarButton;
        private FontAwesome.Sharp.IconButton MsgBox;
    }
}