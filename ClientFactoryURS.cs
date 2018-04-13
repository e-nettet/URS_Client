using System;
using System.ServiceModel.Description;
using System.Xml;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using URS_Client.ServiceReferenceEVurdering;

namespace URS_Client
{
    public static class ClientFactoryURS
    {

        public static PrisModelURSClient GetPrisModelURSClient(Miljoe miljoe, string partyID, string password, string endpointAddress)
        {
            PrisModelURSClient client = new PrisModelURSClient();
            client.Endpoint.Behaviors.Add(new CustomBehavior(partyID));
            client.Endpoint.Behaviors.Add(new ClientViaBehavior(new Uri(URS_Utils.GetEndpointAddress(miljoe))));
            SetClientCredentials(client.ClientCredentials, partyID, password);
            System.ServiceModel.EndpointAddress addr = new System.ServiceModel.EndpointAddress(endpointAddress);
            client.Endpoint.Address = addr;
            return (client);
        }

        public static void SetClientCredentials(ClientCredentials ClientCredentials, string partyID, string password)
        {
            ClientCredentials.UserName.UserName = partyID;
            ClientCredentials.UserName.Password = password;
        }
    }

    public class CustomBehavior : IEndpointBehavior
    {
        private string from;

        public CustomBehavior(string from)
        {
            this.from = from;
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            //Do nothing!
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            //Do nothing!
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            //Do nothing
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(new CustomInspector(from));
        }
    }


    public class CustomInspector : IClientMessageInspector
    {
        private string from;

        public CustomInspector(string from)
        {
            this.from = from;
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            var header = new AddFromHeader(from);
            request.Headers.Add(header);
            request.Headers.To = new Uri("http://efpi.dk/aktoer/21270776");
            return null;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            //Do nothing!
        }
    }

    public class AddFromHeader : MessageHeader
    {
        private string from;

        public AddFromHeader(string from)
        {
            this.from = from;
        }

        public override string Name
        {
            get { return ""; }
        }

        public override string Namespace
        {
            get { return ""; }
        }

        protected override void OnWriteStartHeader(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            writer.WriteStartElement("From", "http://www.w3.org/2005/08/addressing");
        }

        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            writer.WriteStartElement("Address", "http://www.w3.org/2005/08/addressing");
            writer.WriteValue("ean:" + from);
            writer.WriteEndElement();

        }

    }

}

