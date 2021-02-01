
namespace Biciklizam.PresentationLayer
{
    partial class EditBiciklistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBiciklistForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateBiciklistRodenje = new System.Windows.Forms.DateTimePicker();
            this.txtBiciklistIme = new System.Windows.Forms.TextBox();
            this.txtBiciklistPrezime = new System.Windows.Forms.TextBox();
            this.txtBiciklistOIB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Biciklbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(192, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(52, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateBiciklistRodenje
            // 
            this.dateBiciklistRodenje.Location = new System.Drawing.Point(120, 121);
            this.dateBiciklistRodenje.Name = "dateBiciklistRodenje";
            this.dateBiciklistRodenje.Size = new System.Drawing.Size(200, 20);
            this.dateBiciklistRodenje.TabIndex = 18;
            // 
            // txtBiciklistIme
            // 
            this.txtBiciklistIme.Location = new System.Drawing.Point(120, 27);
            this.txtBiciklistIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtBiciklistIme.Name = "txtBiciklistIme";
            this.txtBiciklistIme.Size = new System.Drawing.Size(200, 20);
            this.txtBiciklistIme.TabIndex = 15;
            // 
            // txtBiciklistPrezime
            // 
            this.txtBiciklistPrezime.Location = new System.Drawing.Point(120, 58);
            this.txtBiciklistPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBiciklistPrezime.Name = "txtBiciklistPrezime";
            this.txtBiciklistPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtBiciklistPrezime.TabIndex = 16;
            // 
            // txtBiciklistOIB
            // 
            this.txtBiciklistOIB.Location = new System.Drawing.Point(120, 88);
            this.txtBiciklistOIB.Margin = new System.Windows.Forms.Padding(2);
            this.txtBiciklistOIB.Name = "txtBiciklistOIB";
            this.txtBiciklistOIB.Size = new System.Drawing.Size(200, 20);
            this.txtBiciklistOIB.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Godina rođenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "OIB:";
            // 
            // Biciklbutton
            // 
            this.Biciklbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Biciklbutton.Location = new System.Drawing.Point(27, 152);
            this.Biciklbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Biciklbutton.Name = "Biciklbutton";
            this.Biciklbutton.Size = new System.Drawing.Size(86, 29);
            this.Biciklbutton.TabIndex = 21;
            this.Biciklbutton.Text = "Bicikl";
            this.Biciklbutton.UseVisualStyleBackColor = true;
            this.Biciklbutton.Click += new System.EventHandler(this.Biciklbutton_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(207, 152);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "Statistike";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditBiciklistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 241);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Biciklbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateBiciklistRodenje);
            this.Controls.Add(this.txtBiciklistIme);
            this.Controls.Add(this.txtBiciklistPrezime);
            this.Controls.Add(this.txtBiciklistOIB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditBiciklistForm";
            this.Text = "Uredi biciklista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditBiciklistForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateBiciklistRodenje;
        private System.Windows.Forms.TextBox txtBiciklistIme;
        private System.Windows.Forms.TextBox txtBiciklistPrezime;
        private System.Windows.Forms.TextBox txtBiciklistOIB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Biciklbutton;
        private System.Windows.Forms.Button button3;
    }
}