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
    public partial class SoftDrink : Page
    {
        public SoftDrink()
        {
            InitializeComponent();
        }

        private void clickedSoft(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName="Soft Drink", price="100", quantity="1", tax ="10", total="110", comment=" "};
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName)==true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
            
        }

        private void clickdrink(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Drink", price = "80", quantity = "1", tax = "8", total = "88", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickedJuccie(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Juccie", price = "120", quantity = "1", tax = "12", total = "132", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }

        private void clickCoke(object sender, MouseButtonEventArgs e)
        {
            Item obj = new Item { itemName = "Coke", price = "70", quantity = "1", tax = "7", total = "77", comment = " " };
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            if (mainWindow.checkdup(obj.itemName) == true)
            {
                mainWindow.dgrid.Items.Add(obj);
            }
            mainWindow.calculte();
        }
    }
}
