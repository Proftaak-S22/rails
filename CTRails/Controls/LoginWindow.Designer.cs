namespace CTRails.Controls
{
    partial class LoginWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lPassword = new MaterialSkin.Controls.MaterialLabel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lUsername = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(83, 160);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.loginClick);
            // 
            // tbPassword
            // 
            this.tbPassword.AcceptsReturn = true;
            this.tbPassword.Location = new System.Drawing.Point(29, 134);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.ShortcutsEnabled = false;
            this.tbPassword.Size = new System.Drawing.Size(182, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.WordWrap = false;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Depth = 0;
            this.lPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lPassword.Location = new System.Drawing.Point(25, 111);
            this.lPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(93, 19);
            this.lPassword.TabIndex = 6;
            this.lPassword.Text = "Wachtwoord";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(29, 58);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(182, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.WordWrap = false;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Depth = 0;
            this.lUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.lUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lUsername.Location = new System.Drawing.Point(25, 36);
            this.lUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(118, 19);
            this.lUsername.TabIndex = 1;
            this.lUsername.Text = "Gebruikersnaam";
            // 
            // LoginWindow
            // 
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginWindow";
            this.Size = new System.Drawing.Size(250, 206);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private MaterialSkin.Controls.MaterialLabel lPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private MaterialSkin.Controls.MaterialLabel lUsername;
    }
}
