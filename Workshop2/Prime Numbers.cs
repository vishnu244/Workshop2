using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    public class Prime_Numbers
    {
        public void primeNumber()
        {
            int num, i, count, start, end;

            Console.Write("start number:");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("End Number:");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Numbers Between {0} and {1} are: ",start,end);

            for (num = start; num <= end; num++)
            {
                count = 0;

                for (i = 2; i <= num/2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;

                    }
                }
                if (count == 0 && num != 1)
                    Console.Write("{0} ",num);
            }
        }
    }
}
