using System;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DBhandler
/// </summary>
/// 
public class DBhandler
{
	
     SqlConnection con;
        
        DataTable dt;
        SqlDataAdapter da;
        String datasource = @"Data Source=.\SQLEXPRESS;Initial Catalog=AVVMS;Integrated Security=True";

        public DBhandler()
        {
            con = new SqlConnection(datasource);
        }

        public  DataTable GetTable(String str)
        {
            
                da = new SqlDataAdapter(str, con);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
          
        }

        public DataSet ret(string s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = s;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
	
		
        public int max_plus(string s)
        {
            int id;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = s;
            try
            {
                con.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            }
            catch
            {
                id = 1;
            }
            finally
            {
                con.Close();
            }
            return id;
        }

      
        public decimal sum(string s)
        {
            decimal id;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = s;
            try
            {
                con.Open();
                id = Convert.ToDecimal(cmd.ExecuteScalar());

            }
            catch
            {
                id = 0;
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        
        public string GetValue(String query)
        {
           
            SqlCommand cmd = new SqlCommand();
            con.Open();

            string str;
            try
            {
                cmd = new SqlCommand(query, con);
                str = cmd.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                str = "0";
            }
            con.Close();

            return str;
        }
		
        public void Ins_Up_Del(String query)
        {   
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void close()
        {
            con.Close();
        }


    }



   

