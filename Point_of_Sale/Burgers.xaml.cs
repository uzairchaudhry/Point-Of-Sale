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
    /// Interaction logic for Burgers.xaml
    /// </summary>
    public partial class Burgers : Page
    {
        public Burgers()
        {
            InitializeComponent();
        }

        private void clickC(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Chiken Burger", price = "120", quantity = "1", tax = "12", total = "120", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickS(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Shami Burger", price = "80", quantity = "1", tax = "8", total = "80", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickZ(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Zinger Burger", price = "180", quantity = "1", tax = "18", total = "180", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickG(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Grill Burger", price = "250", quantity = "1", tax = "25", total = "250", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }
    }
}
