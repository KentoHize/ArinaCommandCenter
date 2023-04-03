
namespace ArinaCommandCenter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGameSave = new System.Windows.Forms.Button();
            this.cbbGameList = new System.Windows.Forms.ComboBox();
            this.btnGameSaveMove = new System.Windows.Forms.Button();
            this.btnLatestGameSaveMove = new System.Windows.Forms.Button();
            this.btnLatestGameSaveMove2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGameSave
            // 
            this.btnGameSave.Location = new System.Drawing.Point(114, 78);
            this.btnGameSave.Name = "btnGameSave";
            this.btnGameSave.Size = new System.Drawing.Size(125, 39);
            this.btnGameSave.TabIndex = 0;
            this.btnGameSave.Text = "遊戲存檔備份";
            this.btnGameSave.UseVisualStyleBackColor = true;
            this.btnGameSave.Click += new System.EventHandler(this.btnGameSave_Click);
            // 
            // cbbGameList
            // 
            this.cbbGameList.FormattingEnabled = true;
            this.cbbGameList.Location = new System.Drawing.Point(76, 30);
            this.cbbGameList.Name = "cbbGameList";
            this.cbbGameList.Size = new System.Drawing.Size(394, 23);
            this.cbbGameList.TabIndex = 1;
            this.cbbGameList.SelectedIndexChanged += new System.EventHandler(this.cbbGameList_SelectedIndexChanged);
            // 
            // btnGameSaveMove
            // 
            this.btnGameSaveMove.Location = new System.Drawing.Point(308, 78);
            this.btnGameSaveMove.Name = "btnGameSaveMove";
            this.btnGameSaveMove.Size = new System.Drawing.Size(125, 39);
            this.btnGameSaveMove.TabIndex = 2;
            this.btnGameSaveMove.Text = "遊戲存檔移動";
            this.btnGameSaveMove.UseVisualStyleBackColor = true;
            this.btnGameSaveMove.Click += new System.EventHandler(this.btnGameSaveMove_Click);
            // 
            // btnLatestGameSaveMove
            // 
            this.btnLatestGameSaveMove.Location = new System.Drawing.Point(54, 144);
            this.btnLatestGameSaveMove.Name = "btnLatestGameSaveMove";
            this.btnLatestGameSaveMove.Size = new System.Drawing.Size(208, 40);
            this.btnLatestGameSaveMove.TabIndex = 4;
            this.btnLatestGameSaveMove.Text = "最新存檔移動(30分鐘)";
            this.btnLatestGameSaveMove.UseVisualStyleBackColor = true;
            this.btnLatestGameSaveMove.Click += new System.EventHandler(this.btnLatestGameSaveMove_Click);
            // 
            // btnLatestGameSaveMove2
            // 
            this.btnLatestGameSaveMove2.Location = new System.Drawing.Point(284, 144);
            this.btnLatestGameSaveMove2.Name = "btnLatestGameSaveMove2";
            this.btnLatestGameSaveMove2.Size = new System.Drawing.Size(209, 40);
            this.btnLatestGameSaveMove2.TabIndex = 5;
            this.btnLatestGameSaveMove2.Text = "最新存檔移動(3分鐘)";
            this.btnLatestGameSaveMove2.UseVisualStyleBackColor = true;
            this.btnLatestGameSaveMove2.Click += new System.EventHandler(this.btnLatestGameSaveMove2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShutdown});
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(72, 24);
            this.tsmSystem.Text = "系統&(S)";
            // 
            // tsmShutdown
            // 
            this.tsmShutdown.Name = "tsmShutdown";
            this.tsmShutdown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmShutdown.Size = new System.Drawing.Size(224, 26);
            this.tsmShutdown.Text = "關機";
            this.tsmShutdown.Click += new System.EventHandler(this.tsmShutdown_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 229);
            this.Controls.Add(this.btnLatestGameSaveMove2);
            this.Controls.Add(this.btnLatestGameSaveMove);
            this.Controls.Add(this.btnGameSaveMove);
            this.Controls.Add(this.cbbGameList);
            this.Controls.Add(this.btnGameSave);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "有奈管理面板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameSave;
        private System.Windows.Forms.ComboBox cbbGameList;
        private System.Windows.Forms.Button btnGameSaveMove;
        private System.Windows.Forms.Button btnLatestGameSaveMove;
        private System.Windows.Forms.Button btnLatestGameSaveMove2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmShutdown;
    }
}

