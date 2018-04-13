using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace DAWAAdresse
{
    [DataContract]
    public class Historik
    {
        [DataMember]
        public string oprettet { get; set; }
        [DataMember]
        public string __invalid_name__ændret { get; set; }
    }

    [DataContract]
    public class Vejstykke
    {
        [DataMember]
        public string href { get; set; }
        [DataMember]
        public string navn { get; set; }
        [DataMember]
        public string kode { get; set; }
    }

    [DataContract]
    public class Postnummer
    {
        [DataMember]
        public string href { get; set; }
        [DataMember]
        public string nr { get; set; }
        [DataMember]
        public string navn { get; set; }
    }

    [DataContract]
    public class Kommune
    {
        [DataMember]
        public string href { get; set; }
        [DataMember]
        public string kode { get; set; }
        [DataMember]
        public string navn { get; set; }
    }

    [DataContract]
    public class Ejerlav
    {
        [DataMember]
        public int kode { get; set; }
        [DataMember]
        public string navn { get; set; }
    }

    [DataContract]
    public class Historik2
    {
        [DataMember]
        public string oprettet { get; set; }
        [DataMember]
        public string __invalid_name__ændret { get; set; }
    }

    [DataContract]
    public class Adgangspunkt
    {
        [DataMember]
        public List<double> koordinater { get; set; }
        [DataMember]
        public string __invalid_name__nøjagtighed { get; set; }
        [DataMember]
        public int kilde { get; set; }
        [DataMember]
        public string tekniskstandard { get; set; }
        [DataMember]
        public double tekstretning { get; set; }
        [DataMember]
        public string __invalid_name__ændret { get; set; }
    }

    [DataContract]
    public class DDKN
    {
        [DataMember]
        public string m100 { get; set; }
        [DataMember]
        public string km1 { get; set; }
        [DataMember]
        public string km10 { get; set; }
    }

    [DataContract]
    public class Sogn
    {
        [DataMember]
        public string kode { get; set; }
        [DataMember]
        public string navn { get; set; }
        [DataMember]
        public string href { get; set; }
    }

    [DataContract]
    public class Region
    {
        [DataMember]
        public string kode { get; set; }
        [DataMember]
        public string navn { get; set; }
        [DataMember]
        public string href { get; set; }
    }

    [DataContract]
    public class Retskreds
    {
        [DataMember]
        public string kode { get; set; }
        [DataMember]
        public string navn { get; set; }
        [DataMember]
        public string href { get; set; }
    }

    [DataContract]
    public class Politikreds
    {
        [DataMember]
        public string kode { get; set; }
        [DataMember]
        public string navn { get; set; }
        [DataMember]
        public string href { get; set; }
    }

    [DataContract]
    public class Opstillingskreds
    {
        [DataMember]
        public string kode { get; set; }
        [DataMember]
        public string navn { get; set; }
        [DataMember]
        public string href { get; set; }
    }

    [DataContract]
    public class Ejerlav2
    {
        [DataMember]
        public int kode { get; set; }
        [DataMember]
        public string navn { get; set; }
        [DataMember]
        public string href { get; set; }
    }

    [DataContract]
    public class Jordstykke
    {
        [DataMember]
        public string href { get; set; }
        [DataMember]
        public string matrikelnr { get; set; }
        [DataMember]
        public Ejerlav2 ejerlav { get; set; }
    }

    [DataContract]
    public class Adgangsadresse
    {
        [DataMember]
        public string href { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string kvh { get; set; }
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public Vejstykke vejstykke { get; set; }
        [DataMember]
        public string husnr { get; set; }
        [DataMember]
        public object supplerendebynavn { get; set; }
        [DataMember]
        public Postnummer postnummer { get; set; }
        [DataMember]
        public Kommune kommune { get; set; }
        [DataMember]
        public Ejerlav ejerlav { get; set; }
        [DataMember]
        public string esrejendomsnr { get; set; }
        [DataMember]
        public string matrikelnr { get; set; }
        [DataMember]
        public Historik2 historik { get; set; }
        [DataMember]
        public Adgangspunkt adgangspunkt { get; set; }
        [DataMember]
        public DDKN DDKN { get; set; }
        [DataMember]
        public Sogn sogn { get; set; }
        [DataMember]
        public Region region { get; set; }
        [DataMember]
        public Retskreds retskreds { get; set; }
        [DataMember]
        public Politikreds politikreds { get; set; }
        [DataMember]
        public Opstillingskreds opstillingskreds { get; set; }
        [DataMember]
        public string zone { get; set; }
        [DataMember]
        public Jordstykke jordstykke { get; set; }
    }

    [DataContract]
    public class Adresse
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string kvhx { get; set; }
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public string href { get; set; }
        [DataMember]
        public Historik historik { get; set; }
        [DataMember]
        public object etage { get; set; }
        [DataMember]
        public object __invalid_name__dør { get; set; }
        [DataMember]
        public string adressebetegnelse { get; set; }
        [DataMember]
        public Adgangsadresse adgangsadresse { get; set; }
    }
}
