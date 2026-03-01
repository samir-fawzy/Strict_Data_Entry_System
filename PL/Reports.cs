using BLL.Repository;
using BLL.SpecClasses;
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
using ClosedXML.Excel;
using System.IO;

namespace PL
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private async void GetAllProjects_btn_Click(object sender, EventArgs e)
        {
            try
            {


                dgvData.DataSource = null; // مسح البيانات القديمة من الجدول قبل عرض الجديد


                if (!LatestUpdate_checkBox.Checked)
                {
                    var modelFilter = (int?)Model_ComboBox.SelectedValue;
                    var engineFilter = (int?)Engine_comboBox.SelectedValue;
                    var vehicleNumFilter = string.IsNullOrWhiteSpace(VehicleNumber_txt.Text) ? null : VehicleNumber_txt.Text;
                    var chassisNumFilter = string.IsNullOrWhiteSpace(ChessisNum_txt.Text) ? null : ChessisNum_txt.Text;
                    DateTime? startDateFilter = checkBox1.Checked ? dtp_start.Value : null;
                    DateTime? endDateFilter = checkBox1.Checked ? dtp_end.Value : null;

                    var filter = new FilterVehicleHistory
                    {
                        ModelId = modelFilter,
                        EnigneId = engineFilter,
                        VehicleNumber = vehicleNumFilter,
                        ChassisNumber = chassisNumFilter,
                        Start = startDateFilter,
                        End = endDateFilter
                    };
                    using (var context = DbConfig.CreateContext())
                    {
                        var vehicleHistoryRepo = new GenericRepository<VehicleHistory>(context);

                        // 1. ضفنا await هنا عشان نستنى الداتا تيجي فعلاً
                        var records = await vehicleHistoryRepo.GetAllSpecAsync(new GetAllVehicleHistory(filter));

                        // 2. تشكيل الداتا (Projection) عشان نفردها للـ DataGridView
                        var displayData = records.Select(r => new
                        {

                            // -- بيانات المركبة --
                            // استخدمنا علامة ? عشان لو مفيش داتا البرنامج ميضربش NullReferenceException
                            VehicleNumber = r.VehicleNumber ?? "غير محدد",
                            ChassisNumber = r.ChassisNumber ?? "غير محدد",
                            Brand = r.Model?.Brand.Name ?? "غير محدد",
                            Model = r.Model?.Name ?? "غير محدد",
                            Engine = r.Engine?.Name ?? "غير محدد",
                            FuelType = r.FuelType ?? "غير محدد",
                            Payload = r.Payload?.Name ?? "غير محدد",
                            BatterySize = r.BatterySize?.Name ?? "غير محدد",
                            TireSize = r.TireSize?.Name ?? "غير محدد",
                            TireNumber = r.TireNumber.Name ?? "غير محدد",
                            //AirConditioningType = Enum.GetName(AirConditioningType, p.Vehicle?.AirConditioning)"غير محدد",

                            // -- بيانات الوحدة --
                            UnitName = r.Unit.Name ?? "غير محدد",

                            // -- بيانات التعديل --
                            Preparation = r.Preparation?.Name ?? "غير محدد",
                            Usage = r.Usage?.Name ?? "غير محدد",
                            Status = r.Status?.Name ?? "غير محدد",

                            // -- السجل --
                            HistoryDate = r.Date.ToString("yyyy-MM-dd") ?? "لا يوجد"
                        }).ToList();

                        // 3. نربط الداتا المتنظفة دي بالجدول
                        dgvData.DataSource = displayData;

                        // (اختياري) لو عايز تخفي عمود الـ ID
                        // dgvData.Columns["ProjectId"].Visible = false;
                    }

                }
                else
                {
                    var modelFilter = Model_ComboBox.Text;
                    var engineFilter = Engine_comboBox.Text;
                    var vehicleNumFilter = string.IsNullOrWhiteSpace(VehicleNumber_txt.Text) ? null : VehicleNumber_txt.Text;
                    var chassisNumFilter = string.IsNullOrWhiteSpace(ChessisNum_txt.Text) ? null : ChessisNum_txt.Text;
                    DateTime? startDateFilter = checkBox1.Checked ? dtp_start.Value : null;
                    DateTime? endDateFilter = checkBox1.Checked ? dtp_end.Value : null;
                    var filter = new Filter
                    {
                        Enigne = engineFilter,
                        Model = modelFilter,
                        VehicleNumber = vehicleNumFilter,
                        ChassisNumber = chassisNumFilter,
                        Start = startDateFilter,
                        End = endDateFilter
                    };
                    using (var context = DbConfig.CreateContext())
                    {
                        var projectRepo = new GenericRepository<Project>(context);

                        // 1. ضفنا await هنا عشان نستنى الداتا تيجي فعلاً
                        var records = await projectRepo.GetAllSpecAsync(new GetAllProjects(filter));

                        // 2. تشكيل الداتا (Projection) عشان نفردها للـ DataGridView
                        var displayData = records.Select(p => new
                        {

                            // -- بيانات المركبة --
                            VehicleNumber = p.Vehicle.VehicleNumber ?? "غير محدد",
                            ChassisNumber = p.Vehicle.ChassisNumber ?? "غير محدد",
                            // استخدمنا علامة ? عشان لو مفيش داتا البرنامج ميضربش NullReferenceException
                            Brand = p.Vehicle.Model?.Brand.Name ?? "غير محدد",
                            Model = p.Vehicle.Model?.Name ?? "غير محدد",
                            Engine = p.Vehicle.Engine?.Name ?? "غير محدد",
                            Payload = p.Vehicle.Payload?.Name ?? "غير محدد",
                            BatterySize = p.Vehicle.BatterySize?.Name ?? "غير محدد",
                            TireSize = p.Vehicle.TireSize?.Name ?? "غير محدد",
                            TireNumber = p.Vehicle.TireNumber?.Name ?? "غير محدد",
                            //AirConditioningType = Enum.GetName(AirConditioningType, p.Vehicle?.AirConditioning)"غير محدد",

                            // -- بيانات الوحدة --
                            UnitName = p.Unit.Name ?? "غير محدد",

                            // -- بيانات التعديل --
                            Preparation = p.Edit.Preparation?.Name ?? "غير محدد",
                            Usage = p.Edit.Usage?.Name ?? "غير محدد",
                            Status = p.Edit.Status?.Name ?? "غير محدد",

                            // -- السجل --
                            HistoryDate = p.VehicleHistory.Date.ToString("yyyy-MM-dd") ?? "لا يوجد"
                        }).ToList();

                        // 3. نربط الداتا المتنظفة دي بالجدول
                        dgvData.DataSource = displayData;

                        // (اختياري) لو عايز تخفي عمود الـ ID
                        // dgvData.Columns["ProjectId"].Visible = false;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            using (var context = DbConfig.CreateContext())
            {
                await Helper.SetupComboBoxAsync(Brand_comboBox, new GenericRepository<Brand>(context));
                //await Helper.SetupComboBoxAsync(Model_ComboBox, new GenericRepository<Model>(context));
                await Helper.SetupComboBoxAsync(Engine_comboBox, new GenericRepository<Engine>(context));
            }
            Brand_comboBox.SelectedIndex = -1; // عشان يبدأ بدون اختيار
            Model_ComboBox.SelectedIndex = -1; // عشان يبدأ بدون اختيار
            Engine_comboBox.SelectedIndex = -1; // عشان يبدأ بدون اختيار
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brand_comboBox.SelectedIndex = -1; // عشان يبدأ بدون اختيار
            Model_ComboBox.SelectedIndex = -1; // عشان يبدأ بدون اختيار
            Engine_comboBox.SelectedIndex = -1; // عشان يبدأ بدون اختيار
            VehicleNumber_txt.Text = null;
            ChessisNum_txt.Text = null;
            dgvData.DataSource = null; // مسح البيانات من الجدول
        }

        private async void ExportExcel_btn_Click(object sender, EventArgs e)
        {
            // 1. نتأكد إن الجدول فيه بيانات أصلاً
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد بيانات لتصديرها!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. نفتح شاشة لليوزر عشان يختار هيحفظ الملف فين واسمه إيه
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx"; // تحديد امتداد الملف
                sfd.Title = "حفظ ملف الإكسل";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 3. إنشاء ملف الإكسل
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("بيانات المركبات"); // اسم الشيت من جوه

                            // 4. كتابة أسماء الأعمدة (Headers) في الصف الأول
                            for (int i = 0; i < dgvData.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dgvData.Columns[i].HeaderText;
                            }

                            // 5. كتابة البيانات (Rows)
                            for (int i = 0; i < dgvData.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvData.Columns.Count; j++)
                                {
                                    var cellValue = dgvData.Rows[i].Cells[j].Value;
                                    worksheet.Cell(i + 2, j + 1).Value = cellValue?.ToString() ?? "";
                                }
                            }

                            // (اختياري) تظبيط عرض الأعمدة تلقائياً عشان الكلام ميبقاش مقطوع
                            worksheet.Columns().AdjustToContents();

                            // 6. حفظ الملف في المسار اللي اليوزر اختاره
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("تم تصدير البيانات إلى إكسل بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // الإيرور ده غالباً بيحصل لو اليوزر فاتح ملف الإكسل وببيحاول يحفظ عليه في نفس الوقت
                        MessageBox.Show($"حدث خطأ أثناء الحفظ، تأكد أن الملف ليس مفتوحاً بالفعل.\n\nتفاصيل الخطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void Brand_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Brand_comboBox.SelectedValue is int brandId)
            {
                using (var context = DbConfig.CreateContext())
                {
                    var modelRepo = new GenericRepository<Model>(context);
                    var models = await modelRepo.GetAllSpecAsync(new GetModelsByBrandIdSpec((int)Brand_comboBox.SelectedValue));
                    Model_ComboBox.DataSource = models;
                    Model_ComboBox.DisplayMember = "Name";
                    Model_ComboBox.ValueMember = "Id";
                    Model_ComboBox.SelectedIndex = -1; // لتفريغ الاختيار بعد التحديث
                }
            }
        }
    }
}
