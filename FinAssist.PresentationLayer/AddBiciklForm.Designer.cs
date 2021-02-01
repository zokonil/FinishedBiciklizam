
namespace Biciklizam.PresentationLayer
{
    partial class AddBiciklForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBiciklForm));
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipDropdown = new System.Windows.Forms.ComboBox();
            this.velRameTxt = new System.Windows.Forms.TextBox();
            this.promjerGumeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.debljinaGumetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mjDropdown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.opremaList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(96, 20);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(94, 20);
            this.txtMarka.TabIndex = 21;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(96, 48);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(94, 20);
            this.txtModel.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tip:";
            // 
            // tipDropdown
            // 
            this.tipDropdown.FormattingEnabled = true;
            this.tipDropdown.Items.AddRange(new object[] {
            "Cestovni",
            "Brdski"});
            this.tipDropdown.Location = new System.Drawing.Point(96, 81);
            this.tipDropdown.Name = "tipDropdown";
            this.tipDropdown.Size = new System.Drawing.Size(94, 21);
            this.tipDropdown.TabIndex = 23;
            // 
            // velRameTxt
            // 
            this.velRameTxt.Location = new System.Drawing.Point(96, 151);
            this.velRameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.velRameTxt.Name = "velRameTxt";
            this.velRameTxt.Size = new System.Drawing.Size(94, 20);
            this.velRameTxt.TabIndex = 26;
            // 
            // promjerGumeTxt
            // 
            this.promjerGumeTxt.Location = new System.Drawing.Point(96, 179);
            this.promjerGumeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.promjerGumeTxt.Name = "promjerGumeTxt";
            this.promjerGumeTxt.Size = new System.Drawing.Size(94, 20);
            this.promjerGumeTxt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Velicina rame:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Promjer gume:";
            // 
            // debljinaGumetxt
            // 
            this.debljinaGumetxt.Location = new System.Drawing.Point(96, 206);
            this.debljinaGumetxt.Margin = new System.Windows.Forms.Padding(2);
            this.debljinaGumetxt.Name = "debljinaGumetxt";
            this.debljinaGumetxt.Size = new System.Drawing.Size(94, 20);
            this.debljinaGumetxt.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Debljina gume:";
            // 
            // mjDropdown
            // 
            this.mjDropdown.FormattingEnabled = true;
            this.mjDropdown.Items.AddRange(new object[] {
            "Milimetar",
            "Inč"});
            this.mjDropdown.Location = new System.Drawing.Point(96, 120);
            this.mjDropdown.Name = "mjDropdown";
            this.mjDropdown.Size = new System.Drawing.Size(94, 21);
            this.mjDropdown.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Mjerna jedinica:";
            // 
            // opremaList
            // 
            this.opremaList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.opremaList.CheckBoxes = true;
            this.opremaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.opremaList.HideSelection = false;
            this.opremaList.Location = new System.Drawing.Point(205, 20);
            this.opremaList.Name = "opremaList";
            this.opremaList.Size = new System.Drawing.Size(257, 178);
            this.opremaList.TabIndex = 32;
            this.opremaList.UseCompatibleStateImageBehavior = false;
            this.opremaList.View = System.Windows.Forms.View.Details;
            this.opremaList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.opremaList_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Opis";
            this.columnHeader2.Width = 168;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 35;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(89, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 33);
            this.button3.TabIndex = 34;
            this.button3.Text = "Spremi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(412, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddBiciklForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 275);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opremaList);
            this.Controls.Add(this.mjDropdown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.debljinaGumetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.velRameTxt);
            this.Controls.Add(this.promjerGumeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipDropdown);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBiciklForm";
            this.Text = "Dodaj bicikl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBiciklForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipDropdown;
        private System.Windows.Forms.TextBox velRameTxt;
        private System.Windows.Forms.TextBox promjerGumeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox debljinaGumetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox mjDropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView opremaList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button4;
    }
}