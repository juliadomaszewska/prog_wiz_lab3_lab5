using System;
using System.Data;
using System.Windows.Forms;

namespace lab3_prog_wiz
{
    public partial class Glowne_okno : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public Glowne_okno()
        {
            InitializeComponent();

            button1.Click += btnSaveToCSV_Click;
            button2.Click += btnLoadCSV_Click;
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

        public class Osoba
        {
            public int ID { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int Wiek { get; set; }
            public string Stanowisko { get; set; }

            private static int globalId = 1;

            public Osoba() { }

            public Osoba(string imie, string nazwisko, int wiek, string stanowisko)
            {
                ID = globalId++;
                Imie = imie;
                Nazwisko = nazwisko;
                Wiek = wiek;
                Stanowisko = stanowisko;
            }

            public void DisplayInfo()
            {
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Imię: " + Imie);
                Console.WriteLine("Nazwisko: " + Nazwisko);
                Console.WriteLine("Wiek: " + Wiek);
                Console.WriteLine("Stanowisko: " + Stanowisko);
            }
        }

        public void DodajDoTabeli(string imie, string nazwisko, string wiek, string stanowisko)
        {
            var dataTable = (System.Data.DataTable)bindingSource1.DataSource;

            int ID = dataTable.Rows.Count + 1;

            dataTable.Rows.Add(ID, imie, nazwisko, wiek, stanowisko);
        }

        private void Dodaj_Click(object? sender, EventArgs e)
        {
            using (Informacje InformacjePracownicy = new Informacje(this))
            {
                InformacjePracownicy.ShowDialog();
            }
        }

        private void Usun_Click(object? sender, EventArgs e)
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

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            string csvContent = "Imie,Nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    csvContent += $"{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value},{row.Cells[4].Value}" + Environment.NewLine;
                }
            }
            File.WriteAllText(filePath, csvContent);
        }

        private void btnSaveToCSV_Click(object? sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizację zapisu pliku CSV";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void LoadCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines(filePath);

            DataTable dataTable = (System.Data.DataTable)bindingSource1.DataSource;
            dataTable.Rows.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                string[] values = lines[i].Split(',');

                if (values.Length == 4)
                {
                    int newId = dataTable.Rows.Count + 1;
                    dataTable.Rows.Add(newId, values[0], values[1], values[2], values[3]);
                }
                else if (values.Length == 5)
                {
                    int newId = dataTable.Rows.Count + 1;
                    dataTable.Rows.Add(newId, values[1], values[2], values[3], values[4]);
                }
            }
        }
        private void btnLoadCSV_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {

        }
    }
}