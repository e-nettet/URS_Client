using System;
using URS_Client.ServiceReferenceEVurdering;
using System.Windows.Forms;

namespace URS_Client
{
    public partial class UserControlUdbud : UserControl
    {
        private HaendelseType haendelseType;
        private Kommune[] kommuner;

        public HaendelseType HaendelseType {
            get
            {
                haendelseType.AddressPostal = URS_Utils.GetAddressPostalType(haendelseType.RealPropertyStructure.MunicipalityCode, haendelseType.RealPropertyStructure.MunicipalRealPropertyIdentifier);
                return (haendelseType);
            }
            set => haendelseType = value; }

        public UserControlUdbud()
        {
            haendelseType = new HaendelseType() { Haendelsestype = HaendelsestypeType.SatTilSalg };
            haendelseType.RealPropertyStructure = new RealPropertyStructureType();
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
            haendelseType.EjendomsmaeglerSagsnummer = new SagsnummerIdentifikatorType() { Value = textBoxSagsnummer.Text };
        }

        private void comboBoxEjendomstype_SelectedIndexChanged(object sender, EventArgs e)
        {
            haendelseType.EjendomsType = (EjendomstypeType)comboBoxEjendomstype.SelectedIndex;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            haendelseType.HaendelseDato = dateTimePicker1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            haendelseType.RealPropertyStructure.MunicipalityCode = kommuner[comboBoxKommune.SelectedIndex].kode;
        }

        private void textBoxEjendomsnummer_TextChanged(object sender, EventArgs e)
        {
            string s = ("000000" + textBoxEjendomsnummer.Text); // Formatet skal være 6 karakterer, så man tilføjer foranstilleder nuller
            haendelseType.RealPropertyStructure.MunicipalRealPropertyIdentifier = s.Substring(s.Length - 6, 6);
        }
    }
}
