using System;
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

namespace ArinaCommandCenter
{
    public partial class MainForm : Form
    {
        private static string LocalAppPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static string MoveToFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private List<GameInfo> GameList = new List<GameInfo>
        {
            new GameInfo { Name = "Rance 10", SavePath = @"C:\Users\KentoHize\OneDrive\ドキュメント", SaveSubDirectory = @"AliceSoft\ランス１０" },
            new GameInfo { Name = "Pathfinder", SavePath = @"C:\Users\KentoHize\AppData\LocalLow", SaveSubDirectory = @"Owlcat Games\Pathfinder Kingmaker\Saved Games" },
            new GameInfo { Name = "超昂神騎", SavePath = @"C:\Users\KentoHize\Documents\", SaveSubDirectory = @"AliceSoft\超昂天使エスカレイヤー・リブート" },
            new GameInfo { Name = "Might & Magic Heroes VII", SavePath = @"C:\Program Files (x86)\Ubisoft", SaveSubDirectory = @"Ubisoft Game Launcher\savegames\dd887672-be36-4a2c-9fc7-80d93217b9f3" },
        };

        private List<GameInfo> GameList2 = new List<GameInfo>
        {            
            new GameInfo { Name = "幻燐の姫将軍2", SavePath = LocalAppPath, SaveSubDirectory = @"Eushully\幻燐の姫将軍2DL版", LatestSaveFolder = "SAVE" },
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbbGameList.DataSource = GameList;
            cbbGameList.DisplayMember = "Name";
            cbbGameList2.DataSource = GameList2;
            cbbGameList2.DisplayMember = "Name";
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
            DialogResult dr = MessageBox.Show($"{((GameInfo)cbbGameList2.SelectedItem).Name} 確定移動？", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
                return;
            if (cbbGameList2.SelectedIndex != -1)
            {
                long fileCount = Sonia.CopyGameSave(((GameInfo)cbbGameList2.SelectedItem).SavePath,
                    ((GameInfo)cbbGameList2.SelectedItem).SaveSubDirectory,
                    MoveToFolder);
                MessageBox.Show($"移動完成，已經移動{fileCount}個檔案");
            }
            
        }

        private void LatestGameSaveMove(long inMinutes = 30)
        {
            if (cbbGameList2.SelectedIndex != -1)
            {
                long fileCount = Sonia.CopyLatestGameSave(((GameInfo)cbbGameList2.SelectedItem).SavePath,
                    ((GameInfo)cbbGameList2.SelectedItem).SaveSubDirectory,
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
    }
}
