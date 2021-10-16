using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vong_lap_for_while
{
    class bai4b
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n:");
            int n = Convert.ToInt32(Console.ReadLine());            
            if(n>0)
            {
                int sum = 0;
                int sumLe = 0;
                int nLe = 0;
                int sumChan = 0;
                int nChan = 0;
                for (int i = 1; i <=n; i++)
                {
                    sum += i;
                    
                    if(i%2==1)
                    {
                        sumLe += i;
                        nLe += 1;
                    }
                    if (i % 2 == 0)
                    {
                        sumChan += i;
                        nChan += 1;
                    }
                }
                Console.WriteLine("a)TOng cac so nguyen tu 1 den n = "+sum );
                Console.WriteLine("TBC cac so nguyen tu 1 den n = "+(sum*1f/n));
                Console.WriteLine();
                Console.WriteLine("b)TOng cac so le = "+sumLe);
                Console.WriteLine("Tbc cac so le ="+(sumLe*1f/nLe));
                Console.WriteLine();
                Console.WriteLine("c)TOng cac so chan= "+sumChan);
                Console.WriteLine("Tbc cac so chan= "+(sumChan*1f/nChan));               
            }else
                Console.WriteLine("Nhap so nguyen n>0");

        }
    }
}
