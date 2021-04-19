using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {

        public string Name { set; get; }
        public string Adress { set; get; }
        public int YerOpen { set; get; }
        public Library(string Name, string Adress, int YerOpen)
        {
            this.Adress = Adress;
            this.Name = Name;
            this.YerOpen = YerOpen;

        }
    }

}
