using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directions_Reduction
{
    public class DirReduction
    {
        public static string[] dirReduc(String[] arr)
        {
            List<string> result = new List<string>();

            int N = 0, S = 0, W = 0, E = 0;

            foreach (var a in arr)
            {
                if (a.ToUpper() == "NORTH") N++;
                if (a.ToUpper() == "SOUTH") S++;
                if (a.ToUpper() == "WEST") W++;
                if (a.ToUpper() == "EAST") E++;
            }

            var x = N - S;
            var y = E - W;

            if (x > 0)
            {
                for (int i = 0; i < x; i++)
                {
                    result.Add("NORTH");
                }
            }
            else
            {
                for (int i = 0; i > x; i--)
                {
                    result.Add("SOUTH");
                }
            }

            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result.Add("EAST");
                }
            }
            else
            {
                for (int i = 0; i > y; i--)
                {
                    result.Add("WEST");
                }
            }

            return result.ToArray();
        }
    }
}
