using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class InittialForm : Form
    {
        public InittialForm()
        {
            InitializeComponent();
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void Member_btn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainFrom();
            mainForm.Show();
            this.Hide();
        }
    }
}
