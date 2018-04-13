using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace URS_Client
{
    [DataContract]
    public class Kommune
    {
        [DataMember]
        public string kode { get; set; }
        [DataMember]
        public string navn { get; set; }
        [DataMember]
        public string regionskode { get; set; }
        [DataMember]
        public string __invalid_name__ændret { get; set; }
        [DataMember]
        public int geo_version { get; set; }
        [DataMember]
        public string __invalid_name__geo_ændret { get; set; }
        [DataMember]
        public string href { get; set; }
    }



}

