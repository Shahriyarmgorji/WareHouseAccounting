using System;
using System.Windows.Forms;

namespace WareHouse_Accounting
{
    public partial class FrmSetting : Form
    {
        DCAccountancyDataContext myData = new DCAccountancyDataContext();
        bool? ExistSettings = false;
        DateTime datetime = DateTime.Now;
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCompanyName.Text == string.Empty || TxtCompanyName.Text == null)
                {
                    TxtCompanyName.Text = "";
                }
                if (TxtCompanyName.Text == "")
                {
                    ErrorP.SetError(TxtCompanyName, "Enter CompanyName");
                    TxtCompanyName.Focus();
                }
                else
                {
                    ErrorP.Clear();
                    if (ExistSettings == true)
                    {
                        BsSettings.EndEdit();
                        myData.UpdateSettings(TxtCompanyName.Text, TxtAddressInvoices.Text, TxtContactNumberInvoices.Text,
                            TxtPanelPassword.Text, TxtPanelUsername.Text, TxtRecipientNumber.Text, TxtRemittanceContactNumber.Text,
                            TxtSender.Text, TxtWarehouseRemittanceAddress.Text, integerInput1.Value, integerInput2.Value,
                            checkSMSForTransactions.Checked, checkSmsInvoices.Checked, datetime);
                    }
                    else
                    {
                        myData.InsertSettings(TxtCompanyName.Text, TxtAddressInvoices.Text, TxtContactNumberInvoices.Text,
                            TxtPanelPassword.Text, TxtPanelUsername.Text, TxtRecipientNumber.Text, TxtRemittanceContactNumber.Text,
                            TxtSender.Text, TxtWarehouseRemittanceAddress.Text, integerInput1.Value, integerInput2.Value,
                            checkSMSForTransactions.Checked, checkSmsInvoices.Checked, datetime);
                    }
                    MessageBox.Show("Registration information completed successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                myData.ExistSettings(ref ExistSettings);
                if (ExistSettings == true)
                {
                    BsSettings.DataSource = myData.FiLLSettings();
                }
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
