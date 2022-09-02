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
    public partial class FrmMain : Form
    {
        DCAccountancyDataContext DcMain = new DCAccountancyDataContext();
        bool? lExistRole = false;
        bool? lExistUser = false;
        bool? lExistSettings = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            new FrmSplash().ShowDialog();
            DcMain.ExistRoles(ref lExistRole);
            if (lExistRole == false)
            {
                FrmAddRoles.lEdit = false;
                FrmAddRoles.lExitType = true;
                new FrmAddRoles().ShowDialog();
            }

            DcMain.ExistUsers(ref lExistUser);
            if (lExistUser == false)
            {
                FrmAddUser.lExitType = true;
                FrmAddUser.lIsEdit = false;
                new FrmAddUser().ShowDialog();
            }

            DcMain.ExistSettings(ref lExistSettings);
            if (lExistSettings == false)
            {
                FrmSetting.lExitType = true;
                new FrmSetting().ShowDialog();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new FrmSetting().ShowDialog();
        }

        private void BtnAddRoles_Click(object sender, EventArgs e)
        {
            new FrmShowRoles().ShowDialog();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            new FrmShowUser().ShowDialog();
        }

        private void BtnUserSetting_Click(object sender, EventArgs e)
        {
            new FrmLogInSettings().ShowDialog();
        }
    }
}
