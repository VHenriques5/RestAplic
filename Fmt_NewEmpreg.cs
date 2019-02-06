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
    public partial class Fmt_NewEmpreg : Form
    {
       public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        DB_Acess aceder = new DB_Acess();
   

          

       // int selectedRow;
        int EmpCode = 0;
        SqlCommand cmd;
        SqlDataAdapter adapt = new SqlDataAdapter();
        SqlConnection cnn = new SqlConnection(ConStr);
       
      
      

        public Fmt_NewEmpreg()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DataSet ds = aceder.PGridConsulta("select Empreg.Nome, Empreg.Categoria, Empreg.Emp_Cod, Empreg.Categoria, Empreg.Profissao, Empreg.Genero, Empreg.Idade, Mesa.mesa, Mesa.nlugares, Mesa.esplanada,Mesa.Emp_Cod From Mesa Inner Join Empreg ON Empreg.Emp_Cod=Mesa.Emp_Cod", "test");
            DGViewEmp.DataSource = ds.Tables["test"].DefaultView;

            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = ds.Tables[0].TableName;
        }

        private void Fmt_NewEmpreg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.Empreg' table. You can move, or remove it, as needed.
          //  this.empregTableAdapter.Fill(this.ds1.Empreg);
            

        }



        private void ClearData()
        {

            TxtNome.Text = "";
            TxtProfissao.Text = "";
            TxtIdade.Text = "";
            cbMesa.Text = "";
            TxtCategoria.Text = "";
            TxtGenero.Text = "";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                aceder.Emp(TxtNome.Text,  TxtCategoria.Text, TxtProfissao.Text, TxtGenero.Text, Convert.ToInt32(TxtIdade.Text));
                ClearData();
                MessageBox.Show("Registo Inserido na Base de Dados");

            }
            catch (Exception sqlEx)
            {
                if (sqlEx.Message.StartsWith("Invalid object name"))
                {
                    MessageBox.Show("Erro de origem SQL");
                }

                else
                {
                    MessageBox.Show("User já existe na base de dados");
                }

           
            }
        }


        private void refresh()
        { 
        
            DataSet ds1 = aceder.PGridConsulta("select * From Empreg", "test");
            DGViewEmp.DataSource = ds1.Tables["test"].DefaultView;

            bindingSource1.DataSource = ds1;
            bindingSource1.DataMember = ds1.Tables[0].TableName;
        
        
        }


        
        private void button5_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void DGViewEmp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EmpCode = Convert.ToInt32(DGViewEmp.Rows[e.RowIndex].Cells[0].Value.ToString());
            TxtNome.Text = DGViewEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtCategoria.Text = DGViewEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtProfissao.Text = DGViewEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtGenero.Text = DGViewEmp.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtIdade.Text = DGViewEmp.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbMesa.Text = EmpCode.ToString();
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


        private void button1_Click(object sender, EventArgs e)
        {

            if (TxtNome.Text != "" && TxtIdade.Text != "")
            {

                try
                {

                    string sql = "UPDATE Empreg SET Nome ='" + TxtNome.Text + "', Categoria ='" + TxtCategoria.Text + "', Profissao = '" + TxtProfissao.Text + "',Genero = '" + TxtGenero.Text + "', Idade = '" + Convert.ToInt32(TxtIdade.Text) + "'WHERE Emp_Cod = '" + cbMesa.Text + "' ";
                    this.ExecutarConsulta(sql);
                    MessageBox.Show("Registo atualizado com sucesso");
                    refresh();
                    ClearData();

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

        private void button4_Click(object sender, EventArgs e)
        {

        }

    
  
   

       
        
    }
}
