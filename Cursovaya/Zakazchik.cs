using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cursovaya
{
    class Zakazchik
    {
        private string phone_number;
        public string adres;
        public string kuda;
        private int count = 0;
        private bool check = true;
        private int n = 0;

        public Zakazchik()
        {
        

        Console.WriteLine("Введите номер телефона-");

            proverka();
                                                 
            Console.WriteLine("Введите ваш адрес");
            adres = Console.ReadLine();

            Console.WriteLine("Куда ехать?");
            kuda = Console.ReadLine();
        }
        private void proverka()
        {
        
            do
            {
                n++;
                check = true;
                phone_number = (Console.ReadLine());
                count = 0;
                foreach (char c in phone_number)
                {
                    if (!char.IsDigit(c))
                    {
                        check = false;
                        Console.WriteLine("Некорректно номер телефона.");
                    }
                    count++;
                }
                if (count != 11)
                {
                    Console.WriteLine("Некорректный номер телефона.");
                }
                if (n == 10)
                {
                    Console.WriteLine("ТЫ ДАУН????");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            } while (count != 11 && check == true);
        }
    }
}
