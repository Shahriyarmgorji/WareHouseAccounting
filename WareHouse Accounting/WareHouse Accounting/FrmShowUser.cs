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
    public partial class FrmShowUser : Form
    {
        DCAccountancyDataContext Dc = new DCAccountancyDataContext();
        public FrmShowUser()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowUser_Load(object sender, EventArgs e)
        {
            try
            {
                BsShowUser.DataSource = Dc.FillUsers();

                if (DgvShowUser.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;

                }
                else
                {
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUser.lIsEdit = false;
                new FrmAddUser().ShowDialog();

                BsShowUser.DataSource = Dc.FillUsers();

                if (DgvShowUser.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;

                }
                else
                {
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
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
                FrmAddUser.lIsEdit = true;
                FrmAddUser.nUserId = (int)DgvShowUser.CurrentRow.Cells[0].Value;
                FrmAddUser.nRoleId = (int)DgvShowUser.CurrentRow.Cells[1].Value;
                new FrmAddUser().ShowDialog();
                Dc = new DCAccountancyDataContext();
                BsShowUser.DataSource = Dc.FillUsers();

                if (DgvShowUser.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;

                }
                else
                {
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
                //MessageBox.Show("Registration information completed successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (MessageBox.Show("Are You Sure You Want To Delete This User?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Dc.DeleteUsers((int)DgvShowUser.CurrentRow.Cells[0].Value);
                    BsShowUser.DataSource = Dc.FillUsers();

                    if (DgvShowUser.Rows.Count == 0)
                    {
                        BtnDelete.Enabled = false;
                        BtnEdit.Enabled = false;

                    }
                    else
                    {
                        BtnDelete.Enabled = true;
                        BtnEdit.Enabled = true;

                    }
                }
                //MessageBox.Show("Registration information completed successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("The connection with the server has been lost!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
