namespace Little_Pizza
{
    partial class AdminIslemYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIslemYap));
            this.label1 = new System.Windows.Forms.Label();
            this.kasaLbl = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(0, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 147);
            this.label1.TabIndex = 33;
            this.label1.Text = "K A S A D A K İ   T U T A R";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kasaLbl
            // 
            this.kasaLbl.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasaLbl.ForeColor = System.Drawing.Color.Peru;
            this.kasaLbl.Location = new System.Drawing.Point(1, 201);
            this.kasaLbl.Name = "kasaLbl";
            this.kasaLbl.Size = new System.Drawing.Size(841, 147);
            this.kasaLbl.TabIndex = 34;
            this.kasaLbl.Text = "0     TL";
            this.kasaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Location = new System.Drawing.Point(1, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(107, 50);
            this.btnGeri.TabIndex = 45;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(768, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 50);
            this.btnCikis.TabIndex = 46;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AdminIslemYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(843, 549);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.kasaLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminIslemYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminIslemYap";
            this.Load += new System.EventHandler(this.AdminIslemYap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kasaLbl;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCikis;
    }
}