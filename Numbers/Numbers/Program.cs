using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Order("45 34 24 108 76 58 64 130 80"));
           Console.WriteLine(Order("    2022 70 123    3344 13 "));
        }

        static string Order(string input)
        {
            List<NewWeight> newWeights = new List<NewWeight>();

            foreach (var str in input.Split(new char[] { ' ' }))
            {
                if(str.Length > 0)
                {
                    int newWeight=0;

                    foreach(var num in str.ToCharArray())
                    {
                        newWeight += Convert.ToInt32(num.ToString());
                    }
                    NewWeight weight = new NewWeight(str, newWeight);
                    newWeights.Add(weight);
                }

            }

            string strWeight = string.Join(" ", newWeights.OrderBy(i => i.realWeaight).OrderBy(y => y.miracleWeight).Select(p => p.realWeaight));

            return strWeight;
        }
    }

    class NewWeight
    {
        public string realWeaight { get; set; }
        public int miracleWeight  { get; set; }

        public NewWeight(string realWeight, int miracleWeight)
        {
            this.realWeaight = realWeight;
            this.miracleWeight = miracleWeight;
        }

    }
}
