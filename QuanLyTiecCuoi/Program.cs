using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string conString = @"Data Source = ADMINISTRATOR; Initial Catalog = QUANLYTIECCUOI; Integrated Security = True";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QuanLyTiecCuoi.Service.Service(conString, null));
            //application.run(new receipt(constring));
            //Food foodform = new Food(conString, null);

            //Application.Run(foodform);
            ////Application.Run(new Report(conString));

            //Venue Venue = new Venue(null, conString);

            //Application.Run(Venue);
            ////// Hiển thị form Food


            //// pass the bookingform instance to the food form constructor
            //Food foodform = new Food(conString, null);
            //Application.Run(foodform);

            // GỌI BOOKING 
            Booking bookingform = new Booking(conString);

            Application.Run(bookingform);

        }
    }
}
