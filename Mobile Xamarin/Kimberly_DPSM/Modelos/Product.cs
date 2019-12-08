using System;
using System.ComponentModel;

namespace Modelos
{
    public class Product : INotifyPropertyChanged
    {
        public Product()
        {
        }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Status { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
