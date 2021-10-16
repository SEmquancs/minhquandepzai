using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh2
{
    class bai2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tu nhien n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Tong cac so tu nhien tu 1 den n="+sum);
        }
    }
}
    
