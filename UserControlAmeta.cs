using System.Windows.Forms;
using URS_Client.ServiceReferenceEVurdering;

namespace URS_Client
{
    public partial class UserControlAmeta : UserControl
    {

        private bool isAmeta;
        private HaendelseType haendelseType;
        public bool IsAmeta { get => checkBoxAmetasag.Checked; set => isAmeta = value; }

        //public void SetHaendelseType(ref HaendelseType haendelse) { this.haendelseType = haendelse; }

        public void SetHaendelseType(ref HaendelseType haendelseType)
        {
            this.haendelseType = haendelseType;
        }

        public UserControlAmeta()
        {
            InitializeComponent();
        }

        private void SetComponents()
        {
            if (haendelseType.AmetaInformation != null)
            {
                checkBoxAmetasag.Checked = true;
                textBoxAmteaEjendomsmaegler.Text = haendelseType.AmetaInformation.PartId;
                textBoxAmetaSagsnummer.Text = haendelseType.AmetaInformation.EjendomsmaeglerSagsnummer.Value;
            }
            else
            {
                checkBoxAmetasag.Checked = false;
            }
        }

        private void checkBoxAmetasag_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxAmetasag.Checked) { haendelseType.AmetaInformation = new AmetaInformationType(); }
            else { haendelseType.AmetaInformation = null; }
            textBoxAmetaSagsnummer.Enabled = checkBoxAmetasag.Checked;
            textBoxAmteaEjendomsmaegler.Enabled = checkBoxAmetasag.Checked;
        }

        private void textBoxAmteaEjendomsmaegler_TextChanged(object sender, System.EventArgs e)
        {
            haendelseType.AmetaInformation.PartId = textBoxAmteaEjendomsmaegler.Text;
        }

        private void textBoxAmetaSagsnummer_TextChanged(object sender, System.EventArgs e)
        {
            haendelseType.AmetaInformation.EjendomsmaeglerSagsnummer = new SagsnummerIdentifikatorType() { Value = textBoxAmetaSagsnummer.Text };
        }
    }
}
