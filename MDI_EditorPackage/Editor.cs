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

namespace MDI_EditorPackage
{
    public partial class Editor : Form
    {
        public OpenFileDialog openFile;
        public string file, dataFromFile;
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.W)
            //{
            //    this.Close();
            //}
        }

        private void EditTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.W)
            //{
            //    this.Close();
            //}
        }
        private void EditTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        protected internal void OpenFile()
        {
            try
            {
                Console.WriteLine("Open pressed from menustrip.");

                openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    file = openFile.FileName;
                    Console.WriteLine("Opening file: " + file);

                    dataFromFile = File.ReadAllText(file);
                    EditTextBox.Text = dataFromFile;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occured: " + exp);
            }
        }
        public void CloseCurrentEditor()
        {
            this.Close();
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }
    }
}
