using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SGR
{
    public partial class Fmt_VerPedido : Form
    {
       
          public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
          DB_Acess aceder = new DB_Acess();

          

        public Fmt_VerPedido()
        {
            InitializeComponent();
        }

        
       
        
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fmt_PedMesa_Detail pedetail;
                pedetail = new Fmt_PedMesa_Detail();

             pedetail.IDPedido = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());    
             pedetail.Mesa = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
             pedetail.NomeEmpreg = dataGridView1.CurrentRow.Cells[5].Value.ToString();
             pedetail.Status = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value.ToString());
             pedetail.Prato = dataGridView1.CurrentRow.Cells[4].Value.ToString();
             pedetail.Quant = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
           //edetail.MdiParent = this;
           
            pedetail.Show();

          

             
           // pedetail.ShowDialog();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection cnn = new SqlConnection(ConStr);

            if (cnn.State.ToString() == "Closed")
            {
                cnn.Open();
            }

            string sql = "select count(Status_Ped) from Pedido where Status_Ped=2";
            cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();


            Lblcozinha.Text = sql;
            //LblMesa.Text = 
       
        }

 

    }
}
