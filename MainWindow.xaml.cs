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


namespace XAML_WPF_ListBox_Quete2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick_AddSomeoneToList(object sender, RoutedEventArgs e)
        {
            string infectedPerson = InfectedPersonsName.Text;
            if (InfectedPersonsList.Items.Contains(infectedPerson))
            {
                MessageBox.Show("This infected person is already in the list !");
            }
            else if (infectedPerson == string.Empty)
            {
                MessageBox.Show("Please insert a name !");
            }
            else
            {
                InfectedPersonsList.Items.Add(infectedPerson);
            }
        }


    }
}
