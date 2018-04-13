using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;

namespace URS_Client
{
    static class RESTUtils
    {
        public static string GetStringFromURL(string url)
        {
            WebClient client = new WebClient();
            client.Headers["User-Agent"] = "e-nettet A/S";
            string s = client.DownloadString(url);
            return (s);
        }

        public static HttpWebResponse GetHttpWebResponse(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                return (response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return null;
            }
        }

    }
}
