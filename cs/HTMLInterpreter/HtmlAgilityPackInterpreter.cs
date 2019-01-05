using Common;
using HtmlAgilityPack;

namespace HTMLInterpreter
{
    public class HtmlAgilityPackInterpreter : IHTMLInterpreter
    {
        public string ApplyPermissions(string html)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            foreach (var node in doc.DocumentNode.SelectNodes("//*[@data-accordion-role]"))
            {
                if (node.GetAttributeValue("data-accordion-role", string.Empty).Contains("test-role"))
                {
                    //node.Attributes.Remove("data-accordion-role");
                }
                else
                {
                    node.Remove();
                }
            }

            return doc.DocumentNode.OuterHtml;
        }
    }
}
