using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cursovaya
{
    class Files
    {
      private int path;
    public void getEconomCar()
        {
            Random rnd = new Random();
            path=rnd.Next(0,3);
            StreamReader sr = new StreamReader($@"Info\Econom\Car{path}.txt",System.Text.Encoding.UTF8);
            Console.WriteLine($"Марка автомобиля-{sr.ReadLine()}");
            Console.WriteLine($"Модель автомобиля-{sr.ReadLine()}");
            Console.WriteLine($"Номер автомобиля-{sr.ReadLine()}");
        }
        public void getKomfortCar()
        {
            Random rnd = new Random();
            int path = rnd.Next(0, 3);
            StreamReader sr = new StreamReader($@"Info\Komfort\Car{path}.txt", System.Text.Encoding.UTF8);
            Console.WriteLine($"Марка автомобиля-{sr.ReadLine()}");
            Console.WriteLine($"Модель автомобиля-{sr.ReadLine()}");
            Console.WriteLine($"Номер автомобиля-{sr.ReadLine()}");
        }
        public void getBusnessCar()
        {
            Random rnd = new Random();
            int path = rnd.Next(0, 3);
            StreamReader sr = new StreamReader($@"Info\Busness\Car{path}.txt", System.Text.Encoding.UTF8);
            Console.WriteLine($"Марка автомобиля-{sr.ReadLine()}");
            Console.WriteLine($"Модель автомобиля-{sr.ReadLine()}");
            Console.WriteLine($"Номер автомобиля-{sr.ReadLine()}");
        }
    }
}
