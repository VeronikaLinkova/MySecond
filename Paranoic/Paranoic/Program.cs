using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paranoic
{
    class Program
    {
        

        public DateTime for_date { set; get; }

        
        static void Main(string[] args)
        {

            string text1 = "Введите имя задачи:";
            Console.WriteLine(text1);
            String val1 = ValueCheck(text1);

            string text2 = "Введите дату начала задачи:";
            Console.WriteLine(text2);
            DateTime val2 = ValueData();



            string text3 = "Введите дату окончания задачи:";
            Console.WriteLine(text3);
            DateTime val3 = ValueData();
            bool flag = true;            
            while (flag)
            {
                                
                if (val3 < val2)
                {
                    Console.WriteLine("Дата завершения задачи не может быть меньше даты начала");
                    val3 = ValueData();

                }
                else
                {
                    flag = false;
                }
            }

            

            string text4 = "Введите оценку задачи по времени:";
            Console.WriteLine(text4);
            uint val4 = ValueInt();

            string text5 = "Введите описание задачи:";
            Console.WriteLine(text5);
            String val5 = ValueCheck(text5);
            Console.WriteLine(val1 + " " + val2 + " " + val3 + " " + val4 + " " + val5);
            Console.ReadKey();

        }

        public static String ValueCheck(string text)
        {
            bool flag = true;
            String Name = "";
            while (flag)
            {

                Name = Console.ReadLine();
                int i = Name.Length;
                if (i == 0)
                {
                    Console.WriteLine(text);

                }
                else
                {
                    flag = false;
                }
                
            }
            return Name;
                  
            
        }

        public static DateTime ValueData()
        {
            bool flag1 = true;
            DateTime EndDate = new DateTime();
            while (flag1)
            {
                string input = Console.ReadLine();
                try
                {                    
                    EndDate = Convert.ToDateTime(input).Date;                    
                    flag1 = false;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
                
            }
            return EndDate;
        }

        public static uint ValueInt()
        {
            bool flag1 = true;
            uint val = 0;
            while (flag1)
            {
                string input = Console.ReadLine();
                try
                {                    
                    val = Convert.ToUInt32(input);                    
                    flag1 = false;
                }
                catch
                {
                    Console.WriteLine("Неверный формат ввода оценки по времени!");
                }

            }
            return val;
        }

    }
}
