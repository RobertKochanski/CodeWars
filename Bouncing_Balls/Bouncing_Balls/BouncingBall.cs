using System;
using System.Collections.Generic;
using System.Text;

namespace Bouncing_Balls
{
    public class BouncingBall
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h > 0 && (bounce < 1 && bounce > 0) && window < h)
            {
                int count = 1;
                h *= bounce;

                for (; h > window; h *= bounce)
                {
                    count += 2;
                }

                return count;
            }

            return -1;
        }
    }
}
