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
using DTO;
using BUS;

namespace BookStore_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<SachDTO> selectedBooks = new List<SachDTO>();
        private int total = 0;
        public MainWindow()
        {
            InitializeComponent();
            List<SachDTO> listSach = SachBUS.GetAll();
            dtgBook.ItemsSource = listSach;
            List<TheLoaiDTO> listTheLoai = TheLoaiBUS.GetAllCategories();
            cbbCategory.ItemsSource = listTheLoai;
            List<TacGiaDTO> listTacGia = TacGiaBUS.getAllAuthors();
            cbbAuthor.ItemsSource = listTacGia;
            lblDate.Content = DateTime.Now.Date.ToString();
        }

        private void CbbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TheLoaiDTO selected = (TheLoaiDTO)cbbCategory.SelectedItem;
            List<SachDTO> list = SachBUS.GetBookByCategory(selected);
            dtgBook.ItemsSource = list;
            dtgBook.Items.Refresh();
        }

        private void CbbAuthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TacGiaDTO selected = (TacGiaDTO)cbbAuthor.SelectedItem;
            List<SachDTO> list = SachBUS.GetBookByAuthor(selected);
            dtgBook.ItemsSource = list;
            dtgBook.Items.Refresh();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SachDTO selected = (SachDTO)dtgBook.SelectedItem;
                int amount = int.Parse(txtAmount.Text);
                txtPrice.Text = selected.DonGia;
                int price = int.Parse(txtPrice.Text);
                SachDTO item = selected;
                item.LuongTon = txtAmount.Text;
                selectedBooks.Add(item);
                dtgSelectedItem.ItemsSource = selectedBooks;
                dtgSelectedItem.Items.Refresh();
                total = total + amount * price;
                lblTotalCost.Content = total.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            HoaDonDTO bill = new HoaDonDTO();
            KhachHangDTO customer = new KhachHangDTO();
            customer.TenKH = txtName.Text;
            customer.SDT = txtPhone.Text;
            bill.Ngay = DateTime.Now.Date.ToString();
            bill.ThanhTien = total.ToString();
            bill.Sach = selectedBooks;
            Window receiveMoney = new ReceiveMoneyWindow(bill, customer);
            receiveMoney.ShowDialog();
        }
    }
}
