namespace Atlantik
{
    partial class frmCreerLiaison
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
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.btnCreerLiaison = new System.Windows.Forms.Button();
            this.lblPortDepart = new System.Windows.Forms.Label();
            this.lblPortArrivee = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.cmbPortDepart = new System.Windows.Forms.ComboBox();
            this.cmbPortArrivee = new System.Windows.Forms.ComboBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.cmbSecteur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(12, 145);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(121, 20);
            this.tbxDistance.TabIndex = 3;
            // 
            // btnCreerLiaison
            // 
            this.btnCreerLiaison.Location = new System.Drawing.Point(12, 171);
            this.btnCreerLiaison.Name = "btnCreerLiaison";
            this.btnCreerLiaison.Size = new System.Drawing.Size(121, 23);
            this.btnCreerLiaison.TabIndex = 4;
            this.btnCreerLiaison.Text = "Créer la liaison";
            this.btnCreerLiaison.UseVisualStyleBackColor = true;
            this.btnCreerLiaison.Click += new System.EventHandler(this.btnCreerLiaison_Click);
            // 
            // lblPortDepart
            // 
            this.lblPortDepart.AutoSize = true;
            this.lblPortDepart.Location = new System.Drawing.Point(9, 49);
            this.lblPortDepart.Name = "lblPortDepart";
            this.lblPortDepart.Size = new System.Drawing.Size(80, 13);
            this.lblPortDepart.TabIndex = 1;
            this.lblPortDepart.Text = "Port de départ :";
            // 
            // lblPortArrivee
            // 
            this.lblPortArrivee.AutoSize = true;
            this.lblPortArrivee.Location = new System.Drawing.Point(12, 89);
            this.lblPortArrivee.Name = "lblPortArrivee";
            this.lblPortArrivee.Size = new System.Drawing.Size(75, 13);
            this.lblPortArrivee.TabIndex = 2;
            this.lblPortArrivee.Text = "Port d\'arrivée :";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(12, 129);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 13);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "Distance :";
            // 
            // cmbPortDepart
            // 
            this.cmbPortDepart.FormattingEnabled = true;
            this.cmbPortDepart.Location = new System.Drawing.Point(12, 65);
            this.cmbPortDepart.Name = "cmbPortDepart";
            this.cmbPortDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbPortDepart.TabIndex = 1;
            // 
            // cmbPortArrivee
            // 
            this.cmbPortArrivee.FormattingEnabled = true;
            this.cmbPortArrivee.Location = new System.Drawing.Point(12, 105);
            this.cmbPortArrivee.Name = "cmbPortArrivee";
            this.cmbPortArrivee.Size = new System.Drawing.Size(121, 21);
            this.cmbPortArrivee.TabIndex = 2;
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(12, 9);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(50, 13);
            this.lblSecteur.TabIndex = 8;
            this.lblSecteur.Text = "Secteur :";
            // 
            // cmbSecteur
            // 
            this.cmbSecteur.FormattingEnabled = true;
            this.cmbSecteur.Location = new System.Drawing.Point(12, 25);
            this.cmbSecteur.Name = "cmbSecteur";
            this.cmbSecteur.Size = new System.Drawing.Size(121, 21);
            this.cmbSecteur.TabIndex = 0;
            // 
            // frmCreerLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(146, 205);
            this.Controls.Add(this.btnCreerLiaison);
            this.Controls.Add(this.cmbSecteur);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.cmbPortArrivee);
            this.Controls.Add(this.cmbPortDepart);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblPortArrivee);
            this.Controls.Add(this.lblPortDepart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCreerLiaison";
            this.Text = "Créer une liaison";
            this.Load += new System.EventHandler(this.FrmCreerLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Button btnCreerLiaison;
        private System.Windows.Forms.Label lblPortDepart;
        private System.Windows.Forms.Label lblPortArrivee;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.ComboBox cmbPortDepart;
        private System.Windows.Forms.ComboBox cmbPortArrivee;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ComboBox cmbSecteur;
    }
}