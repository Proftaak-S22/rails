namespace CTRails
{
    partial class TramPlaatsenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatusSchoonmaak = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbStatusDefect = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbStatusRemise = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // btnAddTram
            // 
            this.btnAddTram.Depth = 0;
            this.btnAddTram.Location = new System.Drawing.Point(59, 264);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "* Vul X in om te blokkeren *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Laat leeg om te verwijderen/deblokkeren *";
            // 
            // cbStatusSchoonmaak
            // 
            this.cbStatusSchoonmaak.AutoSize = true;
            this.cbStatusSchoonmaak.Depth = 0;
            this.cbStatusSchoonmaak.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbStatusSchoonmaak.Location = new System.Drawing.Point(82, 201);
            this.cbStatusSchoonmaak.Margin = new System.Windows.Forms.Padding(0);
            this.cbStatusSchoonmaak.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbStatusSchoonmaak.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbStatusSchoonmaak.Name = "cbStatusSchoonmaak";
            this.cbStatusSchoonmaak.Ripple = true;
            this.cbStatusSchoonmaak.Size = new System.Drawing.Size(109, 30);
            this.cbStatusSchoonmaak.TabIndex = 4;
            this.cbStatusSchoonmaak.TabStop = true;
            this.cbStatusSchoonmaak.Text = "Schoonmaak";
            this.cbStatusSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // cbStatusDefect
            // 
            this.cbStatusDefect.AutoSize = true;
            this.cbStatusDefect.Depth = 0;
            this.cbStatusDefect.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbStatusDefect.Location = new System.Drawing.Point(82, 231);
            this.cbStatusDefect.Margin = new System.Windows.Forms.Padding(0);
            this.cbStatusDefect.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbStatusDefect.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbStatusDefect.Name = "cbStatusDefect";
            this.cbStatusDefect.Ripple = true;
            this.cbStatusDefect.Size = new System.Drawing.Size(69, 30);
            this.cbStatusDefect.TabIndex = 4;
            this.cbStatusDefect.TabStop = true;
            this.cbStatusDefect.Text = "Defect";
            this.cbStatusDefect.UseVisualStyleBackColor = true;
            // 
            // cbStatusRemise
            // 
            this.cbStatusRemise.AutoSize = true;
            this.cbStatusRemise.Checked = true;
            this.cbStatusRemise.Depth = 0;
            this.cbStatusRemise.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbStatusRemise.Location = new System.Drawing.Point(82, 171);
            this.cbStatusRemise.Margin = new System.Windows.Forms.Padding(0);
            this.cbStatusRemise.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbStatusRemise.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbStatusRemise.Name = "cbStatusRemise";
            this.cbStatusRemise.Ripple = true;
            this.cbStatusRemise.Size = new System.Drawing.Size(75, 30);
            this.cbStatusRemise.TabIndex = 4;
            this.cbStatusRemise.TabStop = true;
            this.cbStatusRemise.Text = "Remise";
            this.cbStatusRemise.UseVisualStyleBackColor = true;
            // 
            // PopUp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 359);
            this.Controls.Add(this.cbStatusRemise);
            this.Controls.Add(this.cbStatusDefect);
            this.Controls.Add(this.cbStatusSchoonmaak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtTramNummer);
            this.Controls.Add(this.btnAddTram);
            this.Name = "TramPlaatsenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tram plaatsen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopUp1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAddTram;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRadioButton cbStatusSchoonmaak;
        private MaterialSkin.Controls.MaterialRadioButton cbStatusDefect;
        private MaterialSkin.Controls.MaterialRadioButton cbStatusRemise;
        public System.Windows.Forms.TextBox txtTramNummer;
    }
}