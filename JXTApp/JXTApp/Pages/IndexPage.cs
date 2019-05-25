using Xamarin.Forms;

namespace JXTApp.Pages
{
    public class IndexPage : ContentPage
    {
        public IndexPage()
        {
            Content = new ContentView()
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Image
                        {
                            Aspect = Aspect.AspectFill,
                            Source =  "background.png"
                        }
                    },
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    BackgroundColor = Color.FromHex("#002d3d")
                }
            };
        }
    }
}