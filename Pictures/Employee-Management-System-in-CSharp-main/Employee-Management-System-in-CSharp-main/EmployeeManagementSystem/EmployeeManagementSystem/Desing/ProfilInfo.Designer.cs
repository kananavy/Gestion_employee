namespace EmployeeManagementSystem.Desing
{
    partial class ProfilInfo
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilInfo));
            this.label28 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblDateRecrute = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomDep = new System.Windows.Forms.Label();
            this.panel_info1 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCIN = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.lblDiploma = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diplome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbEmployeeImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_info1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(396, 210);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(151, 16);
            this.label28.TabIndex = 62;
            this.label28.Text = "Date de recrutement:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblGrade.Location = new System.Drawing.Point(577, 181);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(41, 15);
            this.lblGrade.TabIndex = 60;
            this.lblGrade.Text = "Grade";
            // 
            // lblDateRecrute
            // 
            this.lblDateRecrute.AutoSize = true;
            this.lblDateRecrute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDateRecrute.Location = new System.Drawing.Point(577, 210);
            this.lblDateRecrute.Name = "lblDateRecrute";
            this.lblDateRecrute.Size = new System.Drawing.Size(33, 15);
            this.lblDateRecrute.TabIndex = 61;
            this.lblDateRecrute.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.NomDep);
            this.panel1.Controls.Add(this.panel_info1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbEmployeeImage);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 323);
            this.panel1.TabIndex = 1;
            // 
            // NomDep
            // 
            this.NomDep.AutoSize = true;
            this.NomDep.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.NomDep.Location = new System.Drawing.Point(577, 19);
            this.NomDep.Name = "NomDep";
            this.NomDep.Size = new System.Drawing.Size(183, 24);
            this.NomDep.TabIndex = 46;
            this.NomDep.Text = "DEPARTEMENT";
            // 
            // panel_info1
            // 
            this.panel_info1.Controls.Add(this.label28);
            this.panel_info1.Controls.Add(this.lblDateRecrute);
            this.panel_info1.Controls.Add(this.lblGrade);
            this.panel_info1.Controls.Add(this.lblPosition);
            this.panel_info1.Controls.Add(this.lblBirthPlace);
            this.panel_info1.Controls.Add(this.lblBirthDay);
            this.panel_info1.Controls.Add(this.label11);
            this.panel_info1.Controls.Add(this.lblCIN);
            this.panel_info1.Controls.Add(this.lblContactNumber);
            this.panel_info1.Controls.Add(this.lblDepartement);
            this.panel_info1.Controls.Add(this.lblDiploma);
            this.panel_info1.Controls.Add(this.lblNationality);
            this.panel_info1.Controls.Add(this.lblAdresse);
            this.panel_info1.Controls.Add(this.lblGender);
            this.panel_info1.Controls.Add(this.lblFullName);
            this.panel_info1.Controls.Add(this.lblEmployeeID);
            this.panel_info1.Controls.Add(this.label12);
            this.panel_info1.Controls.Add(this.label9);
            this.panel_info1.Controls.Add(this.label8);
            this.panel_info1.Controls.Add(this.label6);
            this.panel_info1.Controls.Add(this.label5);
            this.panel_info1.Controls.Add(this.label14);
            this.panel_info1.Controls.Add(this.label4);
            this.panel_info1.Controls.Add(this.label3);
            this.panel_info1.Controls.Add(this.diplome);
            this.panel_info1.Controls.Add(this.label2);
            this.panel_info1.Controls.Add(this.label7);
            this.panel_info1.Controls.Add(this.label18);
            this.panel_info1.Controls.Add(this.panel5);
            this.panel_info1.Controls.Add(this.panel4);
            this.panel_info1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_info1.Location = new System.Drawing.Point(0, 80);
            this.panel_info1.Name = "panel_info1";
            this.panel_info1.Size = new System.Drawing.Size(842, 243);
            this.panel_info1.TabIndex = 44;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPosition.Location = new System.Drawing.Point(577, 8);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(38, 15);
            this.lblPosition.TabIndex = 59;
            this.lblPosition.Text = "Poste";
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBirthPlace.Location = new System.Drawing.Point(577, 144);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(31, 15);
            this.lblBirthPlace.TabIndex = 58;
            this.lblBirthPlace.Text = "Lieu";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBirthDay.Location = new System.Drawing.Point(577, 111);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(33, 15);
            this.lblBirthDay.TabIndex = 57;
            this.lblBirthDay.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(396, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Poste:";
            // 
            // lblCIN
            // 
            this.lblCIN.AutoSize = true;
            this.lblCIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCIN.Location = new System.Drawing.Point(577, 80);
            this.lblCIN.Name = "lblCIN";
            this.lblCIN.Size = new System.Drawing.Size(27, 15);
            this.lblCIN.TabIndex = 56;
            this.lblCIN.Text = "CIN";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblContactNumber.Location = new System.Drawing.Point(577, 44);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(29, 15);
            this.lblContactNumber.TabIndex = 55;
            this.lblContactNumber.Text = "TEL";
            // 
            // lblDepartement
            // 
            this.lblDepartement.AutoSize = true;
            this.lblDepartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDepartement.Location = new System.Drawing.Point(167, 211);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(79, 15);
            this.lblDepartement.TabIndex = 54;
            this.lblDepartement.Text = "Departement";
            // 
            // lblDiploma
            // 
            this.lblDiploma.AutoSize = true;
            this.lblDiploma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDiploma.Location = new System.Drawing.Point(167, 181);
            this.lblDiploma.Name = "lblDiploma";
            this.lblDiploma.Size = new System.Drawing.Size(54, 15);
            this.lblDiploma.TabIndex = 53;
            this.lblDiploma.Text = "Diplome";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNationality.Location = new System.Drawing.Point(167, 144);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(66, 15);
            this.lblNationality.TabIndex = 52;
            this.lblNationality.Text = "Nationalité";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAdresse.Location = new System.Drawing.Point(167, 111);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 15);
            this.lblAdresse.TabIndex = 51;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblGender.Location = new System.Drawing.Point(167, 81);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 15);
            this.lblGender.TabIndex = 50;
            this.lblGender.Text = "Genre";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFullName.Location = new System.Drawing.Point(167, 44);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(34, 15);
            this.lblFullName.TabIndex = 49;
            this.lblFullName.Text = "Nom";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEmployeeID.Location = new System.Drawing.Point(167, 7);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(19, 15);
            this.lblEmployeeID.TabIndex = 48;
            this.lblEmployeeID.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(396, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Grade :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Adresse:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(396, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Lieu de Naissance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(396, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "CIN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(394, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Téléphone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(14, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Departement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom Complet:";
            // 
            // diplome
            // 
            this.diplome.AutoSize = true;
            this.diplome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.diplome.Location = new System.Drawing.Point(14, 180);
            this.diplome.Name = "diplome";
            this.diplome.Size = new System.Drawing.Size(65, 16);
            this.diplome.TabIndex = 9;
            this.diplome.Text = "Diplôme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(396, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Date de Naissance:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(14, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Nationalité:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(728, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(93, 63);
            this.panel5.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.panel4.Location = new System.Drawing.Point(728, 162);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel4.Size = new System.Drawing.Size(111, 80);
            this.panel4.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 71);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(20, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 80);
            this.panel3.TabIndex = 46;
            // 
            // pbEmployeeImage
            // 
            this.pbEmployeeImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbEmployeeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEmployeeImage.BackgroundImage")));
            this.pbEmployeeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmployeeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEmployeeImage.Location = new System.Drawing.Point(117, 4);
            this.pbEmployeeImage.Name = "pbEmployeeImage";
            this.pbEmployeeImage.Size = new System.Drawing.Size(69, 70);
            this.pbEmployeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployeeImage.TabIndex = 15;
            this.pbEmployeeImage.TabStop = false;
            // 
            // ProfilInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ProfilInfo";
            this.Size = new System.Drawing.Size(842, 322);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_info1.ResumeLayout(false);
            this.panel_info1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblDateRecrute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NomDep;
        private System.Windows.Forms.PictureBox pbEmployeeImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_info1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCIN;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.Label lblDiploma;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label diplome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}
