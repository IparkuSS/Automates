using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Adress = "adress";
            library.Name = "Name";
            library.YerOpen = 5;
            Console.WriteLine($"adress - {library.Adress}, Name - {library.Name} Yer = {library.YerOpen}");

        }
    }}

