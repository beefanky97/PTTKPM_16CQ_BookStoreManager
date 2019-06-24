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
using BUS;
using DTO;

namespace BookStore_WPF
{
    /// <summary>
    /// Interaction logic for RegulationsWindow.xaml
    /// </summary>
    public partial class RegulationsWindow : Window
    {
        private bool isEdit = false;
        public RegulationsWindow()
        {
            InitializeComponent();
            List<NguoiDungDTO> list = NguoiDungBUS.GetAll();
            dtgEmployeesList.ItemsSource = list;
            List<QuyDinhDTO> rule = QuyDinhBUS.GetAll();
            txtMinAmount.Text = rule[0].GiaTri;
            txtMaxDeb.Text = rule[1].GiaTri;
            txtMin.Text = rule[2].GiaTri;
            txtSold.Text = rule[3].GiaTri;
        }

        private void BtnConfirmAdd_Click(object sender, RoutedEventArgs e)
        {
            string account = txtAccount.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Password;
            NguoiDungDTO employee = new NguoiDungDTO();
            employee.Email = email;
            employee.HoTen = name;
            employee.TenDangNhap = account;
            employee.MatKhau = password;
            employee.DaXoa = "0";
            if (rbCasher.IsChecked == true)
            {
                employee.NhanVienBanHang = "1";
                employee.NhanVienNhapKho = "0";
                employee.QuanLi = "0";
            }
            if (rbManager.IsChecked == true)
            {
                employee.NhanVienNhapKho = "0";
                employee.NhanVienBanHang = "0";
                employee.QuanLi = "1";
            }
            if (rbWarehouse.IsChecked == true)
            {
                employee.NhanVienBanHang = "0";
                employee.NhanVienNhapKho = "1";
                employee.QuanLi = "0";
            }
            if (rbCasher.IsChecked == false && rbManager.IsChecked == false && rbWarehouse.IsChecked == false)
            {
                MessageBox.Show("Vui lòng chọn một vai trò cho người dùng mới", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Hand);
            } else
            {
                int result = 0;
                if (isEdit == true)
                {
                    NguoiDungDTO selected = (NguoiDungDTO)dtgEmployeesList.SelectedItem;
                    employee.Id = selected.Id;
                    result = NguoiDungBUS.EditEmployee(employee);
                    dtgEmployeesList.ItemsSource = NguoiDungBUS.GetAll();
                    dtgEmployeesList.Items.Refresh();
                }
                else
                {
                    result = NguoiDungBUS.AddEmployee(employee);
                    dtgEmployeesList.ItemsSource = NguoiDungBUS.GetAll();
                    dtgEmployeesList.Items.Refresh();
                }
            }
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtAccount.Text = "";
            txtEmail.Text = "";
            txtPassword.Password = "";
            txtName.Text = "";
            rbCasher.IsChecked = false;
            rbManager.IsChecked = false;
            rbWarehouse.IsChecked = false;
        }

        private void BtnDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            NguoiDungDTO selected = (NguoiDungDTO)dtgEmployeesList.SelectedItem;
            selected.DaXoa = "1";
            int result = NguoiDungBUS.EditEmployee(selected);
            dtgEmployeesList.ItemsSource = NguoiDungBUS.GetAll();
            dtgEmployeesList.Items.Refresh();
        }

        private void DtgEmployeesList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NguoiDungDTO selected = (NguoiDungDTO)dtgEmployeesList.SelectedItem;
            btnAddEmployee.IsChecked = true;
            txtAccount.Text = selected.TenDangNhap;
            txtEmail.Text = selected.Email;
            txtPassword.Password = selected.MatKhau;
            txtName.Text = selected.HoTen;
            btnAddEmployee.IsChecked = true;
            txtAccount.IsEnabled = false;
            txtEmail.IsEnabled = false;
            txtPassword.IsEnabled = false;
            txtName.IsEnabled = false;
            rbCasher.IsChecked = false;
            rbManager.IsChecked = false;
            rbWarehouse.IsChecked = false;
            if (selected.NhanVienBanHang == "1")
            {
                rbCasher.IsChecked = true;
            } else
            {
                if (selected.NhanVienNhapKho == "1")
                {
                    rbWarehouse.IsChecked = true;
                } else
                {
                    rbManager.IsChecked = true;
                }
            }
            isEdit = true;
        }

        private void BtnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            isEdit = false;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
