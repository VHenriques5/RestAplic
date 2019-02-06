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
    public partial class Fmt_Login : Form
    {
       
    
        
        
        public Fmt_Login()
        {
            InitializeComponent();
        }

       
        public void AcessarSistema(string Login, string Senha)
        {

            AcessoDadosLogin objAcessoDados = new AcessoDadosLogin();

            AcessoDadosLogin.Modelo objModelo = new AcessoDadosLogin.Modelo();

            List<AcessoDadosLogin.Modelo> lstRetorno = new List<AcessoDadosLogin.Modelo>();

            objModelo.Login = Login;

            objModelo.Password = Senha;

            lstRetorno = objAcessoDados.ValidarAcesso(objModelo);

            //if (lstRetorno != null && lstRetorno.Count > 0)
            //{

            //    //Significa que o utilizador existe e o redireciono pro form principal

            //    MessageBox.Show("Bem vindo ao Repolho do Mar!");

            //    Fmt_Principal objPrincipal = new Fmt_Principal();

            //   objPrincipal.ShowDialog();

            //} 
            if (!String.IsNullOrEmpty(lstRetorno[0].Perfil))
            {
                Fmt_Principal objPrincipal = new Fmt_Principal();

                objPrincipal.Perfil = lstRetorno[0].Perfil;

                objPrincipal.ShowDialog();

            }
      



        }


        public void xp()
        {

            Fmt_Principal objPrincipal = new Fmt_Principal();



            
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(this.txtLogin.Text) && !String.IsNullOrEmpty(this.txtPassword.Text))
 
                {
 
                    AcessarSistema(this.txtLogin.Text, this.txtPassword.Text);
 
                }
 
            }

     


        }
    }

