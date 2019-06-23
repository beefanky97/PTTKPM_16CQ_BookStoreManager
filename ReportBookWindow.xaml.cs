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
    /// Interaction logic for ReportBookWindow.xaml
    /// </summary>
    public partial class ReportBookWindow : Window
    {
        public ReportBookWindow()
        {
            InitializeComponent();
            //int result = BaoCaoSachTonBUS.GenerateReport();
            List<BaoCaoSachTonDTO> list = BaoCaoSachTonBUS.GetAllData();
            dtgBookReportList.ItemsSource = list;
        }

        private void DtgBookReportList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            BaoCaoSachTonDTO selected = (BaoCaoSachTonDTO)dtgBookReportList.SelectedItem;
            Window reportDetail = new ReportBookDetail(selected);
            reportDetail.ShowDialog();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            int result = BaoCaoSachTonBUS.GenerateReport();
            List<BaoCaoSachTonDTO> list = BaoCaoSachTonBUS.GetAllData();
            dtgBookReportList.ItemsSource = list;
            dtgBookReportList.Items.Refresh();
        }
    }
}
