using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClickable_Click(object sender, EventArgs e)
        {
            string firstNum = textBoxFirstNumber.Text;
            string secondNum = textBoxSecondNumber.Text;

            int numOne;
            int.TryParse(firstNum, out numOne);

            int numTwo;
            int.TryParse(secondNum, out numTwo);

            int result = Utils.Addition(numOne, numTwo);

            textBoxResult.Text = result.ToString();

            if (textBoxResult.Text.Length > 0)
                fileToolStripMenuItem.DropDownItems.Add("new Item");

        }

        private void saveToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
        }

        private void fileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            if (fileToolStripMenuItem.DropDownItems.Count > 1)
                fileToolStripMenuItem.DropDownItems.RemoveAt(1);
        }
    }

}
