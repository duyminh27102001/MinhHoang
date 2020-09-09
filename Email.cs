using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1907A.EmailPages
{
    class Email
    {
        public string Name { get; set; }
        public string TieuDe { get; set; }
        public string Content { get; set; }

        public Email(string name, string tieude, string content)
        {
            this.Name = name;
            this.TieuDe = tieude;
            this.Content = content;
        }
        public override string ToString()
        {
            return Name + "--" + TieuDe + "--" + Content;
        }
    }
}
