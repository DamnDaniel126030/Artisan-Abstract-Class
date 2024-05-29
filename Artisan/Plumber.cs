using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    internal class Plumber : ArtisanClass
    {
        private int Experience;

        public Plumber(int experience, string name, int dailyFee) : base(name, dailyFee)
        {
            Experience = experience;
        }

        public override string ToString()
        {
            return $"Name of artisan: {Name1}\nHis/Her daily fee: {DailyFee1}\nHis/Her experience on the field: {Experience} years";
        }

        public override bool TakeJob(int day)
        {
            for (int i = 0; i < FreeDays1.Length; i++)
            {
                if (i + 1 == day && i != 0 && i != FreeDays1.Length - 1)
                {
                    if (FreeDays1[i - 1] == true && FreeDays1[i] == true && FreeDays1[i + 1] == true)
                    {
                        FreeDays1[i - 1] = false;
                        FreeDays1[i] = false;
                        FreeDays1[i + 1] = false;
                        return true;
                    }
                }
                if (i + 1 == day && i == 0)
                {
                    if(FreeDays1[0] == true && FreeDays1[1] == true && FreeDays1[2] == true)
                    {
                        FreeDays1[0] = false;
                        FreeDays1[1] = false;
                        FreeDays1[2] = false;
                        return true;
                    }
                }
                if (i + 1 == day && i == FreeDays1.Length - 1)
                {
                    if (FreeDays1[FreeDays1.Length - 1] == true && FreeDays1[FreeDays1.Length - 2] == true && FreeDays1[FreeDays1.Length - 3] == true)
                    {
                        FreeDays1[FreeDays1.Length - 1] = false;
                        FreeDays1[FreeDays1.Length - 2] = false;
                        FreeDays1[FreeDays1.Length - 3] = false;
                        return true;
                    }
                }
            }
            return false;

        }   
    }
}
