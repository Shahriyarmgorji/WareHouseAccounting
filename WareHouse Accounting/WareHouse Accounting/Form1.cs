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
        bool? ExistRole = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            new FrmSplash().ShowDialog();
            DcMain.ExistRoles(ref ExistRole);
            if (ExistRole == false)
            {
                FrmAddRoles.lEdit = false;
                FrmAddRoles.lExitType = true;
                new FrmAddRoles().ShowDialog();
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
    }
}
