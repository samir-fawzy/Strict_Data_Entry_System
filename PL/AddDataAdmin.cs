using BLL.Repository;
using DAL.Data.Services;
using DAL.Entities;
using DAL.Entities.EditEntites;
using DAL.Entities.VehicleEntities;
using DAL.EntitiesNotInDB;
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
    public partial class AddDataAdmin : Form
    {
        public AddDataAdmin()
        {
            InitializeComponent();
        }



        private async void Engine_btn_Click(object sender, EventArgs e)
        {
            // فحص سريع عشان منضيفش قيم فاضية
            if (string.IsNullOrWhiteSpace(Engine_txt.Text)) return;
            await HandleContextAsync(new Engine { Name = Engine_txt.Text });
            Engine_txt.Clear();
        }

        private async void Payload_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Payload_txt.Text)) return;
            await HandleContextAsync(new Payload { Name = Payload_txt.Text });
            Payload_txt.Clear();
        }

        private async void BatterySize_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BatterySize_txt.Text)) return;
            await HandleContextAsync(new BatterySize { Name = BatterySize_txt.Text });
            BatterySize_txt.Clear();
        }

        private async void TireSize_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TireSize_txt.Text)) return;
            await HandleContextAsync(new TireSize { Name = TireSize_txt.Text });
            TireSize_txt.Clear();
        }

        private async void Unit_ptn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Unit_txt.Text)) return;
            await HandleContextAsync(new Unit { Name = Unit_txt.Text });
            Unit_txt.Clear();
        }

        private async void Preparation_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Preparation_txt.Text)) return;
            await HandleContextAsync(new Preparation { Name = Preparation_txt.Text });
            Preparation_txt.Clear();
        }

        private async void Usage_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Usage_txt.Text)) return;
            await HandleContextAsync(new Usage { Name = Usage_txt.Text });
            Usage_txt.Clear();
        }



        private async void BrandModel_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Brand_comboBox.Text) || string.IsNullOrWhiteSpace(Model_txt.Text))
            {
                MessageBox.Show("برجاء إدخال اسم الماركة والموديل");
                return;
            }

            var brandId = (int)Brand_comboBox.SelectedValue;
            var model = new Model { Name = Model_txt.Text, BrandId = brandId };

            await HandleContextAsync(model);
            Brand_txt.Clear();
            Model_txt.Clear();
        }

        private async void Status_btn_Click(object sender, EventArgs e)
        {
            await HandleContextAsync(new Status { Name = Status_txt.Text });
            Status_txt.Clear();
        }

        private async void TireNum_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TireNum_txt.Text)) return;
            await HandleContextAsync(new TireNumber { Name = TireNum_txt.Text });
            Usage_txt.Clear();
        }

        private async void BrandSave_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Brand_txt.Text)) return;
            await HandleContextAsync(new Brand { Name = Brand_txt.Text });
            using (var context = DbConfig.CreateContext())
            {
                await Helper.SetupComboBoxAsync(Brand_comboBox, new GenericRepository<Brand>(context));
            }
            Usage_txt.Clear();
        }

        private async void AddDataAdmin_Load(object sender, EventArgs e)
        {
            using(var context = DbConfig.CreateContext())
            {
                await Helper.SetupComboBoxAsync(Brand_comboBox, new GenericRepository<Brand>(context));
            }
        }

        private async Task HandleContextAsync<T>(T entity) where T : Entity
        {
            try
            {
                using (var context = DbConfig.CreateContext())
                {
                    var entityRepo = new GenericRepository<T>(context);

                    await entityRepo.AddAsync(entity);
                    await entityRepo.SaveChangesAsync();

                    // رسالة تأكيد لطيفة لليوزر
                    MessageBox.Show("تم الحفظ بنجاح!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // لو الداتابيز مقفولة أو حصل مشكلة، البرنامج مش هيقفل
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
