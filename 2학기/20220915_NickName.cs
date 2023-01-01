using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220915
{
    internal class NickName
    {
        private Hashtable names = new Hashtable();

        public string this[string i]
        {
            get
            {
                string a = names[i].ToString();
                return a;
            }

            set
            {
                names[i] = value;
            }   
        }
    }
}
