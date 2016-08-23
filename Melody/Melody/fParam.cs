using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Melody
{
    public partial class fParam : Form
    {
        public fParam()
        {
            InitializeComponent();
        }

        private void fParam_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCans_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chlboxInclud_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBrsFold_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3", chlboxInclud.Checked?System.IO.SearchOption.AllDirectories:System.IO.SearchOption.TopDirectoryOnly);
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
            }
        }
    }
}
