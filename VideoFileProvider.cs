using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace CleanMauiBlazorVideoPlayer
{
  internal class VideoFileProvider : IFileProvider
  {
    public VideoFileProvider()
    {
    }

    public IDirectoryContents GetDirectoryContents(string subpath)
    {
      throw new NotImplementedException();
    }

    public IFileInfo GetFileInfo(string subpath)
    {
      if (subpath.StartsWith("videos"))
      {
        return new VideoFileInfo(subpath);
      }
      return new NotFoundFileInfo(subpath);
    }

    public IChangeToken Watch(string filter)
    {
      throw new NotImplementedException();
    }
  }
}