
namespace CZS_ERP_UI.DatosPage
{
    partial class CreateProviderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProviderForm));
            this.MainPanel = new DevExpress.XtraEditors.PanelControl();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new DevExpress.XtraEditors.SimpleButton();
            this.DireccionText = new System.Windows.Forms.TextBox();
            this.ResponsableText = new System.Windows.Forms.TextBox();
            this.CorreoText = new System.Windows.Forms.TextBox();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.TeléfonoText = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.NombreLabel = new DevExpress.XtraEditors.LabelControl();
            this.TeléfonoLabel = new DevExpress.XtraEditors.LabelControl();
            this.ResponsableLabel = new DevExpress.XtraEditors.LabelControl();
            this.DireccionLabel = new DevExpress.XtraEditors.LabelControl();
            this.CorreoLabel = new DevExpress.XtraEditors.LabelControl();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.MsgBox);
            this.MainPanel.Controls.Add(this.GuardarButton);
            this.MainPanel.Controls.Add(this.DireccionText);
            this.MainPanel.Controls.Add(this.ResponsableText);
            this.MainPanel.Controls.Add(this.CorreoText);
            this.MainPanel.Controls.Add(this.NombreText);
            this.MainPanel.Controls.Add(this.TeléfonoText);
            this.MainPanel.Controls.Add(this.NombreLabel);
            this.MainPanel.Controls.Add(this.TeléfonoLabel);
            this.MainPanel.Controls.Add(this.ResponsableLabel);
            this.MainPanel.Controls.Add(this.DireccionLabel);
            this.MainPanel.Controls.Add(this.CorreoLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1278, 841);
            this.MainPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.CloseButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CloseButton.ImageOptions.SvgImage")));
            this.CloseButton.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.Location = new System.Drawing.Point(1247, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 24);
            this.CloseButton.TabIndex = 23;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MsgBox
            // 
            this.MsgBox.FlatAppearance.BorderSize = 0;
            this.MsgBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.MsgBox.IconColor = System.Drawing.Color.DarkRed;
            this.MsgBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MsgBox.IconSize = 32;
            this.MsgBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.Location = new System.Drawing.Point(50, 400);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(350, 187);
            this.MsgBox.TabIndex = 11;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Appearance.Options.UseFont = true;
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Location = new System.Drawing.Point(336, 350);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(64, 24);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // DireccionText
            // 
            this.DireccionText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionText.Location = new System.Drawing.Point(200, 197);
            this.DireccionText.Multiline = true;
            this.DireccionText.Name = "DireccionText";
            this.DireccionText.Size = new System.Drawing.Size(200, 80);
            this.DireccionText.TabIndex = 3;
            // 
            // ResponsableText
            // 
            this.ResponsableText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsableText.Location = new System.Drawing.Point(200, 292);
            this.ResponsableText.Name = "ResponsableText";
            this.ResponsableText.Size = new System.Drawing.Size(200, 27);
            this.ResponsableText.TabIndex = 4;
            // 
            // CorreoText
            // 
            this.CorreoText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoText.Location = new System.Drawing.Point(200, 142);
            this.CorreoText.Name = "CorreoText";
            this.CorreoText.Size = new System.Drawing.Size(200, 27);
            this.CorreoText.TabIndex = 2;
            // 
            // NombreText
            // 
            this.NombreText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreText.Location = new System.Drawing.Point(200, 47);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(200, 27);
            this.NombreText.TabIndex = 0;
            // 
            // TeléfonoText
            // 
            this.TeléfonoText.BeforeTouchSize = new System.Drawing.Size(161, 27);
            this.TeléfonoText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeléfonoText.Location = new System.Drawing.Point(200, 97);
            this.TeléfonoText.Mask = "(###) ### ####";
            this.TeléfonoText.MaxLength = 14;
            this.TeléfonoText.Name = "TeléfonoText";
            this.TeléfonoText.Size = new System.Drawing.Size(161, 27);
            this.TeléfonoText.TabIndex = 1;
            this.TeléfonoText.Click += new System.EventHandler(this.TeléfonoText_Enter);
            this.TeléfonoText.Enter += new System.EventHandler(this.TeléfonoText_Enter);
            // 
            // NombreLabel
            // 
            this.NombreLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Appearance.Options.UseFont = true;
            this.NombreLabel.Location = new System.Drawing.Point(50, 50);
            this.NombreLabel.Margin = new System.Windows.Forms.Padding(4);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(57, 19);
            this.NombreLabel.TabIndex = 6;
            this.NombreLabel.Text = "Nombre";
            // 
            // TeléfonoLabel
            // 
            this.TeléfonoLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeléfonoLabel.Appearance.Options.UseFont = true;
            this.TeléfonoLabel.Location = new System.Drawing.Point(50, 100);
            this.TeléfonoLabel.Margin = new System.Windows.Forms.Padding(4);
            this.TeléfonoLabel.Name = "TeléfonoLabel";
            this.TeléfonoLabel.Size = new System.Drawing.Size(62, 19);
            this.TeléfonoLabel.TabIndex = 7;
            this.TeléfonoLabel.Text = "Teléfono";
            // 
            // ResponsableLabel
            // 
            this.ResponsableLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsableLabel.Appearance.Options.UseFont = true;
            this.ResponsableLabel.Location = new System.Drawing.Point(50, 300);
            this.ResponsableLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ResponsableLabel.Name = "ResponsableLabel";
            this.ResponsableLabel.Size = new System.Drawing.Size(88, 19);
            this.ResponsableLabel.TabIndex = 8;
            this.ResponsableLabel.Text = "Responsable";
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionLabel.Appearance.Options.UseFont = true;
            this.DireccionLabel.Location = new System.Drawing.Point(50, 200);
            this.DireccionLabel.Margin = new System.Windows.Forms.Padding(4);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(65, 19);
            this.DireccionLabel.TabIndex = 9;
            this.DireccionLabel.Text = "Dirección";
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoLabel.Appearance.Options.UseFont = true;
            this.CorreoLabel.Location = new System.Drawing.Point(50, 150);
            this.CorreoLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(48, 19);
            this.CorreoLabel.TabIndex = 10;
            this.CorreoLabel.Text = "Correo";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // CreateProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 841);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateProviderForm";
            this.Text = "CreateProvider";
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl MainPanel;
        private DevExpress.XtraEditors.LabelControl NombreLabel;
        private DevExpress.XtraEditors.LabelControl TeléfonoLabel;
        private DevExpress.XtraEditors.LabelControl ResponsableLabel;
        private DevExpress.XtraEditors.LabelControl DireccionLabel;
        private DevExpress.XtraEditors.LabelControl CorreoLabel;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox TeléfonoText;
        private DevExpress.XtraEditors.SimpleButton GuardarButton;
        private System.Windows.Forms.TextBox DireccionText;
        private System.Windows.Forms.TextBox ResponsableText;
        private System.Windows.Forms.TextBox CorreoText;
        private System.Windows.Forms.TextBox NombreText;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton CloseButton;
    }
}