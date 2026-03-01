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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string password = "12345";
        private void Login_btn_Click(object sender, EventArgs e) // شيلنا async
        {
            if (Pass_txt.Text == password)
            {
                // 1. إنشاء نسخة من الفورم
                AddDataAdmin adminForm = new AddDataAdmin();


                // 3. إظهار الفورم الجديد
                adminForm.Show();

                // 4. إخفاء شاشة تسجيل الدخول الحالية
                this.Hide();
            }
            else
            {
                MessageBox.Show("كلمة المرور غير صحيحة. حاول مرة أخرى.", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
