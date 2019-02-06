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
using System.Globalization;



namespace SGR
{
    public partial class Form1 : Form
    {

        public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        DB_Acess aceder = new DB_Acess();
        int Status_L = 1;
        int Status_P = 1;

        SqlConnection con = new SqlConnection(ConStr);





        public Form1()
        {
            InitializeComponent();



        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "use test select *  from ementa where Prato LIKE '" + TxtProcura.Text + "'";

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            DGVPedidos.DataSource = dtRecord;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtPrato.Text = DGVPedidos.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtPNome.Text = DGVPedidos.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtCompoe.Text = DGVPedidos.Rows[e.RowIndex].Cells[4].Value.ToString();
            // TxtNome.Text = comboBox1.ValueMember = "Verificar";
            TxtData.Text = DateTime.Now.ToShortDateString();
            TxtHora.Text = DateTime.Now.ToShortTimeString();

        }



        private void tabela()
        {
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            //  String scom = "select mesa, nome from ementa inner join Empreg on Empreg.Emp_Cod = ementa.Emp_Cod inner join Mesa on  Mesa.Emp_Cod = ementa.Emp_Cod";
            String scom = "select distinct mesa From Mesa ";
            SqlDataAdapter da = new SqlDataAdapter(scom, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cbMesa.DataSource = null;
            da.Fill(dtResultado);
            cbMesa.DataSource = dtResultado;
            // comboBox1.ValueMember = "Nome";
            cbMesa.DisplayMember = "mesa";
            cbMesa.SelectedItem = "";
            cbMesa.Refresh();

        }


        private void LimpaC()
        {
            TxtPNome.Text = "";
            TxtPrato.Text = "";
            TxtCompoe.Text = "";
            TxtHora.Text = " ";
            TxtPNome.Text = "";
            cbNomeEmpreg.SelectedIndex = -1;
            TxtQuant.Text = "";
            TxtPAdicional.Text = "";
            TxtData.Text = "";
            cbMesa.SelectedIndex = -1;
        }


        private void sinal()
        {


            notifyIcon1.Icon = new System.Drawing.Icon(@"D:\CSharp_Projetos\Restaurante\Setubal\notifres.ico");
            notifyIcon1.Text = "O Repolho do Mar";
            notifyIcon1.Visible = true;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Pedido Enviado";
            notifyIcon1.BalloonTipText = "Pedido enviado para a cozinha";

            notifyIcon1.ShowBalloonTip(1000);

        }


        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            String scom = "select mesa, nome from Mesa inner join Empreg on Empreg.Emp_Cod = Mesa.Emp_Cod";

            SqlDataAdapter da = new SqlDataAdapter(scom, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cbMesa.DataSource = null;
            da.Fill(dtResultado);
            cbMesa.DataSource = dtResultado;
            cbNomeEmpreg.DataSource = dtResultado;
            cbMesa.ValueMember = "mesa";
            cbNomeEmpreg.DisplayMember = "nome";

            con.Close();
        }









        private void button2_Click(object sender, EventArgs e)
        {

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Pedido ([PNome],[mesa],[Prato],[NomeEmpreg],[Quantidade],[PAdicional],[Status_Local],[Status_Ped],[Hora],[Data]) 
                            VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9, @value10)", con);

                cmd.Parameters.AddWithValue("@value1", TxtPNome.Text);
                cmd.Parameters.AddWithValue("@value2", Convert.ToInt32(cbMesa.Text));
                cmd.Parameters.AddWithValue("@value3", TxtPrato.Text);
                cmd.Parameters.AddWithValue("@value4", cbNomeEmpreg.Text);
                cmd.Parameters.AddWithValue("@value5", Convert.ToInt32(TxtQuant.Text));
                cmd.Parameters.AddWithValue("@value6", TxtPAdicional.Text);
                cmd.Parameters.AddWithValue("@value7", Convert.ToInt32(Status_L));
                cmd.Parameters.AddWithValue("@value8", Convert.ToInt32(Status_P));
                cmd.Parameters.AddWithValue("@value9", DateTime.Now.TimeOfDay);
                cmd.Parameters.AddWithValue("@value10", DateTime.Now.Date);

                cmd.ExecuteNonQuery();



                MessageBox.Show("Registo Inserido na Base de Dados");
                LimpaC();
                sinal();

            }
            catch (Exception sqlEx)
            {

                if (sqlEx.Message.StartsWith("Invalid object name"))
                {

                    MessageBox.Show("Erro de origem SQL");
                }


            }
        }





        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //notifyIcon1.Icon = new System.Drawing.Icon(@"D:\CSharp_Projetos\Restaurante\Setubal\notifres.ico");
            //notifyIcon1.Text = "O Repolho do Mar";
            //notifyIcon1.Visible = true;

            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon1.BalloonTipTitle = "Pedido Enviado";
            //notifyIcon1.BalloonTipText = "Pedido enviado para a cozinha";

            //notifyIcon1.ShowBalloonTip(1000);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            LimpaC();




        }




        private void button5_Click(object sender, EventArgs e)
        {
            TxtProcura.Text = "%";


        }


        // em testes (para remover)

        private void tabCBMesa()
        {
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            String scom = "select mesa, nome from Mesa inner join Empreg on Empreg.Emp_Cod = Mesa.Emp_Cod";
           
            SqlDataAdapter da = new SqlDataAdapter(scom, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cbMesa.DataSource = null;
            da.Fill(dtResultado);
            cbMesa.DataSource = dtResultado;
            cbNomeEmpreg.DataSource = dtResultado;
            cbMesa.ValueMember = "mesa";
            cbNomeEmpreg.DisplayMember = "nome";
           // comboBox1.Refresh();

           
        }

        private void cbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

















    }            
        
        
    
}
