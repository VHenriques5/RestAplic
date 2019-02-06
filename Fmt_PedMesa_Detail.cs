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
    public partial class Fmt_PedMesa_Detail : Form
    {

        public string PNome, Prato, NomeEmpreg, PAdicional; // ver o prox comentario
        public int IDPedido, Mesa, Quant, Status;
        public DateTime Hora, Data;
        
        public Fmt_PedMesa_Detail()
        {
            InitializeComponent();
        }

        private void Fmt_PedMesa_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSt1.Pedido' table. You can move, or remove it, as needed.
            this.pedidoTableAdapter.Fill(this.dsSt1.Pedido);
            vartoobj();
        }



        private void vartoobj()
        {
            LblID.Text   = Convert.ToInt32(IDPedido).ToString();
            LblEmp.Text  = NomeEmpreg.ToString();
            LblMesa.Text = Convert.ToInt32(Mesa).ToString();
            LblPrato.Text = Prato.ToString();
            LblQuant.Text = Convert.ToInt32(Quant).ToString();
            if (Status == 2)
            {
                LblM.Visible = true;
                LblC.Visible = false; 
                LblM.Text = Convert.ToInt32(Status).ToString("Cozinha");
                
            }
            else 
            {
                LblM.Visible = false;
                LblC.Visible = true; 
                LblC.Text = Convert.ToInt32(Status).ToString("Mesa");
            } 
            

        }

        private void MesCoz()
        {
           
        
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    
    }


}
