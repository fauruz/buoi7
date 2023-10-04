using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu
{
    public partial class Form1 : Form
    {
        List<string> lst;

        public Form1()
        {
            lst = new List<string>();
            InitializeComponent();
        }
        private bool checkInfo()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter your Name, plz!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(checkInfo())
            {
                lst.Add(txtName.Text);
                txtCount.Text = lst.Count.ToString();
                txtName.Text = string.Empty;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtCount.Text != "")
            {
                if (lst.Count == 0)
                {
                    MessageBox.Show("Them ten!");
                }
                else
                {
                    int i = Convert.ToInt32(txtCount.Text) - 1;
                    if (lst[i] != null)
                        txtName.Text = lst[i].ToString();
                }
            }
            else
            {
                MessageBox.Show("Nhap ma!");
            }
        }
    }
}
