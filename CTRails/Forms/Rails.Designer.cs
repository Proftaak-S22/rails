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
            this.loginWindow = new CTRails.Controls.LoginWindow();
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
            this.tpSchedule = new CTRails.Controls.ScheduleWindow();
            this.btnBekijkRoosters = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditScedule = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lvPersoonlijkRooster = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpRoosterEdit = new System.Windows.Forms.TabPage();
            this.editScheduleTabPage1 = new CTRails.Controls.EditScheduleWindow();
            this.tpGebruikers = new System.Windows.Forms.TabPage();
            this.lvGebruikers = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton34 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton35 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton36 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.remiseWindow1 = new CTRails.Controls.RemiseWindow();
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
            this.btnLogOut.Click += new System.EventHandler(this.btnLogoutClick);
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
            this.tpLogin.Size = new System.Drawing.Size(1168, 505);
            this.tpLogin.TabIndex = 6;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // loginWindow
            // 
            this.loginWindow.Location = new System.Drawing.Point(80, 67);
            this.loginWindow.Name = "loginWindow";
            this.loginWindow.Size = new System.Drawing.Size(989, 432);
            this.loginWindow.TabIndex = 3;
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
            // 
            // cbGebruikerBekijken
            // 
            this.cbGebruikerBekijken.FormattingEnabled = true;
            this.cbGebruikerBekijken.Location = new System.Drawing.Point(884, 67);
            this.cbGebruikerBekijken.Name = "cbGebruikerBekijken";
            this.cbGebruikerBekijken.Size = new System.Drawing.Size(276, 21);
            this.cbGebruikerBekijken.TabIndex = 6;
            this.cbGebruikerBekijken.Text = "Kies een gebruiker...";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(880, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Bekijk rooster van:";
            // 
            // lblRoosterVan
            // 
            this.lblRoosterVan.AutoSize = true;
            this.lblRoosterVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblRoosterVan.Location = new System.Drawing.Point(8, 3);
            this.lblRoosterVan.Name = "lblRoosterVan";
            this.lblRoosterVan.Size = new System.Drawing.Size(315, 39);
            this.lblRoosterVan.TabIndex = 4;
            this.lblRoosterVan.Text = "Rooster van <user>";
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
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Taak";
            this.columnHeader4.Width = 472;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum";
            this.columnHeader5.Width = 154;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tijd";
            this.columnHeader6.Width = 128;
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.btnBekijkRoosters);
            this.tpSchedule.Controls.Add(this.label1);
            this.tpSchedule.Controls.Add(this.btnEditScedule);
            this.tpSchedule.Controls.Add(this.lvPersoonlijkRooster);
            this.tpSchedule.Location = new System.Drawing.Point(4, 22);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedule.Size = new System.Drawing.Size(1268, 505);
            this.tpSchedule.TabIndex = 1;
            this.tpSchedule.Text = "Rooster";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // btnBekijkRoosters
            // 
            this.btnBekijkRoosters.Depth = 0;
            this.btnBekijkRoosters.Location = new System.Drawing.Point(884, 97);
            this.btnBekijkRoosters.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBekijkRoosters.Name = "btnBekijkRoosters";
            this.btnBekijkRoosters.Primary = true;
            this.btnBekijkRoosters.Size = new System.Drawing.Size(276, 46);
            this.btnBekijkRoosters.TabIndex = 4;
            this.btnBekijkRoosters.Text = "Bekijk alle roosters";
            this.btnBekijkRoosters.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Persoonlijk Rooster";
            // 
            // btnEditScedule
            // 
            this.btnEditScedule.Depth = 0;
            this.btnEditScedule.Location = new System.Drawing.Point(884, 45);
            this.btnEditScedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditScedule.Name = "btnEditScedule";
            this.btnEditScedule.Primary = true;
            this.btnEditScedule.Size = new System.Drawing.Size(278, 46);
            this.btnEditScedule.TabIndex = 1;
            this.btnEditScedule.Text = "Wijzig rooster(s)";
            this.btnEditScedule.UseVisualStyleBackColor = true;
            // 
            // lvPersoonlijkRooster
            // 
            this.lvPersoonlijkRooster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPersoonlijkRooster.GridLines = true;
            this.lvPersoonlijkRooster.Location = new System.Drawing.Point(8, 45);
            this.lvPersoonlijkRooster.Name = "lvPersoonlijkRooster";
            this.lvPersoonlijkRooster.Size = new System.Drawing.Size(866, 427);
            this.lvPersoonlijkRooster.TabIndex = 0;
            this.lvPersoonlijkRooster.UseCompatibleStateImageBehavior = false;
            this.lvPersoonlijkRooster.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Taak";
            this.columnHeader1.Width = 472;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Datum";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tijd";
            this.columnHeader3.Width = 128;
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
            // editScheduleTabPage1
            // 
            this.editScheduleTabPage1.Location = new System.Drawing.Point(6, 6);
            this.editScheduleTabPage1.Name = "editScheduleTabPage1";
            this.editScheduleTabPage1.Size = new System.Drawing.Size(1163, 493);
            this.editScheduleTabPage1.TabIndex = 0;
            // 
            // tpGebruikers
            // 
            this.tpGebruikers.Controls.Add(this.lvGebruikers);
            this.tpGebruikers.Controls.Add(this.textBox8);
            this.tpGebruikers.Controls.Add(this.textBox6);
            this.tpGebruikers.Controls.Add(this.textBox7);
            this.tpGebruikers.Controls.Add(this.textBox5);
            this.tpGebruikers.Controls.Add(this.textBox4);
            this.tpGebruikers.Controls.Add(this.textBox1);
            this.tpGebruikers.Controls.Add(this.textBox3);
            this.tpGebruikers.Controls.Add(this.textBox2);
            this.tpGebruikers.Controls.Add(this.dateTimePicker1);
            this.tpGebruikers.Controls.Add(this.comboBox1);
            this.tpGebruikers.Controls.Add(this.label7);
            this.tpGebruikers.Controls.Add(this.label16);
            this.tpGebruikers.Controls.Add(this.label14);
            this.tpGebruikers.Controls.Add(this.label15);
            this.tpGebruikers.Controls.Add(this.label13);
            this.tpGebruikers.Controls.Add(this.label2);
            this.tpGebruikers.Controls.Add(this.label11);
            this.tpGebruikers.Controls.Add(this.label12);
            this.tpGebruikers.Controls.Add(this.label10);
            this.tpGebruikers.Controls.Add(this.label8);
            this.tpGebruikers.Controls.Add(this.materialLabel5);
            this.tpGebruikers.Controls.Add(this.materialRaisedButton34);
            this.tpGebruikers.Controls.Add(this.materialRaisedButton35);
            this.tpGebruikers.Controls.Add(this.materialRaisedButton36);
            this.tpGebruikers.Controls.Add(this.label9);
            this.tpGebruikers.Location = new System.Drawing.Point(4, 22);
            this.tpGebruikers.Name = "tpGebruikers";
            this.tpGebruikers.Padding = new System.Windows.Forms.Padding(3);
            this.tpGebruikers.Size = new System.Drawing.Size(1268, 505);
            this.tpGebruikers.TabIndex = 4;
            this.tpGebruikers.Text = "Gebruikers";
            this.tpGebruikers.UseVisualStyleBackColor = true;
            // 
            // lvGebruikers
            // 
            this.lvGebruikers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvGebruikers.GridLines = true;
            this.lvGebruikers.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lvGebruikers.Location = new System.Drawing.Point(8, 45);
            this.lvGebruikers.Name = "lvGebruikers";
            this.lvGebruikers.Size = new System.Drawing.Size(866, 427);
            this.lvGebruikers.TabIndex = 26;
            this.lvGebruikers.UseCompatibleStateImageBehavior = false;
            this.lvGebruikers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Gebruikersnaam";
            this.columnHeader10.Width = 104;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Geslacht";
            this.columnHeader11.Width = 54;
            // 
            // columnHeader12
            // 
            this.columnHeader12.DisplayIndex = 3;
            this.columnHeader12.Text = "Volledige naam";
            this.columnHeader12.Width = 147;
            // 
            // columnHeader13
            // 
            this.columnHeader13.DisplayIndex = 2;
            this.columnHeader13.Text = "Geboortedatum";
            this.columnHeader13.Width = 88;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Email";
            this.columnHeader14.Width = 121;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Land";
            this.columnHeader15.Width = 74;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Stad";
            this.columnHeader16.Width = 72;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Postcode";
            this.columnHeader17.Width = 84;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Huisnummer";
            this.columnHeader18.Width = 75;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1032, 284);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(129, 20);
            this.textBox8.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1031, 245);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 20);
            this.textBox6.TabIndex = 22;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(885, 284);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 20);
            this.textBox7.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(884, 245);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(884, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(884, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(884, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '•';
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(884, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1013, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "V"});
            this.comboBox1.Location = new System.Drawing.Point(1114, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1111, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Geslacht";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1029, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Huisnummer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1028, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Stad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(882, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Postcode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(881, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Land";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(881, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(881, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Volledige naam";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1020, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Geboortedatum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(881, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Wachtwoord";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(881, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Gebruikersnaam";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(880, 45);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(194, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Nieuwe gegevens/gebruiker";
            // 
            // materialRaisedButton34
            // 
            this.materialRaisedButton34.Depth = 0;
            this.materialRaisedButton34.Location = new System.Drawing.Point(884, 426);
            this.materialRaisedButton34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton34.Name = "materialRaisedButton34";
            this.materialRaisedButton34.Primary = true;
            this.materialRaisedButton34.Size = new System.Drawing.Size(276, 46);
            this.materialRaisedButton34.TabIndex = 16;
            this.materialRaisedButton34.Text = "Geselecteerd gebruiker verwijderen";
            this.materialRaisedButton34.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton35
            // 
            this.materialRaisedButton35.Depth = 0;
            this.materialRaisedButton35.Location = new System.Drawing.Point(884, 374);
            this.materialRaisedButton35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton35.Name = "materialRaisedButton35";
            this.materialRaisedButton35.Primary = true;
            this.materialRaisedButton35.Size = new System.Drawing.Size(276, 46);
            this.materialRaisedButton35.TabIndex = 17;
            this.materialRaisedButton35.Text = "Geselecteerd gebruiker wijzigen";
            this.materialRaisedButton35.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton36
            // 
            this.materialRaisedButton36.Depth = 0;
            this.materialRaisedButton36.Location = new System.Drawing.Point(884, 322);
            this.materialRaisedButton36.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton36.Name = "materialRaisedButton36";
            this.materialRaisedButton36.Primary = true;
            this.materialRaisedButton36.Size = new System.Drawing.Size(276, 46);
            this.materialRaisedButton36.TabIndex = 15;
            this.materialRaisedButton36.Text = "Gebruiker toevoegen";
            this.materialRaisedButton36.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label9.Location = new System.Drawing.Point(8, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 39);
            this.label9.TabIndex = 14;
            this.label9.Text = "Gebruikers";
            // 
            // remiseWindow1
            // 
            this.remiseWindow1.CleanColor = System.Drawing.Color.Blue;
            this.remiseWindow1.DefaultColor = System.Drawing.Color.Black;
            this.remiseWindow1.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.remiseWindow1.Location = new System.Drawing.Point(3, 3);
            this.remiseWindow1.MaintenanceFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.remiseWindow1.Name = "remiseWindow1";
            this.remiseWindow1.Size = new System.Drawing.Size(1264, 478);
            this.remiseWindow1.TabIndex = 0;
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
            this.tpSchedule.PerformLayout();
            this.tpRoosterEdit.ResumeLayout(false);
            this.tpGebruikers.ResumeLayout(false);
            this.tpGebruikers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnLogOut;
        private System.Windows.Forms.TabPage tpGebruikers;
        private System.Windows.Forms.ListView lvGebruikers;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton34;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton35;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton36;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tpRoosterEdit;
        private MaterialSkin.Controls.MaterialRaisedButton btnBekijkRoosters;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditScedule;
        private System.Windows.Forms.ListView lvPersoonlijkRooster;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
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
        private ScheduleWindow tpSchedule;
        private EditScheduleWindow editScheduleTabPage1;
        private LoginWindow loginWindow;
        private RemiseWindow remiseWindow1;
    }
}

