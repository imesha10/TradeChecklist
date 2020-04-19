using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace TradeChecklist
{
    public partial class TradeChecklistForm : Form
    {
        public String[] lines = null;
        List<RadioButton> rbNone = new List<RadioButton>();
        public TradeChecklistForm()
        {
            InitializeComponent();
            loadDefaultLines();
            addOptions(this.lines);

        }

        public void loadDefaultLines()
        {
            var DefaultLines = TradeChecklist.Properties.Settings.Default.Lines;
            lines = new String[DefaultLines.Count];
            TradeChecklist.Properties.Settings.Default.Lines.CopyTo(this.lines,0);
        }
        private void btnOnTopToggle_Click(object sender, EventArgs e)
        {
            toggleAlwaysOnTop();
        }

        private void toggleAlwaysOnTop()
        {
            if (btnOnTopToggle.BackColor == Color.Red)
            {
                this.TopMost = true;
                btnOnTopToggle.BackColor = Color.Green;
            }
            else
            {
                this.TopMost = false;
                btnOnTopToggle.BackColor = Color.Red;
            }
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            AddModForm f1 = new AddModForm();
            if (this.lines != null) f1.setRichTextBoxLines(this.lines);
            
            
            f1.TopMost = this.TopMost;
            f1.ShowDialog();
            if (f1.save) this.lines = f1.lines;
            if (lines == null) return;
            addOptions(this.lines);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lines = null;
            clearOptions();
        }

        private void addOptions(String[] lines)
        {
            flowLayoutPanel.Controls.Clear();
            foreach (String line in lines)
            {
                if (line == null || line == "\n" || line == "") continue;

                GroupBox g1 = new GroupBox();
                g1.Text = line;
                g1.Width = 231;
                g1.Height = 80;

                // Each option has True/False/None/Buy/Sell
                RadioButton rb1 = new RadioButton();
                rb1.Text = "True";
                rb1.Location = new System.Drawing.Point(20, 20);
                rb1.Size = new System.Drawing.Size(50, 17);

                RadioButton rb2 = new RadioButton();
                rb2.Text = "False";
                rb2.Location = new System.Drawing.Point(80, 20);
                rb2.Size = new System.Drawing.Size(50, 17);

                RadioButton rb3 = new RadioButton();
                rb3.Text = "None";
                rb3.Location = new System.Drawing.Point(140, 20);
                rb3.Size = new System.Drawing.Size(60, 17);
                rbNone.Add(rb3);

                RadioButton rb4 = new RadioButton();
                rb4.Text = "Buy";
                rb4.Location = new System.Drawing.Point(20, 50);
                rb4.Size = new System.Drawing.Size(60, 17);

                RadioButton rb5 = new RadioButton();
                rb5.Text = "Sell";
                rb5.Location = new System.Drawing.Point(80, 50);
                rb5.Size = new System.Drawing.Size(60, 17);

                RadioButton rb6 = new RadioButton();
                rb6.Text = "Both";
                rb6.Location = new System.Drawing.Point(140, 50);
                rb6.Size = new System.Drawing.Size(60, 17);

                g1.Controls.AddRange(new Control[] { rb1, rb2, rb3, rb4, rb5, rb6});

                flowLayoutPanel.Controls.Add(g1);
            }
        }

        private void clearOptions()
        {
            foreach(Control c in flowLayoutPanel.Controls)
            {
                c.Dispose();
            }
            flowLayoutPanel.Controls.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in rbNone)
            {
                rb.Checked = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            List<String> s1 = new List<string>();
            foreach (Control c in flowLayoutPanel.Controls)
            {
                String title = c.Text;
                String status = "";
                foreach (Control d in c.Controls)
                {
                    RadioButton rb = (RadioButton)d;
                    if (rb.Checked) status = rb.Text;
                }

                s1.Add(title + ": " + status);
            }
            String rString = String.Join("\n", s1);
            Clipboard.SetText(rString);
        }
    }
}
