using Xamarin.Forms;

namespace JXTApp.Pages
{
    public class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            AbsoluteLayout layout = new AbsoluteLayout();

            splashImage = new Image
            {
                Source = "jxt.png",
                WidthRequest = 192,
                HeightRequest = 90
            };

            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            layout.Children.Add(splashImage);

            BackgroundColor = Color.FromHex("#ffffff");

            Content = layout;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Time-consuming processes such as initialization
            await splashImage.RotateTo(0,  1);
            await splashImage.RotateTo(0,  100, Easing.SinInOut);
            await splashImage.RotateTo(3,  150, Easing.SinInOut);
            await splashImage.RotateTo(-3, 150, Easing.SinInOut);
            await splashImage.RotateTo(5,  150, Easing.SinInOut);
            await splashImage.RotateTo(-5, 150, Easing.SinInOut);
            await splashImage.RotateTo(0,  100, Easing.SinInOut);

            // After loading MainPage it gets navigated to the MenuPage
            Application.Current.MainPage = new MenuPage();
        }
    }
}