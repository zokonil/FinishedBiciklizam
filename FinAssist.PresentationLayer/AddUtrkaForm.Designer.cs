
namespace Biciklizam.PresentationLayer
{
    partial class AddUtrkaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUtrkaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.duljinaTxt = new System.Windows.Forms.TextBox();
            this.TrajanjeBox = new System.Windows.Forms.DateTimePicker();
            this.datumBox = new System.Windows.Forms.DateTimePicker();
            this.RezultatiList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duljina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trajanje:";
            // 
            // duljinaTxt
            // 
            this.duljinaTxt.Location = new System.Drawing.Point(72, 6);
            this.duljinaTxt.Name = "duljinaTxt";
            this.duljinaTxt.Size = new System.Drawing.Size(100, 20);
            this.duljinaTxt.TabIndex = 3;
            // 
            // TrajanjeBox
            // 
            this.TrajanjeBox.CustomFormat = "hh:mm";
            this.TrajanjeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TrajanjeBox.Location = new System.Drawing.Point(72, 38);
            this.TrajanjeBox.Name = "TrajanjeBox";
            this.TrajanjeBox.ShowUpDown = true;
            this.TrajanjeBox.Size = new System.Drawing.Size(100, 20);
            this.TrajanjeBox.TabIndex = 4;
            // 
            // datumBox
            // 
            this.datumBox.Location = new System.Drawing.Point(72, 69);
            this.datumBox.Name = "datumBox";
            this.datumBox.Size = new System.Drawing.Size(200, 20);
            this.datumBox.TabIndex = 5;
            // 
            // RezultatiList
            // 
            this.RezultatiList.CheckBoxes = true;
            this.RezultatiList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.RezultatiList.HideSelection = false;
            this.RezultatiList.Location = new System.Drawing.Point(15, 167);
            this.RezultatiList.Name = "RezultatiList";
            this.RezultatiList.Size = new System.Drawing.Size(245, 150);
            this.RezultatiList.TabIndex = 6;
            this.RezultatiList.UseCompatibleStateImageBehavior = false;
            this.RezultatiList.View = System.Windows.Forms.View.Details;
            this.RezultatiList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.RezultatiList_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mjesto";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 112;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj utrku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(205, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Biciklisti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tip utrke:";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Cestovna utrka",
            "Kriterij",
            "Kronometar"});
            this.typeBox.Location = new System.Drawing.Point(71, 110);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 21);
            this.typeBox.TabIndex = 13;
            // 
            // AddUtrkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 407);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RezultatiList);
            this.Controls.Add(this.datumBox);
            this.Controls.Add(this.TrajanjeBox);
            this.Controls.Add(this.duljinaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUtrkaForm";
            this.Text = "Dodaj utrku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUtrkaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox duljinaTxt;
        private System.Windows.Forms.DateTimePicker TrajanjeBox;
        private System.Windows.Forms.DateTimePicker datumBox;
        private System.Windows.Forms.ListView RezultatiList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}