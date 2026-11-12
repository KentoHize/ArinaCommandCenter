namespace ArinaCommandCenter
{
    partial class frmRequester
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
            this.txtMain = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(1, 3);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(796, 426);
            this.txtMain.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(25, 477);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(330, 25);
            this.txtURL.TabIndex = 12;
            this.txtURL.Text = "https://arinaorganization.org";
            // 
            // btnNavigate
            // 
            this.btnNavigate.Location = new System.Drawing.Point(693, 470);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(65, 34);
            this.btnNavigate.TabIndex = 13;
            this.btnNavigate.Text = "→";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // frmRequester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtMain);
            this.Name = "frmRequester";
            this.Text = "Recevie";
            this.Load += new System.EventHandler(this.frmRequester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnNavigate;
    }
}