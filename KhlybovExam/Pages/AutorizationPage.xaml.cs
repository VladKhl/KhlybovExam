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

namespace KhlybovExam.Pages
{
    /// <summary>
    /// Interaction logic for AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void SignBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = App.prog2Entities.Account.Where(p => p.login == LoginTB.Text && p.password == PassTB.Text).First();
                if (user != null)
                {
                    if (user.id_role == 1)
                    {
                        NavigationService.Navigate(new AdmStartPage());
                        MessageBox.Show("Добро пожаловать администратор!");
                    }
                    else if (user.id_role == 2)
                    {
                        NavigationService.Navigate(new WorkerSkladStartPage());
                        MessageBox.Show("Добро пожаловать работник склада!");
                    }
                    else if (user.id_role == 3)
                    {
                        NavigationService.Navigate(new WorkerRepareStartPage());
                        MessageBox.Show("Добро пожаловать работник мастерской!");
                    }
                    else if (user.id_role == 4)
                    {
                        NavigationService.Navigate(new DirectorStartPage());
                        MessageBox.Show("Добро пожаловать владелец!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}
