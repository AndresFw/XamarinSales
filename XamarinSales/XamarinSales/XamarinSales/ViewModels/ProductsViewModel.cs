namespace XamarinSales.ViewModels
{
    using Sales.ViewModels;
    using System;
    using System.Collections.ObjectModel;
    using XamarinSales.Common.Models;
    using XamarinSales.services;

    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService;  

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            var response = await apiService.GetList<Product>("localhost","","");
        }
    }
}
