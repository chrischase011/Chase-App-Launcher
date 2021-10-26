namespace App_Launcher
{
    partial class Launcher
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.lblGame = new System.Windows.Forms.Label();
            this.btnAddGames = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.tabApps = new System.Windows.Forms.TabPage();
            this.lblApps = new System.Windows.Forms.Label();
            this.btnAddApp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.appPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.newAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.tabApps.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1036, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppToolStripMenuItem,
            this.newAppsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addAppToolStripMenuItem
            // 
            this.addAppToolStripMenuItem.Name = "addAppToolStripMenuItem";
            this.addAppToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.addAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAppToolStripMenuItem.Text = "New Games";
            this.addAppToolStripMenuItem.Click += new System.EventHandler(this.addAppToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 88);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(974, 10);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabGame);
            this.tabs.Controls.Add(this.tabApps);
            this.tabs.Location = new System.Drawing.Point(0, 104);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1039, 455);
            this.tabs.TabIndex = 3;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabSelect);
            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.Color.Transparent;
            this.tabGame.Controls.Add(this.lblGame);
            this.tabGame.Controls.Add(this.btnAddGames);
            this.tabGame.Controls.Add(this.gamePanel);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(1031, 429);
            this.tabGame.TabIndex = 0;
            this.tabGame.Text = "Games";
            this.tabGame.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGame.Location = new System.Drawing.Point(71, 399);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(0, 20);
            this.lblGame.TabIndex = 2;
            // 
            // btnAddGames
            // 
            this.btnAddGames.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddGames.BackColor = System.Drawing.Color.Black;
            this.btnAddGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGames.BorderRadius = 0;
            this.btnAddGames.ButtonText = "Add Games";
            this.btnAddGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGames.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddGames.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddGames.Iconimage = null;
            this.btnAddGames.Iconimage_right = null;
            this.btnAddGames.Iconimage_right_Selected = null;
            this.btnAddGames.Iconimage_Selected = null;
            this.btnAddGames.IconMarginLeft = 0;
            this.btnAddGames.IconMarginRight = 0;
            this.btnAddGames.IconRightVisible = true;
            this.btnAddGames.IconRightZoom = 0D;
            this.btnAddGames.IconVisible = true;
            this.btnAddGames.IconZoom = 90D;
            this.btnAddGames.IsTab = false;
            this.btnAddGames.Location = new System.Drawing.Point(373, 399);
            this.btnAddGames.Name = "btnAddGames";
            this.btnAddGames.Normalcolor = System.Drawing.Color.Black;
            this.btnAddGames.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddGames.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddGames.selected = false;
            this.btnAddGames.Size = new System.Drawing.Size(241, 22);
            this.btnAddGames.TabIndex = 1;
            this.btnAddGames.Text = "Add Games";
            this.btnAddGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddGames.Textcolor = System.Drawing.Color.White;
            this.btnAddGames.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGames.Click += new System.EventHandler(this.btnAddGames_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Location = new System.Drawing.Point(9, 7);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1016, 386);
            this.gamePanel.TabIndex = 0;
            // 
            // tabApps
            // 
            this.tabApps.BackColor = System.Drawing.Color.Transparent;
            this.tabApps.Controls.Add(this.lblApps);
            this.tabApps.Controls.Add(this.btnAddApp);
            this.tabApps.Controls.Add(this.appPanel);
            this.tabApps.Location = new System.Drawing.Point(4, 22);
            this.tabApps.Name = "tabApps";
            this.tabApps.Padding = new System.Windows.Forms.Padding(3);
            this.tabApps.Size = new System.Drawing.Size(1031, 429);
            this.tabApps.TabIndex = 1;
            this.tabApps.Text = "Applications";
            // 
            // lblApps
            // 
            this.lblApps.AutoSize = true;
            this.lblApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApps.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApps.Location = new System.Drawing.Point(39, 403);
            this.lblApps.Name = "lblApps";
            this.lblApps.Size = new System.Drawing.Size(0, 20);
            this.lblApps.TabIndex = 3;
            // 
            // btnAddApp
            // 
            this.btnAddApp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddApp.BackColor = System.Drawing.Color.Black;
            this.btnAddApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddApp.BorderRadius = 0;
            this.btnAddApp.ButtonText = "Add Applications";
            this.btnAddApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddApp.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddApp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddApp.Iconimage = null;
            this.btnAddApp.Iconimage_right = null;
            this.btnAddApp.Iconimage_right_Selected = null;
            this.btnAddApp.Iconimage_Selected = null;
            this.btnAddApp.IconMarginLeft = 0;
            this.btnAddApp.IconMarginRight = 0;
            this.btnAddApp.IconRightVisible = false;
            this.btnAddApp.IconRightZoom = 0D;
            this.btnAddApp.IconVisible = false;
            this.btnAddApp.IconZoom = 90D;
            this.btnAddApp.IsTab = false;
            this.btnAddApp.Location = new System.Drawing.Point(377, 401);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Normalcolor = System.Drawing.Color.Black;
            this.btnAddApp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddApp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddApp.selected = false;
            this.btnAddApp.Size = new System.Drawing.Size(241, 22);
            this.btnAddApp.TabIndex = 2;
            this.btnAddApp.Text = "Add Applications";
            this.btnAddApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddApp.Textcolor = System.Drawing.Color.White;
            this.btnAddApp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // appPanel
            // 
            this.appPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appPanel.Location = new System.Drawing.Point(6, 5);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(1022, 392);
            this.appPanel.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(327, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(437, 65);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Chase\'s App Launcher";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // newAppsToolStripMenuItem
            // 
            this.newAppsToolStripMenuItem.Name = "newAppsToolStripMenuItem";
            this.newAppsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.newAppsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newAppsToolStripMenuItem.Text = "New Apps";
            this.newAppsToolStripMenuItem.Click += new System.EventHandler(this.newAppsToolStripMenuItem_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::App_Launcher.Properties.Resources.cod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 559);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chase\'s App Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            this.tabApps.ResumeLayout(false);
            this.tabApps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabApps;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel appPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddGames;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddApp;
        public System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label lblApps;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ToolStripMenuItem newAppsToolStripMenuItem;
    }
}

