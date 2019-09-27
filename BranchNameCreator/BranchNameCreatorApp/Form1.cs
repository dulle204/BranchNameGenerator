using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchNameCreatorApp
{
    public partial class BranchNameGenerator : Form
    {
        public BranchNameGenerator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = 
                richTextBox2
                .Text
                .Trim()
                .Replace(' ', '_')
                .Replace('\n', '-');

            Clipboard.SetText(richTextBox1.Text);
        }
    }
}
