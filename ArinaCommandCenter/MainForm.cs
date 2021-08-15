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

namespace ArinaCommandCenter
{
    public partial class MainForm : Form
    {

        private List<GameInfo> GameList = new List<GameInfo>
        {
            new GameInfo { Name = "Rance 10", SavePath = @"C:\Users\kentn\OneDrive\ドキュメント", SaveSubDirectory = @"AliceSoft\ランス１０" }
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
            if (cbbGameList.SelectedIndex != -1)
                Sonia.BackupGameSave(((GameInfo)cbbGameList.SelectedItem).SavePath,
                    ((GameInfo)cbbGameList.SelectedItem).SaveSubDirectory);
        }
    }
}
