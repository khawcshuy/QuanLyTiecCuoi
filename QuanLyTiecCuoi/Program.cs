using QuanLyTiecCuoi.DESIGN;
using QuanLyTiecCuoi.NHANVIEN;
using QuanLyTiecCuoi.Private;
using QuanLyTiecCuoi.Service;
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
            //string conString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QUANLYTIECCUOI1;Integrated Security=True";
            //string conString = "Data Source=Doraemon\\SQLEXPRESS;Initial Catalog=QUANLYTIECCUOI;Integrated Security=True";
            string conString = @"Data Source = ADMINISTRATOR; Initial Catalog = QUANLYTIECCUOI; Integrated Security = True";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QuanLyTiecCuoi.Service.Service(conString, null));
            //NhanVien nhanVien = new NhanVien(conString);
            //Application.Run(new NhanVien(conString));
            //InsertNV NHANVIEN = new InsertNV(conString,null);
            //Application.Run(nhanVien);
            //Application.Run(foodform);
            //Application.Run(new Report(conString));

            //Venue Venue = new Venue(null, conString);
            //Application.Run(Venue);
            ////// Hiển thị form Food

            //Application.Run(new Booking(conString));
            //Application.Run(new MainForm(conString));

            //TrangThaiSanh trangThaiSanh = new TrangThaiSanh(conString);
            //Application.Run(trangThaiSanh);




            //// pass the bookingform instance to the food form constructor
            //Food foodform = new Food(conString, null);
            //Application.Run(new Food(conString, null));

            // GỌI BOOKING 
            fLogin login = new fLogin(conString);
            Application.Run(login);
            //TraCuu tracuuform = new TraCuu(conString);
            //Application.Run(tracuuform);
            //fLogin fLogin = new fLogin(conString);
            //Application.Run(fLogin);
            /*TrangThaiSanh form1 = new TrangThaiSanh();
            Application.Run(form1);*/
        }
    }
}
