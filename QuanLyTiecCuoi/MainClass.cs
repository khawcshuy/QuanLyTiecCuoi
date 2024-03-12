using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiecCuoi
{
    internal class MainClass
    {
        public static readonly string con_string = "Data Source=Doraemon\\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True;Encrypt=False";
        public static SqlConnection con = new SqlConnection(con_string);


        public static bool IsValidUser(string User, string Password){
            bool isValid = false;
            string qry = @"SELECT * FROM USERS WHERE USERNAME = '"+ User + "' and UPASS = '"+ Password + "'";
            SqlCommand cmd = new SqlCommand(qry,con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }
    }

}
