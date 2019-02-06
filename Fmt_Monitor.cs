using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR
{
    public partial class Fmt_Monitor : Form
    {
        public Fmt_Monitor()
        {
            InitializeComponent();
        }

        private void Fmt_Monitor_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fmt_Monitorizacao mnt = new Fmt_Monitorizacao();
            mnt.Show();
        }

        private void monitorizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmt_Monitorizacao mnt = new Fmt_Monitorizacao();
            mnt.Show();
        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fmt_VerPedido vermesas = new Fmt_VerPedido();
            vermesas.ShowDialog();
        }
    }
}
