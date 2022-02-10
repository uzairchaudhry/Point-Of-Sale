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
    /// Interaction logic for Cigarettes.xaml
    /// </summary>
    public partial class Cigarettes : Page
    {
        public Cigarettes()
        {
            InitializeComponent();
        }

        private void clickB(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Black Ciggerate", price = "150", quantity = "1", tax = "15", total = "150", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickM(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Malburo Ciggerate", price = "180", quantity = "1", tax = "18", total = "180", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickG(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Gold Flake", price = "100", quantity = "1", tax = "10", total = "100", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickD(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "DunHill Ciggerate", price = "250", quantity = "1", tax = "25", total = "250", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }
    }
}
