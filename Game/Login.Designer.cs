namespace Game
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserID = new TextBox();
            lbID = new Label();
            lbPW = new Label();
            txtPwd = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(102, 35);
            txtUserID.Margin = new Padding(2, 1, 2, 1);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(137, 23);
            txtUserID.TabIndex = 0;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(49, 38);
            lbID.Margin = new Padding(2, 0, 2, 0);
            lbID.Name = "lbID";
            lbID.Size = new Size(50, 15);
            lbID.TabIndex = 1;
            lbID.Text = "아이디 :";
            // 
            // lbPW
            // 
            lbPW.AutoSize = true;
            lbPW.Location = new Point(37, 59);
            lbPW.Margin = new Padding(2, 0, 2, 0);
            lbPW.Name = "lbPW";
            lbPW.Size = new Size(62, 15);
            lbPW.TabIndex = 3;
            lbPW.Text = "비밀번호 :";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(102, 56);
            txtPwd.Margin = new Padding(2, 1, 2, 1);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(137, 23);
            txtPwd.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(37, 77);
            btnLogin.Margin = new Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += login;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(39, 119);
            btnSignUp.Margin = new Padding(2, 1, 2, 1);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(200, 40);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "회원가입";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += SignUp;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 177);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(lbPW);
            Controls.Add(txtPwd);
            Controls.Add(lbID);
            Controls.Add(txtUserID);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login";
            Text = "로그인";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserID;
        private Label lbID;
        private Label lbPW;
        private TextBox txtPwd;
        private Button btnLogin;
        private Button btnSignUp;
    }
}