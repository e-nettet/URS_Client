using System;
using System.Windows.Forms;

namespace URS_Client
{
    public partial class UserControlLogon : UserControl
    {
        private string partID;
        private string jnummer;
        private string password;
        private Miljoe miljoe;

        public UserControlLogon()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            comboBoxMiljoe.DataSource = Enum.GetValues(typeof(Miljoe));
        }


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

        private string TextToPartyID(string text)
        {
            string s = text;
            s = s.Replace(":14", "");
            s = ("5790000000000").Substring(0, 13 - s.Length) + s + ":14";
            return (s);
        }

        private void textBoxPartID_TextChanged(object sender, EventArgs e)
        {
            partID = textBoxPartID.Text;

        }

        private void textBoxPartID_Leave(object sender, EventArgs e)
        {
            textBoxPartID.Text = TextToPartyID(textBoxPartID.Text);
        }
    }
}
