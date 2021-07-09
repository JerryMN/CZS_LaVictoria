
namespace CZS_LaVictoria.ÓrdenesPage
{
    partial class InventarioCrearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioCrearForm));
            this.AreaCombo = new System.Windows.Forms.ComboBox();
            this.AreaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.MaterialLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CategoríaLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CategoríaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CantidadText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.GuardarButton = new DevExpress.XtraEditors.SimpleButton();
            this.MaterialText = new System.Windows.Forms.TextBox();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AreaCombo
            // 
            this.AreaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaCombo.FormattingEnabled = true;
            this.AreaCombo.Location = new System.Drawing.Point(142, 79);
            this.AreaCombo.Name = "AreaCombo";
            this.AreaCombo.Size = new System.Drawing.Size(300, 29);
            this.AreaCombo.TabIndex = 29;
            // 
            // AreaLabel
            // 
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AreaLabel.Location = new System.Drawing.Point(42, 82);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(45, 21);
            this.AreaLabel.TabIndex = 28;
            this.AreaLabel.Text = "Área:";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MaterialLabel.Location = new System.Drawing.Point(42, 32);
            this.MaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(70, 21);
            this.MaterialLabel.TabIndex = 27;
            this.MaterialLabel.Text = "Material:";
            // 
            // CategoríaLabel
            // 
            this.CategoríaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CategoríaLabel.Location = new System.Drawing.Point(42, 132);
            this.CategoríaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoríaLabel.Name = "CategoríaLabel";
            this.CategoríaLabel.Size = new System.Drawing.Size(80, 21);
            this.CategoríaLabel.TabIndex = 28;
            this.CategoríaLabel.Text = "Categoría:";
            // 
            // CategoríaCombo
            // 
            this.CategoríaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CategoríaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoríaCombo.FormattingEnabled = true;
            this.CategoríaCombo.Location = new System.Drawing.Point(142, 129);
            this.CategoríaCombo.Name = "CategoríaCombo";
            this.CategoríaCombo.Size = new System.Drawing.Size(300, 29);
            this.CategoríaCombo.TabIndex = 29;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CantidadLabel.Location = new System.Drawing.Point(42, 182);
            this.CantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(75, 21);
            this.CantidadLabel.TabIndex = 28;
            this.CantidadLabel.Text = "Cantidad:";
            // 
            // CantidadText
            // 
            this.CantidadText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadText.Location = new System.Drawing.Point(142, 179);
            this.CantidadText.MinValue = 0D;
            this.CantidadText.Name = "CantidadText";
            this.CantidadText.Size = new System.Drawing.Size(300, 29);
            this.CantidadText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadText.TabIndex = 31;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Appearance.Options.UseFont = true;
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.GuardarButton.Location = new System.Drawing.Point(404, 232);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(38, 36);
            this.GuardarButton.TabIndex = 32;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MaterialText
            // 
            this.MaterialText.Location = new System.Drawing.Point(142, 29);
            this.MaterialText.Name = "MaterialText";
            this.MaterialText.Size = new System.Drawing.Size(300, 29);
            this.MaterialText.TabIndex = 33;
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
            this.MsgBox.Location = new System.Drawing.Point(42, 282);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(400, 150);
            this.MsgBox.TabIndex = 34;
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
            // InventarioCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.MaterialText);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CantidadText);
            this.Controls.Add(this.CategoríaCombo);
            this.Controls.Add(this.AreaCombo);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.CategoríaLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventarioCrearForm";
            this.Text = "Añadir material a inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AreaCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AreaLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel MaterialLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CategoríaLabel;
        private System.Windows.Forms.ComboBox CategoríaCombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CantidadLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadText;
        private DevExpress.XtraEditors.SimpleButton GuardarButton;
        private System.Windows.Forms.TextBox MaterialText;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}