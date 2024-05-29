using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Specialist specialist = new Specialist();
            specialist.AddArtisansFromFile("specialists.txt");
            specialist.ListArtisans();
        }
    }
}
