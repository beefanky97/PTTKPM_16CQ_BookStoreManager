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
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        private SachDTO selected = null;
        private int TotalCost = 0;
        public AddBook()
        {
            InitializeComponent();
            List<SachDTO> listBook = SachBUS.GetAll();
            dtgBook.ItemsSource = listBook;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (selected == null)
            {
                string name = txtName.Text;
                string author = txtAuthor.Text;
                string category = txtCategory.Text;
                string price = txtPrice.Text;
                string amount = txtAmount.Text;
                string idCategory = TheLoaiBUS.addCategory(category);
                string idAuthor = TacGiaBUS.addAuthor(author);
                SachDTO sach = new SachDTO();
                sach.DonGia = price;
                sach.LuongTon = amount;
                sach.TenSach = name;
                sach.TenTacGia = idAuthor;
                sach.TenTheLoai = idCategory;
                int result = SachBUS.AddBook(sach);
                List<SachDTO> listBook = SachBUS.GetAll();
                dtgBook.ItemsSource = listBook;
                dtgBook.Items.Refresh();
                int Price = int.Parse(price);
                int Amount = int.Parse(amount);
                TotalCost += Price * Amount;
                lblTotal.Text = TotalCost.ToString();
            } else
            {
                selected.LuongTon = txtAmount.Text;
                int Price = int.Parse(selected.DonGia);
                int Amount = int.Parse(selected.LuongTon);
                TotalCost += Price * Amount;
                lblTotal.Text = TotalCost.ToString();
                int result = SachBUS.ChangeAmount(selected);
                if (result < 0)
                {
                    MessageBox.Show("Thêm sách thất bại", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void DtgBook_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selected = (SachDTO)dtgBook.SelectedItem;
            txtAmount.Text = selected.LuongTon;
            txtAuthor.Text = selected.TenTacGia;
            txtCategory.Text = selected.TenTheLoai;
            txtName.Text = selected.TenSach;
            txtPrice.Text = selected.DonGia;
            txtCategory.IsEnabled = false;
            txtName.IsEnabled = false;
            txtPrice.IsEnabled = false;
            txtAuthor.IsEnabled = false;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            txtAmount.Text = "";
            txtAuthor.Text = "";
            txtCategory.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtPrice.IsEnabled = true;
            txtName.IsEnabled = true;
            txtAuthor.IsEnabled = true;
            txtCategory.IsEnabled = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
