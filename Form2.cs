using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeChecklist
{
    public partial class AddModForm : Form
    {
        public String[] lines = null;
        public bool save = false;
        public AddModForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Lines = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lines = richTextBox1.Lines;
            this.save = true;
            this.Close();
        }

        public void setRichTextBoxLines(String[] lines)
        {
            richTextBox1.Lines = lines;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            System.Collections.Specialized.StringCollection sc = new System.Collections.Specialized.StringCollection();
            foreach (String line in richTextBox1.Lines)
            {
                sc.Add(line);
            }
            TradeChecklist.Properties.Settings.Default.Lines = sc;
            TradeChecklist.Properties.Settings.Default.Save();
        }

    }
}
