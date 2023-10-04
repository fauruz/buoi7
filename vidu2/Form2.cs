using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu2
{
    public partial class Form2 : Form
    {
        List<ChamCong> cclst;
        public Form2()
        {
            cclst = new List<ChamCong>();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Require()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng điền họ và tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            if (txtId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return false;
            }
            if (txtDp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập phòng ban của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDp.Focus();
                return false;
            }
            if (txtWd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày công của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWd.Focus();
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Require())
            {
                ChamCong cc = new ChamCong();
                cc.Name = txtName.Text;
                cc.Id = Convert.ToInt32(txtId.Text);
                cc.Gender = cbGender.SelectedIndex;
                cc.Department = txtDp.Text;
                cc.WorkDay = Convert.ToInt32(txtWd.Text);
                if(txtPad.Text != "")
                    cc.PAbsentDay = Convert.ToInt32(txtPad.Text);
                if (txtNpad.Text != "")
                    cc.NPAbsentDay= Convert.ToInt32(txtNpad.Text);
                if (txtLd.Text != "")
                    cc.LateDay = Convert.ToInt32(txtLd.Text);
                lblNotice.ForeColor = Color.ForestGreen;
                lblNotice.Text = "Thêm thành công!";
                btnRefresh_Click(sender, e);
                cclst.Add(cc);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
            }
            else
            {
                bool b = false;
                foreach(ChamCong cc in cclst)
                {
                    if (Convert.ToInt32(txtId.Text) == cc.Id)
                    {
                        txtName.Text = cc.Name;
                        txtDp.Text = cc.Department;
                        cbGender.SelectedIndex = cc.Gender;
                        txtWd.Text = cc.WorkDay.ToString();
                        txtPad.Text = cc.PAbsentDay.ToString();
                        txtNpad.Text = cc.NPAbsentDay.ToString();
                        txtLd.Text = cc.LateDay.ToString();
                        b = true;
                    }
                }
                if (!b)
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên!");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPad.Text = string.Empty;
            txtNpad.Text = string.Empty;
            txtLd.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDp.Text = string.Empty;
            cbGender.SelectedIndex = -1 ;
            txtId.Text = string.Empty;
            txtWd.Text = null;
        }

        private void txtAuto_TextChanged(object sender, EventArgs e)
        {
            bool b = false;
                foreach(ChamCong cc in cclst)
                {
                    if (Convert.ToInt32(txtAuto.Text) == cc.Id)
                    {
                        txtId.Text = txtAuto.Text;
                        txtName.Text = cc.Name;
                        txtDp.Text = cc.Department;
                        cbGender.SelectedIndex = cc.Gender;
                        txtWd.Text = cc.WorkDay.ToString();
                        txtPad.Text = cc.PAbsentDay.ToString();
                        txtNpad.Text = cc.NPAbsentDay.ToString();
                        txtLd.Text = cc.LateDay.ToString();
                        b = true;
                    }
                }
                if (!b)
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên!");
                }
        }
    }
}
