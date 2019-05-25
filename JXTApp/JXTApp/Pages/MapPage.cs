using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace JXTApp.Pages
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            Position position = new Position(-33.8671564, 151.2086889);

            Map map = new Map(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.3)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "JXT Global Pty Ltd",
                Address = "3/92 Pitt St, Sydney"
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