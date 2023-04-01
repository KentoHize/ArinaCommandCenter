
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
            this.cbbGameList2 = new System.Windows.Forms.ComboBox();
            this.btnLatestGameSaveMove = new System.Windows.Forms.Button();
            this.btnLatestGameSaveMove2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGameSave
            // 
            this.btnGameSave.Location = new System.Drawing.Point(277, 36);
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
            this.cbbGameList.Location = new System.Drawing.Point(38, 45);
            this.cbbGameList.Name = "cbbGameList";
            this.cbbGameList.Size = new System.Drawing.Size(201, 23);
            this.cbbGameList.TabIndex = 1;
            // 
            // btnGameSaveMove
            // 
            this.btnGameSaveMove.Location = new System.Drawing.Point(277, 102);
            this.btnGameSaveMove.Name = "btnGameSaveMove";
            this.btnGameSaveMove.Size = new System.Drawing.Size(125, 39);
            this.btnGameSaveMove.TabIndex = 2;
            this.btnGameSaveMove.Text = "遊戲存檔移動";
            this.btnGameSaveMove.UseVisualStyleBackColor = true;
            this.btnGameSaveMove.Click += new System.EventHandler(this.btnGameSaveMove_Click);
            // 
            // cbbGameList2
            // 
            this.cbbGameList2.FormattingEnabled = true;
            this.cbbGameList2.Location = new System.Drawing.Point(38, 111);
            this.cbbGameList2.Name = "cbbGameList2";
            this.cbbGameList2.Size = new System.Drawing.Size(201, 23);
            this.cbbGameList2.TabIndex = 3;
            // 
            // btnLatestGameSaveMove
            // 
            this.btnLatestGameSaveMove.Location = new System.Drawing.Point(38, 162);
            this.btnLatestGameSaveMove.Name = "btnLatestGameSaveMove";
            this.btnLatestGameSaveMove.Size = new System.Drawing.Size(208, 40);
            this.btnLatestGameSaveMove.TabIndex = 4;
            this.btnLatestGameSaveMove.Text = "最新存檔移動(30分鐘)";
            this.btnLatestGameSaveMove.UseVisualStyleBackColor = true;
            this.btnLatestGameSaveMove.Click += new System.EventHandler(this.btnLatestGameSaveMove_Click);
            // 
            // btnLatestGameSaveMove2
            // 
            this.btnLatestGameSaveMove2.Location = new System.Drawing.Point(268, 162);
            this.btnLatestGameSaveMove2.Name = "btnLatestGameSaveMove2";
            this.btnLatestGameSaveMove2.Size = new System.Drawing.Size(209, 40);
            this.btnLatestGameSaveMove2.TabIndex = 5;
            this.btnLatestGameSaveMove2.Text = "最新存檔移動(3分鐘)";
            this.btnLatestGameSaveMove2.UseVisualStyleBackColor = true;
            this.btnLatestGameSaveMove2.Click += new System.EventHandler(this.btnLatestGameSaveMove2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 235);
            this.Controls.Add(this.btnLatestGameSaveMove2);
            this.Controls.Add(this.btnLatestGameSaveMove);
            this.Controls.Add(this.cbbGameList2);
            this.Controls.Add(this.btnGameSaveMove);
            this.Controls.Add(this.cbbGameList);
            this.Controls.Add(this.btnGameSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "有奈管理面板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGameSave;
        private System.Windows.Forms.ComboBox cbbGameList;
        private System.Windows.Forms.Button btnGameSaveMove;
        private System.Windows.Forms.ComboBox cbbGameList2;
        private System.Windows.Forms.Button btnLatestGameSaveMove;
        private System.Windows.Forms.Button btnLatestGameSaveMove2;
    }
}

