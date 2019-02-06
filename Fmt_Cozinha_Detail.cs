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
using System.Threading.Tasks;



namespace SGR
{
    public partial class Fmt_Cozinha_Detail : Form
    {
      

        System.Windows.Forms.Timer timer;
       
        TimeSpan countdownClock = TimeSpan.Zero;

        DB_Acess access = new DB_Acess();

        public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        private int imageNumber = 1;

        int Ten_Sec = 10000;
        int One_Min = 60000;
        int Ten_Min = 600000;





        public string PNome, Prato,NomeEmpreg,PAdicional; // ver o prox comentario
        public int IDPedido, Mesa, Quant, Status;
        public DateTime Hora, Data;
        
        
       
        
        public Fmt_Cozinha_Detail()
        {
            InitializeComponent();

            tempo();

        }

        private void loadNextImage()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }

            imgPicture.ImageLocation = string.Format(@"D:\CSharp_Projetos\Restaurante\Smile\Logo{0}.png", imageNumber);
            imageNumber++;
        }

        private void tmrNextImage_Tick(object sender, EventArgs e)
        {
            tmrNextImage.Interval = 1000 * 60 * 1;
            loadNextImage();
        }




        void Fmt_Cozinha_Detail_Load(object sender, EventArgs e)
        {


               AddTimeToClock(TimeSpan.FromMinutes(20));
               TextBtoVar();
             
            
        }


        //teste() de forma a Fmt_Cozinha_Details ficar com os campos visiveis e acessiveis

        private void tempo()
        {

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (int)TimeSpan.FromSeconds(1).TotalMilliseconds;
            timer.Tick += OnTimeEvent;
            DisplayTime();

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 80;
            timer1.Tick += new EventHandler(timer1_Tick);
        
        }


     
        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }




        public void TextBtoVar()
        {
            TxtID_Pedido.Text = Convert.ToInt32(IDPedido).ToString();
            TxtPNome.Text = PNome;
            TxtMesa.Text = Convert.ToInt32(Mesa).ToString();
            TxtPrato.Text = Prato;
            TxtEmpregado.Text = NomeEmpreg;
            TxtQuantidade.Text = Convert.ToInt32(Quant).ToString();
            TxtPAdicional.Text = PAdicional;
            //TxtHora.Text = Convert.ToDateTime(Hora).ToShortTimeString();
            lblNow.Text = DateTime.Now.ToShortTimeString();


       
        
        
        
        }
        
        private void DisplayTime()
        {
            lblTime.Text = countdownClock.ToString(@"hh\:mm\:ss");
        }

       
        private void limpaTxt()
        {
           TxtID_Pedido.Text = null;
            TxtPNome.Text = "";
            TxtPrato.Text = "";
            TxtEmpregado.Text = "";
            TxtQuantidade.Text = null;
            TxtPAdicional.Text = "";



            lblNow.Text = null;
        
        }
        
        
        
        private void OnTimeEvent(object sender, EventArgs e)
        {
            // subtrai ao inicio do pedido e começa o countdownClock
            countdownClock = countdownClock.Subtract(TimeSpan.FromMilliseconds(timer.Interval));

            if (countdownClock.TotalMilliseconds <= 0)
            {
               
                countdownClock = TimeSpan.Zero;
                timer.Stop();
            }

            // Display tempo atual
            DisplayTime();
        }



        private void AddTimeToClock(TimeSpan timeToAdd)
        {
            // Add tempo ao relogio
            countdownClock += timeToAdd;

            // Display novo tempo
            DisplayTime();

            // re-iniciar se estiver parado
            if (!timer.Enabled) timer.Start();
        }


        private void Button_Ten_Sec_Click(object sender, EventArgs e)
        {
            // Add 10 segundos
            AddTimeToClock(TimeSpan.FromSeconds(10));
        }

        private void Button_One_Min_Click(object sender, EventArgs e)
        {
            // Add 1 minuto
            AddTimeToClock(TimeSpan.FromMinutes(1));
        }

        private void Button_Ten_Min_Click(object sender, EventArgs e)
        {
            // Add 10 minutos
            AddTimeToClock(TimeSpan.FromMinutes(10));
        }

      

     
 

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);



            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            try
            {


                SqlCommand cmd = new SqlCommand(@"update Pedido set Status_Ped=2 where Id_Pedido = @value1", con);

                cmd.Parameters.AddWithValue("@value1", Convert.ToInt32(TxtID_Pedido.Text));


                cmd.ExecuteNonQuery();



                MessageBox.Show("Pedido 1 enviado para a mesa");

                limpaTxt();
                con.Close();
                this.Hide();
            }
            catch (Exception sqlEx)
            {

                if (sqlEx.Message.StartsWith("Invalid object name"))
                {

                    MessageBox.Show("Erro de origem SQL");
                }


            }
        }

     

      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
