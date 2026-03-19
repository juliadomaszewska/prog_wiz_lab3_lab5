using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        }
    }
}
