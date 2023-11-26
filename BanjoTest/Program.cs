using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanjoTest
{
    internal class Program
    {
        public static string AreYouPlayingBanjo(string name)
        {

            string message;
            char firstLetter = name[0];
            if (firstLetter == 'R' || firstLetter == 'r')
            {
                message = (" plays banjo");
            }
            else
            {
                message = (" does not play banjo");
            }

            return name + message;
        }
    }
}
