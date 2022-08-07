using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSales.ViewModels
{
    public class MainViewModel
    {
        public ProductsViewModel Products { get; set; }

        public MainViewModel() {
            this.Products = new ProductsViewModel();
        }
    }
}
