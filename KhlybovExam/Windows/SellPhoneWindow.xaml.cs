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
    /// Interaction logic for SellPhoneWindow.xaml
    /// </summary>
    public partial class SellPhoneWindow : Window
    {
        public SellPhoneWindow()
        {
            InitializeComponent();
            ClientCB.ItemsSource = App.prog2Entities.ClientUser.ToList();
            ClientCB.DisplayMemberPath = "Name";
            PhoneCB.ItemsSource = App.prog2Entities.Phone.ToList();
            PhoneCB.DisplayMemberPath = "Name";
        }

        private void AddSellBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
