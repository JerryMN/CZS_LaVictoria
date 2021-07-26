
namespace CZS_LaVictoria.ÓrdenesPage
{
    partial class AgregarNotasForm
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
            this.NotasText = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotasText
            // 
            this.NotasText.Location = new System.Drawing.Point(50, 50);
            this.NotasText.Multiline = true;
            this.NotasText.Name = "NotasText";
            this.NotasText.Size = new System.Drawing.Size(500, 200);
            this.NotasText.TabIndex = 0;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(388, 256);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 35);
            this.GuardarButton.TabIndex = 1;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.AutoSize = true;
            this.CerrarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.Location = new System.Drawing.Point(472, 256);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(78, 35);
            this.CerrarButton.TabIndex = 2;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // AgregarNotasForm
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarButton;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NotasText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarNotasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Notas a Orden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NotasText;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CerrarButton;
    }
}