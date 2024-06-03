using System;
using System.Collections.Generic;
using System.Text;

namespace How_Much
{
	public class Carboat
	{
		public static string howmuch(int m, int n)
		{
			int min, max;
			List<int> f = new List<int>();
			List<int> c = new List<int>();
			List<int> b = new List<int>();
			if ((0 <= m && m <= n) || (m >= n && n >= 0))
            {
				if(n > m)
                {
					min = m;
					max = n;
                }
                else
                {
					min = n;
					max = m;
				}

                for (int i = min; i <= max; i++)
                {
                    if (i % 9 == 1 && i % 7 == 2)
                    {
						f.Add(i);
						c.Add(i / 9);
						b.Add(i / 7);
                    }
                }

				List<string> temp = new List<string>();

				for (int j = 0; j < f.Count; j++)
                {
					temp.Add($"[M: {f[j]} B: {b[j]} C: {c[j]}]");
                }

				string z = "";

                foreach (var element in temp)
                {
					z += element;
                }

				return $"[{z}]";
            }

			return "[]";
		}
	}
}
