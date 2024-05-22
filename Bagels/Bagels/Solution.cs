using Bagels;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Solution
{

    class BagelSolver
    {
        public static Bagel Bagel
        {
            get
            {
                var bagel = new Bagel();
                PropertyInfo propertyInfo = typeof(Bagel).GetProperty("Value");
                propertyInfo.SetValue(bagel, 4);
                return bagel;
            }
        }
    }
}