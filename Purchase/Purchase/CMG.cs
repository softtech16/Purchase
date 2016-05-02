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
    public partial class CMG : Form
    {
        public CMG()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            this.Hide();
            CMGdetails cmgdetails = new CMGdetails();
            cmgdetails.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department department = new Department();
            department.ShowDialog();
        }
    }
}
