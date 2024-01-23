using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace NumerandoFrazionando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numeratore_label.Visible = false;
            denominatore_label.Visible = false;
            riga.Visible = false;
        }

        public class Frazione
        {
            private int numeratore;
            private int denominatore;


            public int Numeratore
            { get { return numeratore; } set { numeratore = value; } }

            public int Denominatore
            { get { return denominatore; } set { denominatore = value; } }


        }

        // bottone che inserisce la frazione
        private void inserisci_frazione_Click(object sender, EventArgs e)
        {
            // input modfica prodotto nome

            string titolo_input = "Creazione Frazione", frase = "Inserisci il numeratore";
            object input_numeratore = Interaction.InputBox(frase, titolo_input);

            if ((string)input_numeratore == "") // user esce o lascia il campo vuoto
            {
                MessageBox.Show("Errore nell'aggiunta del numeratore", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int prova_numero = 0;

                if (!int.TryParse((string)input_numeratore, out prova_numero)) // controllo che l'input sia di tipo intero
                {
                    MessageBox.Show("Errore nell'aggiunta del numeratore", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // input corretto
                {
                    int numeratore = prova_numero;

                    // denominatore

                    titolo_input = "Creazione Frazione";
                    frase = "Inserisci il denominatore";
                    object input_denominatore = Interaction.InputBox(frase, titolo_input);

                    if ((string)input_denominatore == "") // user esce o lascia il campo vuoto
                    {
                        MessageBox.Show("Errore nell'aggiunta del denominatore", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        prova_numero = 0;

                        if (!int.TryParse((string)input_denominatore, out prova_numero)) // controllo che l'input sia di tipo intero
                        {
                            MessageBox.Show("Errore nell'aggiunta del denominatore", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else // input corretto
                        {
                            int denominatore = prova_numero;

                            // mostro la frazione

                            numeratore_label.Text = numeratore.ToString();
                            numeratore_label.Visible = true;

                            riga.Visible = true;

                            denominatore_label.Text = denominatore.ToString();
                            denominatore_label.Visible = true;
                        }

                    }
                }
            }
        }
    }
}
