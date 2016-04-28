using System.Windows.Forms;
using CTRails.Controls;


namespace CTRails.Forms
{
    partial class Rails
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
            this.btnLogOut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcNavigation = new System.Windows.Forms.TabControl();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.tpRemise = new System.Windows.Forms.TabPage();
            this.tpTrams = new System.Windows.Forms.TabPage();
            this.btnBekijkRoosters1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbGebruikerBekijken = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblRoosterVan = new System.Windows.Forms.Label();
            this.lvRoostersBekijken = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.tpRoosterEdit = new System.Windows.Forms.TabPage();
            this.tpGebruikers = new System.Windows.Forms.TabPage();
            this.loginWindow = new CTRails.Controls.LoginWindow();
            this.remiseWindow1 = new CTRails.Controls.RemiseWindow();
            this.scheduleWindow1 = new CTRails.Controls.ScheduleWindow();
            this.editScheduleTabPage1 = new CTRails.Controls.EditScheduleWindow();
            this.usersWindow1 = new CTRails.Controls.UsersWindow();
            this.tcNavigation.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tpRemise.SuspendLayout();
            this.tpTrams.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.tpRoosterEdit.SuspendLayout();
            this.tpGebruikers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.Location = new System.Drawing.Point(1075, 24);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Primary = true;
            this.btnLogOut.Size = new System.Drawing.Size(101, 40);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Uitloggen";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogoutClick);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(4, 636);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1268, 45);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tcNavigation
            // 
            this.tcNavigation.Controls.Add(this.tpLogin);
            this.tcNavigation.Controls.Add(this.tpRemise);
            this.tcNavigation.Controls.Add(this.tpTrams);
            this.tcNavigation.Controls.Add(this.tpSchedule);
            this.tcNavigation.Controls.Add(this.tpRoosterEdit);
            this.tcNavigation.Controls.Add(this.tpGebruikers);
            this.tcNavigation.Location = new System.Drawing.Point(0, 99);
            this.tcNavigation.Name = "tcNavigation";
            this.tcNavigation.SelectedIndex = 0;
            this.tcNavigation.Size = new System.Drawing.Size(1276, 531);
            this.tcNavigation.TabIndex = 0;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.loginWindow);
            this.tpLogin.Location = new System.Drawing.Point(4, 22);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(1268, 505);
            this.tpLogin.TabIndex = 6;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // tpRemise
            // 
            this.tpRemise.Controls.Add(this.remiseWindow1);
            this.tpRemise.Location = new System.Drawing.Point(4, 22);
            this.tpRemise.Name = "tpRemise";
            this.tpRemise.Padding = new System.Windows.Forms.Padding(3);
            this.tpRemise.Size = new System.Drawing.Size(1268, 505);
            this.tpRemise.TabIndex = 0;
            this.tpRemise.Text = "Remise";
            this.tpRemise.UseVisualStyleBackColor = true;
            // 
            // tpTrams
            // 
            this.tpTrams.Controls.Add(this.btnBekijkRoosters1);
            this.tpTrams.Controls.Add(this.cbGebruikerBekijken);
            this.tpTrams.Controls.Add(this.materialLabel1);
            this.tpTrams.Controls.Add(this.lblRoosterVan);
            this.tpTrams.Controls.Add(this.lvRoostersBekijken);
            this.tpTrams.Location = new System.Drawing.Point(4, 22);
            this.tpTrams.Name = "tpTrams";
            this.tpTrams.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrams.Size = new System.Drawing.Size(1268, 505);
            this.tpTrams.TabIndex = 3;
            this.tpTrams.Text = "Alle roosters bekijken";
            this.tpTrams.UseVisualStyleBackColor = true;
            // 
            // btnBekijkRoosters1
            // 
            this.btnBekijkRoosters1.Depth = 0;
            this.btnBekijkRoosters1.Location = new System.Drawing.Point(884, 426);
            this.btnBekijkRoosters1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBekijkRoosters1.Name = "btnBekijkRoosters1";
            this.btnBekijkRoosters1.Primary = true;
            this.btnBekijkRoosters1.Size = new System.Drawing.Size(276, 46);
            this.btnBekijkRoosters1.TabIndex = 9;
            this.btnBekijkRoosters1.Text = "Wijzig roosters";
            this.btnBekijkRoosters1.UseVisualStyleBackColor = true;
            this.btnBekijkRoosters1.Click += new System.EventHandler(this.btnBekijkRoosters1_Click);
            // 
            // cbGebruikerBekijken
            // 
            this.cbGebruikerBekijken.FormattingEnabled = true;
            this.cbGebruikerBekijken.Location = new System.Drawing.Point(884, 67);
            this.cbGebruikerBekijken.Name = "cbGebruikerBekijken";
            this.cbGebruikerBekijken.Size = new System.Drawing.Size(276, 21);
            this.cbGebruikerBekijken.Sorted = true;
            this.cbGebruikerBekijken.TabIndex = 6;
            this.cbGebruikerBekijken.Text = "Kies een gebruiker...";
            this.cbGebruikerBekijken.SelectedIndexChanged += new System.EventHandler(this.cbGebruikerBekijken_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(880, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 18);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Bekijk rooster van:";
            // 
            // lblRoosterVan
            // 
            this.lblRoosterVan.AutoSize = true;
            this.lblRoosterVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblRoosterVan.Location = new System.Drawing.Point(8, 3);
            this.lblRoosterVan.Name = "lblRoosterVan";
            this.lblRoosterVan.Size = new System.Drawing.Size(288, 39);
            this.lblRoosterVan.TabIndex = 4;
            this.lblRoosterVan.Text = "Roosters bekijken";
            // 
            // lvRoostersBekijken
            // 
            this.lvRoostersBekijken.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvRoostersBekijken.GridLines = true;
            this.lvRoostersBekijken.Location = new System.Drawing.Point(8, 45);
            this.lvRoostersBekijken.Name = "lvRoostersBekijken";
            this.lvRoostersBekijken.Size = new System.Drawing.Size(866, 427);
            this.lvRoostersBekijken.TabIndex = 1;
            this.lvRoostersBekijken.UseCompatibleStateImageBehavior = false;
            this.lvRoostersBekijken.View = System.Windows.Forms.View.Details;
            this.lvRoostersBekijken.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnUserSelected);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tram ID";
            this.columnHeader4.Width = 346;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum";
            this.columnHeader5.Width = 267;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Done?";
            this.columnHeader6.Width = 219;
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.scheduleWindow1);
            this.tpSchedule.Location = new System.Drawing.Point(4, 22);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedule.Size = new System.Drawing.Size(1268, 505);
            this.tpSchedule.TabIndex = 1;
            this.tpSchedule.Text = "Rooster";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // tpRoosterEdit
            // 
            this.tpRoosterEdit.Controls.Add(this.editScheduleTabPage1);
            this.tpRoosterEdit.Location = new System.Drawing.Point(4, 22);
            this.tpRoosterEdit.Name = "tpRoosterEdit";
            this.tpRoosterEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoosterEdit.Size = new System.Drawing.Size(1268, 505);
            this.tpRoosterEdit.TabIndex = 2;
            this.tpRoosterEdit.Text = "Roosters Aanpassen";
            this.tpRoosterEdit.UseVisualStyleBackColor = true;
            // 
            // tpGebruikers
            // 
            this.tpGebruikers.Controls.Add(this.usersWindow1);
            this.tpGebruikers.Location = new System.Drawing.Point(4, 22);
            this.tpGebruikers.Name = "tpGebruikers";
            this.tpGebruikers.Padding = new System.Windows.Forms.Padding(3);
            this.tpGebruikers.Size = new System.Drawing.Size(1268, 505);
            this.tpGebruikers.TabIndex = 4;
            this.tpGebruikers.Text = "Gebruikers";
            this.tpGebruikers.UseVisualStyleBackColor = true;
            // 
            // loginWindow
            // 
            this.loginWindow.Location = new System.Drawing.Point(507, 142);
            this.loginWindow.Name = "loginWindow";
            this.loginWindow.Size = new System.Drawing.Size(250, 206);
            this.loginWindow.TabIndex = 0;
            // 
            // remiseWindow1
            // 
            this.remiseWindow1.Location = new System.Drawing.Point(3, 3);
            this.remiseWindow1.Name = "remiseWindow1";
            this.remiseWindow1.Size = new System.Drawing.Size(1264, 478);
            this.remiseWindow1.TabIndex = 0;
            this.remiseWindow1.Load += new System.EventHandler(this.OnRemiseClick);
            // 
            // scheduleWindow1
            // 
            this.scheduleWindow1.Location = new System.Drawing.Point(8, 3);
            this.scheduleWindow1.Name = "scheduleWindow1";
            this.scheduleWindow1.Size = new System.Drawing.Size(1171, 478);
            this.scheduleWindow1.TabIndex = 0;
            // 
            // editScheduleTabPage1
            // 
            this.editScheduleTabPage1.Location = new System.Drawing.Point(6, 6);
            this.editScheduleTabPage1.Name = "editScheduleTabPage1";
            this.editScheduleTabPage1.Size = new System.Drawing.Size(1163, 493);
            this.editScheduleTabPage1.TabIndex = 0;
            // 
            // usersWindow1
            // 
            this.usersWindow1.Location = new System.Drawing.Point(3, 3);
            this.usersWindow1.Name = "usersWindow1";
            this.usersWindow1.Size = new System.Drawing.Size(1162, 487);
            this.usersWindow1.TabIndex = 0;
            this.usersWindow1.Load += new System.EventHandler(this.usersWindow1_Load);
            // 
            // Rails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 684);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tcNavigation);
            this.Name = "Rails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remise App: Log in a.u.b.";
            this.tcNavigation.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpRemise.ResumeLayout(false);
            this.tpTrams.ResumeLayout(false);
            this.tpTrams.PerformLayout();
            this.tpSchedule.ResumeLayout(false);
            this.tpRoosterEdit.ResumeLayout(false);
            this.tpGebruikers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnLogOut;
        private System.Windows.Forms.TabPage tpGebruikers;
        private System.Windows.Forms.TabPage tpRoosterEdit;
        private System.Windows.Forms.TabPage tpTrams;
        private MaterialSkin.Controls.MaterialRaisedButton btnBekijkRoosters1;
        private System.Windows.Forms.ComboBox cbGebruikerBekijken;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lblRoosterVan;
        private System.Windows.Forms.ListView lvRoostersBekijken;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tpRemise;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TabControl tcNavigation;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tpSchedule;
        private EditScheduleWindow editScheduleTabPage1;
        private RemiseWindow remiseWindow1;
        private UsersWindow usersWindow1;
        private LoginWindow loginWindow;
        private ScheduleWindow scheduleWindow1;
    }
}

