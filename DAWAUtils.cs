using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace URS_Client
{
    public static class DAWAUtils
    {

        private static string GetadresserURL(string kommunekode, string ejendomsnummer)
        {
            string s = "http://dawa.aws.dk/adresser?kommunekode=" + kommunekode + "&esrejendomsnr=" + ejendomsnummer;
            return(s);
        }

        private static string GetkommunerURL()
        {
            string s = "http://dawa.aws.dk/kommuner";
            return (s);
        }

        public static DAWAAdresse.Adresse[] GetAdresserByKommunenummerEjendomsnummer(string kommunekode, string ejendomsnummer) 
        {
            string url = GetadresserURL(kommunekode, ejendomsnummer);
            string response = RESTUtils.GetStringFromURL(url);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DAWAAdresse.Adresse[]));
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(response));
            DAWAAdresse.Adresse[] adresser = (DAWAAdresse.Adresse[])serializer.ReadObject(ms);
            return (adresser);

        }

        public static Kommune[] GetKommuner() 
        {
            string s = RESTUtils.GetStringFromURL(DAWAUtils.GetkommunerURL());
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Kommune[]));
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(s));
            Kommune[] kommuner = (Kommune[])serializer.ReadObject(ms);
            return (kommuner); 
        }
    }
}
