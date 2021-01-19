using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core.Volvo
{
    class VolvoParser : IParser<string[]>
    {
        public string[] Parser(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("product-table__qty"));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
