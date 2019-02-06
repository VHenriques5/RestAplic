using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SGR
{
    public partial class Fmt_Mesas : Form
    {
        
  
       DB_Acess acess = new DB_Acess();

       public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

       SqlCommand cmd;
       SqlDataAdapter adapt = new SqlDataAdapter();
       SqlConnection cnn = new SqlConnection(ConStr);
        
        
        
        
        public Fmt_Mesas()
        {
            InitializeComponent();
            tabControl1.TabPages.Clear();
            Fmt_Login lg = new Fmt_Login();
            lg.Hide();
        }


        private void Limpa()
        {
            TxtMesa.Text = "";
            txtLugares.Text = "";
            checkBox1.Checked = false;
        
        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {

            Limpa();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            if (TxtMesa.Text != "" && txtLugares.Text != "")
            {

                try
                {

                    acess.mesa(Convert.ToInt32(TxtMesa.Text), Convert.ToInt32(txtLugares.Text), checkBox1.Checked);
                    MessageBox.Show("A Mesa " + Convert.ToInt32(TxtMesa.Text) + " foi inserida com sucesso !!! Não se esqueça de atribuir um empregado");
                    Limpa();

                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.Message.StartsWith("Invalid object name"))
                    {
                        MessageBox.Show("ERROR");
                    }

                    else
                    {
                        MessageBox.Show("Esta mesa já existe na base de dados");
                    }
                }
            }
            else
               {

                   MessageBox.Show("Preencha os campos Mesa e Lugares ");
                }
            
            }

      
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                           
         }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(Criar);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(Criar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
             tabControl1.TabPages.Add(Selecionar);  
        }


        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(Editar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(Apagar);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
          
        }

  

        private void button10_Click(object sender, EventArgs e)
        {
            DataSet ds = acess.PreencheGrid("Select top 1 * from Mesa order by mesa desc", "test");
            dataGridView1.DataSource = ds.Tables["test"].DefaultView;

            BSUsers.DataSource = ds;
            BSUsers.DataMember = ds.Tables[0].TableName;
        }

     

        private void button11_Click(object sender, EventArgs e)
        {
            DataSet ds = acess.PreencheGrid("Select * from Mesa order by mesa", "test");
            dataGridView1.DataSource = ds.Tables["test"].DefaultView;

            BSUsers.DataSource = ds;
            BSUsers.DataMember = ds.Tables[0].TableName;
        }

    
      

        private void Fmt_Mesas_Load(object sender, EventArgs e)
        {
          
            this.mesaTableAdapter.Fill(this.testDataSet1.Mesa);
            

        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataSet ds = acess.PGridConsulta("select Empreg.Nome, Empreg.Categoria, Mesa.mesa, Mesa.nlugares, Mesa.esplanada, Mesa.Emp_Cod From Mesa Inner Join Empreg ON Empreg.Emp_Cod=Mesa.Emp_Cod", "test");
            dataGridView1.DataSource = ds.Tables["test"].DefaultView;

            BSUsers.DataSource = ds;
            BSUsers.DataMember = ds.Tables[0].TableName;
        }

        

        public void ExecutarConsulta(string sql)
        {

            if (cnn.State.ToString() == "Closed")
            {
                cnn.Open();
            }


            cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

        }


        private void button15_Click(object sender, EventArgs e)
        {
          
            string sql = "  Update Mesa Set Emp_Cod =  '" + Convert.ToInt32(TxtUpdEmp.Text) + "' where ID_Mesa = '" + Convert.ToInt32(TxtUpdMesa.Text) + "'";
            this.ExecutarConsulta(sql);
            MessageBox.Show("Registo  atualizado");
            Limpa();
           
      
        }

      

        

     


        

     

      
    }
}
