using System;
using System.Windows.Forms;

namespace lab3_prog_wiz
{
    public partial class Glowne_okno : Form
    {
        public Glowne_okno()
        {
            InitializeComponent();

            button1.Click += Dodaj_Click;
            button2.Click += Usun_Click;
            button3.Click += Zapis_Click;
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            using (Informacje InformacjePracownicy = new Informacje(this))
            {
                InformacjePracownicy.ShowDialog();
            }
        }

        private void Usun_Click(object sender, EventArgs e)
        {

        }

        private void Zapis_Click(object sender, EventArgs e)
        {

        }

        private void Odczyt_Click(object sender, EventArgs e)
        {

        }
    }
}
