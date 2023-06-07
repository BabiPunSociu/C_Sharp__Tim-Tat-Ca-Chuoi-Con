using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimTatCaChuoiCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập chuỗi: ");
            string inputString = Console.ReadLine();

            Console.WriteLine("Tất cả các chuỗi con là: ");

            for(int i=0;i < inputString.Length;i++)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for(int j=i;j < inputString.Length;j++)
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
                Console.WriteLine();
            }    
        }
    }
}
