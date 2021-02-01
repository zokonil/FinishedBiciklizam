
namespace Biciklizam.PresentationLayer
{
    partial class AddBiciklistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBiciklistForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBiciklistOIB = new System.Windows.Forms.TextBox();
            this.txtBiciklistPrezime = new System.Windows.Forms.TextBox();
            this.txtBiciklistIme = new System.Windows.Forms.TextBox();
            this.dateBiciklistRodenje = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OIB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ime:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Godina rođenja:";
            // 
            // txtBiciklistOIB
            // 
            this.txtBiciklistOIB.Location = new System.Drawing.Point(120, 88);
            this.txtBiciklistOIB.Margin = new System.Windows.Forms.Padding(2);
            this.txtBiciklistOIB.Name = "txtBiciklistOIB";
            this.txtBiciklistOIB.Size = new System.Drawing.Size(200, 20);
            this.txtBiciklistOIB.TabIndex = 7;
            // 
            // txtBiciklistPrezime
            // 
            this.txtBiciklistPrezime.Location = new System.Drawing.Point(120, 58);
            this.txtBiciklistPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBiciklistPrezime.Name = "txtBiciklistPrezime";
            this.txtBiciklistPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtBiciklistPrezime.TabIndex = 6;
            // 
            // txtBiciklistIme
            // 
            this.txtBiciklistIme.Location = new System.Drawing.Point(120, 27);
            this.txtBiciklistIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtBiciklistIme.Name = "txtBiciklistIme";
            this.txtBiciklistIme.Size = new System.Drawing.Size(200, 20);
            this.txtBiciklistIme.TabIndex = 5;
            // 
            // dateBiciklistRodenje
            // 
            this.dateBiciklistRodenje.Location = new System.Drawing.Point(120, 121);
            this.dateBiciklistRodenje.Name = "dateBiciklistRodenje";
            this.dateBiciklistRodenje.Size = new System.Drawing.Size(200, 20);
            this.dateBiciklistRodenje.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(55, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj biciklista";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(27, 146);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "Bicikl";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(195, 191);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(86, 29);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Zatvori";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddBiciklistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 241);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.button3);
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
            this.Name = "AddBiciklistForm";
            this.Text = "Dodaj biciklista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBiciklistForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBiciklistOIB;
        private System.Windows.Forms.TextBox txtBiciklistPrezime;
        private System.Windows.Forms.TextBox txtBiciklistIme;
        private System.Windows.Forms.DateTimePicker dateBiciklistRodenje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CancelButton;
    }
}