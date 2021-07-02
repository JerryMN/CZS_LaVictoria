
namespace CZS_ERP_UI.ÓrdenesPage
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
            this.PanelNoteOne = new System.Windows.Forms.GroupBox();
            this.TextNoteOne = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PanelNoteTwo = new System.Windows.Forms.GroupBox();
            this.textNoteTwo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ButtonSaveNotes = new FontAwesome.Sharp.IconButton();
            this.PanelNoteOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextNoteOne)).BeginInit();
            this.PanelNoteTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNoteTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelNoteOne
            // 
            this.PanelNoteOne.Controls.Add(this.TextNoteOne);
            this.PanelNoteOne.Location = new System.Drawing.Point(30, 50);
            this.PanelNoteOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelNoteOne.Name = "PanelNoteOne";
            this.PanelNoteOne.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelNoteOne.Size = new System.Drawing.Size(390, 175);
            this.PanelNoteOne.TabIndex = 0;
            this.PanelNoteOne.TabStop = false;
            this.PanelNoteOne.Text = "Nota 1";
            // 
            // TextNoteOne
            // 
            this.TextNoteOne.BeforeTouchSize = new System.Drawing.Size(382, 143);
            this.TextNoteOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextNoteOne.Location = new System.Drawing.Point(4, 27);
            this.TextNoteOne.Multiline = true;
            this.TextNoteOne.Name = "TextNoteOne";
            this.TextNoteOne.Size = new System.Drawing.Size(382, 143);
            this.TextNoteOne.TabIndex = 1;
            // 
            // PanelNoteTwo
            // 
            this.PanelNoteTwo.Controls.Add(this.textNoteTwo);
            this.PanelNoteTwo.Location = new System.Drawing.Point(30, 275);
            this.PanelNoteTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelNoteTwo.Name = "PanelNoteTwo";
            this.PanelNoteTwo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelNoteTwo.Size = new System.Drawing.Size(390, 175);
            this.PanelNoteTwo.TabIndex = 1;
            this.PanelNoteTwo.TabStop = false;
            this.PanelNoteTwo.Text = "Nota 2";
            // 
            // textNoteTwo
            // 
            this.textNoteTwo.BeforeTouchSize = new System.Drawing.Size(382, 143);
            this.textNoteTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNoteTwo.Location = new System.Drawing.Point(4, 27);
            this.textNoteTwo.Multiline = true;
            this.textNoteTwo.Name = "textNoteTwo";
            this.textNoteTwo.Size = new System.Drawing.Size(382, 143);
            this.textNoteTwo.TabIndex = 2;
            // 
            // ButtonSaveNotes
            // 
            this.ButtonSaveNotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonSaveNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonSaveNotes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonSaveNotes.IconColor = System.Drawing.Color.Black;
            this.ButtonSaveNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSaveNotes.Location = new System.Drawing.Point(30, 458);
            this.ButtonSaveNotes.Name = "ButtonSaveNotes";
            this.ButtonSaveNotes.Size = new System.Drawing.Size(119, 37);
            this.ButtonSaveNotes.TabIndex = 3;
            this.ButtonSaveNotes.Text = "Guardar";
            this.ButtonSaveNotes.UseVisualStyleBackColor = true;
            this.ButtonSaveNotes.Click += new System.EventHandler(this.ButtonSaveNotes_Click);
            // 
            // AddNotesForm
            // 
            this.AcceptButton = this.ButtonSaveNotes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonSaveNotes;
            this.ClientSize = new System.Drawing.Size(450, 550);
            this.Controls.Add(this.ButtonSaveNotes);
            this.Controls.Add(this.PanelNoteTwo);
            this.Controls.Add(this.PanelNoteOne);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNotesForm";
            this.PanelNoteOne.ResumeLayout(false);
            this.PanelNoteOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextNoteOne)).EndInit();
            this.PanelNoteTwo.ResumeLayout(false);
            this.PanelNoteTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNoteTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PanelNoteOne;
        private System.Windows.Forms.GroupBox PanelNoteTwo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextNoteOne;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textNoteTwo;
        private FontAwesome.Sharp.IconButton ButtonSaveNotes;
    }
}