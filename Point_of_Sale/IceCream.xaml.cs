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
    /// Interaction logic for IceCream.xaml
    /// </summary>
    public partial class IceCream : Page
    {
        public IceCream()
        {
            InitializeComponent();
        }

        private void clickC(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Cone Ice Cream", price = "80", quantity = "1", tax = "8", total = "80", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickM(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Medium Ice Cream", price = "200", quantity = "1", tax = "20", total = "200", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickL(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Large Ice Cream", price = "300", quantity = "1", tax = "30", total = "300", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickS(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Special Ice Cream", price = "150", quantity = "1", tax = "12", total = "150", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }
    }
}
