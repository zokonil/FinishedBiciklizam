
namespace Biciklizam.PresentationLayer
{
    partial class BiciklistStatisticsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiciklistStatisticsView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brojUtrkaTxt = new System.Windows.Forms.TextBox();
            this.prosjecnoMjestoTxt = new System.Windows.Forms.TextBox();
            this.ProsjecnaBrzinaTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj utrka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prosjecno mjesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prosjecna brzina:";
            // 
            // brojUtrkaTxt
            // 
            this.brojUtrkaTxt.Location = new System.Drawing.Point(128, 21);
            this.brojUtrkaTxt.Name = "brojUtrkaTxt";
            this.brojUtrkaTxt.Size = new System.Drawing.Size(100, 20);
            this.brojUtrkaTxt.TabIndex = 3;
            // 
            // prosjecnoMjestoTxt
            // 
            this.prosjecnoMjestoTxt.Location = new System.Drawing.Point(128, 50);
            this.prosjecnoMjestoTxt.Name = "prosjecnoMjestoTxt";
            this.prosjecnoMjestoTxt.Size = new System.Drawing.Size(100, 20);
            this.prosjecnoMjestoTxt.TabIndex = 4;
            // 
            // ProsjecnaBrzinaTxt
            // 
            this.ProsjecnaBrzinaTxt.Location = new System.Drawing.Point(128, 79);
            this.ProsjecnaBrzinaTxt.Name = "ProsjecnaBrzinaTxt";
            this.ProsjecnaBrzinaTxt.Size = new System.Drawing.Size(100, 20);
            this.ProsjecnaBrzinaTxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BiciklistStatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProsjecnaBrzinaTxt);
            this.Controls.Add(this.prosjecnoMjestoTxt);
            this.Controls.Add(this.brojUtrkaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiciklistStatisticsView";
            this.Text = "Biciklist statistike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox brojUtrkaTxt;
        private System.Windows.Forms.TextBox prosjecnoMjestoTxt;
        private System.Windows.Forms.TextBox ProsjecnaBrzinaTxt;
        private System.Windows.Forms.Button button1;
    }
}