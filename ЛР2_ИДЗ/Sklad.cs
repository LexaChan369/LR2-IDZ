using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2_ИДЗ
{
    internal class Sklad
    {
        public static List<Product> products = new List<Product>();

        public static void Initial()
        {
            var product=new Product();
            product.price = 500;
            product.name = "Mango";
            products.Add(product);
            product = new Product();
            product.price = 1300;
            product.name = "t-shirt";
            products.Add(product);
        }

        public static void Add()
        {
            var product=new Product();
            Console.WriteLine("Введите название товара:");
            product.name = Console.ReadLine();
            Console.WriteLine("Введите цену товара:");
            product.price = int.Parse(Console.ReadLine());
            products.Add(product);
            Console.WriteLine("Товар успешно добавлен");
        }

        public static void GetList()
        {
            if (products.Count != 0)
            {
                foreach (Product tariff in products)
                {
                    Console.WriteLine(tariff.price + "\n" + tariff.name );
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Список продуктов пуст");
            }
        }
    }
}
