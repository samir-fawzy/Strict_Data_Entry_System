namespace PL
{
    partial class Reports
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
            GetAllProjects_btn = new Button();
            dgvData = new DataGridView();
            Brand_comboBox = new ComboBox();
            Model_ComboBox = new ComboBox();
            Engine_comboBox = new ComboBox();
            dtp_start = new DateTimePicker();
            dtp_end = new DateTimePicker();
            Brand_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            VehicleNumber_txt = new TextBox();
            ChessisNum_txt = new TextBox();
            LatestUpdate_checkBox = new CheckBox();
            ExportExcel_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // GetAllProjects_btn
            // 
            GetAllProjects_btn.BackColor = Color.FromArgb(0, 192, 0);
            GetAllProjects_btn.FlatStyle = FlatStyle.Popup;
            GetAllProjects_btn.Font = new Font("Segoe UI", 20F);
            GetAllProjects_btn.Location = new Point(1613, 42);
            GetAllProjects_btn.Name = "GetAllProjects_btn";
            GetAllProjects_btn.Size = new Size(143, 118);
            GetAllProjects_btn.TabIndex = 0;
            GetAllProjects_btn.Text = "Get";
            GetAllProjects_btn.UseVisualStyleBackColor = false;
            GetAllProjects_btn.Click += GetAllProjects_btn_Click;
            // 
            // dgvData
            // 
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 196);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(1790, 438);
            dgvData.TabIndex = 1;
            // 
            // Brand_comboBox
            // 
            Brand_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Brand_comboBox.Font = new Font("Segoe UI", 15F);
            Brand_comboBox.FormattingEnabled = true;
            Brand_comboBox.Location = new Point(1243, 34);
            Brand_comboBox.Name = "Brand_comboBox";
            Brand_comboBox.Size = new Size(216, 36);
            Brand_comboBox.TabIndex = 8;
            Brand_comboBox.SelectedIndexChanged += Brand_comboBox_SelectedIndexChanged;
            // 
            // Model_ComboBox
            // 
            Model_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Model_ComboBox.Font = new Font("Segoe UI", 15F);
            Model_ComboBox.FormattingEnabled = true;
            Model_ComboBox.Location = new Point(862, 34);
            Model_ComboBox.Name = "Model_ComboBox";
            Model_ComboBox.Size = new Size(216, 36);
            Model_ComboBox.TabIndex = 9;
            // 
            // Engine_comboBox
            // 
            Engine_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Engine_comboBox.Font = new Font("Segoe UI", 15F);
            Engine_comboBox.FormattingEnabled = true;
            Engine_comboBox.Location = new Point(504, 34);
            Engine_comboBox.Name = "Engine_comboBox";
            Engine_comboBox.Size = new Size(216, 36);
            Engine_comboBox.TabIndex = 10;
            // 
            // dtp_start
            // 
            dtp_start.Location = new Point(862, 135);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(200, 23);
            dtp_start.TabIndex = 13;
            // 
            // dtp_end
            // 
            dtp_end.Location = new Point(520, 135);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(200, 23);
            dtp_end.TabIndex = 14;
            // 
            // Brand_lbl
            // 
            Brand_lbl.AutoSize = true;
            Brand_lbl.Font = new Font("Segoe UI", 15F);
            Brand_lbl.Location = new Point(1465, 37);
            Brand_lbl.Name = "Brand_lbl";
            Brand_lbl.Size = new Size(67, 28);
            Brand_lbl.TabIndex = 35;
            Brand_lbl.Text = "الماركة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(1465, 130);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 36;
            label1.Text = "رقم الشسيه";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(1084, 42);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 37;
            label2.Text = "الموديل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(726, 37);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 38;
            label3.Text = "المحرك";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(408, 37);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 39;
            label4.Text = "رقم العربة";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(1068, 127);
            label5.Name = "label5";
            label5.Size = new Size(37, 28);
            label5.TabIndex = 40;
            label5.Text = "من";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(726, 129);
            label6.Name = "label6";
            label6.Size = new Size(41, 28);
            label6.TabIndex = 41;
            label6.Text = "الي";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(499, 141);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 42;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(186, 123);
            button1.Name = "button1";
            button1.Size = new Size(194, 45);
            button1.TabIndex = 43;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // VehicleNumber_txt
            // 
            VehicleNumber_txt.Font = new Font("Segoe UI", 15F);
            VehicleNumber_txt.Location = new Point(186, 34);
            VehicleNumber_txt.Name = "VehicleNumber_txt";
            VehicleNumber_txt.Size = new Size(216, 34);
            VehicleNumber_txt.TabIndex = 44;
            // 
            // ChessisNum_txt
            // 
            ChessisNum_txt.Font = new Font("Segoe UI", 15F);
            ChessisNum_txt.Location = new Point(1243, 126);
            ChessisNum_txt.Name = "ChessisNum_txt";
            ChessisNum_txt.Size = new Size(216, 34);
            ChessisNum_txt.TabIndex = 45;
            // 
            // LatestUpdate_checkBox
            // 
            LatestUpdate_checkBox.AutoSize = true;
            LatestUpdate_checkBox.Font = new Font("Segoe UI", 15F);
            LatestUpdate_checkBox.Location = new Point(12, 34);
            LatestUpdate_checkBox.Name = "LatestUpdate_checkBox";
            LatestUpdate_checkBox.Size = new Size(145, 32);
            LatestUpdate_checkBox.TabIndex = 46;
            LatestUpdate_checkBox.Text = "latest update";
            LatestUpdate_checkBox.UseVisualStyleBackColor = true;
            // 
            // ExportExcel_btn
            // 
            ExportExcel_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExportExcel_btn.BackColor = Color.FromArgb(0, 192, 0);
            ExportExcel_btn.FlatStyle = FlatStyle.Popup;
            ExportExcel_btn.Font = new Font("Segoe UI", 20F);
            ExportExcel_btn.Location = new Point(186, 657);
            ExportExcel_btn.Name = "ExportExcel_btn";
            ExportExcel_btn.Size = new Size(194, 59);
            ExportExcel_btn.TabIndex = 47;
            ExportExcel_btn.Text = "To Excel";
            ExportExcel_btn.UseVisualStyleBackColor = false;
            ExportExcel_btn.Click += ExportExcel_btn_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1805, 738);
            Controls.Add(ExportExcel_btn);
            Controls.Add(LatestUpdate_checkBox);
            Controls.Add(ChessisNum_txt);
            Controls.Add(VehicleNumber_txt);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Brand_lbl);
            Controls.Add(dtp_end);
            Controls.Add(dtp_start);
            Controls.Add(Engine_comboBox);
            Controls.Add(Model_ComboBox);
            Controls.Add(Brand_comboBox);
            Controls.Add(dgvData);
            Controls.Add(GetAllProjects_btn);
            Controls.Add(checkBox1);
            Name = "Reports";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetAllProjects_btn;
        private DataGridView dgvData;
        private ComboBox Brand_comboBox;
        private ComboBox Model_ComboBox;
        private ComboBox Engine_comboBox;
        private DateTimePicker dtp_start;
        private DateTimePicker dtp_end;
        private Label Brand_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox VehicleNumber_txt;
        private TextBox ChessisNum_txt;
        private CheckBox LatestUpdate_checkBox;
        private Button ExportExcel_btn;
    }
}