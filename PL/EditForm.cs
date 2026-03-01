using BLL.Repository;
using BLL.SpecClasses;
using DAL.Data.Services;
using DAL.Entities;
using DAL.Entities.EditEntites;
using DAL.Entities.VehicleEntities;
using DAL.EntitiesNotInDB;
using PL.Extensions;

namespace PL
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        string? vNum;
        string? cNum;
        private async void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                vNum = string.IsNullOrWhiteSpace(VehicleNumber_txt.Text) ? null : VehicleNumber_txt.Text;
                cNum = string.IsNullOrWhiteSpace(ChessisNum_txt.Text) ? null : ChessisNum_txt.Text;

                if (vNum == null && cNum == null)
                {
                    MessageBox.Show("ادخل واحد علي الاقل من رقم العربية او رقم الشسيه");
                    return;
                }

                var data = await Helper.LoadStaticData();

                var cabins = data[0];
                var airCond = data[1];
                var batteryNums = data[2];
                var drivetrains = data[3];
                var fuelTypes = data[4];
                var gearboxes = data[5];


                using (var context = DbConfig.CreateContext())
                {
                    var projectRepo = new GenericRepository<Project>(context);
                    var project = await projectRepo.GetByVehicleNumberSpecAsync(new GetByVehicleNumSpec(vNum,cNum));

                    if (project != null)
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
                        await Helper.SetupComboBoxAsync(Status_comboBox, new GenericRepository<Status>(context));
                        await Helper.SetupComboBoxAsync(TireNum_comboBox, new GenericRepository<TireNumber>(context));

                        cabin_combo.DataSource = cabins;
                        AirCond_comboBox.DataSource = airCond;
                        BatteryNumber_comboBox.DataSource = batteryNums;
                        Drivetrains_comboBox.DataSource = drivetrains;
                        FuelType_comboBox.DataSource = fuelTypes;
                        GearBox_comboBox.DataSource = gearboxes;

                        // Vehicle Data
                        Brand_comboBox.Text = project?.Vehicle?.Model?.Brand?.Name ?? "";
                        Model_comboBox.Text = project?.Vehicle?.Model?.Name ?? "";
                        Engine_comboBox.Text = project?.Vehicle?.Engine?.Name ?? "";
                        FuelType_comboBox.Text = project.Vehicle.Fuel ?? "";
                        GearBox_comboBox.Text = project.Vehicle.Gearbox ?? "";
                        cabin_combo.Text = project.Vehicle.Cabin ?? "";
                        AirCond_comboBox.Text = project.Vehicle.AirConditioning ?? "";
                        Payload_comboBox.Text = project.Vehicle.Payload.Name ?? "";
                        BatterySize_comboBox.Text = project.Vehicle.BatterySize.Name ?? "";
                        Drivetrains_comboBox.Text = project.Vehicle.DrivetrainType ?? "";
                        TierSize_comboBox.Text = project.Vehicle.TireSize.Name ?? "";
                        BatteryNumber_comboBox.Text = project.Vehicle.BatteryNumber.ToString() ?? "";
                        Drivetrains_comboBox.Text = project?.Vehicle?.DrivetrainType?.ToString() ?? "";
                        TireNum_comboBox.Text = project?.Vehicle?.TireNumber.Name ?? "";
                        // Edit Data
                        Preparation_comboBox.Text = project?.Edit?.Preparation.Name ?? "";
                        Usage_comboBox.Text = project?.Edit.Usage.Name ?? "";
                        Status_comboBox.Text = project?.Edit.Status.Name ?? "";

                    }
                    else
                    {
                        MessageBox.Show("Not Found!");
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
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

        private async void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = DbConfig.CreateContext())
                {
                    var projectRepo = new GenericRepository<Project>(context);
                    var vehicleHistoryRepo = new GenericRepository<VehicleHistory>(context);
                    // لا نحتاج Repositories للـ Vehicle والـ Edit لأنهم سيتحدثون تلقائياً مع الـ Project

                    // 1. جلب المشروع بكل بياناته المرتبطة
                    var project = await projectRepo.GetByVehicleNumberSpecAsync(new GetByVehicleNumWithTrackingSpec(vNum,cNum));

                    if (project == null)
                    {
                        MessageBox.Show("لم يتم العثور على المشروع!");
                        return;
                    }

                    // 2. تحديث بيانات المركبة (تعديل الكائن الحالي)
                    project.Vehicle.EngineId = (int)Engine_comboBox.SelectedValue;
                    project.Vehicle.PayloadId = (int)Payload_comboBox.SelectedValue;
                    project.Vehicle.BatterySizeId = (int)BatterySize_comboBox.SelectedValue;
                    project.Vehicle.TireSizeId = (int)TierSize_comboBox.SelectedValue;
                    project.Vehicle.BatteryNumber = BatteryNumber_comboBox.Text;
                    project.Vehicle.ModelId = (int)Model_comboBox.SelectedValue;
                    project.Vehicle.TireNumberId = (int)TireNum_comboBox.SelectedValue;
                    project.Vehicle.Cabin = cabin_combo.Text;
                    project.Vehicle.AirConditioning = AirCond_comboBox.Text;
                    project.Vehicle.DrivetrainType = Drivetrains_comboBox.Text;
                    project.Vehicle.Fuel = FuelType_comboBox.Text;
                    project.Vehicle.Gearbox = GearBox_comboBox.Text;
                    // لا داعي لإعادة تعيين الـ VehicleNumber و ChassisNumber لو لم يتغيرا

                    // 3. تحديث بيانات التعديل (Edit)
                    project.Edit.PreparationId = (int)Preparation_comboBox.SelectedValue;
                    project.Edit.UsageId = (int)Usage_comboBox.SelectedValue;
                    project.Edit.StatusId = (int)Status_comboBox.SelectedValue;

                    // 4. ربط المشروع بالوحدة الجديدة (من خلال الـ ID فقط كما طلبت)
                    // هذا السطر يفك الارتباط بالوحدة القديمة ويربطه بالوحدة التي اختارها المستخدم من الكومبوبوكس
                    project.UnitId = (int)Unit_comboBox.SelectedValue;

                    // 5. إضافة سجل تاريخ جديد (History)
                    // يجب أن يكون كائن جديد New Object لكي يتم إضافته كصف جديد في قاعدة البيانات
                    var newVehicleHistory = new VehicleHistory
                    {
                        Date = DateTime.Now,
                        VehicleId = project.Vehicle.Id, // نربطه بالـ Vehicle
                        BatteryNumber = project.Vehicle.BatteryNumber,
                        DrivetrainType = project.Vehicle.DrivetrainType,
                        AirConditioning = project.Vehicle.AirConditioning,
                        FuelType = project.Vehicle.Fuel,
                        Gearbox = project.Vehicle.Gearbox,
                        Cabins = project.Vehicle.Cabin,
                        TireSizeId = project.Vehicle.TireSizeId,
                        ModelId = project.Vehicle.ModelId,
                        EngineId = project.Vehicle.EngineId,
                        PayloadId = project.Vehicle.PayloadId,
                        BatterySizeId = project.Vehicle.BatterySizeId,
                        TireNumberId = project.Vehicle.TireNumberId,
                        ChassisNumber = project.Vehicle.ChassisNumber,
                        VehicleNumber = project.Vehicle.VehicleNumber,
                        PreparationId = project.Edit.PreparationId,
                        UsageId = project.Edit.UsageId,
                        StatusId = project.Edit.StatusId,
                        UnitId = project.UnitId // تسجيل الوحدة وقت هذا التعديل
                    };

                    await vehicleHistoryRepo.AddAsync(newVehicleHistory);
                    await projectRepo.UpdateAsync(project);
                    // 6. حفظ التغييرات
                    // الـ EF Core سيقوم بعمل UPDATE لـ Vehicle و Edit و Project، وعمل INSERT لـ VehicleHistory تلقائياً
                    //await projectRepo.UpdateAsync(project); // قد تحتاج هذا السطر أو لا تحتاجه حسب تصميم GenericRepository الخاص بك
                    await projectRepo.SaveChangesAsync();

                    MessageBox.Show("تم التعديل وحفظ السجل بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في التعديل: " + ex.Message);
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
                    Model_comboBox.DataSource = models;
                    Model_comboBox.DisplayMember = "Name";
                    Model_comboBox.ValueMember = "Id";
                    //Model_comboBox.SelectedIndex = -1; // لتفريغ الاختيار بعد التحديث
                }
            }
        }
    }
}

