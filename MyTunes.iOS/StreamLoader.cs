using System.IO;

namespace MyTunes
{
    public class StreamLoader: IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return File.OpenRead(filename);
        }
    }
}
