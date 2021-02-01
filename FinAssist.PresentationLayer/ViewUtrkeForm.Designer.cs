
namespace Biciklizam.PresentationLayer
{
    partial class ViewUtrkeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUtrkeForm));
            this.utrkeList = new System.Windows.Forms.ListView();
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duljina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trajanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // utrkeList
            // 
            this.utrkeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Datum,
            this.Duljina,
            this.Trajanje});
            this.utrkeList.GridLines = true;
            this.utrkeList.HideSelection = false;
            this.utrkeList.Location = new System.Drawing.Point(12, 12);
            this.utrkeList.Name = "utrkeList";
            this.utrkeList.Size = new System.Drawing.Size(476, 317);
            this.utrkeList.TabIndex = 0;
            this.utrkeList.UseCompatibleStateImageBehavior = false;
            this.utrkeList.View = System.Windows.Forms.View.Details;
            this.utrkeList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.utrkeList_MouseClick);
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 104;
            // 
            // Duljina
            // 
            this.Duljina.Text = "Duljina utrke";
            this.Duljina.Width = 161;
            // 
            // Trajanje
            // 
            this.Trajanje.Text = "Trajanje utrke";
            this.Trajanje.Width = 170;
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Location = new System.Drawing.Point(69, 337);
            this.btnAddNewAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(114, 27);
            this.btnAddNewAccount.TabIndex = 2;
            this.btnAddNewAccount.Text = "Dodaj utrku";
            this.btnAddNewAccount.UseVisualStyleBackColor = true;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddNewAccount_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 37;
            // 
            // ViewUtrkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewAccount);
            this.Controls.Add(this.utrkeList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewUtrkeForm";
            this.Text = "Utrke";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView utrkeList;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Duljina;
        private System.Windows.Forms.ColumnHeader Trajanje;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Id;
    }
}