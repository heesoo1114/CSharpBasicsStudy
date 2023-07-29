using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221017
{
    internal interface INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
