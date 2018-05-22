/* UserInterface.cs
 * Author: Erin Henderson
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A GUI for a program that opens an empty window.
    /// </summary>
    public partial class UserInterface : Form
    
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(uxopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxopenFileDialog.FileName;
                MessageBox.Show(fileName + "Can Not Open");
            }
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (uxsaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxsaveFileDialog.FileName;
                MessageBox.Show(fileName + "Can Not Write");
            }
        }
    }
}
