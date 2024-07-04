using SellManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SellManager
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly QlbanHangContext _context;
        public LoginWindow()
        {
            _context = new QlbanHangContext();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var check = _context.NhanViens.Where(nv => nv.MaDn == txtUsername.Text && nv.MatKhau == txtPassword.Password).FirstOrDefault();
                if (check != null)
                {
                    NhanVienSession.NhanVien = check;
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    mainWindow.MainFrame.Navigate(new CustomerListWindow());
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
