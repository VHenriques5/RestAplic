using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace SGR
{
    public partial class Fmt_Ementa_Criar : Form
    {

        public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        SqlConnection con = new SqlConnection(ConStr);
       

        DB_Acess aceder = new DB_Acess();
     

    




        public Fmt_Ementa_Criar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Fmt_Ementa_Criar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Menu.ementa' table. You can move, or remove it, as needed.
            this.ementaTableAdapter1.Fill(this.dS_Menu.ementa);
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO ementa ([Prato],[PNome],[Composiçao],[preco_in],[data_out],[created_at],[is_active]) 
                            VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7)", con);

           
                cmd.Parameters.AddWithValue("@value1", cbPrato.Text);
                cmd.Parameters.AddWithValue("@value2", txtPNome.Text);
                cmd.Parameters.AddWithValue("@value3", txtComposicao.Text);
                cmd.Parameters.AddWithValue("@value4", Convert.ToInt32(txtPreco.Text));
                cmd.Parameters.AddWithValue("@value5", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@value6", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@value7", Convert.ToInt32(checkBox1.Checked));
         

                cmd.ExecuteNonQuery();



                MessageBox.Show("Registo Inserido na Base de Dados");
                refresh();

                con.Close();
            }
            catch (Exception sqlEx)
            {

                if (sqlEx.Message.StartsWith("Invalid object name"))
                {

                    MessageBox.Show("Erro de origem SQL");
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = DGVCriaEmenta.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbPrato.Text = DGVCriaEmenta.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPNome.Text = DGVCriaEmenta.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtComposicao.Text = DGVCriaEmenta.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPreco.Text = DGVCriaEmenta.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker2.Text = DGVCriaEmenta.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Text = DGVCriaEmenta.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void refresh()
        {

            DataSet ds1 = aceder.PGridConsulta("select * From ementa", "test");
            DGVCriaEmenta.DataSource = ds1.Tables["test"].DefaultView;

            ementaBindingSource1.DataSource = ds1;
            ementaBindingSource1.DataMember = ds1.Tables[0].TableName;


        }



        public void ExecutarConsulta(string sql)
        {

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {

            if (cbPrato.Text != "" && txtPNome.Text != "")
            {

                try
                {
                    string sql = "UPDATE ementa SET Prato  = '" + cbPrato.Text + "'PNome'"+ txtPNome.Text +"', Composiçao ='" + txtComposicao.Text + "', preco_in = '" + txtPreco.Text + "',data_out = '" + dateTimePicker2.Text + "', Created_at '"+ dateTimePicker2.Text +"',is_active = '" + checkBox1.Text  + "'WHERE id = '" + txtID.Text + "' ";
                    this.ExecutarConsulta(sql);

                    refresh();
                    MessageBox.Show("Registo atualizado com sucesso");
                 

                }
                catch (Exception sqlEx)
                {
                    if (sqlEx.Message.StartsWith("Invalid Object name"))
                    {
                        MessageBox.Show("Ver o que se passa");

                    }
                    else
                    {

                        MessageBox.Show("Este registo não está a ser atualizado");

                    }
                }
            }
      
        }

       
    
        
    }
}
