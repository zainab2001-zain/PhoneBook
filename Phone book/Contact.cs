using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book
{
    class Contact
    {
        public Contact(string number,string name)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
