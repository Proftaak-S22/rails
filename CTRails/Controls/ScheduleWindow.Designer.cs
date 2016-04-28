namespace CTRails.Controls
{
    partial class ScheduleWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvPersoonlijkRooster = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Persoonlijk Rooster";
            // 
            // lvPersoonlijkRooster
            // 
            this.lvPersoonlijkRooster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPersoonlijkRooster.GridLines = true;
            this.lvPersoonlijkRooster.Location = new System.Drawing.Point(3, 42);
            this.lvPersoonlijkRooster.Name = "lvPersoonlijkRooster";
            this.lvPersoonlijkRooster.Size = new System.Drawing.Size(866, 427);
            this.lvPersoonlijkRooster.TabIndex = 5;
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
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(876, 42);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // ScheduleWindow
            // 
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPersoonlijkRooster);
            this.Name = "ScheduleWindow";
            this.Size = new System.Drawing.Size(1171, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPersoonlijkRooster;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
