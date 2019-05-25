using JXTApp.Data.Services;
using System.Linq;
using Xamarin.Forms;

namespace JXTApp.Pages.Jobs
{
    public class SuccessPage : ContentPage
    {
        public SuccessPage(int jobId)
        {
            // After loading MainPage it gets navigated to the MenuPage
            Application.Current.MainPage = new MenuPage();

            Data.Models.Jobs job = JobsService.ListAll().FirstOrDefault(q => q.JobId == jobId);

            Button backButton = new Button { Text = "BACK HOME", HorizontalOptions = LayoutOptions.FillAndExpand };
            backButton.Clicked += (sender, e) =>
            {
                Application.Current.MainPage = new MenuPage();
            };

            Content = new StackLayout
            {
                Margin = new Thickness(10, 5),
                Children = {
                    new Image { Source = "header.jpg", Aspect = Aspect.AspectFill },
                    new Label { Text = $"You have successfully applied for the position of {job.JobName}.", Margin = new Thickness(30, 1), FontAttributes = FontAttributes.Bold, HorizontalTextAlignment = TextAlignment.Center },
                    backButton
                }
            };
        }
    }
}