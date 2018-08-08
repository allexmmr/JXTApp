using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace JXTApp.Pages
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            Position position = new Position(-33.8696608, 151.2040941);

            Map map = new Map(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.3)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "JXT Global Pty Ltd",
                Address = "2/50 York Street, Sydney"
            });

            Content = new StackLayout
            {
                Children = {
                    map
                }
            };
        }
    }
}