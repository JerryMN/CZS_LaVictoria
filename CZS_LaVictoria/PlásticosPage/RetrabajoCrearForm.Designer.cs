
namespace CZS_LaVictoria.PlásticosPage
{
    partial class RetrabajoCrearForm
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
            this.FechaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.PiezaMalaCombo = new System.Windows.Forms.ComboBox();
            this.PiezaMalaLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.AccionGroup = new System.Windows.Forms.GroupBox();
            this.MermaRadio = new System.Windows.Forms.RadioButton();
            this.MolerRadio = new System.Windows.Forms.RadioButton();
            this.CorregirRadio = new System.Windows.Forms.RadioButton();
            this.CantidadSalidaLabel = new System.Windows.Forms.Label();
            this.CantidadSalidaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.PesoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PesoPromUnidad = new System.Windows.Forms.Label();
            this.PesoLabel = new System.Windows.Forms.Label();
            this.AccionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(284, 37);
            this.SubtitleLabel.TabIndex = 32;
            this.SubtitleLabel.Text = "Procesar Piezas Malas";
            // 
            // FechaPicker
            // 
            this.FechaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaPicker.Location = new System.Drawing.Point(200, 147);
            this.FechaPicker.Name = "FechaPicker";
            this.FechaPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaPicker.TabIndex = 76;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(50, 150);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(151, 21);
            this.FechaLabel.TabIndex = 75;
            this.FechaLabel.Text = "Fecha de operación*";
            // 
            // PiezaMalaCombo
            // 
            this.PiezaMalaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PiezaMalaCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiezaMalaCombo.FormattingEnabled = true;
            this.PiezaMalaCombo.Location = new System.Drawing.Point(200, 197);
            this.PiezaMalaCombo.Name = "PiezaMalaCombo";
            this.PiezaMalaCombo.Size = new System.Drawing.Size(250, 29);
            this.PiezaMalaCombo.TabIndex = 78;
            this.PiezaMalaCombo.SelectedIndexChanged += new System.EventHandler(this.PiezaMalaCombo_SelectedIndexChanged);
            // 
            // PiezaMalaLabel
            // 
            this.PiezaMalaLabel.AutoSize = true;
            this.PiezaMalaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiezaMalaLabel.Location = new System.Drawing.Point(50, 200);
            this.PiezaMalaLabel.Name = "PiezaMalaLabel";
            this.PiezaMalaLabel.Size = new System.Drawing.Size(80, 21);
            this.PiezaMalaLabel.TabIndex = 77;
            this.PiezaMalaLabel.Text = "Producto*";
            // 
            // CantidadEntradaLabel
            // 
            this.CantidadEntradaLabel.AutoSize = true;
            this.CantidadEntradaLabel.Location = new System.Drawing.Point(50, 250);
            this.CantidadEntradaLabel.Name = "CantidadEntradaLabel";
            this.CantidadEntradaLabel.Size = new System.Drawing.Size(150, 21);
            this.CantidadEntradaLabel.TabIndex = 79;
            this.CantidadEntradaLabel.Text = "Cantidad Disponible";
            // 
            // CantidadEntradaText
            // 
            this.CantidadEntradaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadEntradaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEntradaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadEntradaText.HideTrailingZeros = true;
            this.CantidadEntradaText.Location = new System.Drawing.Point(200, 247);
            this.CantidadEntradaText.MinValue = 0D;
            this.CantidadEntradaText.Name = "CantidadEntradaText";
            this.CantidadEntradaText.ReadOnly = true;
            this.CantidadEntradaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadEntradaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadEntradaText.TabIndex = 80;
            this.CantidadEntradaText.Text = "0";
            this.CantidadEntradaText.WatermarkText = "Ingresa la cantidad";
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
            this.ArrowButton.TabIndex = 81;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // AccionGroup
            // 
            this.AccionGroup.Controls.Add(this.MermaRadio);
            this.AccionGroup.Controls.Add(this.MolerRadio);
            this.AccionGroup.Controls.Add(this.CorregirRadio);
            this.AccionGroup.Location = new System.Drawing.Point(600, 147);
            this.AccionGroup.Name = "AccionGroup";
            this.AccionGroup.Size = new System.Drawing.Size(370, 79);
            this.AccionGroup.TabIndex = 82;
            this.AccionGroup.TabStop = false;
            this.AccionGroup.Text = "Acción*";
            // 
            // MermaRadio
            // 
            this.MermaRadio.AutoSize = true;
            this.MermaRadio.Location = new System.Drawing.Point(281, 40);
            this.MermaRadio.Name = "MermaRadio";
            this.MermaRadio.Size = new System.Drawing.Size(78, 25);
            this.MermaRadio.TabIndex = 0;
            this.MermaRadio.TabStop = true;
            this.MermaRadio.Text = "Merma";
            this.MermaRadio.UseVisualStyleBackColor = true;
            this.MermaRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // MolerRadio
            // 
            this.MolerRadio.AutoSize = true;
            this.MolerRadio.Location = new System.Drawing.Point(154, 40);
            this.MolerRadio.Name = "MolerRadio";
            this.MolerRadio.Size = new System.Drawing.Size(69, 25);
            this.MolerRadio.TabIndex = 0;
            this.MolerRadio.TabStop = true;
            this.MolerRadio.Text = "Moler";
            this.MolerRadio.UseVisualStyleBackColor = true;
            this.MolerRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // CorregirRadio
            // 
            this.CorregirRadio.AutoSize = true;
            this.CorregirRadio.Location = new System.Drawing.Point(10, 40);
            this.CorregirRadio.Name = "CorregirRadio";
            this.CorregirRadio.Size = new System.Drawing.Size(86, 25);
            this.CorregirRadio.TabIndex = 0;
            this.CorregirRadio.TabStop = true;
            this.CorregirRadio.Text = "Corregir";
            this.CorregirRadio.UseVisualStyleBackColor = true;
            this.CorregirRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // CantidadSalidaLabel
            // 
            this.CantidadSalidaLabel.AutoSize = true;
            this.CantidadSalidaLabel.Location = new System.Drawing.Point(596, 250);
            this.CantidadSalidaLabel.Name = "CantidadSalidaLabel";
            this.CantidadSalidaLabel.Size = new System.Drawing.Size(79, 21);
            this.CantidadSalidaLabel.TabIndex = 79;
            this.CantidadSalidaLabel.Text = "Cantidad*";
            // 
            // CantidadSalidaText
            // 
            this.CantidadSalidaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadSalidaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadSalidaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadSalidaText.HideTrailingZeros = true;
            this.CantidadSalidaText.Location = new System.Drawing.Point(720, 247);
            this.CantidadSalidaText.MinValue = 0D;
            this.CantidadSalidaText.Name = "CantidadSalidaText";
            this.CantidadSalidaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadSalidaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadSalidaText.TabIndex = 80;
            this.CantidadSalidaText.Text = "0";
            this.CantidadSalidaText.WatermarkText = "Ingresa la cantidad";
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
            this.MsgBox.Location = new System.Drawing.Point(546, 407);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 84;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(892, 353);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 37);
            this.GuardarButton.TabIndex = 83;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // PesoText
            // 
            this.PesoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PesoText.Enabled = false;
            this.PesoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PesoText.Location = new System.Drawing.Point(720, 297);
            this.PesoText.MinValue = 0D;
            this.PesoText.Name = "PesoText";
            this.PesoText.Size = new System.Drawing.Size(250, 29);
            this.PesoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PesoText.TabIndex = 87;
            this.PesoText.WatermarkText = "Ingresa la cantidad";
            // 
            // PesoPromUnidad
            // 
            this.PesoPromUnidad.AutoSize = true;
            this.PesoPromUnidad.Location = new System.Drawing.Point(972, 300);
            this.PesoPromUnidad.Name = "PesoPromUnidad";
            this.PesoPromUnidad.Size = new System.Drawing.Size(27, 21);
            this.PesoPromUnidad.TabIndex = 86;
            this.PesoPromUnidad.Text = "kg";
            // 
            // PesoLabel
            // 
            this.PesoLabel.AutoSize = true;
            this.PesoLabel.Location = new System.Drawing.Point(596, 300);
            this.PesoLabel.Name = "PesoLabel";
            this.PesoLabel.Size = new System.Drawing.Size(42, 21);
            this.PesoLabel.TabIndex = 85;
            this.PesoLabel.Text = "Peso";
            // 
            // PiezasMalasProcesarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.PesoText);
            this.Controls.Add(this.PesoPromUnidad);
            this.Controls.Add(this.PesoLabel);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.AccionGroup);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.CantidadSalidaText);
            this.Controls.Add(this.CantidadEntradaText);
            this.Controls.Add(this.CantidadSalidaLabel);
            this.Controls.Add(this.CantidadEntradaLabel);
            this.Controls.Add(this.PiezaMalaCombo);
            this.Controls.Add(this.PiezaMalaLabel);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PiezasMalasProcesarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PiezasMalasProcesarForm";
            this.AccionGroup.ResumeLayout(false);
            this.AccionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPicker;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.ComboBox PiezaMalaCombo;
        private System.Windows.Forms.Label PiezaMalaLabel;
        private System.Windows.Forms.Label CantidadEntradaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadEntradaText;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.GroupBox AccionGroup;
        private System.Windows.Forms.RadioButton CorregirRadio;
        private System.Windows.Forms.RadioButton MermaRadio;
        private System.Windows.Forms.RadioButton MolerRadio;
        private System.Windows.Forms.Label CantidadSalidaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadSalidaText;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private Syncfusion.WinForms.Input.SfNumericTextBox PesoText;
        private System.Windows.Forms.Label PesoPromUnidad;
        private System.Windows.Forms.Label PesoLabel;
    }
}