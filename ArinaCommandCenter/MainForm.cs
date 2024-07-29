using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Aritiafel.Characters.Heroes;
using System.IO;
using System.Diagnostics;
using Aritiafel.Locations;
using System.Text.Json;
using IWshRuntimeLibrary;

namespace ArinaCommandCenter
{
    public partial class MainForm : Form
    {
        private static string LocalAppPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static string LocalVirtualStoreProgramFiles = string.Concat(LocalAppPath, @"\VirtualStore\Program Files\");
        private static string LocalVirtualStoreProgramFiles86 = string.Concat(LocalAppPath, @"\VirtualStore\Program Files (x86)\");
        private static string MoveToFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string UnzippedFolder = @"C:\Unziped\";
        private static string ProgramFiles86 = @"C:\Program Files (x86)\";
        private static string ProgramFiles = @"C:\Program Files\";

        private List<GameInfo> GameList = new List<GameInfo>();

        //private List<GameInfo> GameList = new List<GameInfo>
        //{
        //    new GameInfo { Name = "Rance 10", SavePath = MoveToFolder, SaveSubDirectory = @"AliceSoft\ランス１０" },
        //    new GameInfo { Name = "Pathfinder Kingmaker", SavePath = LocalAppPath + "Low", SaveSubDirectory = @"Owlcat Games\Pathfinder Kingmaker\Saved Games" },
        //    new GameInfo { Name = "Pathfinder Wrath of the Righteous", SavePath = LocalAppPath + "Low", SaveSubDirectory = @"Owlcat Games\Pathfinder Wrath Of The Righteous\Saved Games" },
        //    new GameInfo { Name = "超昂天使エスカレイヤー・リブート", SavePath = MoveToFolder, SaveSubDirectory = @"AliceSoft\超昂天使エスカレイヤー・リブート" },
        //    new GameInfo { Name = "超昂神騎エクシール", SavePath = MoveToFolder, SaveSubDirectory = @"AliceSoft\超昂神騎エクシール" },
        //    new GameInfo { Name = "Might & Magic Heroes VII", SavePath = @"C:\Program Files (x86)\Ubisoft", SaveSubDirectory = @"Ubisoft Game Launcher\savegames\dd887672-be36-4a2c-9fc7-80d93217b9f3" },
        //    new GameInfo { Name = "幻燐の姫将軍2", SavePath = LocalAppPath, SaveSubDirectory = @"Eushully\幻燐の姫将軍2DL版"},
        //    new GameInfo { Name = "三國志14", SavePath = MoveToFolder, SaveSubDirectory = @"KoeiTecmo\SAN14", SavePath2 = ProgramFiles86, SaveSubDirectory2 = @"Steam\userdata\79365011\872410\"},
        //    new GameInfo { Name = "聖女戰旗", SavePath = LocalAppPath + "Low", SaveSubDirectory = @"AzureFlameStudio" },
        //    new GameInfo { Name = "Guild Master", SavePath = MoveToFolder, SaveSubDirectory = @"Astronauts_Sirius\Guildmaster"},
        //    new GameInfo { Name = "Elf All Star 脱衣雀3", SavePath = UnzippedFolder, SaveSubDirectory = @"elf_allstar3\savedatsui3" },
        //    //new GameInfo { Name = "王賊", SavePath = ProgramFiles, SaveSubDirectory = @"King\king.sav" }
        //    new GameInfo { Name = "王賊", SavePath = LocalVirtualStoreProgramFiles, SaveSubDirectory = @"King\king.sav" }
        //    //new GameInfo { Name = "御魂", SavePath = @"C:\Game\御魂"}
        //};

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //確認所需資料夾與檔案存在
            string folderorfile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Data");
            if (!Directory.Exists(folderorfile))
                Directory.CreateDirectory(folderorfile);
            folderorfile = Path.Combine(folderorfile, "GameList.json");            
            if (!System.IO.File.Exists(folderorfile))
            {
                StreamWriter sw = new StreamWriter(folderorfile);
                sw.Write("[]");
                sw.Close();
            }

            //讀取GameList
            StreamReader sr = new StreamReader(folderorfile);
            GameList = JsonSerializer.Deserialize<List<GameInfo>>(sr.ReadToEnd());
            sr.Close();

            SettingShop.LoadIniFile(typeof(Setting));
            cbbGameList.DataSource = GameList;
            cbbGameList.DisplayMember = "Name";
            if (!string.IsNullOrEmpty(Setting.LastestPlayedGame))
                cbbGameList.SelectedIndex = GameList.FindIndex(m => m.Name == Setting.LastestPlayedGame);
            else
                cbbGameList.SelectedIndex = 0;            
            cbbBackupDrive.Items.Add("D");
            cbbBackupDrive.Items.Add("E");
            cbbBackupDrive.Items.Add("F");
            cbbBackupDrive.Items.Add("G");
            if (!string.IsNullOrEmpty(Setting.BackupDrive))
                cbbBackupDrive.SelectedIndex = cbbBackupDrive.Items.IndexOf(Setting.BackupDrive);
            else
                cbbBackupDrive.SelectedIndex = 0;
        }

        private void btnGameSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{((GameInfo)cbbGameList.SelectedItem).Name} 確定存檔？", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.Cancel)
                return;
            if (cbbGameList.SelectedIndex != -1)
            {
                Sonia.BackupGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath,
                    ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory, cbbBackupDrive.SelectedItem.ToString());

                if (!string.IsNullOrEmpty(((GameInfo)cbbGameList.SelectedItem).SavePath2))
                {
                    Sonia.BackupGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath2,
                   ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory2, cbbBackupDrive.SelectedItem.ToString());
                }
                MessageBox.Show("存檔完成");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists($@"{cbbBackupDrive.SelectedItem}:\"))
            {
                MessageBox.Show("記得取出隨身碟", "記憶裝置未取出", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }

            if(cbbGameList.SelectedIndex != -1)
            {
                Setting.LastestPlayedGame = ((GameInfo)cbbGameList.SelectedItem).Name;
                Setting.BackupDrive = cbbBackupDrive.SelectedItem.ToString();
            }

            //紀錄最近玩的遊戲            
            SettingShop.SaveIniFile(typeof(Setting));
        }

        private void btnGameSaveMove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{((GameInfo)cbbGameList.SelectedItem).Name} 確定移動？", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
                return;
            if (cbbGameList.SelectedIndex != -1)
            {
                long fileCount = Sonia.CopyGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath,
                    ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory,
                    MoveToFolder);

                if(!string.IsNullOrEmpty(((GameInfo)cbbGameList.SelectedItem).SavePath2))
                {
                    fileCount += Sonia.CopyGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath2,
                    ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory2,
                    MoveToFolder);
                }
                MessageBox.Show($"移動完成，已經移動{fileCount}個檔案");
            }
            
        }

        private void LatestGameSaveMove(long inMinutes = 30)
        {
            if (cbbGameList.SelectedIndex != -1)
            {
                long fileCount = Sonia.CopyLatestGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath,
                    ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory,
                    MoveToFolder, inMinutes);
                if (!string.IsNullOrEmpty(((GameInfo)cbbGameList.SelectedItem).SavePath2))
                {
                    fileCount += Sonia.CopyLatestGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath2,
                    ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory2,
                    MoveToFolder, inMinutes);
                }
                MessageBox.Show($"移動完成，已經移動{fileCount}個檔案");
            }
        }

        private void btnLatestGameSaveMove_Click(object sender, EventArgs e)
        {
            LatestGameSaveMove();
        }

        private void btnLatestGameSaveMove2_Click(object sender, EventArgs e)
        {
            LatestGameSaveMove(3);
        }

        private void tsmShutdown_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"執行關機程序", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel)
                return;
            Process.Start("shutdown", "/s /t 0");
        }

        private void tsmRestart_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"重新啟動", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel)
                return;
            Process.Start("shutdown", "/r /t 0");
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmHibernate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"休眠", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Cancel)
                return;
            Application.SetSuspendState(PowerState.Hibernate, false, false);
        }

        private void tsmSuspend_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"睡眠", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Cancel)
                return;
            Application.SetSuspendState(PowerState.Suspend, false, false);
        }

        private void tsmCreateDesktopShortcut_Click(object sender, EventArgs e)
        {
            //自身
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Arina Command Center.lnk";
            string excutePath = Application.ExecutablePath;
            if (System.IO.File.Exists(shortcutAddress))
                System.IO.File.Delete(shortcutAddress);

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "有奈管理面板";
            shortcut.IconLocation = string.Concat(Application.ExecutablePath, ", 0");
            shortcut.WindowStyle = 1;
            shortcut.TargetPath = excutePath;
            shortcut.Save();

            //ArinaWebsiteManager
            excutePath = @"C:\Programs\ArinaWebsiteManager\ArinaWebsiteManager\bin\Release\ArinaWebsiteManager.exe";
            if (System.IO.File.Exists(excutePath))
            {
                shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Arina Website Manager.lnk";
                if (System.IO.File.Exists(shortcutAddress))
                    System.IO.File.Delete(shortcutAddress);
                shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "有奈網站管理面板";
                shortcut.WindowStyle = 1;
                shortcut.IconLocation = string.Concat(excutePath,", 0");
                shortcut.TargetPath = excutePath;
                shortcut.Save();
            }

            //JsonEditorV2
            excutePath = @"C:\Programs\JsonEditorV2\JsonEditorV2\bin\Release\JsonEditorV2.exe";
            if (System.IO.File.Exists(excutePath))
            {
                shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Json Editor V2 .lnk";
                if (System.IO.File.Exists(shortcutAddress))
                    System.IO.File.Delete(shortcutAddress);
                shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "JSON資料庫";
                shortcut.WindowStyle = 1;
                shortcut.IconLocation = string.Concat(excutePath, ", 0");
                shortcut.TargetPath = excutePath;
                shortcut.Save();
            }
        }
    }
}
