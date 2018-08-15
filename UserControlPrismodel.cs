using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URS_Client.ServiceReferenceEVurdering;
using URS_Client.ServiceReferenceTBIS;


namespace URS_Client
{
    public partial class UserControlPrismodel : UserControl
    {
        private PrisModelHentResponseType prisModelHentResponseType;
        public void SetPrisModelHentResponseType(ref PrisModelHentResponseType prisModelHentResponseType) { this.prisModelHentResponseType = prisModelHentResponseType; }

        private ValidatePartyResponse validatePartyResponse;
        public void SetValidatePartyResponse(ref ValidatePartyResponse validatePartyResponse) { this.validatePartyResponse = validatePartyResponse; }

        public UserControlPrismodel()
        {
            InitializeComponent();
            comboBoxNyPrismodel.DataSource = Enum.GetValues(typeof(PrisModelType));
        }

        public void SetComponents()
        {
            labelJNummer.Text = validatePartyResponse.rknetid;
            labelPrismodel.Text = prisModelHentResponseType.TilmeldingAktivPaaDato.PrisModel.ToString();
            textBoxSystemleverandoerNummer.Text = prisModelHentResponseType.TilmeldingAktivPaaDato.SystemleverandoerNummer.ToString();

            comboBoxNyPrismodel.Enabled = checkBoxSkiftPrismodel.Checked;
            textBoxSystemleverandoerNummer.Enabled = checkBoxSkiftPrismodel.Checked;
        }

        public Boolean SkiftPrismodel()
        {
            Boolean skiftPrismodel = checkBoxSkiftPrismodel.Checked;
            return (skiftPrismodel);
        }

        public PrisModelType GetNyPrismodel()
        {
            PrisModelType p = (PrisModelType)comboBoxNyPrismodel.SelectedIndex;
            return (p);
        }

        public int GetSystemleverandoerNummer()
        {
            int i = int.Parse(textBoxSystemleverandoerNummer.Text);
            return (i);
        }

        private void checkBoxSkiftPrismodel_CheckedChanged(object sender, EventArgs e)
        {
            SetComponents();
        }
    }
}
