namespace Login
{
    partial class playerInformation
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
<<<<<<< Updated upstream
            this.SuspendLayout();
            // 
=======
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbinputName = new System.Windows.Forms.Label();
            this.txtinputName = new System.Windows.Forms.TextBox();
            this.txtWickets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayingRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtBowlingStyle = new System.Windows.Forms.TextBox();
            this.txtBattingStyle = new System.Windows.Forms.TextBox();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbReTypePassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbuserName = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(69, 432);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(245, 47);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search Player";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbinputName
            // 
            this.lbinputName.AutoSize = true;
            this.lbinputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinputName.Location = new System.Drawing.Point(419, 446);
            this.lbinputName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbinputName.Name = "lbinputName";
            this.lbinputName.Size = new System.Drawing.Size(94, 20);
            this.lbinputName.TabIndex = 2;
            this.lbinputName.Text = "Enter Name";
            // 
            // txtinputName
            // 
            this.txtinputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtinputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinputName.Location = new System.Drawing.Point(564, 446);
            this.txtinputName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtinputName.Name = "txtinputName";
            this.txtinputName.Size = new System.Drawing.Size(246, 26);
            this.txtinputName.TabIndex = 3;
            // 
            // txtWickets
            // 
            this.txtWickets.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtWickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWickets.Location = new System.Drawing.Point(564, 361);
            this.txtWickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWickets.Name = "txtWickets";
            this.txtWickets.Size = new System.Drawing.Size(245, 19);
            this.txtWickets.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Wickets";
            // 
            // txtRuns
            // 
            this.txtRuns.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRuns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuns.Location = new System.Drawing.Point(564, 312);
            this.txtRuns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRuns.Name = "txtRuns";
            this.txtRuns.Size = new System.Drawing.Size(245, 19);
            this.txtRuns.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Runs";
            // 
            // txtPlayingRole
            // 
            this.txtPlayingRole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPlayingRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayingRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayingRole.Location = new System.Drawing.Point(564, 223);
            this.txtPlayingRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayingRole.Name = "txtPlayingRole";
            this.txtPlayingRole.Size = new System.Drawing.Size(245, 19);
            this.txtPlayingRole.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Playing Role";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(564, 266);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(245, 19);
            this.txtGender.TabIndex = 28;
            // 
            // txtBowlingStyle
            // 
            this.txtBowlingStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBowlingStyle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBowlingStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBowlingStyle.Location = new System.Drawing.Point(564, 179);
            this.txtBowlingStyle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBowlingStyle.Name = "txtBowlingStyle";
            this.txtBowlingStyle.Size = new System.Drawing.Size(245, 19);
            this.txtBowlingStyle.TabIndex = 27;
            // 
            // txtBattingStyle
            // 
            this.txtBattingStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBattingStyle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBattingStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBattingStyle.Location = new System.Drawing.Point(564, 134);
            this.txtBattingStyle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBattingStyle.Name = "txtBattingStyle";
            this.txtBattingStyle.Size = new System.Drawing.Size(245, 19);
            this.txtBattingStyle.TabIndex = 26;
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDay.Location = new System.Drawing.Point(564, 97);
            this.txtBirthDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(245, 19);
            this.txtBirthDay.TabIndex = 25;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(564, 55);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(245, 19);
            this.txtFullName.TabIndex = 24;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(419, 266);
            this.lbGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(63, 20);
            this.lbGender.TabIndex = 23;
            this.lbGender.Text = "Gender";
            // 
            // lbReTypePassword
            // 
            this.lbReTypePassword.AutoSize = true;
            this.lbReTypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReTypePassword.Location = new System.Drawing.Point(419, 179);
            this.lbReTypePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReTypePassword.Name = "lbReTypePassword";
            this.lbReTypePassword.Size = new System.Drawing.Size(103, 20);
            this.lbReTypePassword.TabIndex = 22;
            this.lbReTypePassword.Text = "Bowling Style";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(419, 138);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(99, 20);
            this.lbPassword.TabIndex = 21;
            this.lbPassword.Text = "Batting Style";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(419, 99);
            this.lbemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(74, 20);
            this.lbemail.TabIndex = 20;
            this.lbemail.Text = "Birth Day";
            // 
            // lbuserName
            // 
            this.lbuserName.AutoSize = true;
            this.lbuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuserName.Location = new System.Drawing.Point(419, 59);
            this.lbuserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbuserName.Name = "lbuserName";
            this.lbuserName.Size = new System.Drawing.Size(80, 20);
            this.lbuserName.TabIndex = 19;
            this.lbuserName.Text = "Full Name";
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(69, 55);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicture.MinimumSize = new System.Drawing.Size(75, 81);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(284, 326);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 1;
            this.profilePicture.TabStop = false;
            // 
>>>>>>> Stashed changes
            // playerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(1341, 698);
            this.Name = "playerInformation";
            this.Text = "playerInformation";
=======
            this.ClientSize = new System.Drawing.Size(908, 574);
            this.Controls.Add(this.txtWickets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRuns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlayingRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtBowlingStyle);
            this.Controls.Add(this.txtBattingStyle);
            this.Controls.Add(this.txtBirthDay);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbReTypePassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbuserName);
            this.Controls.Add(this.txtinputName);
            this.Controls.Add(this.lbinputName);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "playerInformation";
            this.Text = "playerInformation";
            this.Load += new System.EventHandler(this.playerInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
>>>>>>> Stashed changes
            this.ResumeLayout(false);

        }

        #endregion
    }
}