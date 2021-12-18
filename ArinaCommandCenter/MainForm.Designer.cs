
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 192);
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
    }
}

