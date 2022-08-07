namespace XamarinSales.Infraestructure
{
    using XamarinSales.ViewModels;

    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator() {
            this.Main = new MainViewModel();
        }
    }
}
 