namespace CTRails.Controls
{
    partial class TrackView
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
            this.pLine = new System.Windows.Forms.Panel();
            this.btnTrack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sectorOne = new CTRails.Controls.Sector();
            this.SuspendLayout();
            // 
            // pLine
            // 
            this.pLine.BackColor = System.Drawing.Color.Maroon;
            this.pLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLine.Location = new System.Drawing.Point(0, 36);
            this.pLine.Margin = new System.Windows.Forms.Padding(0);
            this.pLine.Name = "pLine";
            this.pLine.Size = new System.Drawing.Size(50, 30);
            this.pLine.TabIndex = 51;
            // 
            // btnTrack
            // 
            this.btnTrack.BackColor = System.Drawing.Color.Transparent;
            this.btnTrack.Depth = 0;
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrack.Location = new System.Drawing.Point(0, 0);
            this.btnTrack.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Primary = true;
            this.btnTrack.Size = new System.Drawing.Size(50, 30);
            this.btnTrack.TabIndex = 49;
            this.btnTrack.Text = "99";
            this.btnTrack.UseVisualStyleBackColor = false;
            // 
            // sectorOne
            // 
            this.sectorOne.Location = new System.Drawing.Point(-3, 69);
            this.sectorOne.Margin = new System.Windows.Forms.Padding(0);
            this.sectorOne.Name = "sectorOne";
            this.sectorOne.SectorObject = null;
            this.sectorOne.Size = new System.Drawing.Size(56, 36);
            this.sectorOne.TabIndex = 52;
            this.sectorOne.Click += new System.EventHandler(this.OnSectorClick);
            // 
            // TrackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.sectorOne);
            this.Controls.Add(this.pLine);
            this.Controls.Add(this.btnTrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TrackView";
            this.Size = new System.Drawing.Size(54, 105);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pLine;
        private MaterialSkin.Controls.MaterialRaisedButton btnTrack;
        private Sector sectorOne;
    }
}
