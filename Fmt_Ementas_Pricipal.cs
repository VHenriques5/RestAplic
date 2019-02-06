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
    public partial class Fmt_Ementas_Pricipal : Form
    {
        public Fmt_Ementas_Pricipal()
        {
            InitializeComponent();
        }

        private void Fmt_Ementas_Pricipal_Load(object sender, EventArgs e)
        {
           // ToolTip tools = new ToolTip();
           // tools.SetToolTip(, "Carrega aqui");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmt_Ementa_Criar emc = new Fmt_Ementa_Criar();
            emc.ShowDialog();
        }
    }
}
