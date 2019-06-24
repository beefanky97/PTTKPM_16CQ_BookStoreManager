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
using BookStore_WPF.ViewModel;

namespace BookStore_WPF.UserControlZone
{
    /// <summary>
    /// Interaction logic for ControlBarUC.xaml
    /// </summary>
    public partial class ControlBarUC : UserControl
    {
        public ControlBarViewModel ViewModel { get; set; }
        public ControlBarUC()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new ControlBarViewModel();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Window main = new MainWindow();
            main.ShowDialog();
        }

        private void BtnAddBook_Click(object sender, RoutedEventArgs e)
        {
            Window add = new AddBook();
            add.ShowDialog();
        }

        private void BtnReceiveMonney_Click(object sender, RoutedEventArgs e)
        {
            Window receive = new ReceiveMoneyWindow();
            receive.ShowDialog();
        }

        private void BtnBookReport_Click(object sender, RoutedEventArgs e)
        {
            Window bookReport = new ReportBookWindow();
            bookReport.ShowDialog();
        }

        private void BtnReportDeb_Click(object sender, RoutedEventArgs e)
        {
            Window debReport = new ReportDebtorsWindow();
            debReport.ShowDialog();
        }

        private void BtnRule_Click(object sender, RoutedEventArgs e)
        {
            Window admin = new RegulationsWindow();
            admin.ShowDialog();
        }
    }
}
