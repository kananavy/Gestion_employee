
namespace EmployeeManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.login_signupBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelHeure = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.login_signupBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.panel12.Location = new System.Drawing.Point(0, 56);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(3, 256);
            this.panel12.TabIndex = 10;
            // 
            // login_signupBtn
            // 
            this.login_signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.login_signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_signupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.login_signupBtn.FlatAppearance.BorderSize = 2;
            this.login_signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.login_signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signupBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signupBtn.ForeColor = System.Drawing.Color.Gold;
            this.login_signupBtn.Location = new System.Drawing.Point(22, 356);
            this.login_signupBtn.Name = "login_signupBtn";
            this.login_signupBtn.Size = new System.Drawing.Size(226, 31);
            this.login_signupBtn.TabIndex = 5;
            this.login_signupBtn.Text = "INSCRIPTION";
            this.login_signupBtn.UseVisualStyleBackColor = false;
            this.login_signupBtn.Click += new System.EventHandler(this.login_signupBtn_Click);
            this.login_signupBtn.MouseEnter += new System.EventHandler(this.login_signupBtn_MouseEnter);
            this.login_signupBtn.MouseLeave += new System.EventHandler(this.login_signupBtn_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(72, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pour créer un compte";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(854, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(575, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ajouter un compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(443, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom d\'Utilisateur:";
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.White;
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.ForeColor = System.Drawing.SystemColors.MenuText;
            this.login_username.Location = new System.Drawing.Point(21, 3);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_username.Size = new System.Drawing.Size(269, 22);
            this.login_username.TabIndex = 1;
            this.login_username.TextAlignChanged += new System.EventHandler(this.login_username_TextAlignChanged);
            this.login_username.AcceptsTabChanged += new System.EventHandler(this.login_username_AcceptsTabChanged);
            this.login_username.BorderStyleChanged += new System.EventHandler(this.login_username_BorderStyleChanged);
            this.login_username.Click += new System.EventHandler(this.login_username_Click);
            this.login_username.CursorChanged += new System.EventHandler(this.login_username_CursorChanged);
            this.login_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            this.login_username.MouseEnter += new System.EventHandler(this.login_username_MouseEnter);
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.White;
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColor = System.Drawing.SystemColors.MenuText;
            this.login_password.Location = new System.Drawing.Point(21, 3);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(269, 22);
            this.login_password.TabIndex = 2;
            this.login_password.Click += new System.EventHandler(this.login_password_Click);
            this.login_password.CursorChanged += new System.EventHandler(this.login_username_CursorChanged);
            this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            this.login_password.MouseEnter += new System.EventHandler(this.login_username_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(443, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mots de Passe";
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.BackColor = System.Drawing.Color.White;
            this.login_showPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPass.ForeColor = System.Drawing.Color.Black;
            this.login_showPass.Location = new System.Drawing.Point(699, 294);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(152, 18);
            this.login_showPass.TabIndex = 3;
            this.login_showPass.Text = "Marquer Mots de Passe";
            this.login_showPass.UseVisualStyleBackColor = false;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.White;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.login_btn.FlatAppearance.BorderSize = 2;
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Red;
            this.login_btn.Location = new System.Drawing.Point(592, 322);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(161, 32);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "CONNEXION";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.MouseEnter += new System.EventHandler(this.login_btn_MouseEnter);
            this.login_btn.MouseLeave += new System.EventHandler(this.login_btn_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::EmployeeManagementSystem.Properties.Resources.mot_de_passe;
            this.pictureBox2.Location = new System.Drawing.Point(286, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.login_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 35);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(21, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 1);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(547, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 70);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 32);
            this.panel5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Verifier votre champ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(547, 235);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 53);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(304, 18);
            this.panel7.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(42, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Verifier votre champ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.login_password);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(304, 35);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(21, 24);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 1);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(883, 21);
            this.panel10.TabIndex = 35;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.panel11.Location = new System.Drawing.Point(277, 56);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(3, 256);
            this.panel11.TabIndex = 9;
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.labelHeure.Location = new System.Drawing.Point(286, 316);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(192, 52);
            this.labelHeure.TabIndex = 37;
            this.labelHeure.Text = "12:43:27";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.date1.Location = new System.Drawing.Point(284, 368);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(194, 23);
            this.date1.TabIndex = 38;
            this.date1.Text = "Vendredi 30 Aout 2024";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 400);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.labelHeure);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_signupBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Label date1;
    }
}

