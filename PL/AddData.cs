using BLL.Repository;
using BLL.SpecClasses;
using DAL.Data.Services;
using DAL.Entities;
using DAL.Entities.EditEntites;
using DAL.Entities.VehicleEntities;
using DAL.EntitiesNotInDB;
using PL.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PL
{
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        private async void AddData_Load(object sender, EventArgs e)
        {

            var cabins = new List<string>
            {
                "كابينة مزدوجة" ,
                "كابينة مفردة",
            };
            cabin_combo.DataSource = cabins;

            var airConditions = new List<string>
            {
                "مكيف" ,
                "غير مكيف",
            };
            AirCond_comboBox.DataSource = airConditions;

            List<int> batteryNumber = new List<int>
            {
               1,
               2
            };


            BatteryNumber_comboBox.DataSource = batteryNumber;

            List<string> drivetrains = new List<string>
            {
                "6x6" ,
                "4x2" ,
                "4x4",
                "4x6",
            };

            Drivetrains_comboBox.DataSource = drivetrains;


            var fuelTypes = new List<string>
            {
                "بدون",
                "بنزين80",
                "بنزين92",
                "سمر ديزل" ,
                "كهرباء",
                "سولار"
            };
            FuelType_comboBox.DataSource = fuelTypes;

            var gearboxTypes = new List<string>
            {
                "يدوي" ,
                "اوتوماتيك",
                "CVT"
            };

            GearBox_comboBox.DataSource = gearboxTypes;

            // start dynamic data
            using (var context = DbConfig.CreateContext())
            {
                await Helper.SetupComboBoxAsync(Brand_comboBox, new GenericRepository<Brand>(context));
                //await Helper.SetupComboBoxAsync(Model_comboBox, new GenericRepository<Model>(context));
                await Helper.SetupComboBoxAsync(Engine_comboBox, new GenericRepository<Engine>(context));
                await Helper.SetupComboBoxAsync(Payload_comboBox, new GenericRepository<Payload>(context));
                await Helper.SetupComboBoxAsync(BatterySize_comboBox, new GenericRepository<BatterySize>(context));
                await Helper.SetupComboBoxAsync(TierSize_comboBox, new GenericRepository<TireSize>(context));
                await Helper.SetupComboBoxAsync(Unit_comboBox, new GenericRepository<Unit>(context));
                await Helper.SetupComboBoxAsync(Preparation_comboBox, new GenericRepository<Preparation>(context));
                await Helper.SetupComboBoxAsync(Usage_comboBox, new GenericRepository<Usage>(context));
                await Helper.SetupComboBoxAsync(Status_comboBox, new GenericRepository<DAL.Entities.EditEntites.Status>(context));
                await Helper.SetupComboBoxAsync(TireNum_comboBox, new GenericRepository<TireNumber>(context));

            }

            Brand_comboBox.SelectedIndex = -1;
            Model_comboBox.SelectedIndex = -1;
            Engine_comboBox.SelectedIndex = -1;
            Payload_comboBox.SelectedIndex = -1;
            BatterySize_comboBox.SelectedIndex = -1;
            TierSize_comboBox.SelectedIndex = -1;
            Unit_comboBox.SelectedIndex = -1;
            Preparation_comboBox.SelectedIndex = -1;
            Usage_comboBox.SelectedIndex = -1;
            Status_comboBox.SelectedIndex = -1;
            TireNum_comboBox.SelectedIndex = -1;
            GearBox_comboBox.SelectedIndex = -1;
            FuelType_comboBox.SelectedIndex = -1;
            cabin_combo.SelectedIndex = -1;
            Drivetrains_comboBox.SelectedIndex = -1;
            AirCond_comboBox.SelectedIndex = -1;
            BatteryNumber_comboBox.SelectedIndex = -1;
            // end dynamic data

        }
        private async void btnSend_AddForm_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrWhiteSpace(VehicleNumber_txt.Text)) ||
                    (string.IsNullOrWhiteSpace(ChessisNum_txt.Text)))
                {
                    MessageBox.Show("تأكد من ادخال جميع البيانات !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var vehicle = new Vehicle
                {
                    EngineId = (int)Engine_comboBox.SelectedValue,
                    PayloadId = (int)Payload_comboBox.SelectedValue,
                    BatterySizeId = (int)BatterySize_comboBox.SelectedValue,
                    TireSizeId = (int)TierSize_comboBox.SelectedValue,
                    BatteryNumber = BatteryNumber_comboBox.Text,
                    ModelId = (int)Model_comboBox.SelectedValue,
                    TireNumberId = (int)TireNum_comboBox.SelectedValue,
                    Cabin = (string)cabin_combo.Text,
                    AirConditioning = (string)AirCond_comboBox.Text,
                    DrivetrainType = (string)Drivetrains_comboBox.Text,
                    Fuel = (string)FuelType_comboBox.Text,
                    Gearbox = (string)GearBox_comboBox.Text,

                    VehicleNumber = VehicleNumber_txt.Text,
                    ChassisNumber = ChessisNum_txt.Text,
                };



                var edit = new Edit
                {
                    PreparationId = (int)Preparation_comboBox.SelectedValue,
                    UsageId = (int)Usage_comboBox.SelectedValue,
                    StatusId = (int)Status_comboBox.SelectedValue,
                };

                var vechicleHistory = new VehicleHistory
                {
                    Date = DateTime.Now,
                    Vehicle = vehicle,
                    BatteryNumber = vehicle.BatteryNumber,
                    DrivetrainType = vehicle.DrivetrainType,
                    AirConditioning = vehicle.AirConditioning,
                    FuelType = vehicle.Fuel,
                    Gearbox = vehicle.Gearbox,
                    Cabins = vehicle.Cabin,
                    TireSizeId = vehicle.TireSizeId,
                    ModelId = vehicle.ModelId,
                    EngineId = vehicle.EngineId,
                    PayloadId = vehicle.PayloadId,
                    BatterySizeId = vehicle.BatterySizeId,
                    TireNumberId = vehicle.TireNumberId,
                    ChassisNumber = vehicle.ChassisNumber,
                    VehicleNumber = vehicle.VehicleNumber,
                    PreparationId = edit.PreparationId,
                    UsageId = edit.UsageId,
                    StatusId = edit.StatusId,
                    UnitId = (int)Unit_comboBox.SelectedValue
                };

                var project = new Project
                {
                    // ربطنا كل الكائنات ببعضها هنا (Navigation Properties)
                    Vehicle = vehicle,
                    VehicleHistory = vechicleHistory,
                    Edit = edit,
                    UnitId = (int)Unit_comboBox.SelectedValue, // تأكد إن فيه قيمة قبل التحويل
                    Unit = null
                };

                // 3. التعامل مع الداتابيز
                using (var context = DbConfig.CreateContext())
                {
                    var projectRepo = new GenericRepository<Project>(context);

                    // السطر ده لوحده كفيل يضيف الـ Project والـ Vehicle والـ Edit والـ History والـ Unit!
                    await projectRepo.AddAsync(project);

                    // حفظ التغييرات في كل الجداول مرة واحدة
                    await projectRepo.SaveChangesAsync();
                }

                MessageBox.Show("تم حفظ البيانات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            VehicleNumber_txt.Clear();
            ChessisNum_txt.Clear();

            Brand_comboBox.SelectedIndex = -1;
            Model_comboBox.SelectedIndex = -1;
            Engine_comboBox.SelectedIndex = -1;
            Payload_comboBox.SelectedIndex = -1;
            BatterySize_comboBox.SelectedIndex = -1;
            TierSize_comboBox.SelectedIndex = -1;
            Unit_comboBox.SelectedIndex = -1;
            Preparation_comboBox.SelectedIndex = -1;
            Usage_comboBox.SelectedIndex = -1;
            Status_comboBox.SelectedIndex = -1;
            TireNum_comboBox.SelectedIndex = -1;
            GearBox_comboBox.SelectedIndex = -1;
            FuelType_comboBox.SelectedIndex = -1;
            cabin_combo.SelectedIndex = -1;
            Drivetrains_comboBox.SelectedIndex = -1;
            AirCond_comboBox.SelectedIndex = -1;
            BatteryNumber_comboBox.SelectedIndex = -1;
        }

        private async void Brand_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Brand_comboBox.SelectedValue is int brandId)
            {
                using (var context = DbConfig.CreateContext())
                {
                    var modelRepo = new GenericRepository<Model>(context);
                    var models = await modelRepo.GetAllSpecAsync(new GetModelsByBrandIdSpec((int)Brand_comboBox.SelectedValue));
                    Model_comboBox.DataSource = models;
                    Model_comboBox.DisplayMember = "Name";
                    Model_comboBox.ValueMember = "Id";
                    Model_comboBox.SelectedIndex = -1; // لتفريغ الاختيار بعد التحديث
                }
            }
        }
    }
}
