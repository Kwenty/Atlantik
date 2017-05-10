namespace Atlantik
{
    partial class frmAjouterTraversee
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
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.dtpDateTraversee = new System.Windows.Forms.DateTimePicker();
            this.dtpHeureTraversee = new System.Windows.Forms.DateTimePicker();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.btnAjouterTraversee = new System.Windows.Forms.Button();
            this.lblBateau = new System.Windows.Forms.Label();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(8, 25);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(201, 21);
            this.cmbLiaison.TabIndex = 0;
            // 
            // dtpDateTraversee
            // 
            this.dtpDateTraversee.Location = new System.Drawing.Point(7, 92);
            this.dtpDateTraversee.Name = "dtpDateTraversee";
            this.dtpDateTraversee.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTraversee.TabIndex = 2;
            // 
            // dtpHeureTraversee
            // 
            this.dtpHeureTraversee.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeureTraversee.Location = new System.Drawing.Point(7, 118);
            this.dtpHeureTraversee.Name = "dtpHeureTraversee";
            this.dtpHeureTraversee.ShowUpDown = true;
            this.dtpHeureTraversee.Size = new System.Drawing.Size(200, 20);
            this.dtpHeureTraversee.TabIndex = 3;
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(8, 65);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(199, 21);
            this.cmbBateau.TabIndex = 1;
            // 
            // btnAjouterTraversee
            // 
            this.btnAjouterTraversee.Location = new System.Drawing.Point(7, 144);
            this.btnAjouterTraversee.Name = "btnAjouterTraversee";
            this.btnAjouterTraversee.Size = new System.Drawing.Size(199, 23);
            this.btnAjouterTraversee.TabIndex = 4;
            this.btnAjouterTraversee.Text = "Ajouter une traversée";
            this.btnAjouterTraversee.UseVisualStyleBackColor = true;
            this.btnAjouterTraversee.Click += new System.EventHandler(this.btnAjouterTraversee_Click);
            // 
            // lblBateau
            // 
            this.lblBateau.AutoSize = true;
            this.lblBateau.Location = new System.Drawing.Point(5, 49);
            this.lblBateau.Name = "lblBateau";
            this.lblBateau.Size = new System.Drawing.Size(47, 13);
            this.lblBateau.TabIndex = 5;
            this.lblBateau.Text = "Bateau :";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(4, 9);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 6;
            this.lblLiaison.Text = "Liaison :";
            // 
            // frmAjouterTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 177);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblBateau);
            this.Controls.Add(this.btnAjouterTraversee);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.dtpHeureTraversee);
            this.Controls.Add(this.dtpDateTraversee);
            this.Controls.Add(this.cmbLiaison);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAjouterTraversee";
            this.Text = "frmAjouterTraversee";
            this.Load += new System.EventHandler(this.frmAjouterTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.DateTimePicker dtpDateTraversee;
        private System.Windows.Forms.DateTimePicker dtpHeureTraversee;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Button btnAjouterTraversee;
        private System.Windows.Forms.Label lblBateau;
        private System.Windows.Forms.Label lblLiaison;
    }
}