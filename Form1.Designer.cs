namespace TradeChecklist
{
    partial class TradeChecklistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOnTopToggle = new System.Windows.Forms.Button();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnTopToggle
            // 
            this.btnOnTopToggle.BackColor = System.Drawing.Color.Red;
            this.btnOnTopToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnTopToggle.Location = new System.Drawing.Point(12, 12);
            this.btnOnTopToggle.Name = "btnOnTopToggle";
            this.btnOnTopToggle.Size = new System.Drawing.Size(75, 23);
            this.btnOnTopToggle.TabIndex = 0;
            this.btnOnTopToggle.Text = "On Top";
            this.btnOnTopToggle.UseVisualStyleBackColor = false;
            this.btnOnTopToggle.Click += new System.EventHandler(this.btnOnTopToggle_Click);
            // 
            // btnAddMod
            // 
            this.btnAddMod.Location = new System.Drawing.Point(93, 12);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(75, 23);
            this.btnAddMod.TabIndex = 1;
            this.btnAddMod.Text = "Add/Mod";
            this.btnAddMod.UseVisualStyleBackColor = true;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 72);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel.TabIndex = 3;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(174, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(93, 41);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // TradeChecklistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(265, 198);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddMod);
            this.Controls.Add(this.btnOnTopToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TradeChecklistForm";
            this.ShowIcon = false;
            this.Text = "TradeChecklist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnTopToggle;
        private System.Windows.Forms.Button btnAddMod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCopy;
    }
}

