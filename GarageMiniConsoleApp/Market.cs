using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GarageMiniConsoleApp
{
    internal class Market : IStore
    {
        private List<Product> _products;
        public List<Product> Products
        {
            get { return _products; }
        }

        public Market()
        {
            _products = new List<Product>();
        }

        public int ProductLimit { get; } = 100;

        public double TotalIncome{ get; private set; }
        public void AddProduct(Product product)
        {
            if (_products.Count < ProductLimit && !_products.Exists(p => p.No == product.No))
            {
                _products.Add(product);
                Console.WriteLine(product.Name +" "+ "Elave edildi");
            }
            else
            {
                Console.WriteLine("Mumkun olmadi");
            }
        }

        public void SellProduct(string productNo)
        {
            Product product = _products.Find(p => p.No == productNo);

            if (product != null && product.Count > 0)
            {
                product.Count--;
                TotalIncome += product.Price;
                Console.WriteLine(product.Name +" "+ "Mehsul satildi");
            }
            else
            {
                Console.WriteLine("Mehsul tapilmadi");
            }
        }

        public void ShowProducts()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine($"No: {product.No} \r\n Adi: {product.Name} \r\n Sayi: {product.Count} \r\n Qiymeti: {product.Price} \r\n Umumi gelir: {TotalIncome}");
            }
        }
    }
}