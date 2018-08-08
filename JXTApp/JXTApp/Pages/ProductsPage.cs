using Xamarin.Forms;

namespace JXTApp.Pages
{
    public class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            TableView tableView = new TableView
            {
                Margin = new Thickness(10, 5, 0, 5),
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection
                    {
                        new ImageCell
                        {
                            ImageSource = "Pintros.jpg",
                            Text = "Pintros",
                            Detail = "Ever heard of a 'Reverse Job Board'? Where, instead of jobs currently open with recruiters, candidates currently open to new jobs are the main attraction?"
                        },
                        new ImageCell
                        {
                            ImageSource = "RecruiterDirectory.jpg",
                            Text = "Recruiter Directory",
                            Detail = "The Recruiter Directory is the fastest growing database of Recruitment Agencies, Job Boards, HR & Talent Solution Providers in Australia."
                        },
                        new ImageCell
                        {
                            ImageSource = "mintii.jpg",
                            Text = "mintii",
                            Detail = "mintii is the latest SaaS product offering from JXT, Australia's only integrated digital recruitment solutions provider."
                        },
                        new ImageCell
                        {
                            ImageSource = "SalarySpy.jpg",
                            Text = "SalarySpy",
                            Detail = "SalarySpy is a smart salary survey tool that recruiters can quickly and simply embed into their websites, for tracking salaries in their sector or niche."
                        },
                        new ImageCell
                        {
                            ImageSource = "Payboss.jpg",
                            Text = "Payboss",
                            Detail = "Payboss is a waaaay easy-to-navigate, can't-get-it-wrong timesheet & expense management system."
                        }
                    }
                }
            };

            Content = new StackLayout
            {
                Children =
                {
                    tableView
                }
            };
        }
    }
}