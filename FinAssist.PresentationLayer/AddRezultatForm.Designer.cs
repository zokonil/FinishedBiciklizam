
namespace Biciklizam.PresentationLayer
{
    partial class AddRezultatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRezultatForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.udaljenostTxt = new System.Windows.Forms.TextBox();
            this.biciklistCombo = new System.Windows.Forms.ComboBox();
            this.TrajanjeBox = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrijeme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ukupna udaljenost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Biciklist:";
            // 
            // udaljenostTxt
            // 
            this.udaljenostTxt.Location = new System.Drawing.Point(122, 69);
            this.udaljenostTxt.Name = "udaljenostTxt";
            this.udaljenostTxt.Size = new System.Drawing.Size(121, 20);
            this.udaljenostTxt.TabIndex = 8;
            // 
            // biciklistCombo
            // 
            this.biciklistCombo.FormattingEnabled = true;
            this.biciklistCombo.Location = new System.Drawing.Point(122, 6);
            this.biciklistCombo.Name = "biciklistCombo";
            this.biciklistCombo.Size = new System.Drawing.Size(121, 21);
            this.biciklistCombo.TabIndex = 9;
            // 
            // TrajanjeBox
            // 
            this.TrajanjeBox.CustomFormat = "hh:mm";
            this.TrajanjeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TrajanjeBox.Location = new System.Drawing.Point(122, 35);
            this.TrajanjeBox.Name = "TrajanjeBox";
            this.TrajanjeBox.ShowUpDown = true;
            this.TrajanjeBox.Size = new System.Drawing.Size(121, 20);
            this.TrajanjeBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddRezultatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 154);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TrajanjeBox);
            this.Controls.Add(this.biciklistCombo);
            this.Controls.Add(this.udaljenostTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRezultatForm";
            this.Text = "Dodaj rezultat";
            this.Load += new System.EventHandler(this.AddRezultatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox udaljenostTxt;
        private System.Windows.Forms.ComboBox biciklistCombo;
        private System.Windows.Forms.DateTimePicker TrajanjeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}