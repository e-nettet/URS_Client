using System;
using System.ComponentModel;
using System.Windows.Forms;
using URS_Client.ServiceReferenceTBIS;
using URS_Client.ServiceReferenceEVurdering;

namespace URS_Client
{
    public enum Miljoe { Test, Produktion}
    public partial class FormIndsend : Form
    {
        private ValidatePartyResponse validatePartyResponse;
        private PrisModelHentResponseType prisModelHentResponseType;
        private string partyID;
        private string password;
        private Miljoe miljoe;
        private HaendelseType haendelseType;
        public int systemleverandoerid;

        private URS_Utils uRS_Utils;

        public FormIndsend()
        {
            InitializeComponent();
            this.Text = this.ProductName + " (version " + this.ProductVersion + ")";
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            haendelseType = new HaendelseType() { Haendelsestype = HaendelsestypeType.SatTilSalg };
            userControlAmeta1.SetHaendelseType(ref haendelseType);
            userControlUdbud1.SetHaendelsesType(ref haendelseType);
            EnableButtons(true);
        }

        private void SetCredentials()
        {
            partyID = userControlLogon1.PartID;
            password = userControlLogon1.Password;
            miljoe = userControlLogon1.Miljoe;
        }

        private void EnableButtons(Boolean enable)
        {
            if (enable)
            {
                buttonNext.Enabled = wizardTabcontrol1.SelectedIndex < wizardTabcontrol1.TabCount - 1;
                buttonTilbage.Enabled = wizardTabcontrol1.SelectedIndex > 0;
            }
            else
            {
                buttonNext.Enabled = false;
                buttonTilbage.Enabled = false;
            }
        }

        private void SetMessage(string message)
        {
            toolStripStatusLabel1.Text = message.Substring(0,  Math.Min(message.Length, 100));
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            switch (wizardTabcontrol1.SelectedIndex)
            {
                case 0: // Login færdig
                    {
                        SetCredentials();
                        if (!backgroundWorkerValidateParty.IsBusy) { backgroundWorkerValidateParty.RunWorkerAsync(); }
                        break;
                    }
                case 1: // Prismodel oplysninger
                    {
                        if (!backgroundWorkerPrismodel.IsBusy) { backgroundWorkerPrismodel.RunWorkerAsync(); } 
                        break;
                    }

                case 2: // Ameta oplysninger registreret
                    {
                        if (!backgroundWorkerAmeta.IsBusy) { backgroundWorkerAmeta.RunWorkerAsync(); }
                        break;
                    }
                case 3: // Udbudshændelse registreret
                    {
                        try
                        {
                            if (!backgroundWorkerSendUdbudshaendelse.IsBusy) { backgroundWorkerSendUdbudshaendelse.RunWorkerAsync(); }
                        }
                        catch (Exception f)
                        {
                            SetMessage(f.Message);
                            EnableButtons(true);
                        }
                        break;
                    }
                default: break;
            }
        }

        private void ButtonTilbage_Click(object sender, EventArgs e)
        {
            SetMessage("OK");
            wizardTabcontrol1.SelectedIndex -= 1;
            EnableButtons(true);
        }

        private void BackgroundWorkerValidateParty_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerValidateParty.ReportProgress(0, "Validerer partid og password");
            try
            {
                validatePartyResponse = RKNet_Utils.GetValidatePartyResponse(miljoe, partyID, password);
                backgroundWorkerValidateParty.ReportProgress(0, "Partid og password valideret: " + validatePartyResponse.backEndStatusCode + " " + validatePartyResponse.backEndStatusText);
            }
            catch (Exception f) { backgroundWorkerValidateParty.ReportProgress(0, f.Message); }

            // Henter også prismodel fra URS
            uRS_Utils = new URS_Utils(miljoe, partyID, password, systemleverandoerid);
            try { prisModelHentResponseType = uRS_Utils.GetPrisModelHentResponseType(DateTime.Now); }
            catch (Exception g) { backgroundWorkerValidateParty.ReportProgress(0, g.Message); }

        }

        private void backgroundWorkerSendUdbudshaendelse_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerSendUdbudshaendelse.ReportProgress(0, "Sender udbudshændelse");
            try
            {
                HaendelseIndsendResponseType response = uRS_Utils.HaendelseIndsend(haendelseType);
                backgroundWorkerSendUdbudshaendelse.ReportProgress(0, "Udbudshændelse sendt");
            }
            catch (Exception f){ backgroundWorkerSendUdbudshaendelse.ReportProgress(0, "Fejl ved send af udbudshændelse: " + f.Message); }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SetMessage(e.UserState.ToString());
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            wizardTabcontrol1.SelectedIndex += 1;
            EnableButtons(true);
        }

        private void backgroundWorkerValidateParty_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (validatePartyResponse.backEndStatusCode == 0)
            {
                userControlPrismodel1.SetValidatePartyResponse(ref validatePartyResponse);
                userControlPrismodel1.SetPrisModelHentResponseType(ref prisModelHentResponseType);
                wizardTabcontrol1.SelectedIndex += 1;
            }
            EnableButtons(true);
        }

        private void backgroundWorkerAmeta_DoWork(object sender, DoWorkEventArgs e)
        {
            if (userControlAmeta1.IsAmeta)
            {
                backgroundWorkerAmeta.ReportProgress(0, "Finder ametasag...");
                try
                {
                    if (uRS_Utils.FindesHaendelse(haendelseType.AmetaInformation.EjendomsmaeglerSagsnummer.Value, haendelseType.AmetaInformation.PartId))
                    {
                        backgroundWorkerAmeta.ReportProgress(0, "Ametasag findes");
                    }
                    else { backgroundWorkerAmeta.ReportProgress(0, "Ametasag findes ikke"); }
                }
                catch (Exception f) { backgroundWorkerAmeta.ReportProgress(0, "Fejl ved find ametasag: " + f.Message); }
            }
        }

        private void wizardTabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (wizardTabcontrol1.SelectedIndex)
            {
                case 1:
                    {
                        userControlPrismodel1.SetComponents();
                        break;
                    }
                default:break;
            }
        }

        private void backgroundWorkerPrismodel_DoWork(object sender, DoWorkEventArgs e)
        {
            if (userControlPrismodel1.SkiftPrismodel())
            {
                PrisModelType nyPrismodel = userControlPrismodel1.GetNyPrismodel();
                SetMessage("Skifter prismodel til " + nyPrismodel.ToString());
                try
                {
                    uRS_Utils.SkiftPrismodel(nyPrismodel, userControlPrismodel1.GetSystemleverandoerNummer());
                    SetMessage("Prismodel skiftet til " + nyPrismodel.ToString());
                }
                catch (Exception f) { backgroundWorkerSendUdbudshaendelse.ReportProgress(0, "Fejl ved ændring af prismodel: " + f.Message); }
            }
        }

    }
}
