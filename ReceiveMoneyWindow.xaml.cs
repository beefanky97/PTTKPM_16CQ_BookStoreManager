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
    /// Interaction logic for ReceiveMoneyWindow.xaml
    /// </summary>
    public partial class ReceiveMoneyWindow : Window
    {
        private HoaDonDTO Bill = new HoaDonDTO();
        private KhachHangDTO Customer = new KhachHangDTO();
        public ReceiveMoneyWindow()
        {
            InitializeComponent();
        }

        public ReceiveMoneyWindow(HoaDonDTO bill, KhachHangDTO customer)
        {
            InitializeComponent();
            Bill.Sach = bill.Sach;
            Bill.ThanhTien = bill.ThanhTien;
            Bill.Ngay = bill.Ngay;
            Customer.TenKH = customer.TenKH;
            Customer.SDT = customer.SDT;
            txtName.Text = Customer.TenKH;
            txtPhone.Text = Customer.SDT;
            dpCashDay.Text = bill.Ngay;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string money = txtMoney.Text;
            string date = dpCashDay.Text;
            Customer.DiaChi = address;
            Customer.Email = email;
            if (KhachHangBUS.checkDeb(name, phone) == 1)
            {
                MessageBox.Show("Deb is over the amount that allowed", "Notification", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                foreach(SachDTO item in Bill.Sach)
                {
                    int amount = SachBUS.FindAmount(item);
                    int buyed = int.Parse(item.LuongTon);
                    int remain = amount - buyed;
                    item.LuongTon = remain.ToString();
                    int result = SachBUS.ChangeAmount(item);
                }
                int cash = int.Parse(money);
                int price = int.Parse(Bill.ThanhTien);
                int deb = price - cash;
                if (deb == 0)
                {
                    if (KhachHangBUS.checkDeb(name, phone) == 0)
                    {
                        Bill.SoTienThanhToan = cash.ToString();
                        Customer.CongNo = null;
                        int res = KhachHangBUS.addCustomer(Customer);
                        if (res <= 0)
                        {
                            MessageBox.Show("Error in database", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        }
                        else
                        {
                            res = HoaDonBUS.AddBill(Bill);
                            if (res <= 0)
                            {
                                MessageBox.Show("Error in database", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Successfull", "Information", MessageBoxButton.OK,
                                    MessageBoxImage.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        int res = HoaDonBUS.AddBill(Bill);
                        if (res <= 0)
                        {
                            MessageBox.Show("Error in database", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Successfull", "Information", MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                        }
                    }
                }
                else
                {
                    if (KhachHangBUS.checkDeb(name, phone) == 0)
                    {
                        Customer.CongNo = new CongNoDTO();
                        Customer.CongNo.NoDau = "0";
                        Customer.CongNo.NoCuoi = deb.ToString();
                        Customer.CongNo.PhatSinh = deb.ToString();
                        int res = KhachHangBUS.addCustomer(Customer);
                        res = HoaDonBUS.AddBill(Bill);
                        if (res <= 0)
                        {
                            MessageBox.Show("Error in database", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Successfull", "Information", MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                        }
                    } else
                    {
                        KhachHangDTO finded = KhachHangBUS.GetCustomer(name, phone);
                        CongNoDTO newDeb = CongnoBUS.getDeb(finded.CongNo.Id);
                        int nocuoi = int.Parse(newDeb.NoCuoi);
                        int phatsinh = nocuoi + deb;
                        newDeb.NoDau = newDeb.NoCuoi;
                        newDeb.NoCuoi = phatsinh.ToString();
                        newDeb.PhatSinh = deb.ToString();
                        CongnoBUS.updateDeb(newDeb);
                        int res = HoaDonBUS.AddBill(Bill);
                        if (res <= 0)
                        {
                            MessageBox.Show("Error in database", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Successfull", "Information", MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                        }
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}