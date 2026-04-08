namespace photoobchod
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obrazekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mistoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukazatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrazekToolStripMenuItem,
            this.mistoToolStripMenuItem,
            this.ukazatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(78, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obrazekToolStripMenuItem
            // 
            this.obrazekToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.obrazekToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.obrazekToolStripMenuItem.Name = "obrazekToolStripMenuItem";
            this.obrazekToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.obrazekToolStripMenuItem.Text = "obrazek";
            this.obrazekToolStripMenuItem.Click += new System.EventHandler(this.obrazekToolStripMenuItem_Click);
            // 
            // mistoToolStripMenuItem
            // 
            this.mistoToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mistoToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.mistoToolStripMenuItem.Name = "mistoToolStripMenuItem";
            this.mistoToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.mistoToolStripMenuItem.Text = "misto";
            this.mistoToolStripMenuItem.Click += new System.EventHandler(this.mistoToolStripMenuItem_Click);
            // 
            // ukazatToolStripMenuItem
            // 
            this.ukazatToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ukazatToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.ukazatToolStripMenuItem.Name = "ukazatToolStripMenuItem";
            this.ukazatToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.ukazatToolStripMenuItem.Text = "ukazat";
            this.ukazatToolStripMenuItem.Click += new System.EventHandler(this.ukazatToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrazekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mistoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukazatToolStripMenuItem;
    }
}