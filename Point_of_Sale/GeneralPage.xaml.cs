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
    /// Interaction logic for GeneralPage.xaml
    /// </summary>
    public partial class GeneralPage : Page
    {
        public GeneralPage()
        {
            InitializeComponent();
        }


        private void clickSoft(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Soft Drink", price = "100", quantity = "1", tax = "10", total = "100", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickDrink(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Drink", price = "80", quantity = "1", tax = "8", total = "80", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickCC(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Cold Coffee", price = "100", quantity = "1", tax = "10", total = "100", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickSB(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Chiken Burger", price = "120", quantity = "1", tax = "12", total = "120", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickCig(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Black Ciggerate", price = "150", quantity = "1", tax = "15", total = "150", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickCI(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Cone Ice Cream", price = "80", quantity = "1", tax = "10", total = "80", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }
    }
}
