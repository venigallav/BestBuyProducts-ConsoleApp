using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const String uri = "http://api.remix.bestbuy.com/v1/products(name=ipad*)?show=name,salePrice,preowned,mobileUrl&format=json&apiKey=YourAPIKey";
            Class1 c = new Class1();
            String json = c.GetData(uri);
            Console.WriteLine(json);
            parseJson pj = new parseJson();
           Rootobject r = pj.parsejson(json);
           foreach(Product p in r.products)
           {
               Console.WriteLine(p.ToString());
           }
            Console.Read();
        }
    }


}
