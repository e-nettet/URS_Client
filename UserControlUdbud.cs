using System;
using URS_Client.ServiceReferenceEVurdering;
using System.Windows.Forms;

namespace URS_Client
{
    public partial class UserControlUdbud : UserControl
    {
        private HaendelseType haendelseType;
        private Kommune[] kommuner;

        public void SetHaendelsesType(ref HaendelseType haendelseType) { this.haendelseType = haendelseType; }

        public UserControlUdbud()
        {
            InitializeComponent();
            comboBoxEjendomstype.DataSource = Enum.GetValues(typeof(EjendomstypeType));
            kommuner = DAWAUtils.GetKommuner();
            SetKommunerCombobox();
        }

        private void SetKommunerCombobox()
        {
            comboBoxKommune.Items.Clear();
            for (int i = 0; i < kommuner.Length; i++) { comboBoxKommune.Items.Add(kommuner[i].kode + " " + kommuner[i].navn); }
        }

        private void textBoxSagsnummer_TextChanged(object sender, EventArgs e)
        {
            if (haendelseType != null)
            { haendelseType.EjendomsmaeglerSagsnummer = new SagsnummerIdentifikatorType() { Value = textBoxSagsnummer.Text }; }
        }

        private void comboBoxEjendomstype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (haendelseType != null) { haendelseType.EjendomsType = (EjendomstypeType)comboBoxEjendomstype.SelectedIndex; }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (haendelseType != null) { haendelseType.HaendelseDato = dateTimePicker1.Value; }
        }

        private void textBoxEjendomsnummer_TextChanged(object sender, EventArgs e)
        {
            SetRealPropertyStructure();
        }

        private void comboBoxKommune_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRealPropertyStructure();
        }

        private void SetRealPropertyStructure()
        {
            string s = ("000000" + textBoxEjendomsnummer.Text); // Formatet skal være 6 karakterer, så man tilføjer foranstilleder nuller
            s = s.Substring(s.Length - 6, 6);

            haendelseType.RealPropertyStructure = new RealPropertyStructureType()
            {
                MunicipalityCode = kommuner[comboBoxKommune.SelectedIndex].kode,
                   MunicipalRealPropertyIdentifier = s
            };

            try
            {
                haendelseType.AddressPostal = URS_Utils.GetAddressPostalType(
                haendelseType.RealPropertyStructure.MunicipalityCode,
                haendelseType.RealPropertyStructure.MunicipalRealPropertyIdentifier);
                richTextBox1.Text =  GetPrettyAddressPostal(haendelseType.AddressPostal);
            }
            catch (Exception e) { richTextBox1.Text = "Ingen adresse fundet"; }
        }
        private string GetPrettyAddressPostal(AddressPostalType addressPostalType)
        {
            string s = "";
            s += addressPostalType.StreetName + " " + addressPostalType.StreetBuildingIdentifier;
            if (addressPostalType.FloorIdentifier != null) { s += ", " + addressPostalType.FloorIdentifier; }
            if (addressPostalType.SuiteIdentifier != null) { s += addressPostalType.SuiteIdentifier; }
            if (addressPostalType.DistrictSubdivisionIdentifier != null) { s += ", " + addressPostalType.DistrictSubdivisionIdentifier; }
            s += ", " + addressPostalType.PostCodeIdentifier + "  " + addressPostalType.DistrictName;
            return (s);
        }
    }
}
