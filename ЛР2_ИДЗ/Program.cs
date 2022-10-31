using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2_ИДЗ
{
    class Programm
    {
        static void Main(string[] args)
        {

            Sklad.Initial();
            Console.WriteLine("Склад готов к работе");
            Console.Write("Как к вам обращаться? ");
            string fio = Console.ReadLine();
            Console.WriteLine("Уважаемый " + fio + ", выберите действие\n" +
                "1-Вывод списка товаров\n" +
                "2-Добавть товар\n" +
                "0-Выход");
            int doIt = int.MaxValue;
            while (doIt > 0)
            {
                Console.Write("Ваш выбор: ");
                doIt = int.Parse(Console.ReadLine());
                switch (doIt)
                {
                    case 1:
                        Sklad.GetList();
                        break;
                    case 2:
                        Sklad.Add();
                        break;
                    case 0:
                        doIt = 0;
                        break;
                    default: break;

                }
            }
            Console.ReadLine();
        }
    }
}