namespace PL
{
    partial class Login
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
            Login_btn = new Button();
            Pass_txt = new TextBox();
            Pass_lbl = new Label();
            SuspendLayout();
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.FromArgb(0, 192, 0);
            Login_btn.FlatStyle = FlatStyle.Popup;
            Login_btn.Font = new Font("Segoe UI", 20F);
            Login_btn.ForeColor = SystemColors.ButtonHighlight;
            Login_btn.Location = new Point(134, 297);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(133, 63);
            Login_btn.TabIndex = 0;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // Pass_txt
            // 
            Pass_txt.Font = new Font("Segoe UI", 20F);
            Pass_txt.Location = new Point(12, 209);
            Pass_txt.Name = "Pass_txt";
            Pass_txt.Size = new Size(393, 43);
            Pass_txt.TabIndex = 1;
            // 
            // Pass_lbl
            // 
            Pass_lbl.AutoSize = true;
            Pass_lbl.Font = new Font("Segoe UI", 20F);
            Pass_lbl.ForeColor = SystemColors.ButtonHighlight;
            Pass_lbl.Location = new Point(134, 148);
            Pass_lbl.Name = "Pass_lbl";
            Pass_lbl.Size = new Size(128, 37);
            Pass_lbl.TabIndex = 2;
            Pass_lbl.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(417, 546);
            Controls.Add(Pass_lbl);
            Controls.Add(Pass_txt);
            Controls.Add(Login_btn);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_btn;
        private TextBox Pass_txt;
        private Label Pass_lbl;
    }
}