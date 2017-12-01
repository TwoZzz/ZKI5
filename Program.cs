using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKI5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Convert.ToString(Console.ReadLine());
            byte[] slovo = Encoding.Default.GetBytes(str);
            string str1 = Convert.ToString(Console.ReadLine());
            byte[] key = Encoding.Default.GetBytes(str1);
            //byte[] shifr = new byte[slovo.Length];
            int b = 0;
            int b1 = 0;
            byte[] deShifr = new byte[slovo.Length];
            byte[] shifr = new byte[slovo.Length];
            int j1 = 0;
            for (int i = 0; i < slovo.Length; i++)
            {
                for (int j = j1; j < key.Length; )
                {
                    Console.WriteLine(slovo[i]);
                    Console.WriteLine(key[j]);
                    b = slovo[i]^key[j];
                    Console.WriteLine(b);
                    shifr[i] = (byte)b;
                    j1++;
                    if (j1 == key.Length)
                    {
                        j1 = 0;
                    }
                    else
                        break;
                    break;
                }
            }
            j1 = 0;
            Console.WriteLine(Encoding.ASCII.GetString(shifr));
            for (int i = 0; i < shifr.Length; i++)
            {
                for (int j = j1; j < key.Length; j++)
                {
                    b1 = shifr[i] ^ key[j];
                    deShifr[i] = (byte)b1;
                    j1++;
                    if (j1 == key.Length)
                    {
                        j1 = 0;
                    }
                    else break;
                    break;
                }
            }
            Console.WriteLine(Encoding.ASCII.GetString(deShifr));
                Console.ReadKey();
        }
    }
}
