namespace Login
{
    partial class addAdmin
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSumit = new System.Windows.Forms.Button();
            this.txtReTypePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbReTypePassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbuserName = new System.Windows.Forms.Label();
            this.lbaddPayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(364, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 51);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSumit
            // 
            this.btnSumit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumit.Location = new System.Drawing.Point(103, 471);
            this.btnSumit.Name = "btnSumit";
            this.btnSumit.Size = new System.Drawing.Size(172, 51);
            this.btnSumit.TabIndex = 24;
            this.btnSumit.Text = "Register";
            this.btnSumit.UseVisualStyleBackColor = true;
            this.btnSumit.Click += new System.EventHandler(this.btnSumit_Click);
            // 
            // txtReTypePassword
            // 
            this.txtReTypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReTypePassword.Location = new System.Drawing.Point(302, 382);
            this.txtReTypePassword.Name = "txtReTypePassword";
            this.txtReTypePassword.Size = new System.Drawing.Size(245, 30);
            this.txtReTypePassword.TabIndex = 22;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(302, 327);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 30);
            this.txtPassword.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(302, 281);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 30);
            this.txtEmail.TabIndex = 20;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(302, 230);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(245, 30);
            this.txtUsername.TabIndex = 19;
            // 
            // lbReTypePassword
            // 
            this.lbReTypePassword.AutoSize = true;
            this.lbReTypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReTypePassword.Location = new System.Drawing.Point(109, 382);
            this.lbReTypePassword.Name = "lbReTypePassword";
            this.lbReTypePassword.Size = new System.Drawing.Size(177, 25);
            this.lbReTypePassword.TabIndex = 17;
            this.lbReTypePassword.Text = "Re Type Password";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(109, 332);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(98, 25);
            this.lbPassword.TabIndex = 16;
            this.lbPassword.Text = "Password";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(109, 284);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(60, 25);
            this.lbemail.TabIndex = 15;
            this.lbemail.Text = "Email";
            // 
            // lbuserName
            // 
            this.lbuserName.AutoSize = true;
            this.lbuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuserName.Location = new System.Drawing.Point(109, 235);
            this.lbuserName.Name = "lbuserName";
            this.lbuserName.Size = new System.Drawing.Size(115, 25);
            this.lbuserName.TabIndex = 14;
            this.lbuserName.Text = "User Name ";
            // 
            // lbaddPayer
            // 
            this.lbaddPayer.AutoSize = true;
            this.lbaddPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddPayer.Location = new System.Drawing.Point(189, 80);
            this.lbaddPayer.Name = "lbaddPayer";
            this.lbaddPayer.Size = new System.Drawing.Size(317, 51);
            this.lbaddPayer.TabIndex = 13;
            this.lbaddPayer.Text = "Register Admin";
            // 
            // addAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 703);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSumit);
            this.Controls.Add(this.txtReTypePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbReTypePassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbuserName);
            this.Controls.Add(this.lbaddPayer);
            this.Name = "addAdmin";
            this.Text = "addAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSumit;
        private System.Windows.Forms.TextBox txtReTypePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbReTypePassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbuserName;
        private System.Windows.Forms.Label lbaddPayer;
    }
}