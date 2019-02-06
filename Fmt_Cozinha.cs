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
using System.Threading.Tasks;


namespace SGR
{
    
    public partial class Fmt_Cozinha : Form
    {
        
        
        DB_Acess access = new DB_Acess();
        
        public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

  

    
        
        public Fmt_Cozinha()
        {
        
            InitializeComponent();

            
            
            SqlConnection cnn = new SqlConnection(ConStr);


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM dbo.Pedido where Status_Ped=1";

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            DGVCozinha.DataSource = dtRecord;
           
        }

 
  

        private void Fmt_Cozinha_Load(object sender, EventArgs e)
        {
           
        }

       

        public void dtime()
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@time";
            parameter.SqlDbType = SqlDbType.Time;
            parameter.Value = DateTime.Parse("23:59:59").TimeOfDay;  
        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DGVCozinha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fmt_Cozinha_Detail detail = new Fmt_Cozinha_Detail();

            detail.IDPedido = Convert.ToInt32(DGVCozinha.CurrentRow.Cells[0].Value.ToString());
           
            detail.PNome = DGVCozinha.CurrentRow.Cells[2].Value.ToString();
            detail.Mesa = Convert.ToInt32(DGVCozinha.CurrentRow.Cells[3].Value.ToString());
            detail.Prato = DGVCozinha.CurrentRow.Cells[4].Value.ToString();
            detail.NomeEmpreg = DGVCozinha.CurrentRow.Cells[5].Value.ToString();
            detail.Quant = Convert.ToInt32(DGVCozinha.CurrentRow.Cells[6].Value.ToString());
            detail.PAdicional = DGVCozinha.CurrentRow.Cells[7].Value.ToString();
            //detail.Hora = Convert.ToDateTime(DGVCozinha.CurrentRow.Cells[8].Value.ToString());
            detail.Show();
        }

       


       }
  }

