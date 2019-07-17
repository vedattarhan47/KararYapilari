namespace WFA_KararYapilari
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
            this.btnDegerKontrolu = new System.Windows.Forms.Button();
            this.btnCiftMiTekMi = new System.Windows.Forms.Button();
            this.btnNotKontrolu = new System.Windows.Forms.Button();
            this.btnAdminKontrolu = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDegerKontrolu
            // 
            this.btnDegerKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegerKontrolu.Location = new System.Drawing.Point(12, 171);
            this.btnDegerKontrolu.Name = "btnDegerKontrolu";
            this.btnDegerKontrolu.Size = new System.Drawing.Size(300, 40);
            this.btnDegerKontrolu.TabIndex = 14;
            this.btnDegerKontrolu.Text = "DEĞER KONTROLÜ";
            this.btnDegerKontrolu.UseVisualStyleBackColor = true;
            this.btnDegerKontrolu.Click += new System.EventHandler(this.BtnDegerKontrolu_Click);
            // 
            // btnCiftMiTekMi
            // 
            this.btnCiftMiTekMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiftMiTekMi.Location = new System.Drawing.Point(12, 125);
            this.btnCiftMiTekMi.Name = "btnCiftMiTekMi";
            this.btnCiftMiTekMi.Size = new System.Drawing.Size(300, 40);
            this.btnCiftMiTekMi.TabIndex = 13;
            this.btnCiftMiTekMi.Text = "ÇİFT - TEK KONTROLÜ";
            this.btnCiftMiTekMi.UseVisualStyleBackColor = true;
            this.btnCiftMiTekMi.Click += new System.EventHandler(this.BtnCiftMiTekMi_Click);
            // 
            // btnNotKontrolu
            // 
            this.btnNotKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotKontrolu.Location = new System.Drawing.Point(12, 79);
            this.btnNotKontrolu.Name = "btnNotKontrolu";
            this.btnNotKontrolu.Size = new System.Drawing.Size(300, 40);
            this.btnNotKontrolu.TabIndex = 12;
            this.btnNotKontrolu.Text = "NOT KONTROLÜ";
            this.btnNotKontrolu.UseVisualStyleBackColor = true;
            this.btnNotKontrolu.Click += new System.EventHandler(this.BtnNotKontrolu_Click);
            // 
            // btnAdminKontrolu
            // 
            this.btnAdminKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminKontrolu.Location = new System.Drawing.Point(12, 33);
            this.btnAdminKontrolu.Name = "btnAdminKontrolu";
            this.btnAdminKontrolu.Size = new System.Drawing.Size(300, 40);
            this.btnAdminKontrolu.TabIndex = 11;
            this.btnAdminKontrolu.Text = "ADMİN KONTROLÜ";
            this.btnAdminKontrolu.UseVisualStyleBackColor = true;
            this.btnAdminKontrolu.Click += new System.EventHandler(this.BtnAdminKontrolu_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(12, 7);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(300, 20);
            this.txtGirisAlani.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 222);
            this.Controls.Add(this.btnDegerKontrolu);
            this.Controls.Add(this.btnCiftMiTekMi);
            this.Controls.Add(this.btnNotKontrolu);
            this.Controls.Add(this.btnAdminKontrolu);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegerKontrolu;
        private System.Windows.Forms.Button btnCiftMiTekMi;
        private System.Windows.Forms.Button btnNotKontrolu;
        private System.Windows.Forms.Button btnAdminKontrolu;
        private System.Windows.Forms.TextBox txtGirisAlani;
    }
}

