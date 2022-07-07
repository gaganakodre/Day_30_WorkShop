using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//m0 = m + 12 × ((14 − m) / 12) − 2
//d0 = (d + x + 31m0 / 12) mod 7
//y0 = y − (14 − m) / 12
//x = y0 + y0 / 4 − y0 / 100 + y0 / 400
namespace WorkShopProblem
{
    public class WorkShopProblem
    {
        public int m, d, m0, d0,y0,y,x;

        
        public void DayAndMonth()
        {
            Console.WriteLine("enter the value of m");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of d");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of m");
            m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of d");
            d = Convert.ToInt32(Console.ReadLine());
            y0= y-(14-m)/12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = m + 12 * ((14 - m) / 12) - 2;
            d0 = (d + x + (31 * m0) / 12) % 7;
           
            
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("inavlid");
                    break;
                    

            }
        }

    }
}
