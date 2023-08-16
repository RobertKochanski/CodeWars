using System;

namespace Chasers_schedule
{
    public class Chaser
    {
        public static int SpeedAndTime(int s, int t)
        {
            var distance = s * t;
            var maxSprints = Math.Ceiling((decimal)t / 2);

            //RRS => 2 + 2 + 2*2 = 8

            for (int i = 0; i <= maxSprints; i++)
            {
                if (s - 3 * i > 0)
                {
                    distance += s - 3 * i;
                }
            }

            return distance;
        }
    }
}
