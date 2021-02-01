namespace Biciklizam.PresentationLayer
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.utrkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledUtrkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUtrkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utrkeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.defaultToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(629, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // utrkeToolStripMenuItem
            // 
            this.utrkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledUtrkaToolStripMenuItem,
            this.dodajUtrkuToolStripMenuItem});
            this.utrkeToolStripMenuItem.Name = "utrkeToolStripMenuItem";
            this.utrkeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.utrkeToolStripMenuItem.Text = "Utrke";
            // 
            // pregledUtrkaToolStripMenuItem
            // 
            this.pregledUtrkaToolStripMenuItem.Name = "pregledUtrkaToolStripMenuItem";
            this.pregledUtrkaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledUtrkaToolStripMenuItem.Text = "Pregled utrka";
            this.pregledUtrkaToolStripMenuItem.Click += new System.EventHandler(this.pregledUtrkaToolStripMenuItem_Click);
            // 
            // dodajUtrkuToolStripMenuItem
            // 
            this.dodajUtrkuToolStripMenuItem.Name = "dodajUtrkuToolStripMenuItem";
            this.dodajUtrkuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajUtrkuToolStripMenuItem.Text = "Dodaj utrku";
            this.dodajUtrkuToolStripMenuItem.Click += new System.EventHandler(this.dodajUtrkuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Biciklisti";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem2.Text = "Pregled biciklista";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem3.Text = "Dodaj biciklista";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultModelToolStripMenuItem_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 415);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainWindow";
            this.Text = "Biciklizam";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem utrkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledUtrkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUtrkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
    }
}