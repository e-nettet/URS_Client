using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URS_Client.ServiceReferenceEVurdering;

namespace URS_Client
{
    public class URS_Utils
    {
        private Miljoe miljoe;
        private string afsender_partid;
        private string modtager_partid;
        private string jnummer;

        public Miljoe Miljoe { get => miljoe; set => miljoe = value; }
        public string Afsender_partid { get => afsender_partid; set => afsender_partid = value; }
        public string Jnummer { get => jnummer; set => jnummer = value; }
        public string Modtager_partid { get => modtager_partid; set => modtager_partid = value; }


        public URS_Utils(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            this.Miljoe = miljoe;
            this.Afsender_partid = afsender_partid;
            this.Jnummer = jnummer;
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

        public static PrisModelTilmeldResponseType PrismodelTilmeld(Miljoe miljoe, string partyID, string password, PrisModelType prismodel, int systemleverandoerNummer) 
        {
            PrisModelURSClient client = ClientFactoryURS.GetPrisModelURSClient(miljoe, partyID, password, GetEndpointAddress(miljoe));
            PrisModelTilmeldRequestType request = new PrisModelTilmeldRequestType
            {
                PartId = partyID,
                SystemleverandoerNummer = systemleverandoerNummer,
                PrisModel = prismodel
            };
            PrisModelTilmeldResponseType response = new PrisModelTilmeldResponseType(); 
            response = client.PrisModelTilmeld(request);
            return (response);
        }

        public static HaendelseIndsendResponseType HaendelseIndsend(Miljoe miljoe, string partyID, string password, HaendelseType haendelseType, int systemleverandoerNummer) 
        {
            PrisModelURSClient client = ClientFactoryURS.GetPrisModelURSClient(miljoe, partyID, password, GetEndpointAddress(miljoe));
            HaendelseIndsendRequestType request = new HaendelseIndsendRequestType
            {
                Haendelse = haendelseType,
                PartId = partyID,
                SystemleverandoerNummer = systemleverandoerNummer
            };

            HaendelseIndsendResponseType response = client.HaendelseIndsend(request);
            return (response);
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
        public static PrisModelHentResponseType GetPrisModelHentResponseType(Miljoe miljoe, string partyID, string password, DateTime dato) 
        {
           PrisModelURSClient client = ClientFactoryURS.GetPrisModelURSClient(miljoe, partyID, password, GetEndpointAddress(miljoe));
            PrisModelHentRequestType request = new PrisModelHentRequestType
            {
                Dato = dato,
                PartId = partyID
            };
            PrisModelHentResponseType response = client.PrisModelHent(request);
           return (response);
        }
    }
}