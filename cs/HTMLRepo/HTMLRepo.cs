using System.IO;
using Common;

namespace HTMLRepo
{
    public class HTMLRepo : IHTMLRepo
    {
        public string GetHTMLPage(string filename)
        {
            var path = @"Repo";

            return File.ReadAllText(Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), path, filename));
        }
    }
}
