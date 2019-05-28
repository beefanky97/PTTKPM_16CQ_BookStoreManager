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
using DTO;
using BUS;

namespace BookStore_WPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            NguoiDungDTO nguoidung = new NguoiDungDTO();
            nguoidung.TenDangNhap = txtUsername.Text;
            nguoidung.MatKhau = pswPassword.Password;
            if (rbCasher.IsChecked == false && rbManager.IsChecked == false && rbWarehouse.IsChecked == false)
            {
                MessageBox.Show("Please select the type of user", "Notification", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            if (rbCasher.IsChecked == true)
            {
                nguoidung.NhanVienBanHang = "1";
            }
            if (rbManager.IsChecked == true)
            {
                nguoidung.QuanLi = "1";
            }
            if (rbWarehouse.IsChecked == true)
            {
                nguoidung.NhanVienNhapKho = "1";
            }
            NguoiDungDTO dangnhap = NguoiDungBUS.Login(nguoidung);
            if (dangnhap != null)
            {
                this.Close();
                Window mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Login failed, please check user name or password","Login Error",MessageBoxButton.OK,MessageBoxImage.Stop);
            }
        }
    }
}
