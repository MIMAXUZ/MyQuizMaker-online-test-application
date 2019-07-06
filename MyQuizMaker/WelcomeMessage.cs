using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQuizMaker
{
    public partial class WelcomeMessage : Form
    {
        public WelcomeMessage()
        {
            InitializeComponent();
        }

        private void WelcomeMessage_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartingButton_Click(object sender, EventArgs e)
        {
            //Closing Welcome page and opened GetTests
            GetTests t = new GetTests();
            this.Visible = false;
            t.Show(this);
        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
