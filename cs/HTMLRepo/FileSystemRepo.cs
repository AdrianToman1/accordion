using System.IO;
using Common;

namespace HTMLRepo
{
    public class FileSystemRepo : IHTMLRepo
    {
        public string GetHTMLPage(string filename)
        {
            var path = @"Repo";

            return File.ReadAllText(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), path, filename));
        }
    }
}
