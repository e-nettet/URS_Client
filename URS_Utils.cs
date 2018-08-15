using System;
using System.Linq;
using URS_Client.ServiceReferenceEVurdering;

namespace URS_Client
{
    public class URS_Utils
    {
        private Miljoe miljoe;
        private string afsender_partid;
        private int systemleverandoerNummer;
        private PrisModelURSClient client;


        public URS_Utils(Miljoe miljoe, string afsender_partid, string password, int systemleverandoerNummer)
        {
            this.miljoe = miljoe;
            this.afsender_partid = afsender_partid;
            this.systemleverandoerNummer = systemleverandoerNummer;
            client = ClientFactoryURS.GetPrisModelURSClient(miljoe, afsender_partid, password, GetEndpointAddress(miljoe));
        }

        public static string GetEndpointAddress(Miljoe miljoe)
        {
            string s;
            switch (miljoe)
            {
                case Miljoe.Test:
                    s = "https://test-e-vurderingspakke.e-nettet.dk/efpi/prismodel/PrisModel.URS";
                    break;
                case Miljoe.Produktion:
                    s = "https://e-vurderingspakke.e-nettet.dk/efpi/prismodel/PrisModel.URS";
                    break;
                default:
                    s = "";
                    break;
            }
            return (s);
        }

        public PrisModelTilmeldResponseType PrismodelTilmeld(PrisModelType prismodel) 
        {
            
            PrisModelTilmeldRequestType request = new PrisModelTilmeldRequestType
            {
                PartId = afsender_partid,
                SystemleverandoerNummer = systemleverandoerNummer,
                PrisModel = prismodel
            };
            PrisModelTilmeldResponseType response = new PrisModelTilmeldResponseType(); 
            response = client.PrisModelTilmeld(request);
            return (response);
        }

        public HaendelseIndsendResponseType HaendelseIndsend(HaendelseType haendelseType) 
        {
            HaendelseIndsendRequestType request = new HaendelseIndsendRequestType
            {
                Haendelse = haendelseType,
                PartId = afsender_partid,
                SystemleverandoerNummer = systemleverandoerNummer
            };

            HaendelseIndsendResponseType response = client.HaendelseIndsend(request);
            return (response);
        }

        public bool FindesHaendelse(string sagsnummer, string partID)
        {
            FindesHaendelseRequestType request = new FindesHaendelseRequestType()
            {
                EjendomsmaeglerSagsnummer = new SagsnummerIdentifikatorType() { Value = sagsnummer },
                PartId = partID
            };
            FindesHaendelseResponseType response = client.FindesHaendelse(request);
            return (response.FindesHaendelse);
        }

        public static AddressPostalType GetAddressPostalType(string kommunekode, string ejendomsnummer) 
        {
            DAWAAdresse.Adresse[] adresser = DAWAUtils.GetAdresserByKommunenummerEjendomsnummer(kommunekode, ejendomsnummer);
            if (adresser.Count() == 0)
            {
                throw new Exception("Ingen adresse fundet for kommunekode " + kommunekode + ", ejendomsnummer " + ejendomsnummer);
            }
            AddressPostalType a = new AddressPostalType()
            {
                CountryIdentificationCode = new CountryIdentificationCodeType { Value = "DK" },
                DistrictName = adresser[0].adgangsadresse.postnummer.navn,
                PostCodeIdentifier = adresser[0].adgangsadresse.postnummer.nr,
                StreetBuildingIdentifier = adresser[0].adgangsadresse.husnr,
                StreetName = adresser[0].adgangsadresse.vejstykke.navn,
                  
            };

            if (adresser[0].etage != null) { a.FloorIdentifier = adresser[0].etage.ToString(); }
            if (adresser[0].__invalid_name__dør != null) { a.SuiteIdentifier = adresser[0].__invalid_name__dør.ToString(); }

            return (a);
        }

        public PrisModelHentResponseType GetPrisModelHentResponseType(DateTime dato) 
        {
            PrisModelHentRequestType request = new PrisModelHentRequestType
            {
                Dato = dato,
                PartId = afsender_partid
            };
            PrisModelHentResponseType response = client.PrisModelHent(request);
           return (response);
        }

        public void SkiftPrismodel(PrisModelType prisModelType, int systemleverandoerNummer)
        {
            PrisModelTilmeldRequestType request = new PrisModelTilmeldRequestType()
            {
                PartId = afsender_partid,
                PrisModel = prisModelType,
                SystemleverandoerNummer = systemleverandoerNummer
            };
            PrisModelTilmeldResponseType response = client.PrisModelTilmeld(request);
        }

    }
}