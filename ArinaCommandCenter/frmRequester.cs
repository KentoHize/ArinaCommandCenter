using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArinaCommandCenter
{
    public partial class frmRequester : Form
    {
        public string NavigateURL
        { get; set; }

        public frmRequester()
        {
            InitializeComponent();
        }

        private void frmRequester_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            HttpWebRequest hwR = (HttpWebRequest)WebRequest.Create(txtURL.Text);
            hwR.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            try
            {
                WebResponse wr = hwR.GetResponse();
                using (HttpWebResponse response = (HttpWebResponse)wr)
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    txtMain.Text = reader.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //btnNavigate(txtURL.Text);
        }
    }
}
