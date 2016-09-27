namespace Storehouse
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库店铺管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批发管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.零售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.后台登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.说明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仓库店铺管理ToolStripMenuItem,
            this.后台登陆ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 仓库店铺管理ToolStripMenuItem
            // 
            this.仓库店铺管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.批发管理ToolStripMenuItem,
            this.零售管理ToolStripMenuItem,
            this.查看记录ToolStripMenuItem});
            this.仓库店铺管理ToolStripMenuItem.Name = "仓库店铺管理ToolStripMenuItem";
            this.仓库店铺管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.仓库店铺管理ToolStripMenuItem.Text = "仓库店铺管理";
            // 
            // 批发管理ToolStripMenuItem
            // 
            this.批发管理ToolStripMenuItem.Name = "批发管理ToolStripMenuItem";
            this.批发管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.批发管理ToolStripMenuItem.Text = "批发管理";
            this.批发管理ToolStripMenuItem.Click += new System.EventHandler(this.批发管理ToolStripMenuItem_Click);
            // 
            // 零售管理ToolStripMenuItem
            // 
            this.零售管理ToolStripMenuItem.Name = "零售管理ToolStripMenuItem";
            this.零售管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.零售管理ToolStripMenuItem.Text = "零售管理";
            this.零售管理ToolStripMenuItem.Click += new System.EventHandler(this.零售管理ToolStripMenuItem_Click);
            // 
            // 查看记录ToolStripMenuItem
            // 
            this.查看记录ToolStripMenuItem.Name = "查看记录ToolStripMenuItem";
            this.查看记录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看记录ToolStripMenuItem.Text = "查看记录";
            this.查看记录ToolStripMenuItem.Click += new System.EventHandler(this.查看记录ToolStripMenuItem_Click);
            // 
            // 后台登陆ToolStripMenuItem
            // 
            this.后台登陆ToolStripMenuItem.Name = "后台登陆ToolStripMenuItem";
            this.后台登陆ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.后台登陆ToolStripMenuItem.Text = "后台登陆";
            this.后台登陆ToolStripMenuItem.Click += new System.EventHandler(this.后台登陆ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.说明ToolStripMenuItem.Text = "说明";
            this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 563);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "【仓库管理系统】";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 后台登陆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库店铺管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批发管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 零售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看记录ToolStripMenuItem;
    }
}