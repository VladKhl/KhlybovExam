using KhlybovExam.DataBase;
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

namespace KhlybovExam.Windows
{
    /// <summary>
    /// Interaction logic for AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientUser clientUser = new ClientUser()
            {
                Name = NameClientTB.Text,
                Surname= SurnameClientTB.Text,
                Middlename = MiddleNameClientTB.Text,
                PhoneNumber= PhoneNumberClientTB.Text,
            };
            App.prog2Entities.ClientUser.Add(clientUser);
            App.prog2Entities.SaveChanges();
            MessageBox.Show("Успешно");
        }
    }
}
