using Point_of_Sale.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.SqlClient;
using System.Data;
using Spire.Pdf.Print;
using System.Windows.Xps.Packaging;
using System.Windows.Xps;
using Spire.Pdf;

namespace Point_of_Sale
{
    public partial class MainWindow : Window
    {
        static int orderno = 0;
        public MainWindow()
        {
            InitializeComponent();
            page.Content = new GeneralPage();
        }

        private void SoftDrinkPage(object sender, RoutedEventArgs e)
        {
            page.Content = new SoftDrink();
        }
        public void calculte()
        {
            double priceSum = 0, taxSum = 0, qSum = 0;
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            for (int i = 0; i < mainWindow.dgrid.Items.Count; i++)
            {
                priceSum += Convert.ToInt32(((Item)mainWindow.dgrid.Items[i]).total);
                qSum += Convert.ToInt32(((Item)mainWindow.dgrid.Items[i]).quantity);
            }
            taxSum = (priceSum / 100) * 14;
            mainWindow.total.Text = Convert.ToString(priceSum);
            mainWindow.subtotal.Text = Convert.ToString(priceSum);
            mainWindow.tax.Text = Convert.ToString(taxSum);
            mainWindow.totalpay.Text = Convert.ToString(priceSum + taxSum);
            mainWindow.totalqan.Text = Convert.ToString(qSum);
        }

        private void deleteRow(object sender, RoutedEventArgs e)
        {
            Button temp = (Button)sender;
            Item obj = temp.DataContext as Item;
            dgrid.Items.Remove(obj);
            calculte();
        }

        private void suspend(object sender, RoutedEventArgs e)
        {
            dgrid.Items.Clear();
            calculte();
        }


        private void payment(object sender, RoutedEventArgs e)
        {
            List<Item> list = new List<Item>();
            if (dgrid.Items.Count > 0)
            {
                foreach (Item obj in dgrid.Items)
                {
                    list.Add(obj);
                }
                string date = DateTime.Now.ToString("D");
                string time = DateTime.Now.ToString("T");
                string price = totalpay.Text;
                if (DBO.addData(price, date, time, list))
                {
                    MessageBox.Show("Order Complete SuccessFully", "Payment Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);

                    PDF();
                    dgrid.Items.Clear();
                    calculte();
                }
                else
                {
                    MessageBox.Show("Order not Complete", "Payment Confirmation", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Order not Complete", "Payment Confirmation", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
        private void PDF()
        {
            try
            {
                MemoryStream lMemoryStream = new MemoryStream();
                Package package = Package.Open(lMemoryStream, FileMode.Create);
                XpsDocument document = new XpsDocument(package);
                XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(document);
                writer.Write(pdf);
                document.Close();
                package.Close();

                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.LoadFromXPS(lMemoryStream);
                orderno++;
                string name = "Order "+Convert.ToString(orderno)+ ".pdf";
                pdfDocument.SaveToFile(name, FileFormat.PDF);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.ToString(),"Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void checkSalt(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            try
            {
                Item temp = mainWindow.dgrid.SelectedItem as Item;
                if (checks(temp.comment, "Salt") == true)
                {
                    temp.comment = temp.comment + " " + salt.Content;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Plz Select One Row", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private bool checks(string comment, string v)
        {
            string[] s = comment.Split(' ');
            foreach (string c in s)
            {
                if (c == v)
                    return false;
            }
            return true;
        }

        private void checkM(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            try {
                Item temp = mainWindow.dgrid.SelectedItem as Item;
                if (checks(temp.comment, "Milk") == true)
                {
                    temp.comment = temp.comment + " " + milk.Content;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Plz Select One Row", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void checkS(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            try
            {
                Item temp = mainWindow.dgrid.SelectedItem as Item;
                if (checks(temp.comment, "Sugar") == true)
                {
                    temp.comment = temp.comment + " " + sugar.Content;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Plz Select One Row", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void checkC(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            try
            {
                Item temp = mainWindow.dgrid.SelectedItem as Item;
                if (checks(temp.comment, "Cream") == true)
                {
                    temp.comment = temp.comment + " " + cream.Content;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Plz Select One Row", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void checkSP(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            try
            {
                Item temp = mainWindow.dgrid.SelectedItem as Item;
                if (checks(temp.comment, "Spicy") == true)
                {
                    temp.comment = temp.comment + " " + spicy.Content;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Plz Select One Row", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void checkI(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            try
            {
                Item temp = mainWindow.dgrid.SelectedItem as Item;
                if (checks(temp.comment, "IceCream") == true)
                {
                    temp.comment = temp.comment + " " + ice.Content;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Plz Select One Row", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
        public bool checkdup(string name)
        {
            MainWindow mainWindow = ((MainWindow)App.Current.MainWindow);
            foreach (Item obj in dgrid.Items)
            {
                if (name == obj.itemName)
                {
                    obj.quantity = Convert.ToString(Convert.ToInt32(obj.quantity) + 1);
                    obj.total = Convert.ToString(Convert.ToInt32(obj.total) * 2);
                    return false;
                }
            }
            return true;
        }

        private void coffePage(object sender, RoutedEventArgs e)
        {
            page.Content = new Coffe();
        }

        private void ciggeratePage(object sender, RoutedEventArgs e)
        {
            page.Content = new Cigarettes();
        }


        private void FoodPage(object sender, RoutedEventArgs e)
        {
            page.Content = new Food();
        }

        private void burgerPage(object sender, RoutedEventArgs e)
        {
            page.Content = new Burgers();
        }

        private void fruitPage(object sender, RoutedEventArgs e)
        {
            page.Content = new Fruit();
        }

        private void icecreamPage(object sender, RoutedEventArgs e)
        {
            page.Content = new IceCream();
        }

        private void gernalPage(object sender, RoutedEventArgs e)
        {
            page.Content = new GeneralPage();
        }
    
    }
}
