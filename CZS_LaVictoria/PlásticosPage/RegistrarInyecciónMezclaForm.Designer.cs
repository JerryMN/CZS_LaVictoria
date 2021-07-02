
namespace CZS_LaVictoria.PlásticosPage
{
    partial class RegistrarInyecciónMezclaForm
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
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MermaFinalText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CantidadSalidaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.SalidaCombo = new System.Windows.Forms.ComboBox();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.MermaRealLabel = new System.Windows.Forms.Label();
            this.CantidadSalidaLabel = new System.Windows.Forms.Label();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.PesoPromLabel = new System.Windows.Forms.Label();
            this.PesoPromText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PesoPromUnidad = new System.Windows.Forms.Label();
            this.MermaMolerLabel = new System.Windows.Forms.Label();
            this.MermaMolerText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MermaMolerUnidad = new System.Windows.Forms.Label();
            this.MermaRealUnidad = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.CantidadEntradaUnidad = new System.Windows.Forms.Label();
            this.CantidadEntradaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MezclaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadEntradaLabel = new System.Windows.Forms.Label();
            this.EntradaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(424, 37);
            this.SubtitleLabel.TabIndex = 31;
            this.SubtitleLabel.Text = "Registro de Inyección con Mezcla";
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
            this.MsgBox.Location = new System.Drawing.Point(550, 450);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 48;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(892, 400);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 35);
            this.GuardarButton.TabIndex = 47;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MermaFinalText
            // 
            this.MermaFinalText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MermaFinalText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaFinalText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MermaFinalText.Location = new System.Drawing.Point(720, 347);
            this.MermaFinalText.MinValue = 0D;
            this.MermaFinalText.Name = "MermaFinalText";
            this.MermaFinalText.ReadOnly = true;
            this.MermaFinalText.Size = new System.Drawing.Size(250, 29);
            this.MermaFinalText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MermaFinalText.TabIndex = 45;
            this.MermaFinalText.WatermarkText = "Calculado automáticamente";
            // 
            // CantidadSalidaText
            // 
            this.CantidadSalidaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadSalidaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadSalidaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadSalidaText.HideTrailingZeros = true;
            this.CantidadSalidaText.Location = new System.Drawing.Point(720, 197);
            this.CantidadSalidaText.MinValue = 0D;
            this.CantidadSalidaText.Name = "CantidadSalidaText";
            this.CantidadSalidaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadSalidaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadSalidaText.TabIndex = 46;
            this.CantidadSalidaText.Text = "0";
            this.CantidadSalidaText.WatermarkText = "Ingresa la cantidad";
            this.CantidadSalidaText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // SalidaCombo
            // 
            this.SalidaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SalidaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SalidaCombo.FormattingEnabled = true;
            this.SalidaCombo.Location = new System.Drawing.Point(720, 147);
            this.SalidaCombo.Name = "SalidaCombo";
            this.SalidaCombo.Size = new System.Drawing.Size(250, 29);
            this.SalidaCombo.TabIndex = 44;
            this.SalidaCombo.SelectedIndexChanged += new System.EventHandler(this.SalidaCombo_SelectedIndexChanged);
            this.SalidaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // ArrowButton
            // 
            this.ArrowButton.FlatAppearance.BorderSize = 0;
            this.ArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArrowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowButton.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.ArrowButton.IconColor = System.Drawing.Color.Black;
            this.ArrowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ArrowButton.Location = new System.Drawing.Point(500, 250);
            this.ArrowButton.Name = "ArrowButton";
            this.ArrowButton.Size = new System.Drawing.Size(44, 36);
            this.ArrowButton.TabIndex = 43;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // MermaRealLabel
            // 
            this.MermaRealLabel.AutoSize = true;
            this.MermaRealLabel.Location = new System.Drawing.Point(600, 350);
            this.MermaRealLabel.Name = "MermaRealLabel";
            this.MermaRealLabel.Size = new System.Drawing.Size(94, 21);
            this.MermaRealLabel.TabIndex = 40;
            this.MermaRealLabel.Text = "Merma Real";
            // 
            // CantidadSalidaLabel
            // 
            this.CantidadSalidaLabel.AutoSize = true;
            this.CantidadSalidaLabel.Location = new System.Drawing.Point(600, 200);
            this.CantidadSalidaLabel.Name = "CantidadSalidaLabel";
            this.CantidadSalidaLabel.Size = new System.Drawing.Size(107, 21);
            this.CantidadSalidaLabel.TabIndex = 41;
            this.CantidadSalidaLabel.Text = "Piezas Buenas";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(73, 21);
            this.SalidaLabel.TabIndex = 42;
            this.SalidaLabel.Text = "Producto";
            // 
            // PesoPromLabel
            // 
            this.PesoPromLabel.AutoSize = true;
            this.PesoPromLabel.Location = new System.Drawing.Point(600, 250);
            this.PesoPromLabel.Name = "PesoPromLabel";
            this.PesoPromLabel.Size = new System.Drawing.Size(87, 21);
            this.PesoPromLabel.TabIndex = 41;
            this.PesoPromLabel.Text = "Peso Prom.";
            // 
            // PesoPromText
            // 
            this.PesoPromText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PesoPromText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoPromText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PesoPromText.Location = new System.Drawing.Point(720, 247);
            this.PesoPromText.MinValue = 0D;
            this.PesoPromText.Name = "PesoPromText";
            this.PesoPromText.Size = new System.Drawing.Size(250, 29);
            this.PesoPromText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PesoPromText.TabIndex = 46;
            this.PesoPromText.WatermarkText = "Ingresa la cantidad";
            this.PesoPromText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // PesoPromUnidad
            // 
            this.PesoPromUnidad.AutoSize = true;
            this.PesoPromUnidad.Location = new System.Drawing.Point(976, 250);
            this.PesoPromUnidad.Name = "PesoPromUnidad";
            this.PesoPromUnidad.Size = new System.Drawing.Size(63, 21);
            this.PesoPromUnidad.TabIndex = 41;
            this.PesoPromUnidad.Text = "gramos";
            // 
            // MermaMolerLabel
            // 
            this.MermaMolerLabel.AutoSize = true;
            this.MermaMolerLabel.Location = new System.Drawing.Point(600, 300);
            this.MermaMolerLabel.Name = "MermaMolerLabel";
            this.MermaMolerLabel.Size = new System.Drawing.Size(117, 21);
            this.MermaMolerLabel.TabIndex = 40;
            this.MermaMolerLabel.Text = "Merma a Moler";
            // 
            // MermaMolerText
            // 
            this.MermaMolerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MermaMolerText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaMolerText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MermaMolerText.Location = new System.Drawing.Point(720, 297);
            this.MermaMolerText.MinValue = 0D;
            this.MermaMolerText.Name = "MermaMolerText";
            this.MermaMolerText.Size = new System.Drawing.Size(250, 29);
            this.MermaMolerText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MermaMolerText.TabIndex = 45;
            this.MermaMolerText.WatermarkText = "Calculado automáticamente";
            this.MermaMolerText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // MermaMolerUnidad
            // 
            this.MermaMolerUnidad.AutoSize = true;
            this.MermaMolerUnidad.Location = new System.Drawing.Point(976, 300);
            this.MermaMolerUnidad.Name = "MermaMolerUnidad";
            this.MermaMolerUnidad.Size = new System.Drawing.Size(27, 21);
            this.MermaMolerUnidad.TabIndex = 41;
            this.MermaMolerUnidad.Text = "kg";
            // 
            // MermaRealUnidad
            // 
            this.MermaRealUnidad.AutoSize = true;
            this.MermaRealUnidad.Location = new System.Drawing.Point(976, 350);
            this.MermaRealUnidad.Name = "MermaRealUnidad";
            this.MermaRealUnidad.Size = new System.Drawing.Size(27, 21);
            this.MermaRealUnidad.TabIndex = 41;
            this.MermaRealUnidad.Text = "kg";
            // 
            // CalcularButton
            // 
            this.CalcularButton.AutoSize = true;
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(808, 400);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(78, 35);
            this.CalcularButton.TabIndex = 47;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // CantidadEntradaUnidad
            // 
            this.CantidadEntradaUnidad.AutoSize = true;
            this.CantidadEntradaUnidad.Location = new System.Drawing.Point(449, 200);
            this.CantidadEntradaUnidad.Name = "CantidadEntradaUnidad";
            this.CantidadEntradaUnidad.Size = new System.Drawing.Size(27, 21);
            this.CantidadEntradaUnidad.TabIndex = 54;
            this.CantidadEntradaUnidad.Text = "kg";
            // 
            // CantidadEntradaText
            // 
            this.CantidadEntradaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadEntradaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEntradaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadEntradaText.Location = new System.Drawing.Point(194, 197);
            this.CantidadEntradaText.MinValue = 0D;
            this.CantidadEntradaText.Name = "CantidadEntradaText";
            this.CantidadEntradaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadEntradaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadEntradaText.TabIndex = 53;
            this.CantidadEntradaText.WatermarkText = "Ingresa la cantidad";
            // 
            // MezclaCombo
            // 
            this.MezclaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MezclaCombo.FormattingEnabled = true;
            this.MezclaCombo.Location = new System.Drawing.Point(194, 147);
            this.MezclaCombo.Name = "MezclaCombo";
            this.MezclaCombo.Size = new System.Drawing.Size(250, 29);
            this.MezclaCombo.TabIndex = 52;
            this.MezclaCombo.SelectedIndexChanged += new System.EventHandler(this.MezclaCombo_SelectedIndexChanged);
            // 
            // CantidadEntradaLabel
            // 
            this.CantidadEntradaLabel.AutoSize = true;
            this.CantidadEntradaLabel.Location = new System.Drawing.Point(50, 200);
            this.CantidadEntradaLabel.Name = "CantidadEntradaLabel";
            this.CantidadEntradaLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadEntradaLabel.TabIndex = 50;
            this.CantidadEntradaLabel.Text = "Cantidad";
            // 
            // EntradaLabel
            // 
            this.EntradaLabel.AutoSize = true;
            this.EntradaLabel.Location = new System.Drawing.Point(50, 150);
            this.EntradaLabel.Name = "EntradaLabel";
            this.EntradaLabel.Size = new System.Drawing.Size(58, 21);
            this.EntradaLabel.TabIndex = 51;
            this.EntradaLabel.Text = "Mezcla";
            // 
            // RegistrarInyecciónMezclaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.CantidadEntradaUnidad);
            this.Controls.Add(this.CantidadEntradaText);
            this.Controls.Add(this.MezclaCombo);
            this.Controls.Add(this.CantidadEntradaLabel);
            this.Controls.Add(this.EntradaLabel);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.MermaMolerText);
            this.Controls.Add(this.MermaFinalText);
            this.Controls.Add(this.PesoPromText);
            this.Controls.Add(this.CantidadSalidaText);
            this.Controls.Add(this.SalidaCombo);
            this.Controls.Add(this.MermaMolerLabel);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.MermaRealLabel);
            this.Controls.Add(this.MermaRealUnidad);
            this.Controls.Add(this.MermaMolerUnidad);
            this.Controls.Add(this.PesoPromUnidad);
            this.Controls.Add(this.PesoPromLabel);
            this.Controls.Add(this.CantidadSalidaLabel);
            this.Controls.Add(this.SalidaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarInyecciónMezclaForm";
            this.Text = "RegistrarInyecciónForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaFinalText;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadSalidaText;
        private System.Windows.Forms.ComboBox SalidaCombo;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.Label MermaRealLabel;
        private System.Windows.Forms.Label CantidadSalidaLabel;
        private System.Windows.Forms.Label SalidaLabel;
        private System.Windows.Forms.Label PesoPromLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox PesoPromText;
        private System.Windows.Forms.Label PesoPromUnidad;
        private System.Windows.Forms.Label MermaMolerLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaMolerText;
        private System.Windows.Forms.Label MermaMolerUnidad;
        private System.Windows.Forms.Label MermaRealUnidad;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Label CantidadEntradaUnidad;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadEntradaText;
        private System.Windows.Forms.ComboBox MezclaCombo;
        private System.Windows.Forms.Label CantidadEntradaLabel;
        private System.Windows.Forms.Label EntradaLabel;
    }
}