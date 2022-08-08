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
    public partial class FrmShowRoles : Form
    {
        DCAccountancyDataContext DcShowRoles = new DCAccountancyDataContext();
        public FrmShowRoles()
        {
            InitializeComponent();
        }
        public void DgvNull()
        {
            if (DgvRolesShow.Rows.Count == 0)
            {
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddRoles.lEdit = false;
                new FrmAddRoles().ShowDialog();
                DgvNull();
                DcShowRoles.FillRoles();
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmShowRoles_Load(object sender, EventArgs e)
        {
            try
            {
                BsShowRoles.DataSource = DcShowRoles.FillRoles();
                DgvNull();
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddRoles.lEdit = true;
                FrmAddRoles.nRoleId = (int)DgvRolesShow.CurrentRow.Cells[0].Value;
                new FrmAddRoles().ShowDialog();
                DcShowRoles = new DCAccountancyDataContext();
                DcShowRoles.FillRoles();
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Delete the selected Role?","Delete Role",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) ==DialogResult.Yes)
                {
                    DcShowRoles.DeleteRoles((int)DgvRolesShow.CurrentRow.Cells[0].Value);
                    DgvNull();
                    MessageBox.Show("Role Deleted successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
