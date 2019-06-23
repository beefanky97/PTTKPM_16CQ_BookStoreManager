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
        public AddBook()
        {
            InitializeComponent();
            List<TacGiaDTO> listAuthor = TacGiaBUS.getAllAuthors();
            List<TheLoaiDTO> listCategory = TheLoaiBUS.GetAllCategories();
            cbbAuthor.ItemsSource = listAuthor;
            cbbCategory.ItemsSource = listCategory;
        }
    }
}
