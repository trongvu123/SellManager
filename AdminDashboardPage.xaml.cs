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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SellManager
{
    /// <summary>
    /// Interaction logic for AdminDashboardPage.xaml
    /// </summary>
    public partial class AdminDashboardPage : Window
    {
        private readonly QlbanHangContext _context;
        public List<StatusOption> StatusOptions { get; set; }
        public AdminDashboardPage()
        {
            InitializeComponent();
            _context = new QlbanHangContext();
            StatusOptions = new List<StatusOption>
    {
        new StatusOption { Value = true, Text = "Khóa" },
        new StatusOption { Value = false, Text = "Hoạt động" }
    };
            DataContext = this;
        }
        public class StatusOption
        {
            public bool Value { get; set; }
            public string Text { get; set; }
        }
        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var list = _context.NhanViens.ToList();
            DgData.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var updatedMembers = DgData.ItemsSource as List<NhanVien>;
            if (updatedMembers != null)
            {
                using (var context = new QlbanHangContext()) 
                {
                    foreach (var member in updatedMembers)
                    {
                        var dbMember = context.NhanViens.Find(member.MaNv);
                        if (dbMember != null)
                        {
                            dbMember.status = member.status;
                        }
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Đã cập nhật trạng thái của tất cả thành viên.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
