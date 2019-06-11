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
    /// Interaction logic for ReportBookDetail.xaml
    /// </summary>
    public partial class ReportBookDetail : Window
    {
        public ReportBookDetail(BaoCaoSachTonDTO item)
        {
            InitializeComponent();
            dtgBookReportDetailList.ItemsSource = item.Sach;
        }
    }
}
