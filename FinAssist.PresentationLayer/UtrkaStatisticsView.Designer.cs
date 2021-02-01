
namespace Biciklizam.PresentationLayer
{
    partial class UtrkaStatisticsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtrkaStatisticsView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.brojBiciklistaTxt = new System.Windows.Forms.TextBox();
            this.prisustvovaliTxt = new System.Windows.Forms.TextBox();
            this.prosjecnaBrzinaTxt = new System.Windows.Forms.TextBox();
            this.prosjecnaUdaljenostTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupni broj biciklista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prosjecna brzina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prisustvovali:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prosjecna udaljenost:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brojBiciklistaTxt
            // 
            this.brojBiciklistaTxt.Location = new System.Drawing.Point(147, 17);
            this.brojBiciklistaTxt.Name = "brojBiciklistaTxt";
            this.brojBiciklistaTxt.Size = new System.Drawing.Size(102, 20);
            this.brojBiciklistaTxt.TabIndex = 5;
            // 
            // prisustvovaliTxt
            // 
            this.prisustvovaliTxt.Location = new System.Drawing.Point(147, 48);
            this.prisustvovaliTxt.Name = "prisustvovaliTxt";
            this.prisustvovaliTxt.Size = new System.Drawing.Size(102, 20);
            this.prisustvovaliTxt.TabIndex = 6;
            // 
            // prosjecnaBrzinaTxt
            // 
            this.prosjecnaBrzinaTxt.Location = new System.Drawing.Point(147, 74);
            this.prosjecnaBrzinaTxt.Name = "prosjecnaBrzinaTxt";
            this.prosjecnaBrzinaTxt.Size = new System.Drawing.Size(102, 20);
            this.prosjecnaBrzinaTxt.TabIndex = 7;
            // 
            // prosjecnaUdaljenostTxt
            // 
            this.prosjecnaUdaljenostTxt.Location = new System.Drawing.Point(147, 103);
            this.prosjecnaUdaljenostTxt.Name = "prosjecnaUdaljenostTxt";
            this.prosjecnaUdaljenostTxt.Size = new System.Drawing.Size(102, 20);
            this.prosjecnaUdaljenostTxt.TabIndex = 8;
            // 
            // UtrkaStatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 186);
            this.Controls.Add(this.prosjecnaUdaljenostTxt);
            this.Controls.Add(this.prosjecnaBrzinaTxt);
            this.Controls.Add(this.prisustvovaliTxt);
            this.Controls.Add(this.brojBiciklistaTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UtrkaStatisticsView";
            this.Text = "Statistike utrke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox brojBiciklistaTxt;
        private System.Windows.Forms.TextBox prisustvovaliTxt;
        private System.Windows.Forms.TextBox prosjecnaBrzinaTxt;
        private System.Windows.Forms.TextBox prosjecnaUdaljenostTxt;
    }
}