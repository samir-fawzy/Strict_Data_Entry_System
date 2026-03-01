namespace PL
{
    partial class InittialForm
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
            Member_btn = new Button();
            Admin_btn = new Button();
            SuspendLayout();
            // 
            // Member_btn
            // 
            Member_btn.BackColor = Color.LimeGreen;
            Member_btn.FlatStyle = FlatStyle.Popup;
            Member_btn.Font = new Font("Segoe UI", 20F);
            Member_btn.Location = new Point(1042, 305);
            Member_btn.Name = "Member_btn";
            Member_btn.Size = new Size(198, 110);
            Member_btn.TabIndex = 0;
            Member_btn.Text = "Member";
            Member_btn.UseVisualStyleBackColor = false;
            Member_btn.Click += Member_btn_Click;
            // 
            // Admin_btn
            // 
            Admin_btn.BackColor = Color.FromArgb(255, 128, 0);
            Admin_btn.FlatStyle = FlatStyle.Popup;
            Admin_btn.Font = new Font("Segoe UI", 20F);
            Admin_btn.ForeColor = SystemColors.ActiveCaptionText;
            Admin_btn.Location = new Point(605, 305);
            Admin_btn.Name = "Admin_btn";
            Admin_btn.Size = new Size(198, 110);
            Admin_btn.TabIndex = 1;
            Admin_btn.Text = "Admin";
            Admin_btn.UseVisualStyleBackColor = false;
            Admin_btn.Click += Admin_btn_Click;
            // 
            // InittialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1806, 820);
            Controls.Add(Admin_btn);
            Controls.Add(Member_btn);
            Name = "InittialForm";
            Text = "InittialForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Member_btn;
        private Button Admin_btn;
    }
}