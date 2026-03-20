using System;
using System.Windows.Forms;

namespace lab3_prog_wiz
{
    public partial class Glowne_okno : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public Glowne_okno()
        {
            InitializeComponent();

            button1.Click += Zapis_Click;
            button2.Click += Odczyt_Click;
            button3.Click += Dodaj_Click;
            button4.Click += Usun_Click;

            var dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Imie", typeof(string));
            dataTable.Columns.Add("Nazwisko", typeof(string));
            dataTable.Columns.Add("Wiek", typeof(string));
            dataTable.Columns.Add("Stanowisko", typeof(string));

            bindingSource1.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource1;

        }

        public void DodajDoTabeli(string imie, string nazwisko, string wiek, string stanowisko)
        {
            var dataTable = (System.Data.DataTable)bindingSource1.DataSource;

            int ID = dataTable.Rows.Count + 1;

            dataTable.Rows.Add(ID, imie, nazwisko, wiek, stanowisko);
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
            if (bindingSource1.Current != null)
            {
                bindingSource1.RemoveCurrent();
            } 
            else 
            {
                MessageBox.Show("Wybierz wiersz do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Zapis_Click(object sender, EventArgs e)
        {

        }

        private void Odczyt_Click(object sender, EventArgs e)
        {

        }
    }
}
