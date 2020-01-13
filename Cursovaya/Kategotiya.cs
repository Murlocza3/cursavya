using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cursovaya
{
    class Kategotiya
    {
        public int prise;
        public int category;
        private int km = 7;
        public Kategotiya()
        {
            Console.WriteLine("Выберете категорию поездки \n 1 - Эконом \n 2 - Комфорт \n 3 - Бизнес \n 0 - Выход");
            category = int.Parse(Console.ReadLine());
            switch (category)
            {
                case 1:
                    prise = 25 * km;
                    break;

                case 2:

                  prise = 50 * km;
                    break;

                case 3:                
                    prise = 100 * km; 
                    break;

                default:
                    Console.WriteLine("Выберете конктретный тип");
                    break;
            }
        }
    }
} 

