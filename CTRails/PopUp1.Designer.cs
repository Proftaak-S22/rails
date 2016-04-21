namespace CTRails
{
    partial class PopUp1
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
            this.btnAddTram = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtTramNummer = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnAddTram
            // 
            this.btnAddTram.Depth = 0;
            this.btnAddTram.Location = new System.Drawing.Point(59, 187);
            this.btnAddTram.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTram.Name = "btnAddTram";
            this.btnAddTram.Primary = true;
            this.btnAddTram.Size = new System.Drawing.Size(155, 56);
            this.btnAddTram.TabIndex = 0;
            this.btnAddTram.Text = "Plaats Tram";
            this.btnAddTram.UseVisualStyleBackColor = true;
            this.btnAddTram.Click += new System.EventHandler(this.btnAddTram_Click);
            // 
            // txtTramNummer
            // 
            this.txtTramNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramNummer.Location = new System.Drawing.Point(59, 114);
            this.txtTramNummer.MaxLength = 4;
            this.txtTramNummer.Name = "txtTramNummer";
            this.txtTramNummer.Size = new System.Drawing.Size(155, 53);
            this.txtTramNummer.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(55, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Tram Nummer";
            // 
            // PopUp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 293);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtTramNummer);
            this.Controls.Add(this.btnAddTram);
            this.Name = "PopUp1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tram plaatsen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopUp1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAddTram;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public System.Windows.Forms.TextBox txtTramNummer;
    }
}