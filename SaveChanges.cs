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
    public partial class SaveChanges : Form
    {
        public bool CancelStatus;

        public bool cancelstat
        {
            get
            {
                return CancelStatus;
            }
        }
        public SaveChanges()
        {
            InitializeComponent();
        }

        private void SaveChanges_Load(object sender, EventArgs e)
        {

        }

        private void Button_Yes_Click(object sender, EventArgs e)
        {
            NetworkCoffee NetCoffeeRef = new NetworkCoffee();
            NetCoffeeRef.SaveAs();
        }

        private void Button_No_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            CancelStatus = true;
            this.Close();
        }
    }
}
