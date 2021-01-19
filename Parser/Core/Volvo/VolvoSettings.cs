using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core.Volvo
{
    class VolvoSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://volvogroupshop.ru/";
        public string Prefix { get; set; } = "";
        public int StartPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
