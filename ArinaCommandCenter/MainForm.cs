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

namespace ArinaCommandCenter
{
    public partial class MainForm : Form
    {

        private List<GameInfo> GameList = new List<GameInfo>
        {
            new GameInfo { Name = "Rance 10", SavePath = @"C:\Users\KentoHize\OneDrive\ドキュメント", SaveSubDirectory = @"AliceSoft\ランス１０" },
            new GameInfo { Name = "Pathfinder", SavePath = @"C:\Users\KentoHize\AppData\LocalLow", SaveSubDirectory = @"Owlcat Games\Pathfinder Kingmaker\Saved Games" },
            new GameInfo { Name = "超昂神騎", SavePath = @"C:\Users\KentoHize\Documents\", SaveSubDirectory = @"AliceSoft\超昂天使エスカレイヤー・リブート" },
            new GameInfo { Name = "Might & Magic Heroes VII", SavePath = @"C:\Program Files (x86)\Ubisoft", SaveSubDirectory = @"Ubisoft Game Launcher\savegames\dd887672-be36-4a2c-9fc7-80d93217b9f3" },
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbbGameList.DataSource = GameList;
            cbbGameList.DisplayMember = "Name";            
        }

        private void btnGameSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{((GameInfo)cbbGameList.SelectedItem).Name} 確定存檔？", "確定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.Cancel)
                return;
            if (cbbGameList.SelectedIndex != -1)
                Sonia.BackupGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath,
                    ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory);

            MessageBox.Show("存檔完成");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(@"E:\"))
            {
                MessageBox.Show("記得取出隨身碟", "記憶裝置未取出", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
