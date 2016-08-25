using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody
{
    public partial class fGame : Form
    {

        public fGame()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Random rdm = new Random();
            WMP.URL = Victorina.list[5];
        }
    }
}
