using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }
        Banka banka = new Banka();
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormGiris f3 = new FormGiris(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

    }
}
