using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchase
{
    public partial class Login : Form
    {
        string username, password;
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void tbx_username_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tbx_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            if(tbx_username.Text =="" | tbx_password.Text == "")
            {
                MessageBox.Show("Please Enter Username or Password!");
            }
            else if(tbx_username.Text == "admin" && tbx_password.Text == "admin")
            {
                Department department = new Department();
                this.Hide();
                department.ShowDialog();
                
                //MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect!");
            }
        }
    }
}
