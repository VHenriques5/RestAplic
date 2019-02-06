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
    public partial class Fmt_Monitorizacao : Form
    {
        public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        
        public Fmt_Monitorizacao()
        {
            InitializeComponent();
        }

        private void Fmt_Monitorizacao_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("Pedido", 50);
            listView1.Columns.Add("Prato", 50);
            listView1.Columns.Add("Mesa", 50);
            listView1.Columns.Add("Empregado", 50);

            listView2.GridLines = true;
            listView2.View = View.Details;         
            listView2.Columns.Add("Pedido", 50);
            listView2.Columns.Add("Prato", 50);
            listView2.Columns.Add("Mesa", 50);
            listView2.Columns.Add("Empregado", 50);


            listView3.GridLines = true;
            listView3.View = View.Details;
            listView3.Columns.Add("Pedido", 50);
            listView3.Columns.Add("Prato", 50);
            listView3.Columns.Add("Mesa", 50);
            listView3.Columns.Add("Empregado", 50);
           

            listView4.GridLines = true;
            listView4.View = View.Details;
            listView4.Columns.Add("Pedido", 50);
            listView4.Columns.Add("Prato", 50);
            listView4.Columns.Add("Mesa", 50);
            listView4.Columns.Add("Empregado", 50);
   

            listView5.GridLines = true;
            listView5.View = View.Details;
            listView5.Columns.Add("Pedido", 50);
            listView5.Columns.Add("Prato", 50);
            listView5.Columns.Add("Mesa", 50);
            listView5.Columns.Add("Empregado", 50);
  

            listView6.GridLines = true;
            listView6.View = View.Details;
            listView6.Columns.Add("Pedido", 50);
            listView6.Columns.Add("Prato", 50);
            listView6.Columns.Add("Mesa", 50);
            listView6.Columns.Add("Empregado", 50);

            
            listView7.GridLines = true;
            listView7.View = View.Details;
            listView7.Columns.Add("Pedido", 50);
            listView7.Columns.Add("Prato", 50);
            listView7.Columns.Add("Mesa", 50);
            listView7.Columns.Add("Empregado", 50);
   
            listView8.GridLines = true;
            listView8.View = View.Details;
            listView8.Columns.Add("Pedido", 50);
            listView8.Columns.Add("Prato", 50);
            listView8.Columns.Add("Mesa", 50);
            listView8.Columns.Add("Empregado", 50);
  
           
            listView9.GridLines = true;
            listView9.View = View.Details;
            listView9.Columns.Add("Pedido", 50);
            listView9.Columns.Add("Prato", 50);
            listView9.Columns.Add("Mesa", 50);
            listView9.Columns.Add("Empregado", 50);
        

            listView10.GridLines = true;
            listView10.View = View.Details;
            listView10.Columns.Add("Pedido", 50);
            listView10.Columns.Add("Prato", 50);
            listView10.Columns.Add("Mesa", 50);
            listView10.Columns.Add("Empregado", 50);
       

            listView11.GridLines = true;
            listView11.View = View.Details;
            listView11.Columns.Add("Pedido", 50);
            listView11.Columns.Add("Prato", 50);
            listView11.Columns.Add("Mesa", 50);
            listView11.Columns.Add("Empregado", 50);


            listView12.GridLines = true;
            listView12.View = View.Details;
            listView12.Columns.Add("Pedido", 50);
            listView12.Columns.Add("Prato", 50);
            listView12.Columns.Add("Mesa", 50);
            listView12.Columns.Add("Empregado", 50);
    

            listView13.GridLines = true;
            listView13.View = View.Details;
            listView13.Columns.Add("Pedido", 50);
            listView13.Columns.Add("Prato", 50);
            listView13.Columns.Add("Mesa", 50);
            listView13.Columns.Add("Empregado", 50);
     

            listView14.GridLines = true;
            listView14.View = View.Details;
            listView14.Columns.Add("Pedido", 50);
            listView14.Columns.Add("Prato", 50);
            listView14.Columns.Add("Mesa", 50);
            listView14.Columns.Add("Empregado", 50);
      

            listView15.GridLines = true;
            listView15.View = View.Details;
            listView15.Columns.Add("Pedido", 50);
            listView15.Columns.Add("Prato", 50);
            listView15.Columns.Add("Mesa", 50);
            listView15.Columns.Add("Empregado", 50);
         

            listView16.GridLines = true;
            listView16.View = View.Details;
            listView16.Columns.Add("Pedido", 50);
            listView16.Columns.Add("Prato", 50);
            listView16.Columns.Add("Mesa", 50);
            listView16.Columns.Add("Empregado", 50);
          

            listView17.GridLines = true;
            listView17.View = View.Details;
            listView17.Columns.Add("Pedido", 50);
            listView17.Columns.Add("Prato", 50);
            listView17.Columns.Add("Mesa", 50);
            listView17.Columns.Add("Empregado", 50);
         

            listView18.GridLines = true;
            listView18.View = View.Details;
            listView18.Columns.Add("Pedido", 50);
            listView18.Columns.Add("Prato", 50);
            listView18.Columns.Add("Mesa", 50);
            listView18.Columns.Add("Empregado", 50);
         

            listView19.GridLines = true;
            listView19.View = View.Details;
            listView19.Columns.Add("Pedido", 50);
            listView19.Columns.Add("Prato", 50);
            listView19.Columns.Add("Mesa", 50);
            listView19.Columns.Add("Empregado", 50);
  

            listView20.GridLines = true;
            listView20.View = View.Details;
            listView20.Columns.Add("Pedido", 50);
            listView20.Columns.Add("Prato", 50);
            listView20.Columns.Add("Mesa", 50);
            listView20.Columns.Add("Empregado", 50);
     

            listView21.GridLines = true;
            listView21.View = View.Details;
            listView21.Columns.Add("Pedido", 50);
            listView21.Columns.Add("Prato", 50);
            listView21.Columns.Add("Mesa", 50);
            listView21.Columns.Add("Empregado", 50);
         

            listView22.GridLines = true;
            listView22.View = View.Details;
            listView22.Columns.Add("Pedido", 50);
            listView22.Columns.Add("Prato", 50);
            listView22.Columns.Add("Mesa", 50);
            listView22.Columns.Add("Empregado", 50);
      

            listView23.GridLines = true;
            listView23.View = View.Details;
            listView23.Columns.Add("Pedido", 50);
            listView23.Columns.Add("Prato", 50);
            listView23.Columns.Add("Mesa", 50);
            listView23.Columns.Add("Empregado", 50);
       

            listView24.GridLines = true;
            listView24.View = View.Details;
            listView24.Columns.Add("Pedido", 50);
            listView24.Columns.Add("Prato", 50);
            listView24.Columns.Add("Mesa", 50);
            listView24.Columns.Add("Empregado", 50);
    

            listView25.GridLines = true;
            listView25.View = View.Details;
            listView25.Columns.Add("Pedido", 50);
            listView25.Columns.Add("Prato", 50);
            listView25.Columns.Add("Mesa", 50);
            listView25.Columns.Add("Empregado", 50);
            
            lista();

        }

        private void lista()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 ";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            //listView2.Items.Clear();

            ColorDialog cldCor = new ColorDialog();



            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());


                if (SDR.GetInt32(3).ToString()=="1" && SDR.GetInt32(9).ToString()=="1")
             
                       listView1.Items.Add(lv).BackColor=Color.LightGreen;
                else
                    if (SDR.GetInt32(3).ToString() == "1" && SDR.GetInt32(9).ToString() == "2")
                        listView1.Items.Add(lv).BackColor = Color.LightPink;

                         if (SDR.GetInt32(3).ToString() == "2" && SDR.GetInt32(9).ToString() == "1")

                                listView2.Items.Add(lv).BackColor = Color.LightGreen;
                             else
                               if (SDR.GetInt32(3).ToString() == "2" && SDR.GetInt32(9).ToString() == "2")
                                     listView2.Items.Add(lv).BackColor = Color.LightPink; 

                
                                if (SDR.GetInt32(3).ToString() == "3" && SDR.GetInt32(9).ToString() == "1")

                                        listView3.Items.Add(lv).BackColor = Color.LightGreen;
                                    else
                                        if (SDR.GetInt32(3).ToString() == "3" && SDR.GetInt32(9).ToString() == "2")
                                                listView3.Items.Add(lv).BackColor = Color.LightPink;


                                            if (SDR.GetInt32(3).ToString() == "4" && SDR.GetInt32(9).ToString() == "1")

                                                listView4.Items.Add(lv).BackColor = Color.LightGreen;
                                            else
                                                if (SDR.GetInt32(3).ToString() == "4" && SDR.GetInt32(9).ToString() == "2")
                                                    listView4.Items.Add(lv).BackColor = Color.LightPink;
                                              
                
                                                  if (SDR.GetInt32(3).ToString() == "5" && SDR.GetInt32(9).ToString() == "1")

                                                        listView5.Items.Add(lv).BackColor = Color.LightGreen;
                                                    else
                                                        if (SDR.GetInt32(3).ToString() == "5" && SDR.GetInt32(9).ToString() == "2")
                                                            listView5.Items.Add(lv).BackColor = Color.LightPink;
                                                          
                
                                                            if (SDR.GetInt32(3).ToString() == "6" && SDR.GetInt32(9).ToString() == "1")

                                                                listView6.Items.Add(lv).BackColor = Color.LightGreen;
                                                            else
                                                                if (SDR.GetInt32(3).ToString() == "6" && SDR.GetInt32(9).ToString() == "2")
                                                                    listView6.Items.Add(lv).BackColor = Color.LightPink;

                                                                    if (SDR.GetInt32(3).ToString() == "7" && SDR.GetInt32(9).ToString() == "1")

                                                                        listView7.Items.Add(lv).BackColor = Color.LightGreen;
                                                                    else
                                                                        if (SDR.GetInt32(3).ToString() == "7" && SDR.GetInt32(9).ToString() == "2")
                                                                              listView7.Items.Add(lv).BackColor = Color.LightPink;
                                                                            if (SDR.GetInt32(3).ToString() == "8" && SDR.GetInt32(9).ToString() == "1")

                                                                                listView8.Items.Add(lv).BackColor = Color.LightGreen;
                                                                            else
                                                                                if (SDR.GetInt32(3).ToString() == "8" && SDR.GetInt32(9).ToString() == "2")
                                                                                    listView8.Items.Add(lv).BackColor = Color.LightPink;
                                                                                  
                                                                                   if (SDR.GetInt32(3).ToString() == "9" && SDR.GetInt32(9).ToString() == "1")

                                                                                        listView9.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                    else
                                                                                        if (SDR.GetInt32(3).ToString() == "9" && SDR.GetInt32(9).ToString() == "2")
                                                                                            listView9.Items.Add(lv).BackColor = Color.LightPink;
               
                                                                                            if (SDR.GetInt32(3).ToString() == "10" && SDR.GetInt32(9).ToString() == "1")

                                                                                                listView10.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                            else
                                                                                                if (SDR.GetInt32(3).ToString() == "10" && SDR.GetInt32(9).ToString() == "2")
                                                                                                    listView10.Items.Add(lv).BackColor = Color.LightPink;
               
               
                                                                                                        if (SDR.GetInt32(3).ToString() == "11" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView11.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "11" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView11.Items.Add(lv).BackColor = Color.LightPink;




                                                                                                        if (SDR.GetInt32(3).ToString() == "12" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView12.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "12" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView12.Items.Add(lv).BackColor = Color.LightPink;
                                                                                                        
                
                
                                                                                                        if (SDR.GetInt32(3).ToString() == "13" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView13.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "13" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView13.Items.Add(lv).BackColor = Color.LightPink;

                                                                                                        if (SDR.GetInt32(3).ToString() == "14" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView14.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "14" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView14.Items.Add(lv).BackColor = Color.LightPink;

                                                                                                        if (SDR.GetInt32(3).ToString() == "15" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView15.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "15" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView15.Items.Add(lv).BackColor = Color.LightPink;

                                                                                                        if (SDR.GetInt32(3).ToString() == "16" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView16.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "16" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView16.Items.Add(lv).BackColor = Color.LightPink;

                                                                                                        if (SDR.GetInt32(3).ToString() == "17" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView17.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "17" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView17.Items.Add(lv).BackColor = Color.LightPink;


                                                                                                        if (SDR.GetInt32(3).ToString() == "18" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView18.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "18" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView18.Items.Add(lv).BackColor = Color.LightPink;


                                                                                                        if (SDR.GetInt32(3).ToString() == "19" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView19.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "19" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView19.Items.Add(lv).BackColor = Color.LightPink;


                                                                                                        if (SDR.GetInt32(3).ToString() == "20" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView20.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "20" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView20.Items.Add(lv).BackColor = Color.LightPink;


                                                                                                        if (SDR.GetInt32(3).ToString() == "21" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView21.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "21" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView21.Items.Add(lv).BackColor = Color.LightPink;


                                                                                                        if (SDR.GetInt32(3).ToString() == "22" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView22.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "22" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView22.Items.Add(lv).BackColor = Color.LightPink;

                                                                                                       
                                                                                                            if (SDR.GetInt32(3).ToString() == "23" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView23.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "23" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView23.Items.Add(lv).BackColor = Color.LightPink; if (SDR.GetInt32(3).ToString() == "11" && SDR.GetInt32(9).ToString() == "1")



                                                                                                            if (SDR.GetInt32(3).ToString() == "24" && SDR.GetInt32(9).ToString() == "1")       
                                                                                                                    listView24.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "24" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView24.Items.Add(lv).BackColor = Color.LightPink;

                                                                                                        if (SDR.GetInt32(3).ToString() == "25" && SDR.GetInt32(9).ToString() == "1")

                                                                                                            listView25.Items.Add(lv).BackColor = Color.LightGreen;
                                                                                                        else
                                                                                                            if (SDR.GetInt32(3).ToString() == "25" && SDR.GetInt32(9).ToString() == "2")
                                                                                                                listView25.Items.Add(lv).BackColor = Color.LightPink;


                                                                                                        
            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();
        
        
        }

        private void lista3()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=3";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView3.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
              
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView3.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista4()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=4";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView4.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());

                listView4.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista5()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=5";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView5.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());

                listView5.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista6()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=6";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView6.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
               
                listView6.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista7()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=7";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView7.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());

                listView7.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista8()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=8";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView8.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());

                listView8.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista9()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=9";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView9.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView9.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista10()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=10 " ;

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView10.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView10.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista11()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=11";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView11.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView11.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista12()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=12";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView12.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView12.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista13()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped>=1 and mesa=13";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView13.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView13.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista14()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=14";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView14.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView14.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista15()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=15";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView15.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView15.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista16()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=16";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView16.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView16.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista17()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=17";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView17.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView17.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista18()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=18";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView18.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView18.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista19()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=19";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView19.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView19.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista20()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=20";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView20.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView20.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista21()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=21";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView21.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView21.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista22()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=22";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView22.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView22.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista23()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=23";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView23.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView23.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista24()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=24";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView24.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView24.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

        private void lista25()
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1 and mesa=25";

            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView25.Items.Clear();




            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView25.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();


        }

       



        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=2";
          
            
            SqlCommand cmd = new SqlCommand(sql,cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView1.Items.Clear();
           
            


            while (SDR.Read())
            {
                ListViewItem  lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView1.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConStr);

            cnn.Open();

            string sql = "SELECT * FROM dbo.Pedido where Status_Ped=1";


            SqlCommand cmd = new SqlCommand(sql, cnn);


            SqlDataReader SDR;
            SDR = cmd.ExecuteReader();
            listView1.Items.Clear();


            while (SDR.Read())
            {
                ListViewItem lv = new ListViewItem(SDR.GetInt32(0).ToString());
                lv.SubItems.Add(SDR.GetString(2).ToString());
                lv.SubItems.Add(SDR.GetInt32(3).ToString());
                lv.SubItems.Add(SDR.GetString(5).ToString());
                lv.SubItems.Add(SDR.GetInt32(9).ToString());
                listView1.Items.Add(lv);

            }

            SDR.Close();
            cmd.Dispose();
            cnn.Close();
        }



    }
}
