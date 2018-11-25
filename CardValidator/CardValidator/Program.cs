using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardValidator
{
    class Program
    {
        static void Main(string[] args)
        {                 
            Console.WriteLine("Введите номер карты");
            string CardNumber = Console.ReadLine();
            LuhnAlgorithm(CardNumber);             
            Console.ReadKey();                        
        }

        static void LuhnAlgorithm(String name)
        {
            int y = 0;
            int z = 0;
            int len = name.Length;
            if (len % 2 == 0)
            {                
                for (int i = 0; i < len; i = i + 1)
                {
                    if (i % 2 == 0)
                    {
                        int x = (Convert.ToInt32(name[i].ToString())) * 2;
                        if (x > 9)
                        {
                            x = x - 9;
                        }
                        y += x;
                    }
                    else
                    {
                        int x = Convert.ToInt32(name[i].ToString());                       
                        z += x;
                    }
                }

            } 
            
            else
            {                
                for (int i = 0; i < len; i = i + 1)
                {
                    if (i % 2 != 0)
                    {
                        int x = (Convert.ToInt32(name[i].ToString())) * 2;
                        if (x > 9)
                        {
                            x = x - 9;
                        }
                        y = y + x;                        
                    }
                    else
                    {
                        int x = Convert.ToInt32(name[i].ToString());
                        z += x;
                    }
                                        
                }

            }
                        
            if ((z + y) % 10 == 0)
            {
                Console.WriteLine("Номер карты валидный");
            }
            else
            {
                Console.WriteLine("Номер карты невалидный");
            }
            
        }
    }
}
