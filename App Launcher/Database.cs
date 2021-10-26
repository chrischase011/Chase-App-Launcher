using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Bunifu.Framework.UI;
using System.Drawing;
namespace App_Launcher
{
    class Database
    {
        public SQLiteConnection conn;
        public SQLiteCommand cmd;
        public void CreateDatabaseAndDatabaseTables()
        {

            try {
                if (File.Exists("launcher.sqlite"))
                {
                    CreateTables();
                }
                else
                {
                    SQLiteConnection.CreateFile("launcher.sqlite");
                    CreateTables();
                    MessageBox.Show("Successfully generated the files on the first launch.");
                }
               

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // err = e.ToString();
            }
            
        }
       
        protected void CreateTables()
        {
            try
            {
                conn = new SQLiteConnection("Data Source=launcher.sqlite;Version=3;");
                conn.Open();
                string sql1 = "CREATE TABLE IF NOT EXISTS Games (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    " name TEXT NOT NULL, path TEXT NOT NULL, image TEXT NOT NULL)";
                string sql2 = "CREATE TABLE IF NOT EXISTS Apps (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    " name TEXT NOT NULL, path TEXT NOT NULL, image TEXT NOT NULL)";

                SQLiteCommand cmd1 = new SQLiteCommand(sql1, conn);
                SQLiteCommand cmd2 = new SQLiteCommand(sql2, conn);

                cmd1.ExecuteNonQueryAsync();
                cmd2.ExecuteNonQueryAsync();

              //  succ = "Successfully generate files for the application";
                conn.Close();

              
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
    }
}
