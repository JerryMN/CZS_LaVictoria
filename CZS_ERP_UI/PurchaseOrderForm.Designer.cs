
namespace CZS_ERP_UI
{
    partial class PurchaseOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
            this.MainPanel = new DevExpress.XtraEditors.PanelControl();
            this.EditOrderCheck = new DevExpress.XtraEditors.CheckEdit();
            this.FechaEntregaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.TeléfonoText = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.ResponsableCombo = new System.Windows.Forms.ComboBox();
            this.AreaCombo = new System.Windows.Forms.ComboBox();
            this.ProveedorCombo = new System.Windows.Forms.ComboBox();
            this.OrdenText = new System.Windows.Forms.TextBox();
            this.OrdenLabel = new DevExpress.XtraEditors.LabelControl();
            this.ProveedorLabel = new DevExpress.XtraEditors.LabelControl();
            this.TeléfonoLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DirecciónText = new DevExpress.XtraEditors.LabelControl();
            this.FechaText = new DevExpress.XtraEditors.LabelControl();
            this.ResponsableLabel = new DevExpress.XtraEditors.LabelControl();
            this.AreaLabel = new DevExpress.XtraEditors.LabelControl();
            this.FechaEntregaLabel = new DevExpress.XtraEditors.LabelControl();
            this.FechaOrdenLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditOrderCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.EditOrderCheck);
            this.MainPanel.Controls.Add(this.FechaEntregaPicker);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.TeléfonoText);
            this.MainPanel.Controls.Add(this.ResponsableCombo);
            this.MainPanel.Controls.Add(this.AreaCombo);
            this.MainPanel.Controls.Add(this.ProveedorCombo);
            this.MainPanel.Controls.Add(this.OrdenText);
            this.MainPanel.Controls.Add(this.OrdenLabel);
            this.MainPanel.Controls.Add(this.ProveedorLabel);
            this.MainPanel.Controls.Add(this.TeléfonoLabel);
            this.MainPanel.Controls.Add(this.labelControl1);
            this.MainPanel.Controls.Add(this.DirecciónText);
            this.MainPanel.Controls.Add(this.FechaText);
            this.MainPanel.Controls.Add(this.ResponsableLabel);
            this.MainPanel.Controls.Add(this.AreaLabel);
            this.MainPanel.Controls.Add(this.FechaEntregaLabel);
            this.MainPanel.Controls.Add(this.FechaOrdenLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1278, 841);
            this.MainPanel.TabIndex = 0;
            // 
            // EditOrderCheck
            // 
            this.EditOrderCheck.Location = new System.Drawing.Point(328, 48);
            this.EditOrderCheck.Name = "EditOrderCheck";
            this.EditOrderCheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditOrderCheck.Properties.Appearance.Options.UseFont = true;
            this.EditOrderCheck.Properties.Caption = "Editar";
            this.EditOrderCheck.Size = new System.Drawing.Size(75, 23);
            this.EditOrderCheck.TabIndex = 24;
            this.EditOrderCheck.CheckedChanged += new System.EventHandler(this.EditOrderCheck_CheckedChanged);
            // 
            // FechaEntregaPicker
            // 
            this.FechaEntregaPicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.FechaEntregaPicker.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.FechaEntregaPicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEntregaPicker.Format = "dd/MMM/yyyy";
            this.FechaEntregaPicker.Location = new System.Drawing.Point(634, 193);
            this.FechaEntregaPicker.Name = "FechaEntregaPicker";
            this.FechaEntregaPicker.Size = new System.Drawing.Size(163, 31);
            this.FechaEntregaPicker.TabIndex = 23;
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
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TeléfonoText
            // 
            this.TeléfonoText.BackColor = System.Drawing.SystemColors.Control;
            this.TeléfonoText.BeforeTouchSize = new System.Drawing.Size(161, 27);
            this.TeléfonoText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeléfonoText.Location = new System.Drawing.Point(210, 147);
            this.TeléfonoText.Mask = "(###) ### ####";
            this.TeléfonoText.MaxLength = 14;
            this.TeléfonoText.Name = "TeléfonoText";
            this.TeléfonoText.ReadOnly = true;
            this.TeléfonoText.Size = new System.Drawing.Size(161, 27);
            this.TeléfonoText.TabIndex = 21;
            // 
            // ResponsableCombo
            // 
            this.ResponsableCombo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsableCombo.FormattingEnabled = true;
            this.ResponsableCombo.Location = new System.Drawing.Point(600, 147);
            this.ResponsableCombo.Name = "ResponsableCombo";
            this.ResponsableCombo.Size = new System.Drawing.Size(197, 27);
            this.ResponsableCombo.TabIndex = 20;
            // 
            // AreaCombo
            // 
            this.AreaCombo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaCombo.FormattingEnabled = true;
            this.AreaCombo.Location = new System.Drawing.Point(600, 97);
            this.AreaCombo.Name = "AreaCombo";
            this.AreaCombo.Size = new System.Drawing.Size(197, 27);
            this.AreaCombo.TabIndex = 20;
            // 
            // ProveedorCombo
            // 
            this.ProveedorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedorCombo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorCombo.FormattingEnabled = true;
            this.ProveedorCombo.Location = new System.Drawing.Point(210, 97);
            this.ProveedorCombo.Name = "ProveedorCombo";
            this.ProveedorCombo.Size = new System.Drawing.Size(225, 27);
            this.ProveedorCombo.TabIndex = 20;
            this.ProveedorCombo.TextChanged += new System.EventHandler(this.ProveedorCombo_TextChanged);
            // 
            // OrdenText
            // 
            this.OrdenText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdenText.Location = new System.Drawing.Point(210, 47);
            this.OrdenText.Name = "OrdenText";
            this.OrdenText.ReadOnly = true;
            this.OrdenText.Size = new System.Drawing.Size(112, 27);
            this.OrdenText.TabIndex = 19;
            // 
            // OrdenLabel
            // 
            this.OrdenLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdenLabel.Appearance.Options.UseFont = true;
            this.OrdenLabel.Location = new System.Drawing.Point(50, 50);
            this.OrdenLabel.Margin = new System.Windows.Forms.Padding(4);
            this.OrdenLabel.Name = "OrdenLabel";
            this.OrdenLabel.Size = new System.Drawing.Size(61, 19);
            this.OrdenLabel.TabIndex = 17;
            this.OrdenLabel.Text = "Orden #";
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorLabel.Appearance.Options.UseFont = true;
            this.ProveedorLabel.Location = new System.Drawing.Point(50, 100);
            this.ProveedorLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(72, 19);
            this.ProveedorLabel.TabIndex = 17;
            this.ProveedorLabel.Text = "Proveedor";
            // 
            // TeléfonoLabel
            // 
            this.TeléfonoLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeléfonoLabel.Appearance.Options.UseFont = true;
            this.TeléfonoLabel.Location = new System.Drawing.Point(50, 150);
            this.TeléfonoLabel.Margin = new System.Windows.Forms.Padding(4);
            this.TeléfonoLabel.Name = "TeléfonoLabel";
            this.TeléfonoLabel.Size = new System.Drawing.Size(62, 19);
            this.TeléfonoLabel.TabIndex = 17;
            this.TeléfonoLabel.Text = "Teléfono";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 200);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 19);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Dirección";
            // 
            // DirecciónText
            // 
            this.DirecciónText.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecciónText.Appearance.Options.UseFont = true;
            this.DirecciónText.Location = new System.Drawing.Point(210, 200);
            this.DirecciónText.Margin = new System.Windows.Forms.Padding(4);
            this.DirecciónText.Name = "DirecciónText";
            this.DirecciónText.Size = new System.Drawing.Size(65, 19);
            this.DirecciónText.TabIndex = 17;
            this.DirecciónText.Text = "Dirección";
            // 
            // FechaText
            // 
            this.FechaText.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaText.Appearance.Options.UseFont = true;
            this.FechaText.Location = new System.Drawing.Point(560, 50);
            this.FechaText.Margin = new System.Windows.Forms.Padding(4);
            this.FechaText.Name = "FechaText";
            this.FechaText.Size = new System.Drawing.Size(104, 19);
            this.FechaText.TabIndex = 14;
            this.FechaText.Text = "dd/mmm/yyyy";
            // 
            // ResponsableLabel
            // 
            this.ResponsableLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsableLabel.Appearance.Options.UseFont = true;
            this.ResponsableLabel.Location = new System.Drawing.Point(500, 150);
            this.ResponsableLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ResponsableLabel.Name = "ResponsableLabel";
            this.ResponsableLabel.Size = new System.Drawing.Size(88, 19);
            this.ResponsableLabel.TabIndex = 15;
            this.ResponsableLabel.Text = "Responsable";
            // 
            // AreaLabel
            // 
            this.AreaLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLabel.Appearance.Options.UseFont = true;
            this.AreaLabel.Location = new System.Drawing.Point(500, 100);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(4);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(33, 19);
            this.AreaLabel.TabIndex = 15;
            this.AreaLabel.Text = "Área";
            // 
            // FechaEntregaLabel
            // 
            this.FechaEntregaLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEntregaLabel.Appearance.Options.UseFont = true;
            this.FechaEntregaLabel.Location = new System.Drawing.Point(500, 200);
            this.FechaEntregaLabel.Margin = new System.Windows.Forms.Padding(4);
            this.FechaEntregaLabel.Name = "FechaEntregaLabel";
            this.FechaEntregaLabel.Size = new System.Drawing.Size(121, 19);
            this.FechaEntregaLabel.TabIndex = 15;
            this.FechaEntregaLabel.Text = "Fecha de Entrega";
            // 
            // FechaOrdenLabel
            // 
            this.FechaOrdenLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaOrdenLabel.Appearance.Options.UseFont = true;
            this.FechaOrdenLabel.Location = new System.Drawing.Point(500, 50);
            this.FechaOrdenLabel.Margin = new System.Windows.Forms.Padding(4);
            this.FechaOrdenLabel.Name = "FechaOrdenLabel";
            this.FechaOrdenLabel.Size = new System.Drawing.Size(40, 19);
            this.FechaOrdenLabel.TabIndex = 15;
            this.FechaOrdenLabel.Text = "Fecha";
            // 
            // PurchaseOrderForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 841);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseOrderForm";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditOrderCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeléfonoText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl MainPanel;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox TeléfonoText;
        private System.Windows.Forms.ComboBox ProveedorCombo;
        private System.Windows.Forms.TextBox OrdenText;
        private DevExpress.XtraEditors.LabelControl DirecciónText;
        private DevExpress.XtraEditors.LabelControl FechaText;
        private DevExpress.XtraEditors.LabelControl FechaOrdenLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaEntregaPicker;
        private System.Windows.Forms.ComboBox ResponsableCombo;
        private System.Windows.Forms.ComboBox AreaCombo;
        private DevExpress.XtraEditors.LabelControl ResponsableLabel;
        private DevExpress.XtraEditors.LabelControl AreaLabel;
        private DevExpress.XtraEditors.LabelControl FechaEntregaLabel;
        private DevExpress.XtraEditors.CheckEdit EditOrderCheck;
        private DevExpress.XtraEditors.LabelControl OrdenLabel;
        private DevExpress.XtraEditors.LabelControl ProveedorLabel;
        private DevExpress.XtraEditors.LabelControl TeléfonoLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton CloseButton;
    }
}