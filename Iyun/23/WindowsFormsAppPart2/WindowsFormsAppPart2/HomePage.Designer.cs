namespace WindowsFormsAppPart2
{
    partial class HomePage
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
            this.showUsernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aboutUserEdit = new System.Windows.Forms.TextBox();
            this.saveUserInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showUsernameLabel
            // 
            this.showUsernameLabel.AutoSize = true;
            this.showUsernameLabel.Location = new System.Drawing.Point(13, 13);
            this.showUsernameLabel.Name = "showUsernameLabel";
            this.showUsernameLabel.Size = new System.Drawing.Size(0, 13);
            this.showUsernameLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // nameEdit
            // 
            this.nameEdit.Location = new System.Drawing.Point(86, 17);
            this.nameEdit.Name = "nameEdit";
            this.nameEdit.Size = new System.Drawing.Size(203, 20);
            this.nameEdit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // surnameEdit
            // 
            this.surnameEdit.Location = new System.Drawing.Point(86, 76);
            this.surnameEdit.Name = "surnameEdit";
            this.surnameEdit.Size = new System.Drawing.Size(203, 20);
            this.surnameEdit.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Istifadəçi adı";
            // 
            // usernameEdit
            // 
            this.usernameEdit.Enabled = false;
            this.usernameEdit.Location = new System.Drawing.Point(505, 17);
            this.usernameEdit.Name = "usernameEdit";
            this.usernameEdit.Size = new System.Drawing.Size(203, 20);
            this.usernameEdit.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifrə";
            // 
            // passwordEdit
            // 
            this.passwordEdit.Location = new System.Drawing.Point(505, 76);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.Size = new System.Drawing.Size(203, 20);
            this.passwordEdit.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Istifadəçi haqqında məlumat";
            // 
            // aboutUserEdit
            // 
            this.aboutUserEdit.Location = new System.Drawing.Point(33, 167);
            this.aboutUserEdit.Multiline = true;
            this.aboutUserEdit.Name = "aboutUserEdit";
            this.aboutUserEdit.Size = new System.Drawing.Size(675, 121);
            this.aboutUserEdit.TabIndex = 4;
            // 
            // saveUserInfoBtn
            // 
            this.saveUserInfoBtn.Location = new System.Drawing.Point(33, 309);
            this.saveUserInfoBtn.Name = "saveUserInfoBtn";
            this.saveUserInfoBtn.Size = new System.Drawing.Size(139, 41);
            this.saveUserInfoBtn.TabIndex = 5;
            this.saveUserInfoBtn.Text = "Yadda Saxla";
            this.saveUserInfoBtn.UseVisualStyleBackColor = true;
            this.saveUserInfoBtn.Click += new System.EventHandler(this.saveUserInfoBtn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 472);
            this.Controls.Add(this.saveUserInfoBtn);
            this.Controls.Add(this.usernameEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aboutUserEdit);
            this.Controls.Add(this.passwordEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showUsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoş gəlmisiniz!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showUsernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aboutUserEdit;
        private System.Windows.Forms.Button saveUserInfoBtn;
    }
}