namespace LaufwerkAnzeige
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_Ausgabe = new System.Windows.Forms.ListBox();
            this.btnLaufwerk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_Ausgabe
            // 
            this.lbx_Ausgabe.FormattingEnabled = true;
            this.lbx_Ausgabe.Location = new System.Drawing.Point(151, 41);
            this.lbx_Ausgabe.Name = "lbx_Ausgabe";
            this.lbx_Ausgabe.Size = new System.Drawing.Size(158, 186);
            this.lbx_Ausgabe.TabIndex = 0;
            this.lbx_Ausgabe.DoubleClick += new System.EventHandler(this.lbx_Ausgabe_DoubleClick);
            // 
            // btnLaufwerk
            // 
            this.btnLaufwerk.Location = new System.Drawing.Point(151, 263);
            this.btnLaufwerk.Name = "btnLaufwerk";
            this.btnLaufwerk.Size = new System.Drawing.Size(75, 23);
            this.btnLaufwerk.TabIndex = 1;
            this.btnLaufwerk.Text = "Laufwerke";
            this.btnLaufwerk.UseVisualStyleBackColor = true;
            this.btnLaufwerk.Click += new System.EventHandler(this.btnLaufwerk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLaufwerk);
            this.Controls.Add(this.lbx_Ausgabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Ausgabe;
        private System.Windows.Forms.Button btnLaufwerk;
    }
}

