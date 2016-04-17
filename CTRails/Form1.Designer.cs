namespace CTRails
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
            this.tabTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tpRemise = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLine = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tpSchoonmaak = new System.Windows.Forms.TabPage();
            this.tsTabs = new MaterialSkin.Controls.MaterialTabSelector();
            this.tpReparatie = new System.Windows.Forms.TabPage();
            this.tpTrams = new System.Windows.Forms.TabPage();
            this.tpSporen = new System.Windows.Forms.TabPage();
            this.tpLijnen = new System.Windows.Forms.TabPage();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabTabs.SuspendLayout();
            this.tpRemise.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTabs
            // 
            this.tabTabs.Controls.Add(this.tpRemise);
            this.tabTabs.Controls.Add(this.tpSchoonmaak);
            this.tabTabs.Controls.Add(this.tpReparatie);
            this.tabTabs.Controls.Add(this.tpTrams);
            this.tabTabs.Controls.Add(this.tpSporen);
            this.tabTabs.Controls.Add(this.tpLijnen);
            this.tabTabs.Controls.Add(this.tpLogin);
            this.tabTabs.Depth = 0;
            this.tabTabs.Location = new System.Drawing.Point(0, 63);
            this.tabTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabTabs.Name = "tabTabs";
            this.tabTabs.SelectedIndex = 0;
            this.tabTabs.Size = new System.Drawing.Size(1176, 481);
            this.tabTabs.TabIndex = 0;
            // 
            // tpRemise
            // 
            this.tpRemise.Controls.Add(this.materialRaisedButton2);
            this.tpRemise.Controls.Add(this.btnLine);
            this.tpRemise.Location = new System.Drawing.Point(4, 22);
            this.tpRemise.Name = "tpRemise";
            this.tpRemise.Padding = new System.Windows.Forms.Padding(3);
            this.tpRemise.Size = new System.Drawing.Size(1168, 455);
            this.tpRemise.TabIndex = 0;
            this.tpRemise.Text = "Remise";
            this.tpRemise.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.BackColor = System.Drawing.Color.Transparent;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialRaisedButton2.Location = new System.Drawing.Point(8, 42);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(50, 30);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "2013";
            this.materialRaisedButton2.UseVisualStyleBackColor = false;
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.Depth = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLine.Location = new System.Drawing.Point(8, 6);
            this.btnLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLine.Name = "btnLine";
            this.btnLine.Primary = true;
            this.btnLine.Size = new System.Drawing.Size(50, 30);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "30";
            this.btnLine.UseVisualStyleBackColor = false;
            // 
            // tpSchoonmaak
            // 
            this.tpSchoonmaak.Location = new System.Drawing.Point(4, 22);
            this.tpSchoonmaak.Name = "tpSchoonmaak";
            this.tpSchoonmaak.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchoonmaak.Size = new System.Drawing.Size(1168, 455);
            this.tpSchoonmaak.TabIndex = 1;
            this.tpSchoonmaak.Text = "Schoonmaak";
            this.tpSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // tsTabs
            // 
            this.tsTabs.BaseTabControl = null;
            this.tsTabs.Depth = 0;
            this.tsTabs.ForeColor = System.Drawing.Color.White;
            this.tsTabs.Location = new System.Drawing.Point(0, 550);
            this.tsTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsTabs.Name = "tsTabs";
            this.tsTabs.Size = new System.Drawing.Size(1176, 45);
            this.tsTabs.TabIndex = 1;
            this.tsTabs.Text = "Test";
            // 
            // tpReparatie
            // 
            this.tpReparatie.Location = new System.Drawing.Point(4, 22);
            this.tpReparatie.Name = "tpReparatie";
            this.tpReparatie.Padding = new System.Windows.Forms.Padding(3);
            this.tpReparatie.Size = new System.Drawing.Size(1168, 455);
            this.tpReparatie.TabIndex = 2;
            this.tpReparatie.Text = "Reparatie";
            this.tpReparatie.UseVisualStyleBackColor = true;
            // 
            // tpTrams
            // 
            this.tpTrams.Location = new System.Drawing.Point(4, 22);
            this.tpTrams.Name = "tpTrams";
            this.tpTrams.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrams.Size = new System.Drawing.Size(1168, 455);
            this.tpTrams.TabIndex = 3;
            this.tpTrams.Text = "Trams";
            this.tpTrams.UseVisualStyleBackColor = true;
            // 
            // tpSporen
            // 
            this.tpSporen.Location = new System.Drawing.Point(4, 22);
            this.tpSporen.Name = "tpSporen";
            this.tpSporen.Padding = new System.Windows.Forms.Padding(3);
            this.tpSporen.Size = new System.Drawing.Size(1168, 455);
            this.tpSporen.TabIndex = 4;
            this.tpSporen.Text = "Sporen";
            this.tpSporen.UseVisualStyleBackColor = true;
            // 
            // tpLijnen
            // 
            this.tpLijnen.Location = new System.Drawing.Point(4, 22);
            this.tpLijnen.Name = "tpLijnen";
            this.tpLijnen.Padding = new System.Windows.Forms.Padding(3);
            this.tpLijnen.Size = new System.Drawing.Size(1168, 455);
            this.tpLijnen.TabIndex = 5;
            this.tpLijnen.Text = "Lijnen";
            this.tpLijnen.UseVisualStyleBackColor = true;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.textBox2);
            this.tpLogin.Controls.Add(this.textBox1);
            this.tpLogin.Controls.Add(this.materialLabel2);
            this.tpLogin.Controls.Add(this.materialLabel1);
            this.tpLogin.Controls.Add(this.btnLogin);
            this.tpLogin.Location = new System.Drawing.Point(4, 22);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(1168, 455);
            this.tpLogin.TabIndex = 6;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(565, 288);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(579, 164);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Email";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(556, 240);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Wachtwoord";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(511, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 607);
            this.Controls.Add(this.tsTabs);
            this.Controls.Add(this.tabTabs);
            this.Name = "Form1";
            this.Text = "Welkom <user>";
            this.tabTabs.ResumeLayout(false);
            this.tpRemise.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector tsTabs;
        private System.Windows.Forms.TabPage tpSchoonmaak;
        private System.Windows.Forms.TabPage tpRemise;
        private MaterialSkin.Controls.MaterialTabControl tabTabs;
        private MaterialSkin.Controls.MaterialRaisedButton btnLine;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.TabPage tpReparatie;
        private System.Windows.Forms.TabPage tpTrams;
        private System.Windows.Forms.TabPage tpSporen;
        private System.Windows.Forms.TabPage tpLijnen;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
    }
}

