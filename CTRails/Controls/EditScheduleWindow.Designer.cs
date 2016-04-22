namespace CTRails.Controls
{
    partial class EditScheduleWindow
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbTijd = new System.Windows.Forms.TextBox();
            this.tbTaak = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGebruikerEdit = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnVerwijderTaak = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnWijzigTaak = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNieuweTaak = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lvRoostersWijzigen = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(879, 170);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(276, 20);
            this.dtpDatum.TabIndex = 26;
            // 
            // tbTijd
            // 
            this.tbTijd.Location = new System.Drawing.Point(879, 214);
            this.tbTijd.Name = "tbTijd";
            this.tbTijd.Size = new System.Drawing.Size(276, 20);
            this.tbTijd.TabIndex = 24;
            // 
            // tbTaak
            // 
            this.tbTaak.Location = new System.Drawing.Point(879, 126);
            this.tbTaak.Name = "tbTaak";
            this.tbTaak.Size = new System.Drawing.Size(276, 20);
            this.tbTaak.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(876, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tijd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(876, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Taak";
            // 
            // cbGebruikerEdit
            // 
            this.cbGebruikerEdit.FormattingEnabled = true;
            this.cbGebruikerEdit.Location = new System.Drawing.Point(879, 67);
            this.cbGebruikerEdit.Name = "cbGebruikerEdit";
            this.cbGebruikerEdit.Size = new System.Drawing.Size(276, 21);
            this.cbGebruikerEdit.TabIndex = 20;
            this.cbGebruikerEdit.Text = "Kies een gebruiker...";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(875, 91);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(161, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Nieuwe gegevens/taak";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(875, 45);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(134, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Bekijk rooster van:";
            // 
            // btnVerwijderTaak
            // 
            this.btnVerwijderTaak.Depth = 0;
            this.btnVerwijderTaak.Location = new System.Drawing.Point(879, 426);
            this.btnVerwijderTaak.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerwijderTaak.Name = "btnVerwijderTaak";
            this.btnVerwijderTaak.Primary = true;
            this.btnVerwijderTaak.Size = new System.Drawing.Size(276, 46);
            this.btnVerwijderTaak.TabIndex = 16;
            this.btnVerwijderTaak.Text = "Geselecteerd taak verwijderen";
            this.btnVerwijderTaak.UseVisualStyleBackColor = true;
            // 
            // btnWijzigTaak
            // 
            this.btnWijzigTaak.Depth = 0;
            this.btnWijzigTaak.Location = new System.Drawing.Point(879, 292);
            this.btnWijzigTaak.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWijzigTaak.Name = "btnWijzigTaak";
            this.btnWijzigTaak.Primary = true;
            this.btnWijzigTaak.Size = new System.Drawing.Size(276, 46);
            this.btnWijzigTaak.TabIndex = 17;
            this.btnWijzigTaak.Text = "Geselecteerd taak wijzigen";
            this.btnWijzigTaak.UseVisualStyleBackColor = true;
            // 
            // btnNieuweTaak
            // 
            this.btnNieuweTaak.Depth = 0;
            this.btnNieuweTaak.Location = new System.Drawing.Point(879, 240);
            this.btnNieuweTaak.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNieuweTaak.Name = "btnNieuweTaak";
            this.btnNieuweTaak.Primary = true;
            this.btnNieuweTaak.Size = new System.Drawing.Size(276, 46);
            this.btnNieuweTaak.TabIndex = 15;
            this.btnNieuweTaak.Text = "Taak toevoegen";
            this.btnNieuweTaak.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "Roosters Wijzigen";
            // 
            // lvRoostersWijzigen
            // 
            this.lvRoostersWijzigen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvRoostersWijzigen.GridLines = true;
            this.lvRoostersWijzigen.Location = new System.Drawing.Point(3, 45);
            this.lvRoostersWijzigen.Name = "lvRoostersWijzigen";
            this.lvRoostersWijzigen.Size = new System.Drawing.Size(866, 427);
            this.lvRoostersWijzigen.TabIndex = 13;
            this.lvRoostersWijzigen.UseCompatibleStateImageBehavior = false;
            this.lvRoostersWijzigen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Taak";
            this.columnHeader7.Width = 472;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Datum";
            this.columnHeader8.Width = 154;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tijd";
            this.columnHeader9.Width = 128;
            // 
            // EditScheduleTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbTijd);
            this.Controls.Add(this.tbTaak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGebruikerEdit);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnVerwijderTaak);
            this.Controls.Add(this.btnWijzigTaak);
            this.Controls.Add(this.btnNieuweTaak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvRoostersWijzigen);
            this.Name = "EditScheduleWindow";
            this.Size = new System.Drawing.Size(1163, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbTijd;
        private System.Windows.Forms.TextBox tbTaak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGebruikerEdit;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerwijderTaak;
        private MaterialSkin.Controls.MaterialRaisedButton btnWijzigTaak;
        private MaterialSkin.Controls.MaterialRaisedButton btnNieuweTaak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvRoostersWijzigen;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}
