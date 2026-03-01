namespace PL
{
    partial class MainFrom
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
            menuStrip1 = new MenuStrip();
            اضافةToolStripMenuItem = new ToolStripMenuItem();
            تعديلاوحذفToolStripMenuItem = new ToolStripMenuItem();
            تقاريرToolStripMenuItem = new ToolStripMenuItem();
            MainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { اضافةToolStripMenuItem, تعديلاوحذفToolStripMenuItem, تقاريرToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1805, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // اضافةToolStripMenuItem
            // 
            اضافةToolStripMenuItem.Name = "اضافةToolStripMenuItem";
            اضافةToolStripMenuItem.Size = new Size(49, 20);
            اضافةToolStripMenuItem.Text = "اضافة";
            اضافةToolStripMenuItem.Click += اضافةToolStripMenuItem_Click;
            // 
            // تعديلاوحذفToolStripMenuItem
            // 
            تعديلاوحذفToolStripMenuItem.Name = "تعديلاوحذفToolStripMenuItem";
            تعديلاوحذفToolStripMenuItem.Size = new Size(88, 20);
            تعديلاوحذفToolStripMenuItem.Text = "تعديل او حذف";
            تعديلاوحذفToolStripMenuItem.Click += تعديلاوحذفToolStripMenuItem_Click;
            // 
            // تقاريرToolStripMenuItem
            // 
            تقاريرToolStripMenuItem.Name = "تقاريرToolStripMenuItem";
            تقاريرToolStripMenuItem.Size = new Size(47, 20);
            تقاريرToolStripMenuItem.Text = "تقارير";
            تقاريرToolStripMenuItem.Click += تقاريرToolStripMenuItem_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ActiveCaption;
            MainPanel.BorderStyle = BorderStyle.Fixed3D;
            MainPanel.Location = new Point(12, 27);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1900, 960);
            MainPanel.TabIndex = 1;
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1805, 877);
            Controls.Add(MainPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainFrom";
            Text = "MainFrom";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem اضافةToolStripMenuItem;
        private ToolStripMenuItem تعديلاوحذفToolStripMenuItem;
        private Panel MainPanel;
        private ToolStripMenuItem تقاريرToolStripMenuItem;
    }
}