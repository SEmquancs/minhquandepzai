using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vong_lap_for_while
{
    class bai5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen duong n=");
            int n = Convert.ToInt32(Console.ReadLine());
            long sum = 0;
            long quyLuat = 1;

            for (int i = 1; i <=n; i++)
            {               
                quyLuat *= i;
                sum += quyLuat;
            }
            Console.WriteLine("Tong cac so tu 1 den n theo quy luat giai thua = "+(sum);
        }
    }
}
