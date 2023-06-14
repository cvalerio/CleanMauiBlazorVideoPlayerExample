using Microsoft.AspNetCore.Components.WebView.Maui;

namespace CleanMauiBlazorVideoPlayer;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

    ExtendedBlazorWebView wv = new()
    {
      HostPage = "wwwroot/index.html"

    };
    wv.RootComponents.Clear();

    RootComponent rc = new()
    {
      Selector = "#app",
      ComponentType = typeof(Main),
    };
    wv.RootComponents.Add(rc);

    Content = wv;
	}
}
