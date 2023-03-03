using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psn.forms
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
                            InitializeComponent();
        }
    
        private void frm_login_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            while (txtuser.Text == "" || txtpwd.Text == "")
            {
                txtuser.Clear();
                txtuser.Focus();
                txtpwd.Clear();
                return;
            }
        }
    }
}
        