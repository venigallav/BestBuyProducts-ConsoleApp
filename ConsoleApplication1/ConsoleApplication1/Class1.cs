using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;

namespace ConsoleApplication1
{
    public class Class1
    {
        String name;
        double salePrice;
        string mobileUrl;
        public string GetData( string uri)
        {
            
            string jsonresult = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);          
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.GetResponseStream();
                    using (StreamReader read = new StreamReader(response.GetResponseStream()))
                    {
                        jsonresult = read.ReadToEnd();
                    }
                }
                response.Close();
            }

            catch (WebException e)
            {
                Console.WriteLine("\nException occured");
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }

            return jsonresult;
        }
    }


}
