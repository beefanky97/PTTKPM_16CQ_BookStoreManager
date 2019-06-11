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
        public MainWindow()
        {
            InitializeComponent();
            List<SachDTO> listSach = SachBUS.GetAll();
            dtgBook.ItemsSource = listSach;
            List<TheLoaiDTO> listTheLoai = TheLoaiBUS.GetAllCategories();
            cbbCategory.ItemsSource = listTheLoai;
            List<TacGiaDTO> listTacGia = TacGiaBUS.getAllAuthors();
            cbbAuthor.ItemsSource = listTacGia;
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
    }
}
