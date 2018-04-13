using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using URS_Client.ServiceReferenceTBIS;

namespace URS_Client

{
    public static class RKNet_Utils
    {
        public static string GetEndpointAddress(Miljoe miljoe)
        {
            string s;
            switch (miljoe)
            {
                case Miljoe.Produktion:
                    s = "https://tbisws.e-nettet.dk/TBISWS/Main";
                    break;
                case Miljoe.Test:
                    s = "https://test-tbisws.e-nettet.dk/TBISWS/Main";
                    break;
                default:
                    s = "";
                    break;
            }
            return (s);
        }

        public static MainClient GetMainClient(Miljoe miljoe)
        {
            MainClient client = new MainClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(RKNet_Utils.GetEndpointAddress(miljoe));
            return (client);
        }

        public static ValidatePartyResponse GetValidatePartyResponse(Miljoe miljoe, string partyID, string password)
        {
            ServiceReferenceTBIS.MainClient client = GetMainClient(miljoe);
            client.ClientCredentials.UserName.UserName = partyID;
            client.ClientCredentials.UserName.Password = password;
            ValidatePartyResponse response = client.validateParty(partyID, password);
            return (response);
        }

    }
}
