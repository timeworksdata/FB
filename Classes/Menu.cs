using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FB
{
    class Menu
    {


        private ObservableCollection<Category> _category = new ObservableCollection<Category>();


        public ObservableCollection<Category> category
        {
            get { return _category; }
            set { _category = value; }
        }


    }
}
