namespace Atlantik
{
    partial class frmReservation
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
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblNumeroDateHeure = new System.Windows.Forms.Label();
            this.lblTexteSaisir = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.gbxCoordonnees = new System.Windows.Forms.GroupBox();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.tbxCodePostal = new System.Windows.Forms.TextBox();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblType1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTarifType8 = new System.Windows.Forms.Label();
            this.lblType8 = new System.Windows.Forms.Label();
            this.lblTarifType7 = new System.Windows.Forms.Label();
            this.lblType7 = new System.Windows.Forms.Label();
            this.lblType6 = new System.Windows.Forms.Label();
            this.lblTarifType6 = new System.Windows.Forms.Label();
            this.lblTarifType5 = new System.Windows.Forms.Label();
            this.lblType5 = new System.Windows.Forms.Label();
            this.nudType4 = new System.Windows.Forms.NumericUpDown();
            this.nudType8 = new System.Windows.Forms.NumericUpDown();
            this.nudType3 = new System.Windows.Forms.NumericUpDown();
            this.nudType2 = new System.Windows.Forms.NumericUpDown();
            this.nudType7 = new System.Windows.Forms.NumericUpDown();
            this.nudType1 = new System.Windows.Forms.NumericUpDown();
            this.lblTarifType1 = new System.Windows.Forms.Label();
            this.nudType6 = new System.Windows.Forms.NumericUpDown();
            this.lblTarifType2 = new System.Windows.Forms.Label();
            this.lblTarifType3 = new System.Windows.Forms.Label();
            this.nudType5 = new System.Windows.Forms.NumericUpDown();
            this.lblType4 = new System.Windows.Forms.Label();
            this.lblTarifType4 = new System.Windows.Forms.Label();
            this.lblType3 = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.btnReserver = new System.Windows.Forms.Button();
            this.lblDevise1 = new System.Windows.Forms.Label();
            this.lblDevise3 = new System.Windows.Forms.Label();
            this.lblDevise4 = new System.Windows.Forms.Label();
            this.lblDevise2 = new System.Windows.Forms.Label();
            this.lblDevise5 = new System.Windows.Forms.Label();
            this.lblDevise6 = new System.Windows.Forms.Label();
            this.lblDevise8 = new System.Windows.Forms.Label();
            this.lblDevise7 = new System.Windows.Forms.Label();
            this.gbxCoordonnees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudType4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(12, 9);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(60, 13);
            this.lblLiaison.TabIndex = 0;
            this.lblLiaison.Text = "Liaison A-B";
            // 
            // lblNumeroDateHeure
            // 
            this.lblNumeroDateHeure.AutoSize = true;
            this.lblNumeroDateHeure.Location = new System.Drawing.Point(12, 22);
            this.lblNumeroDateHeure.Name = "lblNumeroDateHeure";
            this.lblNumeroDateHeure.Size = new System.Drawing.Size(191, 13);
            this.lblNumeroDateHeure.TabIndex = 1;
            this.lblNumeroDateHeure.Text = "Traversée n°X le jj/mm/aaaa à hhHmm";
            // 
            // lblTexteSaisir
            // 
            this.lblTexteSaisir.AutoSize = true;
            this.lblTexteSaisir.Location = new System.Drawing.Point(12, 35);
            this.lblTexteSaisir.Name = "lblTexteSaisir";
            this.lblTexteSaisir.Size = new System.Drawing.Size(224, 13);
            this.lblTexteSaisir.TabIndex = 2;
            this.lblTexteSaisir.Text = "Saisir les informations relatives à la réservation";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(16, 22);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom :";
            // 
            // gbxCoordonnees
            // 
            this.gbxCoordonnees.Controls.Add(this.lblCp);
            this.gbxCoordonnees.Controls.Add(this.lblVille);
            this.gbxCoordonnees.Controls.Add(this.tbxVille);
            this.gbxCoordonnees.Controls.Add(this.tbxCodePostal);
            this.gbxCoordonnees.Controls.Add(this.tbxAdresse);
            this.gbxCoordonnees.Controls.Add(this.lblAdresse);
            this.gbxCoordonnees.Controls.Add(this.tbxNom);
            this.gbxCoordonnees.Controls.Add(this.lblNom);
            this.gbxCoordonnees.Location = new System.Drawing.Point(313, 61);
            this.gbxCoordonnees.Name = "gbxCoordonnees";
            this.gbxCoordonnees.Size = new System.Drawing.Size(224, 126);
            this.gbxCoordonnees.TabIndex = 411;
            this.gbxCoordonnees.TabStop = false;
            this.gbxCoordonnees.Text = "Coordonnées";
            this.gbxCoordonnees.Visible = false;
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(16, 74);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(69, 13);
            this.lblCp.TabIndex = 10;
            this.lblCp.Text = "Code postal :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(16, 100);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 9;
            this.lblVille.Text = "Ville :";
            // 
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(91, 97);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(100, 20);
            this.tbxVille.TabIndex = 12;
            // 
            // tbxCodePostal
            // 
            this.tbxCodePostal.Location = new System.Drawing.Point(91, 71);
            this.tbxCodePostal.Name = "tbxCodePostal";
            this.tbxCodePostal.Size = new System.Drawing.Size(100, 20);
            this.tbxCodePostal.TabIndex = 11;
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(91, 45);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(100, 20);
            this.tbxAdresse.TabIndex = 10;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(16, 48);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "Adresse :";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(91, 19);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(100, 20);
            this.tbxNom.TabIndex = 9;
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(6, 22);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(43, 13);
            this.lblType1.TabIndex = 11;
            this.lblType1.Text = "Adulte :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDevise7);
            this.groupBox1.Controls.Add(this.lblDevise8);
            this.groupBox1.Controls.Add(this.lblDevise6);
            this.groupBox1.Controls.Add(this.lblDevise5);
            this.groupBox1.Controls.Add(this.lblDevise2);
            this.groupBox1.Controls.Add(this.lblDevise4);
            this.groupBox1.Controls.Add(this.lblDevise3);
            this.groupBox1.Controls.Add(this.lblDevise1);
            this.groupBox1.Controls.Add(this.lblTarifType8);
            this.groupBox1.Controls.Add(this.lblType8);
            this.groupBox1.Controls.Add(this.lblTarifType7);
            this.groupBox1.Controls.Add(this.lblType7);
            this.groupBox1.Controls.Add(this.lblType6);
            this.groupBox1.Controls.Add(this.lblTarifType6);
            this.groupBox1.Controls.Add(this.lblTarifType5);
            this.groupBox1.Controls.Add(this.lblType5);
            this.groupBox1.Controls.Add(this.nudType4);
            this.groupBox1.Controls.Add(this.nudType8);
            this.groupBox1.Controls.Add(this.nudType3);
            this.groupBox1.Controls.Add(this.nudType2);
            this.groupBox1.Controls.Add(this.nudType7);
            this.groupBox1.Controls.Add(this.nudType1);
            this.groupBox1.Controls.Add(this.lblTarifType1);
            this.groupBox1.Controls.Add(this.nudType6);
            this.groupBox1.Controls.Add(this.lblTarifType2);
            this.groupBox1.Controls.Add(this.lblTarifType3);
            this.groupBox1.Controls.Add(this.nudType5);
            this.groupBox1.Controls.Add(this.lblType4);
            this.groupBox1.Controls.Add(this.lblTarifType4);
            this.groupBox1.Controls.Add(this.lblType3);
            this.groupBox1.Controls.Add(this.lblType2);
            this.groupBox1.Controls.Add(this.lblType1);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 238);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarifs";
            // 
            // lblTarifType8
            // 
            this.lblTarifType8.AutoSize = true;
            this.lblTarifType8.Location = new System.Drawing.Point(149, 204);
            this.lblTarifType8.Name = "lblTarifType8";
            this.lblTarifType8.Size = new System.Drawing.Size(28, 13);
            this.lblTarifType8.TabIndex = 36;
            this.lblTarifType8.Text = "Tarif";
            // 
            // lblType8
            // 
            this.lblType8.AutoSize = true;
            this.lblType8.Location = new System.Drawing.Point(6, 204);
            this.lblType8.Name = "lblType8";
            this.lblType8.Size = new System.Drawing.Size(42, 13);
            this.lblType8.TabIndex = 35;
            this.lblType8.Text = "Camion";
            // 
            // lblTarifType7
            // 
            this.lblTarifType7.AutoSize = true;
            this.lblTarifType7.Location = new System.Drawing.Point(149, 178);
            this.lblTarifType7.Name = "lblTarifType7";
            this.lblTarifType7.Size = new System.Drawing.Size(28, 13);
            this.lblTarifType7.TabIndex = 34;
            this.lblTarifType7.Text = "Tarif";
            // 
            // lblType7
            // 
            this.lblType7.AutoSize = true;
            this.lblType7.Location = new System.Drawing.Point(6, 178);
            this.lblType7.Name = "lblType7";
            this.lblType7.Size = new System.Drawing.Size(67, 13);
            this.lblType7.TabIndex = 33;
            this.lblType7.Text = "Camping Car";
            // 
            // lblType6
            // 
            this.lblType6.AutoSize = true;
            this.lblType6.Location = new System.Drawing.Point(6, 152);
            this.lblType6.Name = "lblType6";
            this.lblType6.Size = new System.Drawing.Size(46, 13);
            this.lblType6.TabIndex = 32;
            this.lblType6.Text = "Fourgon";
            // 
            // lblTarifType6
            // 
            this.lblTarifType6.AutoSize = true;
            this.lblTarifType6.Location = new System.Drawing.Point(149, 152);
            this.lblTarifType6.Name = "lblTarifType6";
            this.lblTarifType6.Size = new System.Drawing.Size(28, 13);
            this.lblTarifType6.TabIndex = 31;
            this.lblTarifType6.Text = "Tarif";
            // 
            // lblTarifType5
            // 
            this.lblTarifType5.AutoSize = true;
            this.lblTarifType5.Location = new System.Drawing.Point(149, 126);
            this.lblTarifType5.Name = "lblTarifType5";
            this.lblTarifType5.Size = new System.Drawing.Size(28, 13);
            this.lblTarifType5.TabIndex = 30;
            this.lblTarifType5.Text = "Tarif";
            // 
            // lblType5
            // 
            this.lblType5.AutoSize = true;
            this.lblType5.Location = new System.Drawing.Point(6, 126);
            this.lblType5.Name = "lblType5";
            this.lblType5.Size = new System.Drawing.Size(103, 13);
            this.lblType5.TabIndex = 29;
            this.lblType5.Text = "Voiture long.ing.5m :";
            // 
            // nudType4
            // 
            this.nudType4.Location = new System.Drawing.Point(221, 98);
            this.nudType4.Name = "nudType4";
            this.nudType4.Size = new System.Drawing.Size(41, 20);
            this.nudType4.TabIndex = 4;
            this.nudType4.ValueChanged += new System.EventHandler(this.nudType4_ValueChanged);
            // 
            // nudType8
            // 
            this.nudType8.Location = new System.Drawing.Point(221, 202);
            this.nudType8.Name = "nudType8";
            this.nudType8.Size = new System.Drawing.Size(41, 20);
            this.nudType8.TabIndex = 8;
            this.nudType8.ValueChanged += new System.EventHandler(this.nudType8_ValueChanged);
            // 
            // nudType3
            // 
            this.nudType3.Location = new System.Drawing.Point(221, 72);
            this.nudType3.Name = "nudType3";
            this.nudType3.Size = new System.Drawing.Size(41, 20);
            this.nudType3.TabIndex = 3;
            this.nudType3.ValueChanged += new System.EventHandler(this.nudType3_ValueChanged);
            // 
            // nudType2
            // 
            this.nudType2.Location = new System.Drawing.Point(221, 46);
            this.nudType2.Name = "nudType2";
            this.nudType2.Size = new System.Drawing.Size(41, 20);
            this.nudType2.TabIndex = 2;
            this.nudType2.ValueChanged += new System.EventHandler(this.nudType2_ValueChanged);
            // 
            // nudType7
            // 
            this.nudType7.Location = new System.Drawing.Point(221, 176);
            this.nudType7.Name = "nudType7";
            this.nudType7.Size = new System.Drawing.Size(41, 20);
            this.nudType7.TabIndex = 7;
            this.nudType7.ValueChanged += new System.EventHandler(this.nudType7_ValueChanged);
            // 
            // nudType1
            // 
            this.nudType1.Location = new System.Drawing.Point(221, 20);
            this.nudType1.Name = "nudType1";
            this.nudType1.Size = new System.Drawing.Size(41, 20);
            this.nudType1.TabIndex = 1;
            this.nudType1.ValueChanged += new System.EventHandler(this.nudType1_ValueChanged);
            // 
            // lblTarifType1
            // 
            this.lblTarifType1.AutoSize = true;
            this.lblTarifType1.Location = new System.Drawing.Point(149, 22);
            this.lblTarifType1.Name = "lblTarifType1";
            this.lblTarifType1.Size = new System.Drawing.Size(28, 13);
            this.lblTarifType1.TabIndex = 18;
            this.lblTarifType1.Text = "Tarif";
            // 
            // nudType6
            // 
            this.nudType6.Location = new System.Drawing.Point(221, 150);
            this.nudType6.Name = "nudType6";
            this.nudType6.Size = new System.Drawing.Size(41, 20);
            this.nudType6.TabIndex = 6;
            this.nudType6.ValueChanged += new System.EventHandler(this.nudType6_ValueChanged);
            // 
            // lblTarifType2
            // 
            this.lblTarifType2.AutoSize = true;
            this.lblTarifType2.Location = new System.Drawing.Point(149, 48);
            this.lblTarifType2.Name = "lblTarifType2";
            this.lblTarifType2.Size = new System.Drawing.Size(28, 13);
            this.lblTarifType2.TabIndex = 17;
            this.lblTarifType2.Text = "Tarif";
            // 
            // lblTarifType3
            // 
            this.lblTarifType3.AutoSize = true;
            this.lblTarifType3.Location = new System.Drawing.Point(149, 74);
            this.lblTarifType3.Name = "lblTarifType3";
            this.lblTarifType3.Size = new System.Drawing.Size(28, 13);
            this.lblTarifType3.TabIndex = 16;
            this.lblTarifType3.Text = "Tarif";
            // 
            // nudType5
            // 
            this.nudType5.Location = new System.Drawing.Point(221, 124);
            this.nudType5.Name = "nudType5";
            this.nudType5.Size = new System.Drawing.Size(41, 20);
            this.nudType5.TabIndex = 5;
            this.nudType5.ValueChanged += new System.EventHandler(this.nudType5_ValueChanged);
            // 
            // lblType4
            // 
            this.lblType4.AutoSize = true;
            this.lblType4.Location = new System.Drawing.Point(6, 100);
            this.lblType4.Name = "lblType4";
            this.lblType4.Size = new System.Drawing.Size(103, 13);
            this.lblType4.TabIndex = 15;
            this.lblType4.Text = "Voiture long.ing.4m :";
            // 
            // lblTarifType4
            // 
            this.lblTarifType4.AutoSize = true;
            this.lblTarifType4.Location = new System.Drawing.Point(149, 100);
            this.lblTarifType4.Name = "lblTarifType4";
            this.lblTarifType4.Size = new System.Drawing.Size(28, 13);
            this.lblTarifType4.TabIndex = 14;
            this.lblTarifType4.Text = "Tarif";
            // 
            // lblType3
            // 
            this.lblType3.AutoSize = true;
            this.lblType3.Location = new System.Drawing.Point(6, 74);
            this.lblType3.Name = "lblType3";
            this.lblType3.Size = new System.Drawing.Size(91, 13);
            this.lblType3.TabIndex = 13;
            this.lblType3.Text = "Enfant 0 à 7 ans :";
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(6, 48);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(94, 13);
            this.lblType2.TabIndex = 12;
            this.lblType2.Text = "Junior 8 à 18 ans :";
            // 
            // btnReserver
            // 
            this.btnReserver.Location = new System.Drawing.Point(360, 276);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(132, 23);
            this.btnReserver.TabIndex = 13;
            this.btnReserver.Text = "Enregistrer la réservation";
            this.btnReserver.UseVisualStyleBackColor = true;
            this.btnReserver.Visible = false;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // lblDevise1
            // 
            this.lblDevise1.AutoSize = true;
            this.lblDevise1.Location = new System.Drawing.Point(178, 22);
            this.lblDevise1.Name = "lblDevise1";
            this.lblDevise1.Size = new System.Drawing.Size(13, 13);
            this.lblDevise1.TabIndex = 37;
            this.lblDevise1.Text = "€";
            // 
            // lblDevise3
            // 
            this.lblDevise3.AutoSize = true;
            this.lblDevise3.Location = new System.Drawing.Point(178, 74);
            this.lblDevise3.Name = "lblDevise3";
            this.lblDevise3.Size = new System.Drawing.Size(13, 13);
            this.lblDevise3.TabIndex = 38;
            this.lblDevise3.Text = "€";
            // 
            // lblDevise4
            // 
            this.lblDevise4.AutoSize = true;
            this.lblDevise4.Location = new System.Drawing.Point(178, 100);
            this.lblDevise4.Name = "lblDevise4";
            this.lblDevise4.Size = new System.Drawing.Size(13, 13);
            this.lblDevise4.TabIndex = 39;
            this.lblDevise4.Text = "€";
            // 
            // lblDevise2
            // 
            this.lblDevise2.AutoSize = true;
            this.lblDevise2.Location = new System.Drawing.Point(178, 48);
            this.lblDevise2.Name = "lblDevise2";
            this.lblDevise2.Size = new System.Drawing.Size(13, 13);
            this.lblDevise2.TabIndex = 40;
            this.lblDevise2.Text = "€";
            // 
            // lblDevise5
            // 
            this.lblDevise5.AutoSize = true;
            this.lblDevise5.Location = new System.Drawing.Point(178, 126);
            this.lblDevise5.Name = "lblDevise5";
            this.lblDevise5.Size = new System.Drawing.Size(13, 13);
            this.lblDevise5.TabIndex = 41;
            this.lblDevise5.Text = "€";
            // 
            // lblDevise6
            // 
            this.lblDevise6.AutoSize = true;
            this.lblDevise6.Location = new System.Drawing.Point(178, 152);
            this.lblDevise6.Name = "lblDevise6";
            this.lblDevise6.Size = new System.Drawing.Size(13, 13);
            this.lblDevise6.TabIndex = 42;
            this.lblDevise6.Text = "€";
            // 
            // lblDevise8
            // 
            this.lblDevise8.AutoSize = true;
            this.lblDevise8.Location = new System.Drawing.Point(178, 204);
            this.lblDevise8.Name = "lblDevise8";
            this.lblDevise8.Size = new System.Drawing.Size(13, 13);
            this.lblDevise8.TabIndex = 43;
            this.lblDevise8.Text = "€";
            // 
            // lblDevise7
            // 
            this.lblDevise7.AutoSize = true;
            this.lblDevise7.Location = new System.Drawing.Point(178, 178);
            this.lblDevise7.Name = "lblDevise7";
            this.lblDevise7.Size = new System.Drawing.Size(13, 13);
            this.lblDevise7.TabIndex = 44;
            this.lblDevise7.Text = "€";
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 312);
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxCoordonnees);
            this.Controls.Add(this.lblTexteSaisir);
            this.Controls.Add(this.lblNumeroDateHeure);
            this.Controls.Add(this.lblLiaison);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReservation";
            this.Text = "Réservation";
            this.gbxCoordonnees.ResumeLayout(false);
            this.gbxCoordonnees.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudType4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudType5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblNumeroDateHeure;
        private System.Windows.Forms.Label lblTexteSaisir;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox gbxCoordonnees;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.TextBox tbxCodePostal;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTarifType1;
        private System.Windows.Forms.Label lblTarifType2;
        private System.Windows.Forms.Label lblTarifType3;
        private System.Windows.Forms.Label lblType4;
        private System.Windows.Forms.Label lblTarifType4;
        private System.Windows.Forms.Label lblType3;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Label lblTarifType8;
        private System.Windows.Forms.Label lblType8;
        private System.Windows.Forms.Label lblTarifType7;
        private System.Windows.Forms.Label lblType7;
        private System.Windows.Forms.Label lblType6;
        private System.Windows.Forms.Label lblTarifType6;
        private System.Windows.Forms.Label lblTarifType5;
        private System.Windows.Forms.Label lblType5;
        private System.Windows.Forms.NumericUpDown nudType4;
        private System.Windows.Forms.NumericUpDown nudType8;
        private System.Windows.Forms.NumericUpDown nudType3;
        private System.Windows.Forms.NumericUpDown nudType2;
        private System.Windows.Forms.NumericUpDown nudType7;
        private System.Windows.Forms.NumericUpDown nudType1;
        private System.Windows.Forms.NumericUpDown nudType6;
        private System.Windows.Forms.NumericUpDown nudType5;
        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.Label lblDevise7;
        private System.Windows.Forms.Label lblDevise8;
        private System.Windows.Forms.Label lblDevise6;
        private System.Windows.Forms.Label lblDevise5;
        private System.Windows.Forms.Label lblDevise2;
        private System.Windows.Forms.Label lblDevise4;
        private System.Windows.Forms.Label lblDevise3;
        private System.Windows.Forms.Label lblDevise1;
    }
}