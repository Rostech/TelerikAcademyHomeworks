using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_rugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int widthHeight = 2 * n + 1;
            int r = n-(n - (d/2 + 1));
            int l = n + (n - (d / 2 + 1));
            int rDown = 0;
            int lDown = widthHeight-1;
            for (int i = 0; i < widthHeight; i++)
            {
                for (int j = 0; j < widthHeight; j++)
                {
                    // print X
                    if((j == n && (i == (n - (d/2+1))|| i== (n + (d/2+1))))
                        || (j == (n + (d / 2 + 1)) || j == (n - (d / 2 + 1))) && i == n)
                    {
                        Console.Write("X");
                    }

                    else if (j > rDown && j <= r - 1 || (j==0 && i < ( n-(n-(d/2+1))  )))// || (j > rDown && i < (n-(d/2+1)) && j < r))
                    {
                        Console.Write("#");
                    }
                    else if((j > l && j < lDown) || (j == widthHeight-1 && i < (n-(n - (d/2+1))) ))
                    {
                        Console.Write("#");
                    }
                    //pring \
                    else if(j == r &&  (i < (n - (d/2+1))|| i> n))
                    {
                        Console.Write("\\");
                    }
                    //print /
                    else if (j == l && (i < (n - (d / 2 + 1)) || i > n))
                    {
                        Console.Write("/");
                    }
                        // print \ down
                    else if (j == rDown && ((i >= n - (n - (d / 2 + 1)) && i <= n) || 
                       ((i >= n - (n - (d / 2 + 1))))))
                    {
                        Console.Write("\\");
                    }
                        // print / down
                    else if (j == lDown && ((i >= n - (n - (d / 2 + 1)) && i <= n) ||
                       ((i >= n - (n - (d / 2 + 1))))))
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                if (i >= n - (n - (d / 2 + 1)))
                {
                    rDown++;
                    lDown--;
                }
                r++;
                l--;
                Console.WriteLine();
            }
        }
    }
}
