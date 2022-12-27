using KhlybovExam.DataBase;
using KhlybovExam.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace KhlybovExam.Pages
{
    /// <summary>
    /// Interaction logic for AdmStartPage.xaml
    /// </summary>
    public partial class AdmStartPage : Page
    {
        public AdmStartPage()
        {
            InitializeComponent();
            PhoneListDG.ItemsSource = App.prog2Entities.Phone.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AutorizationPage());
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.Show();
        }

        private void SellPhoneBtn_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
               // var phone = PhoneListDG.SelectedItem as Phone;

            //}
            //catch
            //{
                //MessageBox.Show("Выберите телефон");
            //}
        }
    }
}
