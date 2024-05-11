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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new fLogin());
            //Application.Run(new Venue());
            Application.Run(new Receipt());
            //Food foodform = new Food();

            ////// Hiển thị form Food
            ////Application.Run(foodform);
            //Booking bookingform = new Booking();

            ////// pass the bookingform instance to the food form constructor
            //Food foodform = new Food(bookingform);
            //Application.Run(bookingform);

        }
    }
}
