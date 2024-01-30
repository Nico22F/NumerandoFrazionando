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
            this.somma_bottone = new System.Windows.Forms.Button();
            this.sottrai_bottone = new System.Windows.Forms.Button();
            this.moltiplica_button = new System.Windows.Forms.Button();
            this.divisione_button = new System.Windows.Forms.Button();
            this.eleva_button = new System.Windows.Forms.Button();
            this.conversione_button = new System.Windows.Forms.Button();
            this.conv_fraz_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inserisci_frazione
            // 
            this.inserisci_frazione.Location = new System.Drawing.Point(121, 532);
            this.inserisci_frazione.Margin = new System.Windows.Forms.Padding(4);
            this.inserisci_frazione.Name = "inserisci_frazione";
            this.inserisci_frazione.Size = new System.Drawing.Size(312, 55);
            this.inserisci_frazione.TabIndex = 0;
            this.inserisci_frazione.Text = "INSERISCI / MODIFICA FRAZIONE";
            this.inserisci_frazione.UseVisualStyleBackColor = true;
            this.inserisci_frazione.Click += new System.EventHandler(this.inserisci_frazione_Click);
            // 
            // numeratore_label
            // 
            this.numeratore_label.AutoSize = true;
            this.numeratore_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeratore_label.Location = new System.Drawing.Point(234, 157);
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
            this.denominatore_label.Location = new System.Drawing.Point(234, 203);
            this.denominatore_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.denominatore_label.Name = "denominatore_label";
            this.denominatore_label.Size = new System.Drawing.Size(99, 33);
            this.denominatore_label.TabIndex = 2;
            this.denominatore_label.Text = "label2";
            // 
            // riga
            // 
            this.riga.AutoSize = true;
            this.riga.Location = new System.Drawing.Point(203, 190);
            this.riga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.riga.Name = "riga";
            this.riga.Size = new System.Drawing.Size(142, 16);
            this.riga.TabIndex = 3;
            this.riga.Text = "---------------------------";
            // 
            // Semplifica_fraz
            // 
            this.Semplifica_fraz.Location = new System.Drawing.Point(121, 471);
            this.Semplifica_fraz.Name = "Semplifica_fraz";
            this.Semplifica_fraz.Size = new System.Drawing.Size(312, 54);
            this.Semplifica_fraz.TabIndex = 4;
            this.Semplifica_fraz.Text = "SEMPLIFICA LA FRAZIONE";
            this.Semplifica_fraz.UseVisualStyleBackColor = true;
            this.Semplifica_fraz.Click += new System.EventHandler(this.Semplifica_fraz_Click);
            // 
            // somma_bottone
            // 
            this.somma_bottone.Location = new System.Drawing.Point(440, 532);
            this.somma_bottone.Name = "somma_bottone";
            this.somma_bottone.Size = new System.Drawing.Size(61, 55);
            this.somma_bottone.TabIndex = 5;
            this.somma_bottone.Text = "+";
            this.somma_bottone.UseVisualStyleBackColor = true;
            this.somma_bottone.Click += new System.EventHandler(this.somma_bottone_Click);
            // 
            // sottrai_bottone
            // 
            this.sottrai_bottone.Location = new System.Drawing.Point(440, 471);
            this.sottrai_bottone.Name = "sottrai_bottone";
            this.sottrai_bottone.Size = new System.Drawing.Size(61, 55);
            this.sottrai_bottone.TabIndex = 6;
            this.sottrai_bottone.Text = "-";
            this.sottrai_bottone.UseVisualStyleBackColor = true;
            this.sottrai_bottone.Click += new System.EventHandler(this.sottrai_bottone_Click);
            // 
            // moltiplica_button
            // 
            this.moltiplica_button.Location = new System.Drawing.Point(53, 531);
            this.moltiplica_button.Name = "moltiplica_button";
            this.moltiplica_button.Size = new System.Drawing.Size(61, 56);
            this.moltiplica_button.TabIndex = 7;
            this.moltiplica_button.Text = "X";
            this.moltiplica_button.UseVisualStyleBackColor = true;
            this.moltiplica_button.Click += new System.EventHandler(this.moltiplica_button_Click);
            // 
            // divisione_button
            // 
            this.divisione_button.Location = new System.Drawing.Point(53, 471);
            this.divisione_button.Name = "divisione_button";
            this.divisione_button.Size = new System.Drawing.Size(61, 56);
            this.divisione_button.TabIndex = 8;
            this.divisione_button.Text = "/";
            this.divisione_button.UseVisualStyleBackColor = true;
            this.divisione_button.Click += new System.EventHandler(this.divisione_button_Click);
            // 
            // eleva_button
            // 
            this.eleva_button.Location = new System.Drawing.Point(121, 409);
            this.eleva_button.Name = "eleva_button";
            this.eleva_button.Size = new System.Drawing.Size(312, 54);
            this.eleva_button.TabIndex = 9;
            this.eleva_button.Text = "ELEVA FRAZIONE";
            this.eleva_button.UseVisualStyleBackColor = true;
            this.eleva_button.Click += new System.EventHandler(this.eleva_button_Click);
            // 
            // conversione_button
            // 
            this.conversione_button.Location = new System.Drawing.Point(121, 349);
            this.conversione_button.Name = "conversione_button";
            this.conversione_button.Size = new System.Drawing.Size(312, 54);
            this.conversione_button.TabIndex = 10;
            this.conversione_button.Text = "CONVERSIONE IN DECIMALE";
            this.conversione_button.UseVisualStyleBackColor = true;
            this.conversione_button.Click += new System.EventHandler(this.conversione_button_Click);
            // 
            // conv_fraz_button
            // 
            this.conv_fraz_button.Location = new System.Drawing.Point(121, 289);
            this.conv_fraz_button.Name = "conv_fraz_button";
            this.conv_fraz_button.Size = new System.Drawing.Size(312, 54);
            this.conv_fraz_button.TabIndex = 11;
            this.conv_fraz_button.Text = "CONVERSIONE IN FRAZIONE";
            this.conv_fraz_button.UseVisualStyleBackColor = true;
            this.conv_fraz_button.Click += new System.EventHandler(this.conv_fraz_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 600);
            this.Controls.Add(this.conv_fraz_button);
            this.Controls.Add(this.conversione_button);
            this.Controls.Add(this.eleva_button);
            this.Controls.Add(this.divisione_button);
            this.Controls.Add(this.moltiplica_button);
            this.Controls.Add(this.sottrai_bottone);
            this.Controls.Add(this.somma_bottone);
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
        private System.Windows.Forms.Button somma_bottone;
        private System.Windows.Forms.Button sottrai_bottone;
        private System.Windows.Forms.Button moltiplica_button;
        private System.Windows.Forms.Button divisione_button;
        private System.Windows.Forms.Button eleva_button;
        private System.Windows.Forms.Button conversione_button;
        private System.Windows.Forms.Button conv_fraz_button;
    }
}

