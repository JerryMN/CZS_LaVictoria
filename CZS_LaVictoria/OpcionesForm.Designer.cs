
namespace CZS_LaVictoria
{
    partial class OpcionesForm
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
            this.CorreoSubtitleLabel = new System.Windows.Forms.Label();
            this.CorreoText = new System.Windows.Forms.TextBox();
            this.SmtpText = new System.Windows.Forms.TextBox();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.SmtpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContraseñaText = new System.Windows.Forms.TextBox();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 50);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(131, 37);
            this.SubtitleLabel.TabIndex = 17;
            this.SubtitleLabel.Text = "Opciones";
            // 
            // CorreoSubtitleLabel
            // 
            this.CorreoSubtitleLabel.AutoSize = true;
            this.CorreoSubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoSubtitleLabel.Location = new System.Drawing.Point(50, 150);
            this.CorreoSubtitleLabel.Name = "CorreoSubtitleLabel";
            this.CorreoSubtitleLabel.Size = new System.Drawing.Size(74, 25);
            this.CorreoSubtitleLabel.TabIndex = 17;
            this.CorreoSubtitleLabel.Text = "Correo";
            // 
            // CorreoText
            // 
            this.CorreoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoText.Location = new System.Drawing.Point(220, 247);
            this.CorreoText.Name = "CorreoText";
            this.CorreoText.Size = new System.Drawing.Size(250, 29);
            this.CorreoText.TabIndex = 22;
            // 
            // SmtpText
            // 
            this.SmtpText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpText.Location = new System.Drawing.Point(220, 197);
            this.SmtpText.Name = "SmtpText";
            this.SmtpText.Size = new System.Drawing.Size(250, 29);
            this.SmtpText.TabIndex = 23;
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoLabel.Location = new System.Drawing.Point(50, 250);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(58, 21);
            this.CorreoLabel.TabIndex = 20;
            this.CorreoLabel.Text = "Correo";
            // 
            // SmtpLabel
            // 
            this.SmtpLabel.AutoSize = true;
            this.SmtpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpLabel.Location = new System.Drawing.Point(50, 200);
            this.SmtpLabel.Name = "SmtpLabel";
            this.SmtpLabel.Size = new System.Drawing.Size(113, 21);
            this.SmtpLabel.TabIndex = 21;
            this.SmtpLabel.Text = "Servidor SMTP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Contraseña";
            // 
            // ContraseñaText
            // 
            this.ContraseñaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaText.Location = new System.Drawing.Point(220, 300);
            this.ContraseñaText.Name = "ContraseñaText";
            this.ContraseñaText.PasswordChar = '*';
            this.ContraseñaText.Size = new System.Drawing.Size(250, 29);
            this.ContraseñaText.TabIndex = 22;
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
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
            this.MsgBox.Location = new System.Drawing.Point(50, 400);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 157);
            this.MsgBox.TabIndex = 25;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(392, 350);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 33);
            this.GuardarButton.TabIndex = 24;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // OpcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ContraseñaText);
            this.Controls.Add(this.CorreoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SmtpText);
            this.Controls.Add(this.CorreoLabel);
            this.Controls.Add(this.SmtpLabel);
            this.Controls.Add(this.CorreoSubtitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpcionesForm";
            this.Text = "OpcionesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label CorreoSubtitleLabel;
        private System.Windows.Forms.TextBox CorreoText;
        private System.Windows.Forms.TextBox SmtpText;
        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.Label SmtpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContraseñaText;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
    }
}