using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Artisan
{
    internal class Specialist
    {
        public List<ArtisanClass> artisans;

        public Specialist()
        {
            artisans = new List<ArtisanClass>();
        }

        public void AddArtisansFromFile(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            string[] properties;
            string specialization;
            string name;
            int dailyFee;
            string areaOfExpertise;
            int yearsOfExperience;

            foreach (string line in lines)
            {
                properties = line.Split(';');
                specialization = properties[0];
                name = properties[1];
                dailyFee = int.Parse(properties[2]);
                areaOfExpertise = properties[3];
                yearsOfExperience = 0;

                if (specialization == "Tiler" && areaOfExpertise != "-")
                {
                    if (areaOfExpertise == "Indoor")
                    {
                        artisans.Add(new Tiler(name, dailyFee, Location.Indoor));
                    }
                    else
                    {
                        artisans.Add(new Tiler(name, dailyFee, Location.Outdoor));
                    }
                }
                if (specialization == "Plumber" && yearsOfExperience != 0)
                {
                    yearsOfExperience = int.Parse(properties[4]);
                    artisans.Add(new Plumber(yearsOfExperience, name, dailyFee));
                }
                
            }
        }

        public void ListArtisans()
        {
            Console.WriteLine("What type of specialists do you need information about? (Tiler or Plumber)");
            string specialization = Console.ReadLine();

            foreach (var artisan in artisans)
            {
                if(specialization == "Tiler" && artisan is Tiler)
                {
                    Console.WriteLine(artisan.ToString());
                }
                else if (specialization == "Plumber" && artisan is Plumber)
                {
                    Console.WriteLine(artisan.ToString());
                }
            }
        }
    }
}
