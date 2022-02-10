using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.Model
{
    class Item : INotifyPropertyChanged
    {

        private string _itemName;
        private string _price;
        private string _quantity;
        private string _total;
        private string _tax;
        private string _comment;
        public string itemName { 
            get { return _itemName; }
            set {
                this._itemName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("itemName"));
                }
            }
        }
        public string price {
            get { return _price; }
            set {
                this._price = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("price"));
                }
            }
        }
        public string quantity {
            get { return _quantity; }
            set {
                this._quantity = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("quantity"));
                }
            }
        }
        public string total { 
            get { return _total; }
            set {
                this._total = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("total"));
                }
            }
        }
        public string tax
        {
            get { return _tax; }
            set
            {
                this._tax = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("tax"));
                }
            }
        }
        
        public string comment
        {
            get { return this._comment; }
            set
            {
                this._comment = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Comment"));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
