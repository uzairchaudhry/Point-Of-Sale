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
    /// Interaction logic for Food.xaml
    /// </summary>
    public partial class Food : Page
    {
        public Food()
        {
            InitializeComponent();
        }

        private void clickV(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Vegetable Salad", price = "100", quantity = "1", tax = "10", total = "100", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickF(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Fruit Salad", price = "150", quantity = "1", tax = "15", total = "150", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();

        }

        private void clickC(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Chicken Salad", price = "200", quantity = "1", tax = "20", total = "200", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickR(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Russian Salad", price = "180", quantity = "1", tax = "15", total = "180", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }
    }
}
