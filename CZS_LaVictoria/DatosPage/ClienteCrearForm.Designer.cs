
namespace CZS_LaVictoria.DatosPage
{
    partial class ClienteCrearForm
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
            this.AtencionLabel = new System.Windows.Forms.Label();
            this.DirecciónLabel = new System.Windows.Forms.Label();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.Teléfono1Label = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.Teléfono2Label = new System.Windows.Forms.Label();
            this.CiudadLabel = new System.Windows.Forms.Label();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.AtencionText = new System.Windows.Forms.TextBox();
            this.CorreoText = new System.Windows.Forms.TextBox();
            this.Teléfono1Text = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.Teléfono2Text = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.DirecciónText = new System.Windows.Forms.TextBox();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CiudadCombo = new System.Windows.Forms.ComboBox();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SubtitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Teléfono1Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teléfono2Text)).BeginInit();
            this.SuspendLayout();
            // 
            // AtencionLabel
            // 
            this.AtencionLabel.AutoSize = true;
            this.AtencionLabel.Location = new System.Drawing.Point(50, 200);
            this.AtencionLabel.Name = "AtencionLabel";
            this.AtencionLabel.Size = new System.Drawing.Size(78, 21);
            this.AtencionLabel.TabIndex = 3;
            this.AtencionLabel.Text = "Atención*";
            // 
            // DirecciónLabel
            // 
            this.DirecciónLabel.AutoSize = true;
            this.DirecciónLabel.Location = new System.Drawing.Point(50, 400);
            this.DirecciónLabel.Name = "DirecciónLabel";
            this.DirecciónLabel.Size = new System.Drawing.Size(82, 21);
            this.DirecciónLabel.TabIndex = 11;
            this.DirecciónLabel.Text = "Dirección*";
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Location = new System.Drawing.Point(50, 250);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(65, 21);
            this.CorreoLabel.TabIndex = 5;
            this.CorreoLabel.Text = "Correo*";
            // 
            // Teléfono1Label
            // 
            this.Teléfono1Label.AutoSize = true;
            this.Teléfono1Label.Location = new System.Drawing.Point(50, 300);
            this.Teléfono1Label.Name = "Teléfono1Label";
            this.Teléfono1Label.Size = new System.Drawing.Size(75, 21);
            this.Teléfono1Label.TabIndex = 7;
            this.Teléfono1Label.Text = "Teléfono*";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(50, 150);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(75, 21);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre*";
            // 
            // Teléfono2Label
            // 
            this.Teléfono2Label.AutoSize = true;
            this.Teléfono2Label.Location = new System.Drawing.Point(50, 350);
            this.Teléfono2Label.Name = "Teléfono2Label";
            this.Teléfono2Label.Size = new System.Drawing.Size(81, 21);
            this.Teléfono2Label.TabIndex = 9;
            this.Teléfono2Label.Text = "Teléfono 2";
            // 
            // CiudadLabel
            // 
            this.CiudadLabel.AutoSize = true;
            this.CiudadLabel.Location = new System.Drawing.Point(50, 500);
            this.CiudadLabel.Name = "CiudadLabel";
            this.CiudadLabel.Size = new System.Drawing.Size(66, 21);
            this.CiudadLabel.TabIndex = 13;
            this.CiudadLabel.Text = "Ciudad*";
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(220, 147);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(250, 29);
            this.NombreText.TabIndex = 2;
            // 
            // AtencionText
            // 
            this.AtencionText.Location = new System.Drawing.Point(220, 197);
            this.AtencionText.Name = "AtencionText";
            this.AtencionText.Size = new System.Drawing.Size(250, 29);
            this.AtencionText.TabIndex = 4;
            // 
            // CorreoText
            // 
            this.CorreoText.Location = new System.Drawing.Point(220, 247);
            this.CorreoText.Name = "CorreoText";
            this.CorreoText.Size = new System.Drawing.Size(250, 29);
            this.CorreoText.TabIndex = 6;
            // 
            // Teléfono1Text
            // 
            this.Teléfono1Text.BeforeTouchSize = new System.Drawing.Size(250, 29);
            this.Teléfono1Text.Location = new System.Drawing.Point(220, 297);
            this.Teléfono1Text.Mask = "(###) ### ####";
            this.Teléfono1Text.MaxLength = 14;
            this.Teléfono1Text.Name = "Teléfono1Text";
            this.Teléfono1Text.Size = new System.Drawing.Size(250, 29);
            this.Teléfono1Text.TabIndex = 8;
            this.Teléfono1Text.Click += new System.EventHandler(this.Teléfono1Text_Enter);
            this.Teléfono1Text.Enter += new System.EventHandler(this.Teléfono1Text_Enter);
            // 
            // Teléfono2Text
            // 
            this.Teléfono2Text.BeforeTouchSize = new System.Drawing.Size(250, 29);
            this.Teléfono2Text.Location = new System.Drawing.Point(220, 347);
            this.Teléfono2Text.Mask = "(###) ### ####";
            this.Teléfono2Text.MaxLength = 14;
            this.Teléfono2Text.Name = "Teléfono2Text";
            this.Teléfono2Text.Size = new System.Drawing.Size(250, 29);
            this.Teléfono2Text.TabIndex = 10;
            this.Teléfono2Text.Click += new System.EventHandler(this.Teléfono2Text_Enter);
            this.Teléfono2Text.Enter += new System.EventHandler(this.Teléfono2Text_Enter);
            // 
            // DirecciónText
            // 
            this.DirecciónText.Location = new System.Drawing.Point(220, 397);
            this.DirecciónText.Multiline = true;
            this.DirecciónText.Name = "DirecciónText";
            this.DirecciónText.Size = new System.Drawing.Size(250, 84);
            this.DirecciónText.TabIndex = 12;
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
            this.MsgBox.Location = new System.Drawing.Point(50, 600);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 150);
            this.MsgBox.TabIndex = 16;
            this.MsgBox.TabStop = false;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Location = new System.Drawing.Point(392, 550);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 31);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CiudadCombo
            // 
            this.CiudadCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CiudadCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CiudadCombo.FormattingEnabled = true;
            this.CiudadCombo.Location = new System.Drawing.Point(220, 497);
            this.CiudadCombo.Name = "CiudadCombo";
            this.CiudadCombo.Size = new System.Drawing.Size(250, 29);
            this.CiudadCombo.TabIndex = 14;
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
            this.SubtitleLabel.Size = new System.Drawing.Size(174, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Crear Cliente";
            // 
            // ClienteCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CiudadCombo);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.DirecciónText);
            this.Controls.Add(this.Teléfono2Text);
            this.Controls.Add(this.Teléfono1Text);
            this.Controls.Add(this.CorreoText);
            this.Controls.Add(this.AtencionText);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.AtencionLabel);
            this.Controls.Add(this.CiudadLabel);
            this.Controls.Add(this.DirecciónLabel);
            this.Controls.Add(this.CorreoLabel);
            this.Controls.Add(this.Teléfono2Label);
            this.Controls.Add(this.Teléfono1Label);
            this.Controls.Add(this.NombreLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClienteCrearForm";
            this.Text = "CrearClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.Teléfono1Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teléfono2Text)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AtencionLabel;
        private System.Windows.Forms.Label DirecciónLabel;
        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.Label Teléfono1Label;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label Teléfono2Label;
        private System.Windows.Forms.Label CiudadLabel;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.TextBox AtencionText;
        private System.Windows.Forms.TextBox CorreoText;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox Teléfono1Text;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox Teléfono2Text;
        private System.Windows.Forms.TextBox DirecciónText;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ComboBox CiudadCombo;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Label SubtitleLabel;
    }
}