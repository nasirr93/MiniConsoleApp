using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageMiniConsoleApp
{
    internal interface IStore
    {
        List<Product> Products { get; }
        int ProductLimit { get; }
        double TotalIncome { get; }
        void AddProduct(Product product);
        void SellProduct(string productNo);
        void ShowProducts();
    }
}
