using Microsoft.Extensions.FileProviders;

namespace CleanMauiBlazorVideoPlayer
{
  internal class VideoFileInfo : IFileInfo
  {
    private string subpath;
    private Stream stream;

    public VideoFileInfo(string subpath)
    {
      this.subpath = subpath;
      var assembly = typeof(VideoFileInfo).Assembly;
      this.stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.mov_bbb.mp4");
    }

    public bool Exists => true;

    public long Length => stream.Length;

    public string PhysicalPath => subpath;

    public string Name => subpath;

    public DateTimeOffset LastModified => DateTimeOffset.UtcNow;

    public bool IsDirectory => false;

    public Stream CreateReadStream()
    {
      return stream;
    }
  }
}