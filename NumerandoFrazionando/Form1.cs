using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static NumerandoFrazionando.Form1;

namespace NumerandoFrazionando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Frazione frazione = new Frazione();
        private void Form1_Load(object sender, EventArgs e)
        {
            numeratore_label.Visible = false;
            denominatore_label.Visible = false;
            riga.Visible = false;
            Semplifica_fraz.Visible = false;
        }

        // variabili globali

        public class Frazione
        {
            private int numeratore;
            private int denominatore;
            private bool segno_negativo1; // numeratore
            private bool segno_negativo2; // denominatore


            public int Numeratore
            { get { return numeratore; } set { this.numeratore = value; } }

            public int Denominatore
            { get { return denominatore; } set { denominatore = value; } }

            public bool Segno_negativo1
            { get { return segno_negativo1; } set { segno_negativo1 = value; } }

            public bool Segno_negativo2
            { get { return segno_negativo2; } set { segno_negativo2 = value; } }


            public bool ControlloSegno( int n)
            {
                bool segno = false;

                if (n < 0)
                {
                    segno = true;
                }

                return segno;
            }

            // trova il numero minore


            public int TrovaMinore(int n1, int n2)
            {
                // rendo i numeri positivi

                if (n1 < 0)
                {
                    n1 *= -1;
                }

                if (n2 < 0)
                {
                    n2 *= -1;
                }

                // trovo il numero più piccolo

                int min = 0;

                if (n1 < n2)
                {
                    min = n1;
                }
                else if (n2 < n1)
                {
                    min = n2;
                }
                else if (n1 == n2)
                {
                    min = n1;
                }

                return min;
            }

            // semplifica la frazione se possibile

            public void Semplifica(int num,int den)
            {
                // semplifico numeri

                bool semplifica = true;

                while (semplifica == true)
                {
                    semplifica = false;

                    int min = TrovaMinore(num, den);

                    for (int i = 1; i < min; i++)
                    {
                        if (num % i == 0 && den % i == 0)
                        {
                            if (i != 1)
                            {
                                num /= i; den /= i;
                                semplifica = true;
                            }
                        }
                    }
                }

                // semplifico segni 

                if (Segno_negativo1 == true && Segno_negativo2 == true)
                {
                    num *= -1;
                    den *= -1;
                }

                numeratore = num;
                denominatore = den;

            }


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
                    frazione.Numeratore = prova_numero;

                    // controllo segno

                    frazione.Segno_negativo1 = frazione.ControlloSegno(frazione.Numeratore);

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
                            frazione.Denominatore = prova_numero;

                            // controllo segno

                            frazione.Segno_negativo2 = frazione.ControlloSegno(frazione.Denominatore);

                            // mostro la frazione

                            numeratore_label.Text = frazione.Numeratore.ToString();
                            numeratore_label.Visible = true;

                            riga.Visible = true;

                            denominatore_label.Text = frazione.Denominatore.ToString();
                            denominatore_label.Visible = true;

                            // mostro bottoni

                            Semplifica_fraz.Visible = true;
                        }

                    }
                }
            }
        }

        // SEMPLIFICA FRAZIONE
        private void Semplifica_fraz_Click(object sender, EventArgs e)
        {
            
            frazione.Semplifica(frazione.Numeratore,frazione.Denominatore);

            numeratore_label.Text = frazione.Numeratore.ToString();
            denominatore_label.Text = frazione.Denominatore.ToString();

        }
    }
}
