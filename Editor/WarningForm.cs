using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this class is a form that returns a value of 0 if cancel is selected, or 1 if confirm is selected
//it is used to make sure users dont accidentally delete their work
namespace Editor
{
    public partial class WarningForm : Form
    {

        private int _returnValue = 0;

        public int returnValue
        {
            get { return _returnValue; }
        }


        public WarningForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            _returnValue = 1;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _returnValue = 0;
            this.Close();
        }

    }
}
