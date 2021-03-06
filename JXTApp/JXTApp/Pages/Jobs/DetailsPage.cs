﻿using JXTApp.Data.Services;
using System.Linq;
using Xamarin.Forms;

namespace JXTApp.Pages.Jobs
{
    public class DetailsPage : ContentPage
    {
        public DetailsPage(int jobId)
        {
            Data.Models.Jobs job = JobsService.ListAll().FirstOrDefault(q => q.JobId == jobId);

            Button backButton = new Button { Text = "BACK", HorizontalOptions = LayoutOptions.FillAndExpand };
            backButton.Clicked += (sender, e) =>
             {
                 Application.Current.MainPage = new IndexPage();
             };

            Button applyButton = new Button { Text = "APPLY", HorizontalOptions = LayoutOptions.FillAndExpand };
            applyButton.Clicked += (sender, e) =>
            {
                Application.Current.MainPage = new SuccessPage(job.JobId);
            };

            Content = new StackLayout
            {
                Margin = new Thickness(10, 5),
                Children = {
                    new Image { Source = "header.jpg", Aspect = Aspect.AspectFill },
                    new Label { Text = $"{job.JobName}", FontAttributes = FontAttributes.Bold },
                    new Label { Text = $"Salary: {job.SalaryLowerBand} - {job.SalaryUpperBand}." },
                    new Label { Text = $"Description: {job.Description}." },
                    //backButton,
                    applyButton
                }
            };
        }
    }
}