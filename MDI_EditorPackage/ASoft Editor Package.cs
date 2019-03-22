using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_EditorPackage
{
    public partial class ASoft_Editor_Package : Form
    {

        public ASoft_Editor_Package()
        {
            InitializeComponent();
        }

        private void ASoft_Editor_Package_Load(object sender, EventArgs e)
        {

        }
        //Menu > File > New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenNewEditor();
        }

        //Menu > File > Exit Application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenTextFile();
        }
    }
}
