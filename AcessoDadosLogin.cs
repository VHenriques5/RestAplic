using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SGR
{
    class AcessoDadosLogin
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        private string strInstrucaoSelect = "SELECT L.IDLogin, L.Login, L.Password, U.Nome, P.Perfil FROM Login AS L INNER JOIN Users AS U ON U.IDLogin = L.IDLogin INNER JOIN Perfil AS P ON P.IDPerfil = U.IDPerfil WHERE L.Login = @Login AND L.Password = @Password AND U.EhAtivo = 1";

        public class Modelo
        {

            public int IdLogin { get; set; }

            public string Login { get; set; }

            public string Password { get; set; }

            public string Nome { get; set; }

            public string Perfil { get; set; }

        }


        public List<Modelo> ValidarAcesso(Modelo dadosModelo)
        {

            List<Modelo> lstRetorno = new List<Modelo>();

            using (SqlConnection objConexao = new SqlConnection(strConnectionString))
            {

                using (SqlCommand objCommand = new SqlCommand(strInstrucaoSelect, objConexao))
                {

                    objCommand.Parameters.AddWithValue("@Login", dadosModelo.Login);

                    objCommand.Parameters.AddWithValue("@Password", dadosModelo.Password);

                    try
                    {

                        objConexao.Open();

                        SqlDataReader objDataReader = objCommand.ExecuteReader();

                        if (objDataReader.HasRows)
                        {

                            while (objDataReader.Read())
                            {

                                Modelo objModelo = new Modelo();

                                objModelo.IdLogin = Convert.ToInt32(objDataReader["IdLogin"].ToString());

                                objModelo.Login = objDataReader["Login"].ToString();

                                objModelo.Password = objDataReader["Password"].ToString();

                                objModelo.Nome = objDataReader["Nome"].ToString();

                                objModelo.Perfil = objDataReader["Perfil"].ToString();

                                lstRetorno.Add(objModelo);

                            }

                        }

                        objDataReader.Close();

                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);

                    }

                    finally
                    {

                        objConexao.Close();

                    }

                }

            }

            return lstRetorno;

        }

        public class Categoria
        {
            public int Emp_Cod { get; set; }
            public string mesa { get; set; }
            public string Nome { get; set; }
       
        
        }




       
    }
}
