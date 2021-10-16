using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vong_lap_for_while
{
    class bai3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n:");
            int n = Convert.ToInt32(Console.ReadLine());
            float sum = default;
            for (int i = 1; i <=n; i++)
            {
                sum += 1f / i;

            }
            Console.WriteLine("TOng cac so nguyen = "+sum);
        }
    }
}
