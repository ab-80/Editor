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
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Editor
{
    public partial class EditorPage : Form
    {
        public EditorPage()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            WarningForm warning = new WarningForm();
            DialogResult result = warning.ShowDialog();

            //uses the WarningForm to confirm that the user wants to start a new page
            if (warning.returnValue == 1)
            {
                richTextBox1.Clear();
            }

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();

                using (StreamReader selectedFile = new StreamReader(ofd.FileName))
                {
                    richTextBox1.Text = selectedFile.ReadToEnd();
                    selectedFile.Close();
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileToBeSaved = new SaveFileDialog();
            fileToBeSaved.Title = "Save File";

            if (fileToBeSaved.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(fileToBeSaved.FileName))
                {
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                }
            }

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripRedo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void newLabel_Click(object sender, EventArgs e)
        {
            WarningForm warning = new WarningForm();
            DialogResult result = warning.ShowDialog();

            //uses the WarningForm to confirm that the user wants to start a new page
            if (warning.returnValue == 1)
            {
                richTextBox1.Clear();
            }
        }

        private void openLabel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();

                using (StreamReader selectedFile = new StreamReader(ofd.FileName))
                {
                    richTextBox1.Text = selectedFile.ReadToEnd();
                    selectedFile.Close();
                }
            }
        }

        private void saveLabel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileToBeSaved = new SaveFileDialog();
            fileToBeSaved.Title = "Save File";

            if (fileToBeSaved.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(fileToBeSaved.FileName))
                {
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                }
            }
        }

        private void cutLabel_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyLabel_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteLabel_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoLabel_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoLabel_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectAllLabel_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();

        }

        private void toolStripRun_Click(object sender, EventArgs e)
        {
            /*
            outputBox.Items.Clear();
            Interpreter interpreter = new Interpreter();
            ArrayList outputList = new ArrayList();
            outputList = interpreter.Run(richTextBox1.Text);
            for(int i = 0; i < outputList.Count; i++)
            {
                outputBox.Items.Add(i);
            }
            */

            
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileToBeSaved = new SaveFileDialog();
            fileToBeSaved.Title = "Save File";

            if (fileToBeSaved.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(fileToBeSaved.FileName))
                {
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                }
            }
        }
    }
}
