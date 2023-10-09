using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GarageMiniConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            
            while (true)
            {
                Console.WriteLine("\r\nMenu: ");

                Console.WriteLine("1.Product elave et");
                Console.WriteLine("2.Product sat");
                Console.WriteLine("3.Productlara bax");
                Console.WriteLine("4.Menudan çıx");


                string secim = Console.ReadLine();


                switch (secim)
                {
                    case "1":
                        Console.WriteLine("No: ");
                        string noStr;
                        int no;
                        do
                        {
                           noStr = Console.ReadLine();
                        } while (!int.TryParse(noStr, out no));

                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Price: ");
                        string priceStr;
                        double price;
                        do
                        {
                            priceStr = Console.ReadLine();
                        } while (!double.TryParse(priceStr,out price));

                        Console.WriteLine("Count: ");
                        string countStr;
                        int count;
                        do
                        {
                            countStr = Console.ReadLine();
                        } while (!int.TryParse(countStr,out count));

                        Product product = new Product
                        {
                            No = noStr,
                            Name = name,
                            Price = price,
                            Count= count
                        };
                        market.AddProduct(product);
                        break;




                    case "2":
                        Console.WriteLine("Mehsul No daxil edin: ");
                        string productNo = Console.ReadLine(); ;
                        market.SellProduct(productNo);
                        break;




                    case "3":
                        Console.WriteLine("Marketdeki mehsullar: ");
                        market.ShowProducts();
                        break;



                    case "4":
                        Console.WriteLine("Proqramdan cixilir...");
                        return;



                    default:
                        Console.WriteLine("Yanlis secim ! Yeniden cehd edin");
                        break;
                }
            }


        }
    }
}
