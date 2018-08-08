using JXTApp.Data.Services;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace JXTApp.Pages.Jobs
{
    public class IndexPage : ContentPage
    {
        public IndexPage()
        {
            var jobs = JobsService.ListAll();

            Dictionary<int, string> source = new Dictionary<int, string>();

            foreach (var job in jobs)
            {
                source.Add(job.JobId, $"{job.JobId.ToString("0000000")} :: {job.JobName}");
            }

            ListView listView = new ListView
            {
                ItemsSource = source.Select(q => q.Value)
            };

            listView.ItemTapped += (sender, e) =>
            {
                string title = (string)((ListView)sender).SelectedItem;
                int jobId = source.FirstOrDefault(q => q.Value == title).Key;
                string message = jobs.FirstOrDefault(q => q.JobId == jobId).Description;

                DisplayAlert(title, message, jobId);

                ((ListView)sender).SelectedItem = null;
            };

            Content = listView;
        }

        #region DisplayAlert

        /// <summary>
        /// Display Alert Modal
        /// </summary>
        /// <param name="title">Title which should be displayed in the alert</param>
        /// <param name="message">Message which should be displayed in the alert</param>
        /// <param name="jobId">Job ID</param>
        private async void DisplayAlert(string title, string message, int jobId)
        {
            bool show = await DisplayAlert(title, message, "SHOW DETAILS", "CANCEL");

            if (show)
            {
                //Application.Current.MainPage = new DetailsPage(jobId);
                await Navigation.PushModalAsync(new DetailsPage(jobId));
            }
        }

        #endregion
    }
}