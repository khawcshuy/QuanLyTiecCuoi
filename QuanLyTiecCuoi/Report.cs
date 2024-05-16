using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class Report : Form
    {
        public string conString;
        public Report(string conSring)
        {
            InitializeComponent();
            this.conString = conSring;
        }

        private void listView1_load(object sender, EventArgs e)
        {
          
        }

        private void Report_Load(object sender, EventArgs e)
        {
            ProdPeferiod();
        }


        private void ProdPeferiod(string Thang = null, string Nam = null)
        {
            if(Thang == null)
            {
                Thang = DateTime.Now.Month.ToString();

            }
            if(Nam == null)
            {
                Nam = DateTime.Now.Year.ToString();
            }    

            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand("ProdPeferiod", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NAM", Nam);
                    cmd.Parameters.AddWithValue("@THANG", Thang);




                    var totalParam = new SqlParameter("@TOTAL", SqlDbType.Money) { Direction = ParameterDirection.Output };
                    var totalVenueParam = new SqlParameter("@TOTALVENUE", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var totalPartyParam = new SqlParameter("@TOTALPARTY", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var totalServiceUsedParam = new SqlParameter("@TOTALSERVICEUSED", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var totalFoodUsedParam = new SqlParameter("@TOTALFOODUSED", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var totalTableUsedParam = new SqlParameter("@TOTALTABLEUSED", SqlDbType.Int) { Direction = ParameterDirection.Output};


                    cmd.Parameters.Add(totalParam);
                    cmd.Parameters.Add(totalVenueParam);
                    cmd.Parameters.Add(totalPartyParam);
                    cmd.Parameters.Add(totalServiceUsedParam);
                    cmd.Parameters.Add(totalFoodUsedParam);
                    cmd.Parameters.Add(totalTableUsedParam);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    // Retrieve the values from the output parameters and handle nulls
                    var total = totalParam.Value != DBNull.Value ? (decimal)totalParam.Value : 0;
                    var totalVenue = totalVenueParam.Value != DBNull.Value ? (int)totalVenueParam.Value : 0;
                    var totalParty = totalPartyParam.Value != DBNull.Value ? (int)totalPartyParam.Value : 0;
                    var totalServiceUsed = totalServiceUsedParam.Value != DBNull.Value ? (int)totalServiceUsedParam.Value : 0;
                    var totalFoodUsed = totalFoodUsedParam.Value != DBNull.Value ? (int)totalFoodUsedParam.Value : 0;
                    var  totalTableUsed = totalTableUsedParam.Value != DBNull.Value ? (int)totalTableUsedParam.Value : 0;


                    RevenueValue.Text = total.ToString("N2");
                    ReportOfMonth.Text = ReportOfMonth.Text + " " + Thang;
                    TotalVenueValue.Text = totalVenue.ToString();
                    totalFoodValue.Text = totalParty.ToString();
                    totalSerivceValue.Text = totalServiceUsed.ToString();
                    totalPartyValue.Text = totalFoodUsed.ToString();
                    totalTableValue.Text = totalTableUsed.ToString();



                }
            }
        }



        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}