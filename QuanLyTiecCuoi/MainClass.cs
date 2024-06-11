using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyTiecCuoi
{
    internal class MainClass
    {
        public static readonly string con_string = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QUANLYTIECCUOI1;Integrated Security=True";
        //public static readonly string con_string = "Data Source=Doraemon\\SQLEXPRESS;Initial Catalog=QUANLYTIECCUOI;Integrated Security=True";
        //public static readonly string con_string = @"Data Source = ADMINISTRATOR; Initial Catalog = QUANLYTIECCUOI; Integrated Security = True";
        public static SqlConnection con = new SqlConnection(con_string);

<<<<<<< HEAD

        public static bool IsValidUser(string User, string Password)
        {
=======
            
        public static bool IsValidUser(string User, string Password){
>>>>>>> 78dd66e5ebb4a9454f6ed200fabf83c4fb627b53
            using (SqlConnection connection = new SqlConnection(con_string))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE USERNAME='" + User + "' AND UPASS='" + Password + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", User);
                cmd.Parameters.AddWithValue("@Password", Password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }
    }

}
