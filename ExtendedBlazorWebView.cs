using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.FileProviders;

namespace CleanMauiBlazorVideoPlayer
{
  internal class ExtendedBlazorWebView : BlazorWebView
  {
    public override IFileProvider CreateFileProvider(string contentRootDir)
    {
      var baseFileProvider = base.CreateFileProvider(contentRootDir);
      return new CompositeFileProvider(
        new VideoFileProvider(),
        baseFileProvider);
    }
  }
}