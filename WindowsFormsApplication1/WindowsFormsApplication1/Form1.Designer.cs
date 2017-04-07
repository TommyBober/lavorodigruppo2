namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listNomi = new System.Windows.Forms.ListBox();
            this.listLibri = new System.Windows.Forms.ListBox();
            this.prestaButton = new System.Windows.Forms.Button();
            this.libroButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listNomi
            // 
            this.listNomi.FormattingEnabled = true;
            this.listNomi.Location = new System.Drawing.Point(12, 0);
            this.listNomi.Name = "listNomi";
            this.listNomi.Size = new System.Drawing.Size(212, 134);
            this.listNomi.TabIndex = 0;
            this.listNomi.SelectedIndexChanged += new System.EventHandler(this.listNomi_SelectedIndexChanged);
            // 
            // listLibri
            // 
            this.listLibri.FormattingEnabled = true;
            this.listLibri.Location = new System.Drawing.Point(379, 0);
            this.listLibri.Name = "listLibri";
            this.listLibri.Size = new System.Drawing.Size(203, 134);
            this.listLibri.TabIndex = 1;
            this.listLibri.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // prestaButton
            // 
            this.prestaButton.Location = new System.Drawing.Point(248, 90);
            this.prestaButton.Name = "prestaButton";
            this.prestaButton.Size = new System.Drawing.Size(110, 44);
            this.prestaButton.TabIndex = 2;
            this.prestaButton.Text = "Presta";
            this.prestaButton.UseVisualStyleBackColor = true;
            this.prestaButton.Click += new System.EventHandler(this.prestaButton_Click);
            // 
            // libroButton
            // 
            this.libroButton.Location = new System.Drawing.Point(248, 53);
            this.libroButton.Name = "libroButton";
            this.libroButton.Size = new System.Drawing.Size(110, 23);
            this.libroButton.TabIndex = 3;
            this.libroButton.Text = "Info Libro";
            this.libroButton.UseVisualStyleBackColor = true;
            this.libroButton.Click += new System.EventHandler(this.libroButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(248, 14);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(111, 23);
            this.userButton.TabIndex = 4;
            this.userButton.Text = "Info Utente";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(71, 153);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(470, 159);
            this.textBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 324);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.libroButton);
            this.Controls.Add(this.prestaButton);
            this.Controls.Add(this.listLibri);
            this.Controls.Add(this.listNomi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listNomi;
        private System.Windows.Forms.ListBox listLibri;
        private System.Windows.Forms.Button prestaButton;
        private System.Windows.Forms.Button libroButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.TextBox textBox;
    }
}

