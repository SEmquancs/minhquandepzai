using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vong_lap_for_while
{
    class bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tu nhien n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cac so le se la :");
            for (int i = 0; i <= n; i++)
            {
                if(i%2==1)
                {
                    Console.Write(i +" ");
                }             
            }
            Console.WriteLine();

            Console.WriteLine("Cac so chan se la :");
            for (int i = 0; i <=n; i++)
            {
                if(i%2==0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();          
        }   
    }
}
