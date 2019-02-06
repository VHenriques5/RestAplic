using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SGR
{
    public partial class Fmt_Principal : Form
    {
        DB_Acess connect = new DB_Acess();

        public string Perfil = string.Empty;

        SqlConnection con;

        public Fmt_Principal()
        {

            InitializeComponent();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fmt_Mesas mes = new Fmt_Mesas();
            mes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fmt_NewEmpreg emp = new Fmt_NewEmpreg();
            emp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja encerrar a aplicação?", "Saida", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (Convert.ToString(dr) == "Yes")
            {
                this.Close();
            }
            
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fmt_Cozinha coz = new Fmt_Cozinha();
            coz.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fmt_Monitor mon = new Fmt_Monitor();
            mon.ShowDialog();
        }

        private void Fmt_Principal_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Perfil))
            {

                switch (Perfil)
                {

                    case "Administrador":

                         this.button1.Visible = true;

                        this.button2.Visible = true;
                        
                        this.button3.Visible = true;

                        this.button4.Visible = true;
                        
                        this.button5.Visible = true;

                        this.button6.Visible = true;
                        
                        this.button7.Visible = true;

                        break;

                    case "Gerente":

                        this.button1.Visible = true;

                        this.button2.Visible = true;
                        
                        this.button3.Visible = true;

                        this.button4.Visible = true;
                        
                        this.button5.Visible = true;

                        this.button6.Visible = true;
                        
                        this.button7.Visible = true;

                        break;

                    case "Empregado":

                        this.button1.Visible = false;

                        this.button2.Visible = false;
                        
                        this.button3.Visible = true;

                        this.button4.Visible = true;
                        
                        this.button5.Visible = false;

                        this.button6.Visible = false;
                        
                        this.button7.Visible = true;

                       

                        break;

                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fmt_Ementas_Pricipal fep = new Fmt_Ementas_Pricipal();
            fep.ShowDialog();
        }

    }
}  
        


       
    

      

      
    

