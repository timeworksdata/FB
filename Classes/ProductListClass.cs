using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FB
{
    class ProductListClass
    {
   
 private ObservableCollection<Product> _product = new ObservableCollection<Product>();


        public ObservableCollection<Product> product
        {
            get { return _product; }
            set { _product = value; }
        }

    }
}
