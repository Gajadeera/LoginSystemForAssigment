namespace Login
{
    partial class addPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPlayer));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lbaddPayer = new System.Windows.Forms.Label();
            this.lbuserName = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbReTypePassword = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.txtBattingStyle = new System.Windows.Forms.TextBox();
            this.txtBowlingStyle = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.btnSumit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPlayingRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRuns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textWickets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPicture = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.btnImageLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lbaddPayer
            // 
            this.lbaddPayer.AutoSize = true;
            this.lbaddPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddPayer.Location = new System.Drawing.Point(252, 41);
            this.lbaddPayer.Name = "lbaddPayer";
            this.lbaddPayer.Size = new System.Drawing.Size(233, 51);
            this.lbaddPayer.TabIndex = 0;
            this.lbaddPayer.Text = "Add Player";
            // 
            // lbuserName
            // 
            this.lbuserName.AutoSize = true;
            this.lbuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuserName.Location = new System.Drawing.Point(109, 146);
            this.lbuserName.Name = "lbuserName";
            this.lbuserName.Size = new System.Drawing.Size(100, 25);
            this.lbuserName.TabIndex = 1;
            this.lbuserName.Text = "Full Name";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(109, 195);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(91, 25);
            this.lbemail.TabIndex = 2;
            this.lbemail.Text = "Birth Day";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(109, 243);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(121, 25);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Batting Style";
            // 
            // lbReTypePassword
            // 
            this.lbReTypePassword.AutoSize = true;
            this.lbReTypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReTypePassword.Location = new System.Drawing.Point(109, 293);
            this.lbReTypePassword.Name = "lbReTypePassword";
            this.lbReTypePassword.Size = new System.Drawing.Size(129, 25);
            this.lbReTypePassword.TabIndex = 4;
            this.lbReTypePassword.Text = "Bowling Style";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(109, 400);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(77, 25);
            this.lbGender.TabIndex = 5;
            this.lbGender.Text = "Gender";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(302, 141);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(327, 30);
            this.txtFullName.TabIndex = 6;
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDay.Location = new System.Drawing.Point(302, 192);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(327, 30);
            this.txtBirthDay.TabIndex = 7;
            // 
            // txtBattingStyle
            // 
            this.txtBattingStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBattingStyle.Location = new System.Drawing.Point(302, 238);
            this.txtBattingStyle.Name = "txtBattingStyle";
            this.txtBattingStyle.Size = new System.Drawing.Size(327, 30);
            this.txtBattingStyle.TabIndex = 8;
            // 
            // txtBowlingStyle
            // 
            this.txtBowlingStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBowlingStyle.Location = new System.Drawing.Point(302, 293);
            this.txtBowlingStyle.Name = "txtBowlingStyle";
            this.txtBowlingStyle.Size = new System.Drawing.Size(327, 30);
            this.txtBowlingStyle.TabIndex = 9;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(302, 400);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(327, 30);
            this.txtGender.TabIndex = 10;
            // 
            // btnSumit
            // 
            this.btnSumit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumit.Location = new System.Drawing.Point(114, 696);
            this.btnSumit.Name = "btnSumit";
            this.btnSumit.Size = new System.Drawing.Size(248, 51);
            this.btnSumit.TabIndex = 11;
            this.btnSumit.Text = "Submit";
            this.btnSumit.UseVisualStyleBackColor = true;
            this.btnSumit.Click += new System.EventHandler(this.btnSumit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(405, 696);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(224, 51);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPlayingRole
            // 
            this.txtPlayingRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayingRole.Location = new System.Drawing.Point(302, 347);
            this.txtPlayingRole.Name = "txtPlayingRole";
            this.txtPlayingRole.Size = new System.Drawing.Size(327, 30);
            this.txtPlayingRole.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Playing Role";
            // 
            // textRuns
            // 
            this.textRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRuns.Location = new System.Drawing.Point(302, 457);
            this.textRuns.Name = "textRuns";
            this.textRuns.Size = new System.Drawing.Size(327, 30);
            this.textRuns.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Runs";
            // 
            // textWickets
            // 
            this.textWickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWickets.Location = new System.Drawing.Point(302, 517);
            this.textWickets.Name = "textWickets";
            this.textWickets.Size = new System.Drawing.Size(327, 30);
            this.textWickets.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Wickets";
            // 
            // lbPicture
            // 
            this.lbPicture.AutoSize = true;
            this.lbPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPicture.Location = new System.Drawing.Point(109, 586);
            this.lbPicture.Name = "lbPicture";
            this.lbPicture.Size = new System.Drawing.Size(131, 25);
            this.lbPicture.TabIndex = 19;
            this.lbPicture.Text = "Profile Picture";
            // 
            // profilePicture
            // 
            this.profilePicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.ErrorImage")));
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.InitialImage = null;
            this.profilePicture.Location = new System.Drawing.Point(302, 571);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(82, 85);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 20;
            this.profilePicture.TabStop = false;
            // 
            // btnImageLoad
            // 
            this.btnImageLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageLoad.Location = new System.Drawing.Point(390, 571);
            this.btnImageLoad.Name = "btnImageLoad";
            this.btnImageLoad.Size = new System.Drawing.Size(239, 85);
            this.btnImageLoad.TabIndex = 21;
            this.btnImageLoad.Text = "Image";
            this.btnImageLoad.UseVisualStyleBackColor = true;
            this.btnImageLoad.Click += new System.EventHandler(this.btnImageLoad_Click);
            // 
            // addPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 789);
            this.Controls.Add(this.btnImageLoad);
            this.Controls.Add(this.lbPicture);
            this.Controls.Add(this.textWickets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRuns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlayingRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSumit);
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
            this.Controls.Add(this.lbaddPayer);
            this.Controls.Add(this.profilePicture);
            this.Name = "addPlayer";
            this.Text = "Add Player";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lbaddPayer;
        private System.Windows.Forms.Label lbuserName;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbReTypePassword;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtBirthDay;
        private System.Windows.Forms.TextBox txtBattingStyle;
        private System.Windows.Forms.TextBox txtBowlingStyle;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Button btnSumit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPlayingRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRuns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textWickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPicture;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button btnImageLoad;
    }
}