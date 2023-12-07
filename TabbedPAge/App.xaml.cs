using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Application = Microsoft.Maui.Controls.Application;
using TabbedPage = Microsoft.Maui.Controls.TabbedPage;

namespace TabbedPAge;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
        var tabbedPage = new TabbedPage
            {
                Children =
                {
                    new ContentPage() { Title = "Page1"}
                    ,new ContentPage() { Title = "Page2"}
                    ,new ContentPage() { Title = "Page3"}
                
                }
            };

        tabbedPage.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
            .SetToolbarPlacement(ToolbarPlacement.Bottom);

        MainPage = tabbedPage;
    }
}