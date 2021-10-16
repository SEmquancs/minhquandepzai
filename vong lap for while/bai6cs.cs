using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vong_lap_for_while
{
    class bai6cs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen k=");
            int k = Convert.ToInt32(Console.ReadLine());
            
            int sumchiaHetchok = 0;
            for (int i = 1; i <=n; i++)
            {
                if(i%k==0)
                {
                    sumchiaHetchok += i;                    
                }
            }
            Console.WriteLine("Tong cac so  tu nhien chia het cho k = "+sumchiaHetchok);

        }   

    }
}
