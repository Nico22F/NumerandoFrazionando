namespace NumerandoFrazionando
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
            this.inserisci_frazione = new System.Windows.Forms.Button();
            this.numeratore_label = new System.Windows.Forms.Label();
            this.denominatore_label = new System.Windows.Forms.Label();
            this.riga = new System.Windows.Forms.Label();
            this.Semplifica_fraz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inserisci_frazione
            // 
            this.inserisci_frazione.Location = new System.Drawing.Point(121, 506);
            this.inserisci_frazione.Margin = new System.Windows.Forms.Padding(4);
            this.inserisci_frazione.Name = "inserisci_frazione";
            this.inserisci_frazione.Size = new System.Drawing.Size(312, 81);
            this.inserisci_frazione.TabIndex = 0;
            this.inserisci_frazione.Text = "INSERISCI / MODIFICA FRAZIONE";
            this.inserisci_frazione.UseVisualStyleBackColor = true;
            this.inserisci_frazione.Click += new System.EventHandler(this.inserisci_frazione_Click);
            // 
            // numeratore_label
            // 
            this.numeratore_label.AutoSize = true;
            this.numeratore_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeratore_label.Location = new System.Drawing.Point(234, 216);
            this.numeratore_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeratore_label.Name = "numeratore_label";
            this.numeratore_label.Size = new System.Drawing.Size(99, 33);
            this.numeratore_label.TabIndex = 1;
            this.numeratore_label.Text = "label1";
            // 
            // denominatore_label
            // 
            this.denominatore_label.AutoSize = true;
            this.denominatore_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denominatore_label.Location = new System.Drawing.Point(234, 316);
            this.denominatore_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.denominatore_label.Name = "denominatore_label";
            this.denominatore_label.Size = new System.Drawing.Size(99, 33);
            this.denominatore_label.TabIndex = 2;
            this.denominatore_label.Text = "label2";
            // 
            // riga
            // 
            this.riga.AutoSize = true;
            this.riga.Location = new System.Drawing.Point(209, 277);
            this.riga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.riga.Name = "riga";
            this.riga.Size = new System.Drawing.Size(142, 16);
            this.riga.TabIndex = 3;
            this.riga.Text = "---------------------------";
            // 
            // Semplifica_fraz
            // 
            this.Semplifica_fraz.Location = new System.Drawing.Point(121, 443);
            this.Semplifica_fraz.Name = "Semplifica_fraz";
            this.Semplifica_fraz.Size = new System.Drawing.Size(153, 56);
            this.Semplifica_fraz.TabIndex = 4;
            this.Semplifica_fraz.Text = "SEMPLIFICA LA FRAZIONE";
            this.Semplifica_fraz.UseVisualStyleBackColor = true;
            this.Semplifica_fraz.Click += new System.EventHandler(this.Semplifica_fraz_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Semplifica_fraz);
            this.Controls.Add(this.riga);
            this.Controls.Add(this.denominatore_label);
            this.Controls.Add(this.numeratore_label);
            this.Controls.Add(this.inserisci_frazione);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Frazionando22F";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inserisci_frazione;
        private System.Windows.Forms.Label numeratore_label;
        private System.Windows.Forms.Label denominatore_label;
        private System.Windows.Forms.Label riga;
        private System.Windows.Forms.Button Semplifica_fraz;
        private System.Windows.Forms.Button button1;
    }
}

