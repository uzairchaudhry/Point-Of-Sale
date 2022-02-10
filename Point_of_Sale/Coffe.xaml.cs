using Point_of_Sale.Model;
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

namespace Point_of_Sale
{
    /// <summary>
    /// Interaction logic for Coffe.xaml
    /// </summary>
    public partial class Coffe : Page
    {
        public Coffe()
        {
            InitializeComponent();
        }

        private void clickSC(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Small Coffe", price = "300", quantity = "1", tax = "30", total = "300", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickCupC(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Cup Cold", price = "150", quantity = "1", tax = "15", total = "150", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickColdC(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Cold Coffe", price = "200", quantity = "1", tax = "20", total = "2200", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickSimpleC(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Simple Coffe", price = "100", quantity = "1", tax = "10", total = "100", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }
    }
}
