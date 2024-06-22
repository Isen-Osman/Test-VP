namespace StudentForm
{
    partial class DodadiStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.lbIndeks = new System.Windows.Forms.TextBox();
            this.lbImeiPrezime = new System.Windows.Forms.TextBox();
            this.btnDodadiStudent = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbImePrezime = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIndeks
            // 
            this.lbIndeks.Location = new System.Drawing.Point(22, 45);
            this.lbIndeks.Name = "lbIndeks";
            this.lbIndeks.Size = new System.Drawing.Size(220, 20);
            this.lbIndeks.TabIndex = 0;
            this.lbIndeks.Validating += new System.ComponentModel.CancelEventHandler(this.tbIndeks_Validating);
            // 
            // lbImeiPrezime
            // 
            this.lbImeiPrezime.Location = new System.Drawing.Point(22, 111);
            this.lbImeiPrezime.Name = "lbImeiPrezime";
            this.lbImeiPrezime.Size = new System.Drawing.Size(220, 20);
            this.lbImeiPrezime.TabIndex = 1;
            this.lbImeiPrezime.TextChanged += new System.EventHandler(this.lbImeiPrezime_TextChanged);
            this.lbImeiPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.lbIme_Validating);
            // 
            // btnDodadiStudent
            // 
            this.btnDodadiStudent.Location = new System.Drawing.Point(22, 163);
            this.btnDodadiStudent.Name = "btnDodadiStudent";
            this.btnDodadiStudent.Size = new System.Drawing.Size(220, 33);
            this.btnDodadiStudent.TabIndex = 2;
            this.btnDodadiStudent.Text = "Dodadi Student";
            this.btnDodadiStudent.UseVisualStyleBackColor = true;
            this.btnDodadiStudent.Click += new System.EventHandler(this.btnDodadiStudent_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(22, 202);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(220, 33);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Indeks";
            // 
            // lbImePrezime
            // 
            this.lbImePrezime.AutoSize = true;
            this.lbImePrezime.Location = new System.Drawing.Point(19, 95);
            this.lbImePrezime.Name = "lbImePrezime";
            this.lbImePrezime.Size = new System.Drawing.Size(68, 13);
            this.lbImePrezime.TabIndex = 5;
            this.lbImePrezime.Text = "Ime i prezime";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodadiStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 269);
            this.Controls.Add(this.lbImePrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodadiStudent);
            this.Controls.Add(this.lbImeiPrezime);
            this.Controls.Add(this.lbIndeks);
            this.Name = "DodadiStudentForm";
            this.Text = "DodadiStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbIndeks;
        private System.Windows.Forms.TextBox lbImeiPrezime;
        private System.Windows.Forms.Button btnDodadiStudent;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbImePrezime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}