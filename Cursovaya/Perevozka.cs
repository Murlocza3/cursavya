using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cursovaya
{
    class Perevozka
    {
        private DateTime data;
        private DateTime thisDay;
        private DateTime timecoming;
        private string from;
        private string whither;
        private int sum;
        private int carmodul;
        private int skidka;
        private int skidka1;
        public Perevozka()
        {
            Zakazchik zakazchik = new Zakazchik();

            data = DateTime.Now;
            from = zakazchik.adres;
            whither = zakazchik.kuda;
            Kategotiya kategotiya = new Kategotiya();
            carmodul = kategotiya.category;
            sum = kategotiya.prise;

            Company company = new Company();
            string c = company.name;
            string t = company.tele;
            string ad = company.addres;




            Console.WriteLine("Дата оформления заявки-" + data);
            thisDay = DateTime.Today;
            Console.WriteLine("Дата отправления -" + thisDay.ToString("D"));
            string curTimeLong = DateTime.Now.ToLongTimeString();
            timecoming = DateTime.Parse(curTimeLong);
            timecoming = timecoming.AddMinutes(10);
            Console.WriteLine("Время прибытия машины-" + timecoming.ToString("T"));
            Console.WriteLine("Машина приедет на адрес-" + from);
            Console.WriteLine("Адрес места назначения-" + whither);
            if (carmodul == 1)
            {
                Console.WriteLine("Ваш тип поездки-Эконом");
                Console.WriteLine($"Ваша стоимость поезки-{sum} рублей ");
            }
            if (carmodul == 2)
            {
                Console.WriteLine("Ваш тип поездки-Комфорт");
                Console.WriteLine($"Ваша стоимость поезки-{sum} рублей ");
            }
            if (carmodul == 3)
            {
                Console.WriteLine("Ваш тип поездки-Бизнес");
                Console.WriteLine($"Ваша стоимость поезки-{sum} рублей ");
            }
            ckidka();

            Files files = new Files();
             if (carmodul == 1)
            {
                files.getEconomCar();

            }
               if (carmodul == 2)   
            {
                    files.getKomfortCar();              
            }
                if (carmodul == 3)
                {
                    files.getBusnessCar();
                }

                Console.WriteLine("**************************************");
                Console.WriteLine("Компании перевозчика-" + c);
                Console.WriteLine("Телфон компании-" + t);
                Console.WriteLine("Адрес перевозчика-" + ad);
            
        }
            public void ckidka()
            {
                Console.WriteLine("Если у вас купон на скидку ? \n 1-Да \n 2-Нет");
                skidka = int.Parse(Console.ReadLine());

                switch (skidka)
                {
                    case 1:
                        Console.WriteLine("Введите промокод");
                        skidka1 = int.Parse(Console.ReadLine());
                        switch (skidka1)
                        {
                            case 50:
                                Console.WriteLine($"Ваша стоимость поезки-{sum / 2} рублей ");
                                break;
                            case 30:
                                Console.WriteLine($"Ваша стоимость поезки-{sum * 30 / 100} рублей ");
                                break;
                            default:
                                Console.WriteLine($"Промокод не действителен \nВаша стоимость поезки-{sum} рублей ");
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine($"Ваша стоимость поезки-{sum} рублей ");
                        break;
                    default:
                        Console.WriteLine($"Неверное условие\nВаша стоимость поезки-{sum} рублей ");
                        break;
                }
            }
        
    }
}
