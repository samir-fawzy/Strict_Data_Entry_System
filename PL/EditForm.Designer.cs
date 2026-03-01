namespace PL
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ChessisNum_txt = new TextBox();
            VehicleNumber_txt = new TextBox();
            label4 = new Label();
            label1 = new Label();
            Search_btn = new Button();
            Edit_btn = new Button();
            bindingSource1 = new BindingSource(components);
            Clear_btn = new Button();
            Brand_lbl = new Label();
            TireSIze_lbl = new Label();
            Usage_lbl = new Label();
            Drivetrains_lbl = new Label();
            BatteryNumber_lbl = new Label();
            Model_lbl = new Label();
            BatterySize_lbl = new Label();
            Preparation_lbl = new Label();
            Payload_lbl = new Label();
            GearBox_lbl = new Label();
            Status_lbl = new Label();
            Engine_lbl = new Label();
            Fuel_lbl = new Label();
            AirCond_lbl = new Label();
            Cabin_lbl = new Label();
            Status_comboBox = new ComboBox();
            Unit_comboBox = new ComboBox();
            Preparation_comboBox = new ComboBox();
            Usage_comboBox = new ComboBox();
            BatterySize_comboBox = new ComboBox();
            TierSize_comboBox = new ComboBox();
            Payload_comboBox = new ComboBox();
            Engine_comboBox = new ComboBox();
            Brand_comboBox = new ComboBox();
            Model_comboBox = new ComboBox();
            FuelType_comboBox = new ComboBox();
            GearBox_comboBox = new ComboBox();
            BatteryNumber_comboBox = new ComboBox();
            Drivetrains_comboBox = new ComboBox();
            AirCond_comboBox = new ComboBox();
            cabin_combo = new ComboBox();
            Unit_lbl = new Label();
            label2 = new Label();
            TireNum_comboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // ChessisNum_txt
            // 
            ChessisNum_txt.Font = new Font("Segoe UI", 15F);
            ChessisNum_txt.Location = new Point(1002, 36);
            ChessisNum_txt.Name = "ChessisNum_txt";
            ChessisNum_txt.Size = new Size(216, 34);
            ChessisNum_txt.TabIndex = 49;
            // 
            // VehicleNumber_txt
            // 
            VehicleNumber_txt.Font = new Font("Segoe UI", 15F);
            VehicleNumber_txt.Location = new Point(1421, 33);
            VehicleNumber_txt.Name = "VehicleNumber_txt";
            VehicleNumber_txt.Size = new Size(216, 34);
            VehicleNumber_txt.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1643, 36);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 47;
            label4.Text = "رقم العربة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(1224, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 46;
            label1.Text = "رقم الشسيه";
            // 
            // Search_btn
            // 
            Search_btn.BackColor = Color.FromArgb(0, 192, 0);
            Search_btn.FlatStyle = FlatStyle.Popup;
            Search_btn.Font = new Font("Segoe UI", 20F);
            Search_btn.Location = new Point(759, 33);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(111, 42);
            Search_btn.TabIndex = 50;
            Search_btn.Text = "بحث";
            Search_btn.UseVisualStyleBackColor = false;
            Search_btn.Click += Search_btn_Click;
            // 
            // Edit_btn
            // 
            Edit_btn.BackColor = Color.LightSalmon;
            Edit_btn.FlatStyle = FlatStyle.Popup;
            Edit_btn.Location = new Point(378, 678);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(202, 48);
            Edit_btn.TabIndex = 79;
            Edit_btn.Text = "تعديل";
            Edit_btn.UseVisualStyleBackColor = false;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // Clear_btn
            // 
            Clear_btn.BackColor = Color.Silver;
            Clear_btn.FlatStyle = FlatStyle.Popup;
            Clear_btn.Location = new Point(102, 678);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(202, 48);
            Clear_btn.TabIndex = 82;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = false;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // Brand_lbl
            // 
            Brand_lbl.AutoSize = true;
            Brand_lbl.Font = new Font("Segoe UI", 15F);
            Brand_lbl.Location = new Point(1581, 165);
            Brand_lbl.Name = "Brand_lbl";
            Brand_lbl.Size = new Size(67, 28);
            Brand_lbl.TabIndex = 113;
            Brand_lbl.Text = "الماركة";
            // 
            // TireSIze_lbl
            // 
            TireSIze_lbl.AutoSize = true;
            TireSIze_lbl.Font = new Font("Segoe UI", 15F);
            TireSIze_lbl.Location = new Point(333, 372);
            TireSIze_lbl.Name = "TireSIze_lbl";
            TireSIze_lbl.Size = new Size(134, 28);
            TireSIze_lbl.TabIndex = 112;
            TireSIze_lbl.Text = "مقاس الكاوتش";
            // 
            // Usage_lbl
            // 
            Usage_lbl.AutoSize = true;
            Usage_lbl.Font = new Font("Segoe UI", 15F);
            Usage_lbl.Location = new Point(1161, 489);
            Usage_lbl.Name = "Usage_lbl";
            Usage_lbl.Size = new Size(92, 28);
            Usage_lbl.TabIndex = 111;
            Usage_lbl.Text = "الاستخدام";
            // 
            // Drivetrains_lbl
            // 
            Drivetrains_lbl.AutoSize = true;
            Drivetrains_lbl.Font = new Font("Segoe UI", 15F);
            Drivetrains_lbl.Location = new Point(1161, 372);
            Drivetrains_lbl.Name = "Drivetrains_lbl";
            Drivetrains_lbl.Size = new Size(56, 28);
            Drivetrains_lbl.TabIndex = 110;
            Drivetrains_lbl.Text = "الدفع";
            // 
            // BatteryNumber_lbl
            // 
            BatteryNumber_lbl.AutoSize = true;
            BatteryNumber_lbl.Font = new Font("Segoe UI", 15F);
            BatteryNumber_lbl.Location = new Point(744, 372);
            BatteryNumber_lbl.Name = "BatteryNumber_lbl";
            BatteryNumber_lbl.Size = new Size(130, 28);
            BatteryNumber_lbl.TabIndex = 109;
            BatteryNumber_lbl.Text = "عدد البطاريات";
            // 
            // Model_lbl
            // 
            Model_lbl.AutoSize = true;
            Model_lbl.Font = new Font("Segoe UI", 15F);
            Model_lbl.Location = new Point(1164, 160);
            Model_lbl.Name = "Model_lbl";
            Model_lbl.Size = new Size(76, 28);
            Model_lbl.TabIndex = 108;
            Model_lbl.Text = "الموديل";
            // 
            // BatterySize_lbl
            // 
            BatterySize_lbl.AutoSize = true;
            BatterySize_lbl.Font = new Font("Segoe UI", 15F);
            BatterySize_lbl.Location = new Point(333, 264);
            BatterySize_lbl.Name = "BatterySize_lbl";
            BatterySize_lbl.Size = new Size(135, 28);
            BatterySize_lbl.TabIndex = 107;
            BatterySize_lbl.Text = "مقاس البطارية";
            // 
            // Preparation_lbl
            // 
            Preparation_lbl.AutoSize = true;
            Preparation_lbl.Font = new Font("Segoe UI", 15F);
            Preparation_lbl.Location = new Point(1595, 484);
            Preparation_lbl.Name = "Preparation_lbl";
            Preparation_lbl.Size = new Size(68, 28);
            Preparation_lbl.TabIndex = 106;
            Preparation_lbl.Text = "التجهيز";
            // 
            // Payload_lbl
            // 
            Payload_lbl.AutoSize = true;
            Payload_lbl.Font = new Font("Segoe UI", 15F);
            Payload_lbl.Location = new Point(744, 265);
            Payload_lbl.Name = "Payload_lbl";
            Payload_lbl.Size = new Size(75, 28);
            Payload_lbl.TabIndex = 105;
            Payload_lbl.Text = "الحمولة";
            // 
            // GearBox_lbl
            // 
            GearBox_lbl.AutoSize = true;
            GearBox_lbl.Font = new Font("Segoe UI", 15F);
            GearBox_lbl.Location = new Point(1164, 264);
            GearBox_lbl.Name = "GearBox_lbl";
            GearBox_lbl.Size = new Size(153, 28);
            GearBox_lbl.TabIndex = 104;
            GearBox_lbl.Text = "نوع الجايروسكوب";
            // 
            // Status_lbl
            // 
            Status_lbl.AutoSize = true;
            Status_lbl.Font = new Font("Segoe UI", 15F);
            Status_lbl.Location = new Point(750, 482);
            Status_lbl.Name = "Status_lbl";
            Status_lbl.Size = new Size(58, 28);
            Status_lbl.TabIndex = 103;
            Status_lbl.Text = "الحالة";
            // 
            // Engine_lbl
            // 
            Engine_lbl.AutoSize = true;
            Engine_lbl.Font = new Font("Segoe UI", 15F);
            Engine_lbl.Location = new Point(753, 160);
            Engine_lbl.Name = "Engine_lbl";
            Engine_lbl.Size = new Size(105, 28);
            Engine_lbl.TabIndex = 102;
            Engine_lbl.Text = "نوع المحرك";
            // 
            // Fuel_lbl
            // 
            Fuel_lbl.AutoSize = true;
            Fuel_lbl.Font = new Font("Segoe UI", 15F);
            Fuel_lbl.Location = new Point(1581, 264);
            Fuel_lbl.Name = "Fuel_lbl";
            Fuel_lbl.Size = new Size(98, 28);
            Fuel_lbl.TabIndex = 101;
            Fuel_lbl.Text = "نوع الوقود";
            // 
            // AirCond_lbl
            // 
            AirCond_lbl.AutoSize = true;
            AirCond_lbl.Font = new Font("Segoe UI", 15F);
            AirCond_lbl.Location = new Point(1581, 369);
            AirCond_lbl.Name = "AirCond_lbl";
            AirCond_lbl.Size = new Size(75, 28);
            AirCond_lbl.TabIndex = 100;
            AirCond_lbl.Text = "التكييف";
            // 
            // Cabin_lbl
            // 
            Cabin_lbl.AutoSize = true;
            Cabin_lbl.Font = new Font("Segoe UI", 15F);
            Cabin_lbl.Location = new Point(333, 159);
            Cabin_lbl.Name = "Cabin_lbl";
            Cabin_lbl.Size = new Size(104, 28);
            Cabin_lbl.TabIndex = 99;
            Cabin_lbl.Text = "نوع الكابينة";
            // 
            // Status_comboBox
            // 
            Status_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Status_comboBox.Font = new Font("Segoe UI", 15F);
            Status_comboBox.FormattingEnabled = true;
            Status_comboBox.Location = new Point(528, 479);
            Status_comboBox.Name = "Status_comboBox";
            Status_comboBox.Size = new Size(216, 36);
            Status_comboBox.TabIndex = 98;
            // 
            // Unit_comboBox
            // 
            Unit_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Unit_comboBox.Font = new Font("Segoe UI", 15F);
            Unit_comboBox.FormattingEnabled = true;
            Unit_comboBox.Location = new Point(102, 479);
            Unit_comboBox.Name = "Unit_comboBox";
            Unit_comboBox.Size = new Size(216, 36);
            Unit_comboBox.TabIndex = 97;
            // 
            // Preparation_comboBox
            // 
            Preparation_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Preparation_comboBox.Font = new Font("Segoe UI", 15F);
            Preparation_comboBox.FormattingEnabled = true;
            Preparation_comboBox.Location = new Point(1356, 479);
            Preparation_comboBox.Name = "Preparation_comboBox";
            Preparation_comboBox.Size = new Size(216, 36);
            Preparation_comboBox.TabIndex = 96;
            // 
            // Usage_comboBox
            // 
            Usage_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Usage_comboBox.Font = new Font("Segoe UI", 15F);
            Usage_comboBox.FormattingEnabled = true;
            Usage_comboBox.Location = new Point(939, 481);
            Usage_comboBox.Name = "Usage_comboBox";
            Usage_comboBox.Size = new Size(216, 36);
            Usage_comboBox.TabIndex = 95;
            // 
            // BatterySize_comboBox
            // 
            BatterySize_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BatterySize_comboBox.Font = new Font("Segoe UI", 15F);
            BatterySize_comboBox.FormattingEnabled = true;
            BatterySize_comboBox.Location = new Point(111, 261);
            BatterySize_comboBox.Name = "BatterySize_comboBox";
            BatterySize_comboBox.Size = new Size(216, 36);
            BatterySize_comboBox.TabIndex = 94;
            // 
            // TierSize_comboBox
            // 
            TierSize_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TierSize_comboBox.Font = new Font("Segoe UI", 15F);
            TierSize_comboBox.FormattingEnabled = true;
            TierSize_comboBox.Location = new Point(111, 369);
            TierSize_comboBox.Name = "TierSize_comboBox";
            TierSize_comboBox.Size = new Size(216, 36);
            TierSize_comboBox.TabIndex = 93;
            // 
            // Payload_comboBox
            // 
            Payload_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Payload_comboBox.Font = new Font("Segoe UI", 15F);
            Payload_comboBox.FormattingEnabled = true;
            Payload_comboBox.Location = new Point(522, 262);
            Payload_comboBox.Name = "Payload_comboBox";
            Payload_comboBox.Size = new Size(216, 36);
            Payload_comboBox.TabIndex = 92;
            // 
            // Engine_comboBox
            // 
            Engine_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Engine_comboBox.Font = new Font("Segoe UI", 15F);
            Engine_comboBox.FormattingEnabled = true;
            Engine_comboBox.Location = new Point(531, 157);
            Engine_comboBox.Name = "Engine_comboBox";
            Engine_comboBox.Size = new Size(216, 36);
            Engine_comboBox.TabIndex = 91;
            // 
            // Brand_comboBox
            // 
            Brand_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Brand_comboBox.Font = new Font("Segoe UI", 15F);
            Brand_comboBox.FormattingEnabled = true;
            Brand_comboBox.Location = new Point(1359, 157);
            Brand_comboBox.Name = "Brand_comboBox";
            Brand_comboBox.Size = new Size(216, 36);
            Brand_comboBox.TabIndex = 90;
            Brand_comboBox.SelectedIndexChanged += Brand_comboBox_SelectedIndexChanged;
            // 
            // Model_comboBox
            // 
            Model_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Model_comboBox.Font = new Font("Segoe UI", 15F);
            Model_comboBox.FormattingEnabled = true;
            Model_comboBox.Location = new Point(942, 157);
            Model_comboBox.Name = "Model_comboBox";
            Model_comboBox.Size = new Size(216, 36);
            Model_comboBox.TabIndex = 89;
            // 
            // FuelType_comboBox
            // 
            FuelType_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FuelType_comboBox.Font = new Font("Segoe UI", 15F);
            FuelType_comboBox.FormattingEnabled = true;
            FuelType_comboBox.Location = new Point(1359, 261);
            FuelType_comboBox.Name = "FuelType_comboBox";
            FuelType_comboBox.Size = new Size(216, 36);
            FuelType_comboBox.TabIndex = 88;
            // 
            // GearBox_comboBox
            // 
            GearBox_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GearBox_comboBox.Font = new Font("Segoe UI", 15F);
            GearBox_comboBox.FormattingEnabled = true;
            GearBox_comboBox.Location = new Point(942, 261);
            GearBox_comboBox.Name = "GearBox_comboBox";
            GearBox_comboBox.Size = new Size(216, 36);
            GearBox_comboBox.TabIndex = 87;
            // 
            // BatteryNumber_comboBox
            // 
            BatteryNumber_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BatteryNumber_comboBox.Font = new Font("Segoe UI", 15F);
            BatteryNumber_comboBox.FormattingEnabled = true;
            BatteryNumber_comboBox.Location = new Point(522, 369);
            BatteryNumber_comboBox.Name = "BatteryNumber_comboBox";
            BatteryNumber_comboBox.Size = new Size(216, 36);
            BatteryNumber_comboBox.TabIndex = 86;
            // 
            // Drivetrains_comboBox
            // 
            Drivetrains_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Drivetrains_comboBox.Font = new Font("Segoe UI", 15F);
            Drivetrains_comboBox.FormattingEnabled = true;
            Drivetrains_comboBox.Location = new Point(939, 369);
            Drivetrains_comboBox.Name = "Drivetrains_comboBox";
            Drivetrains_comboBox.Size = new Size(219, 36);
            Drivetrains_comboBox.TabIndex = 85;
            // 
            // AirCond_comboBox
            // 
            AirCond_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AirCond_comboBox.Font = new Font("Segoe UI", 15F);
            AirCond_comboBox.FormattingEnabled = true;
            AirCond_comboBox.Location = new Point(1359, 367);
            AirCond_comboBox.Name = "AirCond_comboBox";
            AirCond_comboBox.Size = new Size(216, 36);
            AirCond_comboBox.TabIndex = 84;
            // 
            // cabin_combo
            // 
            cabin_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            cabin_combo.Font = new Font("Segoe UI", 15F);
            cabin_combo.FormattingEnabled = true;
            cabin_combo.Location = new Point(111, 157);
            cabin_combo.Name = "cabin_combo";
            cabin_combo.Size = new Size(216, 36);
            cabin_combo.TabIndex = 83;
            // 
            // Unit_lbl
            // 
            Unit_lbl.AutoSize = true;
            Unit_lbl.Font = new Font("Segoe UI", 15F);
            Unit_lbl.Location = new Point(324, 484);
            Unit_lbl.Name = "Unit_lbl";
            Unit_lbl.Size = new Size(66, 28);
            Unit_lbl.TabIndex = 114;
            Unit_lbl.Text = "الوحدة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(1578, 581);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 116;
            label2.Text = "عدد الكاوتش";
            // 
            // TireNum_comboBox
            // 
            TireNum_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TireNum_comboBox.Font = new Font("Segoe UI", 15F);
            TireNum_comboBox.FormattingEnabled = true;
            TireNum_comboBox.Location = new Point(1356, 578);
            TireNum_comboBox.Name = "TireNum_comboBox";
            TireNum_comboBox.Size = new Size(216, 36);
            TireNum_comboBox.TabIndex = 115;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1806, 823);
            Controls.Add(label2);
            Controls.Add(TireNum_comboBox);
            Controls.Add(Unit_lbl);
            Controls.Add(Brand_lbl);
            Controls.Add(TireSIze_lbl);
            Controls.Add(Usage_lbl);
            Controls.Add(Drivetrains_lbl);
            Controls.Add(BatteryNumber_lbl);
            Controls.Add(Model_lbl);
            Controls.Add(BatterySize_lbl);
            Controls.Add(Preparation_lbl);
            Controls.Add(Payload_lbl);
            Controls.Add(GearBox_lbl);
            Controls.Add(Status_lbl);
            Controls.Add(Engine_lbl);
            Controls.Add(Fuel_lbl);
            Controls.Add(AirCond_lbl);
            Controls.Add(Cabin_lbl);
            Controls.Add(Status_comboBox);
            Controls.Add(Unit_comboBox);
            Controls.Add(Preparation_comboBox);
            Controls.Add(Usage_comboBox);
            Controls.Add(BatterySize_comboBox);
            Controls.Add(TierSize_comboBox);
            Controls.Add(Payload_comboBox);
            Controls.Add(Engine_comboBox);
            Controls.Add(Brand_comboBox);
            Controls.Add(Model_comboBox);
            Controls.Add(FuelType_comboBox);
            Controls.Add(GearBox_comboBox);
            Controls.Add(BatteryNumber_comboBox);
            Controls.Add(Drivetrains_comboBox);
            Controls.Add(AirCond_comboBox);
            Controls.Add(cabin_combo);
            Controls.Add(Clear_btn);
            Controls.Add(Edit_btn);
            Controls.Add(Search_btn);
            Controls.Add(ChessisNum_txt);
            Controls.Add(VehicleNumber_txt);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ChessisNum_txt;
        private TextBox VehicleNumber_txt;
        private Label label4;
        private Label label1;
        private Button Search_btn;
        private Button Edit_btn;
        private BindingSource bindingSource1;
        private Button Clear_btn;
        private Label Brand_lbl;
        private Label TireSIze_lbl;
        private Label Usage_lbl;
        private Label Drivetrains_lbl;
        private Label BatteryNumber_lbl;
        private Label Model_lbl;
        private Label BatterySize_lbl;
        private Label Preparation_lbl;
        private Label Payload_lbl;
        private Label GearBox_lbl;
        private Label Status_lbl;
        private Label Engine_lbl;
        private Label Fuel_lbl;
        private Label AirCond_lbl;
        private Label Cabin_lbl;
        private ComboBox Status_comboBox;
        private ComboBox Unit_comboBox;
        private ComboBox Preparation_comboBox;
        private ComboBox Usage_comboBox;
        private ComboBox BatterySize_comboBox;
        private ComboBox TierSize_comboBox;
        private ComboBox Payload_comboBox;
        private ComboBox Engine_comboBox;
        private ComboBox Brand_comboBox;
        private ComboBox Model_comboBox;
        private ComboBox FuelType_comboBox;
        private ComboBox GearBox_comboBox;
        private ComboBox BatteryNumber_comboBox;
        private ComboBox Drivetrains_comboBox;
        private ComboBox AirCond_comboBox;
        private ComboBox cabin_combo;
        private Label Unit_lbl;
        private Label label2;
        private ComboBox TireNum_comboBox;
    }
}