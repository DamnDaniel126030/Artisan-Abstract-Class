using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    internal class Tiler : ArtisanClass
    {
        private Location areaOfExpertise;

        public Tiler(string name, int dailyFee, Location specialization) : base(name, dailyFee)
        {
            areaOfExpertise = specialization;
        }

        public int NumberOfFreeDays()
        {
            int numOfFreeDays = 0;

            foreach(bool day in FreeDays1)
            {
                if (day)
                {
                    numOfFreeDays++;
                }
            }
            return numOfFreeDays;
        }

        public override string ToString()
        {
            return $"Name of Tiler: {Name1}\nHis/Her daily fee: {DailyFee1}\nHis/Her area of expertise: {areaOfExpertise}";
        }

        public override bool TakeJob(int day)
        {
            for (int i = 0; i < FreeDays1.Length; i++)
            {
                if(i + 1 == day)
                {
                    FreeDays1[i] = false;
                    return true;
                }
            }
            return false;
        }


    }
}
