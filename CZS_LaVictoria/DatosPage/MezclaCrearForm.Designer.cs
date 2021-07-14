
namespace CZS_LaVictoria.DatosPage
{
    partial class MezclaCrearForm
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
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.CantidadText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.MaterialesListBox = new System.Windows.Forms.ListBox();
            this.CantidadesListBox = new System.Windows.Forms.ListBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(175, 37);
            this.SubtitleLabel.TabIndex = 17;
            this.SubtitleLabel.Text = "Crear Mezcla";
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MaterialCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MaterialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(220, 197);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(250, 29);
            this.MaterialCombo.TabIndex = 19;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(50, 200);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(67, 21);
            this.MaterialLabel.TabIndex = 18;
            this.MaterialLabel.Text = "Material";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(50, 250);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(72, 21);
            this.Cantidad.TabIndex = 21;
            this.Cantidad.Text = "Cantidad";
            // 
            // CantidadText
            // 
            this.CantidadText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadText.Location = new System.Drawing.Point(220, 250);
            this.CantidadText.MinValue = 0D;
            this.CantidadText.Name = "CantidadText";
            this.CantidadText.Size = new System.Drawing.Size(250, 29);
            this.CantidadText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadText.TabIndex = 36;
            this.CantidadText.WatermarkText = "Ingresa la cantidad";
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
            this.MsgBox.Location = new System.Drawing.Point(506, 400);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 157);
            this.MsgBox.TabIndex = 38;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(848, 350);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 33);
            this.GuardarButton.TabIndex = 37;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.AutoSize = true;
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Location = new System.Drawing.Point(392, 300);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(78, 33);
            this.AgregarButton.TabIndex = 37;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // MaterialesListBox
            // 
            this.MaterialesListBox.FormattingEnabled = true;
            this.MaterialesListBox.ItemHeight = 21;
            this.MaterialesListBox.Location = new System.Drawing.Point(520, 147);
            this.MaterialesListBox.Name = "MaterialesListBox";
            this.MaterialesListBox.Size = new System.Drawing.Size(200, 193);
            this.MaterialesListBox.TabIndex = 39;
            // 
            // CantidadesListBox
            // 
            this.CantidadesListBox.FormattingEnabled = true;
            this.CantidadesListBox.ItemHeight = 21;
            this.CantidadesListBox.Location = new System.Drawing.Point(726, 147);
            this.CantidadesListBox.Name = "CantidadesListBox";
            this.CantidadesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CantidadesListBox.Size = new System.Drawing.Size(200, 193);
            this.CantidadesListBox.TabIndex = 39;
            // 
            // EliminarButton
            // 
            this.EliminarButton.AutoSize = true;
            this.EliminarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(764, 350);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(78, 33);
            this.EliminarButton.TabIndex = 37;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(50, 150);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(68, 21);
            this.NombreLabel.TabIndex = 18;
            this.NombreLabel.Text = "Nombre";
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(220, 147);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(250, 29);
            this.NombreText.TabIndex = 40;
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // MezclaCrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.CantidadesListBox);
            this.Controls.Add(this.MaterialesListBox);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CantidadText);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.MaterialCombo);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MezclaCrearForm";
            this.Text = "MezclaCrearForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label Cantidad;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadText;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ListBox MaterialesListBox;
        private System.Windows.Forms.ListBox CantidadesListBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}