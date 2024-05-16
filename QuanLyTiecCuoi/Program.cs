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
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QuanLyTiecCuoi.Service.Service(conString, null));
            //Application.Run(new Receipt(conString));
            //Food foodform = new Food(conString, null);

            //Application.Run(foodform);
            Application.Run(new Report(conString));

            //Venue Venue = new Venue(null, conString);
            //Application.Run(Venue);
            ////// Hiển thị form Food

            //Booking bookingform = new Booking(conString);

            ////// pass the bookingform instance to the food form constructor
            //Food foodform = new Food(conString, bookingform);
            //Application.Run(bookingform);

        }
    }
}
