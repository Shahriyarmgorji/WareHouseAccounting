using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouse_Accounting
{
    public partial class FrmAddRoles : Form
    {
        DCAccountancyDataContext DcRoles = new DCAccountancyDataContext();
        public static bool lExitType = false;
        public static bool lEdit = false;
       
        public static int nRoleId = 0;
        DateTime? datetime = DateTime.Now;
        public FrmAddRoles()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool lExcution = true;
            #region ClearData
            if (TxtRoleName.Text == null)
            {
                TxtRoleName.Text = "";
            }
            #endregion
            #region Validation
            if (TxtRoleName.Text == "")
            {
                lExcution = false;
                EpRoles.SetError(TxtRoleName, "Please Enter Role Name");
                TxtRoleName.Focus();
            }
            #endregion
            try
            {
                if (lExcution)
                {
                    EpRoles.Clear();
                    if (lEdit)
                    {
                        BsRoles.EndEdit();
                        DcRoles.UpdateRoles(nRoleId, TxtRoleName.Text, CkBWareHouse.Checked, CkBAccounts.Checked, CkbPersons.Checked
                            , CkbFactors.Checked, CkbSettings.Checked, CkbUsers.Checked, datetime);
                    }
                    else
                    {
                        DcRoles.InsertRoles(TxtRoleName.Text, CkBWareHouse.Checked, CkBAccounts.Checked, CkbPersons.Checked
                            , CkbFactors.Checked, CkbSettings.Checked, CkbUsers.Checked, datetime);
                        TxtRoleName.Text = string.Empty;
                        CkBWareHouse.Checked = false;
                        CkBAccounts.Checked = false;
                        CkbPersons.Checked = false;
                        CkbFactors.Checked = false;
                        CkbSettings.Checked = false;
                        CkbUsers.Checked = false;
                        TxtRoleName.Focus();
                    }
                    MessageBox.Show("Registration information completed successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lExitType = false;
                }
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAddRoles_Load(object sender, EventArgs e)
        {
            try
            {
                if (lEdit)
                {
                    BsRoles.DataSource = DcRoles.FillRolesByRoleID(nRoleId);
                }
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAddRoles_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lExitType)
            {
                Application.Exit();
            }
        }
    }
}
