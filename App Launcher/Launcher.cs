using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bunifu.Framework.UI;
using System.Data.SQLite;
using System.Diagnostics;
namespace App_Launcher
{
    public partial class Launcher : Form
    {
        Database db = new Database();

        public Launcher()
        {
            InitializeComponent();
            TabControlTransparent();
        }

        public void TabControlTransparent()
        {
            tabs.SelectedTab.BackgroundImage = App_Launcher.Properties.Resources.teemo1;
            tabs.SelectedTab.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabSelect(object sender, TabControlEventArgs e)
        {
            tabs.SelectedTab.BackgroundImage = App_Launcher.Properties.Resources.teemo1;
            tabs.SelectedTab.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            db.CreateDatabaseAndDatabaseTables();
            LoadGames();
            LoadApps();
        }

        private void btnAddGames_Click(object sender, EventArgs e)
        {
            AddGames();
        }
        private void AddGames()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Exe file (*.exe)|*.exe";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string iconPath = "";
                var fileStream = fileDialog.OpenFile();
                Icon icon = ExtractIcon(filePath);

                if (!Directory.Exists(Application.StartupPath + "/Games"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "/Games");
                }
                if (icon != null)
                {
                    string icoPath = Application.StartupPath + "/Games/" + fileName + ".ico";

                    try
                    {

                        using (FileStream stream = new FileStream(icoPath, FileMode.CreateNew))
                        {
                            icon.Save(stream);
                            iconPath = icoPath;
                        }
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show("File: " + fileName + " already exists.", "Existing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                AddApplication(filePath, iconPath, 1);
                //MessageBox.Show("Path: " + filePath + "\nIcon: " + icon+"\nDirectory: "+Application.StartupPath);
            }
        }

        private static Icon ExtractIcon(string path)
        {
            Icon icon = (Icon)null;
            try
            {
                icon = Icon.ExtractAssociatedIcon(path);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return icon;
        }
        public void AddApplication(string exePath, string iconPath, int cat)
        {
            try
            {
                string name = Path.GetFileNameWithoutExtension(exePath);
                SQLiteConnection conn = new SQLiteConnection("Data Source=launcher.sqlite;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(null, conn);

                if (cat == 1)
                {
                    cmd.CommandText = "INSERT INTO Games (name,path,image) VALUES(@name,@path,@image)";

                    SQLiteParameter nameParam = new SQLiteParameter("@name", System.Data.DbType.String, 0);
                    SQLiteParameter pathParam = new SQLiteParameter("@path", System.Data.DbType.String, 0);
                    SQLiteParameter imageParam = new SQLiteParameter("@image", System.Data.DbType.String, 0);
                    nameParam.Value = name;
                    pathParam.Value = exePath;
                    imageParam.Value = iconPath;

                    cmd.Parameters.Add(nameParam);
                    cmd.Parameters.Add(pathParam);
                    cmd.Parameters.Add(imageParam);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    LoadGames();
                }
                if (cat == 2)
                {
                    cmd.CommandText = "INSERT INTO Apps (name,path,image) VALUES(@name,@path,@image)";

                    SQLiteParameter nameParam = new SQLiteParameter("@name", System.Data.DbType.String, 0);
                    SQLiteParameter pathParam = new SQLiteParameter("@path", System.Data.DbType.String, 0);
                    SQLiteParameter imageParam = new SQLiteParameter("@image", System.Data.DbType.String, 0);
                    nameParam.Value = name;
                    pathParam.Value = exePath;
                    imageParam.Value = iconPath;

                    cmd.Parameters.Add(nameParam);
                    cmd.Parameters.Add(pathParam);
                    cmd.Parameters.Add(imageParam);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    LoadApps();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void LoadGames()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=launcher.sqlite;Version=3;");
                conn.Open();
                string sql = "SELECT * FROM Games";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                SQLiteDataReader r = cmd.ExecuteReader();
                int x = 10, y = 10, i = 1;
                while (r.Read())
                {
                    //MessageBox.Show(r["name"].ToString()+ r["path"].ToString()+ r["image"].ToString());
                    if (i == 9)
                    {
                        x = 10;
                        y += 100;
                        i = 1;
                    }
                    PlaceGames(x, y, r["name"].ToString(), r["path"].ToString(), r["image"].ToString());
                    x += 100;
                    i++;
                }

                r.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void PlaceGames(int x, int y, string name, string path, string icoPath)
        {
            BunifuFlatButton btn = new BunifuFlatButton();
            ToolTip tp = new ToolTip();
            btn.Normalcolor = Color.Transparent;
            btn.OnHovercolor = Color.Transparent;
            btn.BackColor = Color.Transparent;
            btn.Iconimage = null;
            btn.BackgroundImage = Image.FromFile(icoPath);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Activecolor = Color.Transparent;
            btn.ButtonText = "";
            //btn.textalign = contentalignment.bottomcenter;
            btn.ForeColor = Color.White;
            btn.BorderStyle = BorderStyle.FixedSingle;
            btn.Size = new Size(60, 60);
            btn.Location = new Point(x, y);
            btn.Click += new EventHandler(btn_Click);
            btn.MouseMove += new MouseEventHandler(btn_MouseMove);
            void btn_MouseMove(object sender, EventArgs e)
            {
                tp.InitialDelay = 500;
                tp.ReshowDelay = 100;
                tp.AutoPopDelay = 5000;
                tp.ShowAlways = true;

                tp.SetToolTip(btn, "Run " + name);
                lblGame.Text = "Run " + name;
                
            }
            
            void btn_Click(object sender, EventArgs e)
            {

                MessageBox.Show("Run " + name);


                try
                {
                    Process pr = new Process();
                    pr.StartInfo.FileName = path;
                    pr.StartInfo.UseShellExecute = false;
                    pr.Start();
                    //pr.WaitForExit();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }




            }
            gamePanel.Controls.Add(btn);
        }



        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            AddApps();
        }

        public void AddApps()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Exe file (*.exe)|*.exe";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string iconPath = "";
                var fileStream = fileDialog.OpenFile();
                Icon icon = ExtractIcon(filePath);

                if (!Directory.Exists(Application.StartupPath + "/Apps"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "/Apps");
                }
                if (icon != null)
                {
                    string icoPath = Application.StartupPath + "/Apps/" + fileName + ".ico";

                    try
                    {

                        using (FileStream stream = new FileStream(icoPath, FileMode.CreateNew))
                        {
                            icon.Save(stream);
                            iconPath = icoPath;
                        }
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show("File: " + fileName + " already exists.", "Existing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                AddApplication(filePath, iconPath, 2);
            }
        }
        public void LoadApps()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=launcher.sqlite;Version=3;");
                conn.Open();
                string sql = "SELECT * FROM Apps";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                SQLiteDataReader r = cmd.ExecuteReader();
                int x = 10, y = 10, i = 1;
                while (r.Read())
                {
                    //MessageBox.Show(r["name"].ToString()+ r["path"].ToString()+ r["image"].ToString());
                    if (i == 9)
                    {
                        x = 10;
                        y += 100;
                        i = 1;
                    }
                    PlaceApp(x, y, r["name"].ToString(), r["path"].ToString(), r["image"].ToString());
                    x += 100;
                    i++;
                }

                r.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void PlaceApp(int x, int y, string name, string path, string icoPath)
        {
            BunifuFlatButton btn = new BunifuFlatButton();
            ToolTip tp = new ToolTip();
            btn.Normalcolor = Color.Transparent;
            btn.OnHovercolor = Color.Transparent;
            btn.BackColor = Color.Transparent;
            btn.Iconimage = Image.FromFile(icoPath);
            btn.Activecolor = Color.Transparent;
            btn.ButtonText = "Run " + name;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.ForeColor = Color.White;
            btn.BorderStyle = BorderStyle.FixedSingle;
            btn.Size = new Size(60, 60);
            btn.Location = new Point(x, y);
            
            btn.Click += new EventHandler(btn_Click);
            btn.MouseMove += new MouseEventHandler(btn_MouseMove);
            void btn_MouseMove(object sender, EventArgs e)
            {
                tp.InitialDelay = 500;
                tp.ReshowDelay = 100;
                tp.AutoPopDelay = 5000;
                tp.ShowAlways = true;

                tp.SetToolTip(btn, "Run " + name);
                lblApps.Text = "Run " + name;

            }
            void btn_Click(object sender, EventArgs e)
            {

                MessageBox.Show("Run " + name);


                try
                {
                    Process pr = new Process();
                    pr.StartInfo.FileName = path;
                    pr.StartInfo.UseShellExecute = false;
                    pr.Start();
                    //pr.WaitForExit();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }




            }
            appPanel.Controls.Add(btn);
        }

        private void addAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Are you sure you want to add Games?", "App Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (a)
            {
                case DialogResult.Yes:
                    AddGames();
                    break;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye!","App Launcher");
            Application.Exit();
        }

        private void newAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Are you sure you want to add Application?", "App Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (a)
            {
                case DialogResult.Yes:
                    AddApps();
                    break;
                
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chase's App Launcher\nVersion 1.0\n\nThank you for using Chase's App Launcher. More features" +
                " to be added soon. In case you have question/suggestion, you can post issues on my github repository (github.com/chrischase011)" +
                "\n\nThank you.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}