﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aritiafel.Characters.Heroes;
using System.IO;
using System.Diagnostics;
using IWshRuntimeLibrary;
using System.Runtime.Remoting.Lifetime;

namespace ArinaCommandCenter
{
    public partial class MainForm : Form
    {
        private static string LocalAppPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static string MoveToFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private List<GameInfo> GameList = new List<GameInfo>
        {
            new GameInfo { Name = "Rance 10", SavePath = MoveToFolder, SaveSubDirectory = @"AliceSoft\ランス１０" },
            new GameInfo { Name = "Pathfinder Kingmaker", SavePath = LocalAppPath + "Low", SaveSubDirectory = @"Owlcat Games\Pathfinder Kingmaker\Saved Games" },
            new GameInfo { Name = "超昂神騎", SavePath = MoveToFolder, SaveSubDirectory = @"AliceSoft\超昂天使エスカレイヤー・リブート" },
            new GameInfo { Name = "Might & Magic Heroes VII", SavePath = @"C:\Program Files (x86)\Ubisoft", SaveSubDirectory = @"Ubisoft Game Launcher\savegames\dd887672-be36-4a2c-9fc7-80d93217b9f3" },
            new GameInfo { Name = "幻燐の姫将軍2", SavePath = LocalAppPath, SaveSubDirectory = @"Eushully\幻燐の姫将軍2DL版"},
        };

        //private List<GameInfo> GameList2 = new List<GameInfo>((IEnumerable<GameInfo>) GameList);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbbGameList.DataSource = GameList;
            cbbGameList.DisplayMember = "Name";
            cbbGameList.SelectedIndex = 4;
            //cbbGameList2.DataSource = GameList2;
            //cbbGameList2.DisplayMember = "Name";
        }

        private void btnGameSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{((GameInfo)cbbGameList.SelectedItem).Name} 確定存檔？", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.Cancel)
                return;
            if (cbbGameList.SelectedIndex != -1)
            {
                Sonia.BackupGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath,
                    ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory);
                MessageBox.Show("存檔完成");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(@"E:\"))
            {
                MessageBox.Show("記得取出隨身碟", "記憶裝置未取出", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
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
            Application.SetSuspendState(PowerState.Hibernate, false, false);
        }

        private void tsmSuspend_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, false, false);
        }

        private void tsmCreateDesktopShortcut_Click(object sender, EventArgs e)
        {

            //自身
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Arina Command Center.lnk";
            if (System.IO.File.Exists(shortcutAddress))
                System.IO.File.Delete(shortcutAddress);

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "有奈管理面板";
            shortcut.IconLocation = string.Concat(Application.ExecutablePath, ", 0");
            shortcut.WindowStyle = 1;
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.Save();
            
            //ArinaWebsiteManager
            if (System.IO.File.Exists(@"C:\Programs\ArinaWebsiteManager\ArinaWebsiteManager\bin\Release\ArinaWebsiteManager.exe"))
            {
                shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Arina Website Manager.lnk";
                if (System.IO.File.Exists(shortcutAddress))
                    System.IO.File.Delete(shortcutAddress);
                shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "有奈網站管理面板";
                shortcut.WindowStyle = 1;
                shortcut.IconLocation = @"C:\Programs\ArinaWebsiteManager\ArinaWebsiteManager\bin\Release\ArinaWebsiteManager.exe, 0";
                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.Save();
            }

            //JsonEditorV2
            if (System.IO.File.Exists(@"C:\Programs\JsonEditorV2\JsonEditorV2\bin\Release\JsonEditorV2.exe"))
            {
                shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Json Editor V2 .lnk";
                if (System.IO.File.Exists(shortcutAddress))
                    System.IO.File.Delete(shortcutAddress);
                shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "JSON資料庫";
                shortcut.WindowStyle = 1;
                shortcut.IconLocation = @"C:\Programs\JsonEditorV2\JsonEditorV2\bin\Release\JsonEditorV2.exe, 0";
                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.Save();
            }
        }
    }
}
