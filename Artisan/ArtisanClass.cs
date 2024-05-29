using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    internal abstract class ArtisanClass
    {
        private string Name;
        private int DailyFee;
        private bool[] FreeDays;

        public ArtisanClass(string name, int dailyFee)
        {
            Name = name;
            DailyFee = dailyFee;
            FreeDays = new bool[31];
            for (int i = 0; i < FreeDays.Length; i++)
            {
                FreeDays[i] = true;
            }
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public int DailyFee1
        {
            get => DailyFee;
            set => DailyFee = value;
        }

        public bool[] FreeDays1
        {
            get => FreeDays;
            set => FreeDays = value;
        }

        public override string ToString()
        {
            return $"Name of the artisan: {Name}\nHis/Her daily fee: {DailyFee}";
        }

        public abstract bool TakeJob(int day);
    }
}
