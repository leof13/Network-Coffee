using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Coffee
{
    public partial class InfoPopup : Form
    {
        public InfoPopup()
        {
            InitializeComponent();
        }

        private void InfoPopup_Load(object sender, EventArgs e)
        {
            Label_Info.Text = Label_Info.Text + Version.SoftwareVersion;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
