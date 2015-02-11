using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApplication1
{
 
public class Rootobject
{
public int from { get; set; }
public int to { get; set; }
public int total { get; set; }
public int currentPage { get; set; }
public int totalPages { get; set; }
public string queryTime { get; set; }
public string totalTime { get; set; }
public bool partial { get; set; }
public string canonicalUrl { get; set; }
public Product[] products { get; set; }

public override string ToString()
{
    return base.ToString();
}
}

public class Product
{
public string name { get; set; }
public float salePrice { get; set; }
public bool preowned { get; set; }
public string mobileUrl { get; set; }
public override string ToString()
{
    return "Item: " + "Name =" + name + ", " + "SalePrice =" + salePrice + ", " + "PreOwned =" + preowned + ", "
                + "MobileUrl =" + mobileUrl;
}
}
public class parseJson
{
    public Rootobject parsejson(String input) 
        {
            Rootobject r = JsonConvert.DeserializeObject<Rootobject>(input);
            return r;
        }
    }
}