using System;
using System.Windows.Forms;

namespace URS_Client
{
    public partial class UserControlLogon : UserControl
    {
        private string partID;
        private string jnummer;
        private string password;
        private int systemleverandoerID;
        private Miljoe miljoe;

        public UserControlLogon()
        {
            InitializeComponent();
            comboBoxMiljoe.DataSource = Enum.GetValues(typeof(Miljoe));
        }

        public int SystemleverandoerID { get => systemleverandoerID; set => systemleverandoerID = value; }

        public string Password { get => password; set => password = value; }
        public Miljoe Miljoe { get => miljoe; set => miljoe = value; }
        public string PartID { get => partID; set => partID = value; }
        public string Jnummer { get => jnummer; set => jnummer = value; }

        private void ComboBoxMiljoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Miljoe = (Miljoe)comboBoxMiljoe.SelectedIndex;
        }
        
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            Password = textBoxPassword.Text;
        }

        private void textBoxSystemleverandoerID_TextChanged(object sender, EventArgs e)
        {
            systemleverandoerID = int.Parse( textBoxSystemleverandoerID.Text);
        }

        private void textBoxPartID_TextChanged(object sender, EventArgs e)
        {
            partID = textBoxPartID.Text;

        }
    }
}
