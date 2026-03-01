using BLL.Repository;
using DAL.Data.Services;
using DAL.Entities;
using DAL.Entities.EditEntites;
using DAL.Entities.VehicleEntities;
using Microsoft.EntityFrameworkCore;
using PL.Extensions;
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
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private AddData addDataForm;
        private Reports reportsForm;
        private EditForm editForm;

        private Form activeForm = null;


        private async void OpenChildForm(Form childForm)
        {
            // 1. لو في فورم مفتوحة حالياً، "اخفيها" بس متقفلهاش عشان الداتا متطيرش
            if (activeForm != null && activeForm != childForm)
            {
                activeForm.Hide();
            }

            // 2. حدد إن الفورم دي هي اللي نشطة دلوقتي
            activeForm = childForm;

            // 3. لو الفورم دي لسة متضافتش جوه الـ Panel قبل كدة، جهزها وضيفها
            if (!MainPanel.Controls.Contains(childForm))
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                MainPanel.Controls.Add(childForm);
                MainPanel.Tag = childForm;
            }

            // 4. هاتها في المقدمة واعرضها بالداتا اللي جواها
            childForm.BringToFront();
            childForm.Show();
        }
        private void اضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addDataForm == null || addDataForm.IsDisposed)
            {
                addDataForm = new AddData();
            }
            OpenChildForm(addDataForm);
        }

        private void تعديلاوحذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editForm == null || editForm.IsDisposed)
            {
                editForm = new EditForm();
            }
            OpenChildForm(editForm);
        }

        private void تقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportsForm == null || reportsForm.IsDisposed)
            {
                reportsForm = new Reports();
            }
            OpenChildForm(reportsForm);
        }

        private void addDataAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddDataAdmin());
        }
    }
}
