
namespace CZS_LaVictoria.DatosPage
{
    partial class ProveedorCrearForm
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
            this.NombreLabel = new System.Windows.Forms.Label();
            this.TeléfonoLabel = new System.Windows.Forms.Label();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.DirecciónLabel = new System.Windows.Forms.Label();
            this.ResponsableLabel = new System.Windows.Forms.Label();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.CorreoText = new System.Windows.Forms.TextBox();
            this.DirecciónText = new System.Windows.Forms.TextBox();
            this.ResponsableText = new System.Windows.Forms.TextBox();
            this.TeléfonoText = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.CondicionesLabel = new System.Windows.Forms.Label();
            this.CondicionesCombo = new System.Windows.Forms.ComboBox();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(50, 150);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(75, 21);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre*";
            // 
            // TeléfonoLabel
            // 
            this.TeléfonoLabel.AutoSize = true;
            this.TeléfonoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeléfonoLabel.Location = new System.Drawing.Point(50, 200);
            this.TeléfonoLabel.Name = "TeléfonoLabel";
            this.TeléfonoLabel.Size = new System.Drawing.Size(75, 21);
            this.TeléfonoLabel.TabIndex = 3;
            this.TeléfonoLabel.Text = "Teléfono*";
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoLabel.Location = new System.Drawing.Point(50, 250);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(65, 21);
            this.CorreoLabel.TabIndex = 5;
            this.CorreoLabel.Text = "Correo*";
            // 
            // DirecciónLabel
            // 
            this.DirecciónLabel.AutoSize = true;
            this.DirecciónLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecciónLabel.Location = new System.Drawing.Point(50, 300);
            this.DirecciónLabel.Name = "DirecciónLabel";
            this.DirecciónLabel.Size = new System.Drawing.Size(75, 21);
            this.DirecciónLabel.TabIndex = 7;
            this.DirecciónLabel.Text = "Dirección";
            // 
            // ResponsableLabel
            // 
            this.ResponsableLabel.AutoSize = true;
            this.ResponsableLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsableLabel.Location = new System.Drawing.Point(50, 400);
            this.ResponsableLabel.Name = "ResponsableLabel";
            this.ResponsableLabel.Size = new System.Drawing.Size(79, 21);
            this.ResponsableLabel.TabIndex = 9;
            this.ResponsableLabel.Text = "Contacto*";
            // 
            // NombreText
            // 
            this.NombreText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreText.Location = new System.Drawing.Point(220, 147);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(250, 29);
            this.NombreText.TabIndex = 2;
            // 
            // CorreoText
            // 
            this.CorreoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoText.Location = new System.Drawing.Point(220, 247);
            this.CorreoText.Name = "CorreoText";
            this.CorreoText.Size = new System.Drawing.Size(250, 29);
            this.CorreoText.TabIndex = 6;
            // 
            // DirecciónText
            // 
            this.DirecciónText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecciónText.Location = new System.Drawing.Point(220, 297);
            this.DirecciónText.Multiline = true;
            this.DirecciónText.Name = "DirecciónText";
            this.DirecciónText.Size = new System.Drawing.Size(250, 84);
            this.DirecciónText.TabIndex = 8;
            // 
            // ResponsableText
            // 
            this.ResponsableText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsableText.Location = new System.Drawing.Point(220, 397);
            this.ResponsableText.Name = "ResponsableText";
            this.ResponsableText.Size = new System.Drawing.Size(250, 29);
            this.ResponsableText.TabIndex = 10;
            // 
            // TeléfonoText
            // 
            this.TeléfonoText.BeforeTouchSize = new System.Drawing.Size(250, 29);
            this.TeléfonoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeléfonoText.Location = new System.Drawing.Point(220, 197);
            this.TeléfonoText.Mask = "(###) ### ####";
            this.TeléfonoText.MaxLength = 14;
            this.TeléfonoText.Name = "TeléfonoText";
            this.TeléfonoText.Size = new System.Drawing.Size(250, 29);
            this.TeléfonoText.TabIndex = 4;
            this.TeléfonoText.Click += new System.EventHandler(this.TeléfonoText_Enter);
            this.TeléfonoText.Enter += new System.EventHandler(this.TeléfonoText_Enter);
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
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // CondicionesLabel
            // 
            this.CondicionesLabel.AutoSize = true;
            this.CondicionesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondicionesLabel.Location = new System.Drawing.Point(50, 450);
            this.CondicionesLabel.Name = "CondicionesLabel";
            this.CondicionesLabel.Size = new System.Drawing.Size(95, 21);
            this.CondicionesLabel.TabIndex = 11;
            this.CondicionesLabel.Text = "Condiciones";
            // 
            // CondicionesCombo
            // 
            this.CondicionesCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CondicionesCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CondicionesCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondicionesCombo.FormattingEnabled = true;
            this.CondicionesCombo.Location = new System.Drawing.Point(220, 447);
            this.CondicionesCombo.Name = "CondicionesCombo";
            this.CondicionesCombo.Size = new System.Drawing.Size(250, 29);
            this.CondicionesCombo.TabIndex = 12;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(215, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Crear Proveedor";
            // 
            // ProveedorCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CondicionesCombo);
            this.Controls.Add(this.CondicionesLabel);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.TeléfonoText);
            this.Controls.Add(this.ResponsableText);
            this.Controls.Add(this.DirecciónText);
            this.Controls.Add(this.CorreoText);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.ResponsableLabel);
            this.Controls.Add(this.DirecciónLabel);
            this.Controls.Add(this.CorreoLabel);
            this.Controls.Add(this.TeléfonoLabel);
            this.Controls.Add(this.NombreLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProveedorCrearForm";
            this.Text = "CrearProveedorForm";
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label TeléfonoLabel;
        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.Label DirecciónLabel;
        private System.Windows.Forms.Label ResponsableLabel;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.TextBox CorreoText;
        private System.Windows.Forms.TextBox DirecciónText;
        private System.Windows.Forms.TextBox ResponsableText;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox TeléfonoText;
        private System.Windows.Forms.Button GuardarButton;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Label CondicionesLabel;
        private System.Windows.Forms.ComboBox CondicionesCombo;
        private System.Windows.Forms.Label SubtitleLabel;
    }
}