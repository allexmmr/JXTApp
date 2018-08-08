using Xamarin.Forms;

namespace JXTApp.Pages
{
    public class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            Children.Add(new IndexPage()
            {
                Title = "Home",
                Icon = "home.png"
            });

            Children.Add(new ProductsPage()
            {
                Title = "Products",
                Icon = "products.png"
            });

            Children.Add(new Jobs.IndexPage()
            {
                Title = "Jobs",
                Icon = "jobs.png"
            });

            Children.Add(new MapPage()
            {
                Title = "Map",
                Icon = "map.png"
            });
        }
    }
}