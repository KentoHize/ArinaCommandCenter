﻿
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
            this.tsmSuspend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHibernate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreateDesktopShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbBackupDrive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJEGameList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGameSave
            // 
            this.btnGameSave.Location = new System.Drawing.Point(92, 167);
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
            this.cbbGameList.Location = new System.Drawing.Point(43, 65);
            this.cbbGameList.Name = "cbbGameList";
            this.cbbGameList.Size = new System.Drawing.Size(358, 23);
            this.cbbGameList.TabIndex = 1;
            // 
            // btnGameSaveMove
            // 
            this.btnGameSaveMove.Location = new System.Drawing.Point(331, 167);
            this.btnGameSaveMove.Name = "btnGameSaveMove";
            this.btnGameSaveMove.Size = new System.Drawing.Size(125, 39);
            this.btnGameSaveMove.TabIndex = 2;
            this.btnGameSaveMove.Text = "遊戲存檔移動";
            this.btnGameSaveMove.UseVisualStyleBackColor = true;
            this.btnGameSaveMove.Click += new System.EventHandler(this.btnGameSaveMove_Click);
            // 
            // btnLatestGameSaveMove
            // 
            this.btnLatestGameSaveMove.Location = new System.Drawing.Point(43, 227);
            this.btnLatestGameSaveMove.Name = "btnLatestGameSaveMove";
            this.btnLatestGameSaveMove.Size = new System.Drawing.Size(208, 40);
            this.btnLatestGameSaveMove.TabIndex = 4;
            this.btnLatestGameSaveMove.Text = "最新存檔移動(30分鐘)";
            this.btnLatestGameSaveMove.UseVisualStyleBackColor = true;
            this.btnLatestGameSaveMove.Click += new System.EventHandler(this.btnLatestGameSaveMove_Click);
            // 
            // btnLatestGameSaveMove2
            // 
            this.btnLatestGameSaveMove2.Location = new System.Drawing.Point(298, 227);
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
            this.tsmSystem,
            this.tsmReset});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSuspend,
            this.tsmHibernate,
            this.tsmRestart,
            this.tsmShutdown,
            this.toolStripMenuItem1,
            this.tsmExit});
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(72, 23);
            this.tsmSystem.Text = "系統&(S)";
            // 
            // tsmSuspend
            // 
            this.tsmSuspend.Name = "tsmSuspend";
            this.tsmSuspend.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmSuspend.Size = new System.Drawing.Size(224, 26);
            this.tsmSuspend.Text = "睡眠";
            this.tsmSuspend.Click += new System.EventHandler(this.tsmSuspend_Click);
            // 
            // tsmHibernate
            // 
            this.tsmHibernate.Name = "tsmHibernate";
            this.tsmHibernate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsmHibernate.Size = new System.Drawing.Size(224, 26);
            this.tsmHibernate.Text = "休眠";
            this.tsmHibernate.Click += new System.EventHandler(this.tsmHibernate_Click);
            // 
            // tsmRestart
            // 
            this.tsmRestart.Name = "tsmRestart";
            this.tsmRestart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmRestart.Size = new System.Drawing.Size(224, 26);
            this.tsmRestart.Text = "重新啟動";
            this.tsmRestart.Click += new System.EventHandler(this.tsmRestart_Click);
            // 
            // tsmShutdown
            // 
            this.tsmShutdown.Name = "tsmShutdown";
            this.tsmShutdown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmShutdown.Size = new System.Drawing.Size(224, 26);
            this.tsmShutdown.Text = "關機";
            this.tsmShutdown.Click += new System.EventHandler(this.tsmShutdown_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmExit.Size = new System.Drawing.Size(224, 26);
            this.tsmExit.Text = "結束";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmReset
            // 
            this.tsmReset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCreateDesktopShortcut});
            this.tsmReset.Name = "tsmReset";
            this.tsmReset.Size = new System.Drawing.Size(103, 23);
            this.tsmReset.Text = "重新設定(&R)";
            // 
            // tsmCreateDesktopShortcut
            // 
            this.tsmCreateDesktopShortcut.Name = "tsmCreateDesktopShortcut";
            this.tsmCreateDesktopShortcut.Size = new System.Drawing.Size(182, 26);
            this.tsmCreateDesktopShortcut.Text = "產生桌面捷徑";
            this.tsmCreateDesktopShortcut.Click += new System.EventHandler(this.tsmCreateDesktopShortcut_Click);
            // 
            // cbbBackupDrive
            // 
            this.cbbBackupDrive.FormattingEnabled = true;
            this.cbbBackupDrive.Location = new System.Drawing.Point(352, 117);
            this.cbbBackupDrive.Name = "cbbBackupDrive";
            this.cbbBackupDrive.Size = new System.Drawing.Size(117, 23);
            this.cbbBackupDrive.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "備份磁碟機位置";
            // 
            // btnJEGameList
            // 
            this.btnJEGameList.Location = new System.Drawing.Point(415, 52);
            this.btnJEGameList.Name = "btnJEGameList";
            this.btnJEGameList.Size = new System.Drawing.Size(92, 47);
            this.btnJEGameList.TabIndex = 9;
            this.btnJEGameList.Text = "編輯(Json Editor)";
            this.btnJEGameList.UseVisualStyleBackColor = true;
            this.btnJEGameList.Click += new System.EventHandler(this.btnJEGameList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 301);
            this.Controls.Add(this.btnJEGameList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbBackupDrive);
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
        private System.Windows.Forms.ToolStripMenuItem tsmRestart;
        private System.Windows.Forms.ToolStripMenuItem tsmSuspend;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmHibernate;
        private System.Windows.Forms.ToolStripMenuItem tsmReset;
        private System.Windows.Forms.ToolStripMenuItem tsmCreateDesktopShortcut;
        private System.Windows.Forms.ComboBox cbbBackupDrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJEGameList;
    }
}

