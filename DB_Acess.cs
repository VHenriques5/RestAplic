using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SGR
{
    
    class DB_Acess
    {
       
        SqlConnection Conn;


         public DB_Acess()
         {

             Conn = DB_Connection.GetConnection();
            

         }


        // Create
        
        
     //Inserir Mesa
        
        public void mesa(int mesa, int nlugares, bool esplanada)
         {

             if (Conn.State.ToString() == "Closed")
             {
                 Conn.Open();
             }

             SqlCommand newCmd = Conn.CreateCommand();
             newCmd.Connection = Conn;
             newCmd.CommandType = CommandType.Text;
             newCmd.CommandText = "Insert into Mesa (mesa, nlugares, esplanada) values ('" + mesa + "', '" + nlugares + "', '" + esplanada + "')";
             newCmd.ExecuteNonQuery();
             
         }


        //Update Mesa

        public void upd_mesa(int mesa, int nlugares, bool esplanada, int empregado)
        {

            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }

            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.Connection = Conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update Mesa set mesa ='" + mesa + "', nlugares = '" + nlugares + "', esplanada ='" + esplanada + "', Empreg.Nome'" + empregado + "')";
            newCmd.ExecuteNonQuery();
            Conn.Close();
        }
      
        
        // Inserir Empregados 
        public void Emp(string Nome, string Categoria, string Profissao, string Genero, int idade)
        {

            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }

            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.Connection = Conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Insert into Empreg values ('" + Nome + "','"+Categoria+"','"+Profissao+"','"+Genero+"','"+idade+"')";
            newCmd.ExecuteNonQuery();
            Conn.Close();
        }


        // Update Empregados 
        public void UpdateEmpreg(int Emp_Cod, string Nome, string Categoria, string Profissao, string Genero, int idade)
        {

            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }

            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.Connection = Conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "UPDATE Empreg SET Nome ='" + Nome + "', Categoria ='" + Categoria + "', Profissao = '" + Profissao + "',Genero = '" + Genero + "', Idade = '" + idade + "'WHERE Emp_Cod = '" + Emp_Cod + "' ";
            newCmd.ExecuteNonQuery();

        }

        // update MESA

        public void UpdateMesa(int mesa, int lugares, bool espana, int EmpCode, int idmesa)
        {

            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }

            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.Connection = Conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "UPDATE Mesa SET mesa ='" + mesa + "', nlugares ='" + lugares + "', esplanada = '" + espana + "',Empreg.Emp_Cod = '" + EmpCode + "'WHERE ID_Mesa = '" + idmesa + "' ";
            newCmd.ExecuteNonQuery();

        }

        // Inserir Pedidos a partir do menu 
        public void Pedidos(string pnome, int mesa, string prato, string nempreg, int quantidade, string padd, int status_local, int status_Ped)  
          {

            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }

            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.Connection = Conn;
            newCmd.CommandType = CommandType.Text; 
            newCmd.CommandText = "Insert into Pedido (PNome,mesa,Prato,NomeEmpreg,Quantidade,PAdicional,Status_Local,Status_Ped ) Values ('" + pnome + "','" + mesa + "','" + prato + "','" + nempreg + "','" + quantidade + "','" + padd + "', '" + status_local + "', '" + status_Ped + "')";
            newCmd.ExecuteNonQuery();
           
        }



        // Pertendo que este metodo devolva a ultima mesa inserida na Base de Dados

        public string mesa_consulta(string mesa ) 
        {
            
            string temp = "";
            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }
            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "SELECT TOP 1 mesa " + mesa + " FROM Mesa order by mesa desc";
            SqlDataReader dr = newCmd.ExecuteReader();

            while (dr.Read())
            {
                temp = dr[mesa].ToString();
            }
            dr.Close();
            Conn.Close();
            return temp;
        }

      

        public DataSet PreencheGrid(string Query, string Table)
        {

            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }
            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.Connection = Conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = Query;

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, Table);
            Conn.Close();
            return ds;

        }

        public DataSet PGridConsulta(string Query, string Table)
        {
            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }
            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.Connection = Conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = Query;

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, Table);
            Conn.Close();
            return ds;

        }

  // Update mesas 
  /// 
  /// </summary>
  /// <param name="Query"></param>
  /// <param name="Table"></param>
  /// <returns></returns>
  /// 
        public DataSet Update_mesas(string Query, string Table)
        {
            if (Conn.State.ToString() == "Closed")
            {
                Conn.Open();
            }
            SqlCommand newCmd = Conn.CreateCommand();
            newCmd.Connection = Conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = Query;

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
           // da.Fill(ds, Table);
            Conn.Close();
            return ds;

        }


    }



}
