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
    public partial class FrmAddUser : Form
    {
        DCAccountancyDataContext Dc = new DCAccountancyDataContext();
        public static bool lExitType = false;
        public static bool lIsEdit = false;
        public static int nUserId = 0;
        public static int nRoleId = 0;
        bool? lCheckUserName = false;
        DateTime dt = DateTime.Now;
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            try
            {
                BsRoles.DataSource = Dc.FillRoles();

                if (lIsEdit)
                {
                    CBAddRole.SelectedValue = nRoleId;
                    BsAddUser.DataSource = Dc.FillUsersById(nUserId);
                    TxtUserName.ReadOnly = true;
                }
                else
                {
                    TxtUserName.ReadOnly = false;
                }
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EPAddUser.Clear();
                bool lExecution = true;
                #region ClearData
                if (TxtUserName.Text == string.Empty || TxtUserName.Text == null)
                {
                    TxtUserName.Text = "";
                }
                if (TxtPassword.Text == string.Empty || TxtPassword.Text == null)
                {
                    TxtPassword.Text = "";
                }
                #endregion

                #region Validation
                if (TxtUserName.Text == "")
                {
                    EPAddUser.Clear();
                    lExecution = false;
                    EPAddUser.SetError(TxtUserName, "Enter UserName");
                    TxtUserName.Focus();

                }
                if (TxtPassword.Text == "")
                {
                    lExecution = false;
                    EPAddUser.Clear();
                    EPAddUser.SetError(TxtPassword, "Enter Password");
                    TxtPassword.Focus();
                }
                #endregion
                if (lExecution)
                {
                    EPAddUser.Clear();
                    if (lIsEdit)
                    {
                        BsAddUser.EndEdit();
                        Dc.UpdateUsers(nUserId, (int)CBAddRole.SelectedValue, TxtUserName.Text, TxtPassword.Text, dt);
                    }
                    else
                    {
                        Dc.CheckUserName(ref lCheckUserName, TxtUserName.Text);

                        if (lCheckUserName == true)
                        {
                            EPAddUser.SetError(TxtUserName, "Duplicate UserName!");
                            TxtUserName.Focus();
                        }
                        else
                        {
                            EPAddUser.Clear();
                            Dc.InsertUsers((int)CBAddRole.SelectedValue, TxtUserName.Text, TxtPassword.Text, dt);
                            TxtUserName.Text = string.Empty;
                            TxtPassword.Text = string.Empty;
                            TxtUserName.Focus();
                            lExitType = false;
                        }

                    }
                    MessageBox.Show("Add User completed successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lExitType)
            {
                Application.Exit();
            }
        }
    }
}
