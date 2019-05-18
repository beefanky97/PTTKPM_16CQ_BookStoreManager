using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace BookStore_WPF.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool IsLoaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        //Mọi thứ xử lý nằm trong này
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                IsLoaded = true;
                //LoginWindow loginWindow = new LoginWindow();
                //loginWindow.ShowDialog();
                AddBook addBook = new AddBook();
                addBook.ShowDialog();
            }); 
        }
    }
}
