using System;
using System.Windows.Forms;

namespace lab3_prog_wiz
{
    public partial class Informacje : Form
    {
        private Glowne_okno glowneOkno;
        public Informacje(Glowne_okno glowneOkno)
        {
            InitializeComponent();
            this.glowneOkno = glowneOkno;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Add("Ordynator");
            comboBox1.Items.Add("Lekarz specjalista");
            comboBox1.Items.Add("Rezydent");

            button1.Click += Zatwierdz_Click;
            button2.Click += Anuluj_Click;

        }
        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string wiek = textBox3.Text;
            string stanowisko = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) || string.IsNullOrWhiteSpace(wiek) || string.IsNullOrWhiteSpace(stanowisko))
            {
                MessageBox.Show("Uzupełnij brakujące dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            { 
                glowneOkno.DodajDoTabeli(imie, nazwisko, wiek, stanowisko); 
                this.Close();
            }
        }
        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
