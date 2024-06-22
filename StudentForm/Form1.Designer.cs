namespace StudentForm
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
            this.lbStudenti = new System.Windows.Forms.ListBox();
            this.nudUplati = new System.Windows.Forms.NumericUpDown();
            this.btnDodadiStudent = new System.Windows.Forms.Button();
            this.btnIzbrisiUplati = new System.Windows.Forms.Button();
            this.btnDodadiUplati = new System.Windows.Forms.Button();
            this.lbStudentInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUplati)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudenti
            // 
            this.lbStudenti.FormattingEnabled = true;
            this.lbStudenti.Location = new System.Drawing.Point(12, 24);
            this.lbStudenti.Name = "lbStudenti";
            this.lbStudenti.Size = new System.Drawing.Size(204, 316);
            this.lbStudenti.TabIndex = 0;
            this.lbStudenti.SelectedIndexChanged += new System.EventHandler(this.lbStudenti_SelectedIndexChanged);
            // 
            // nudUplati
            // 
            this.nudUplati.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudUplati.Location = new System.Drawing.Point(241, 24);
            this.nudUplati.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudUplati.Name = "nudUplati";
            this.nudUplati.Size = new System.Drawing.Size(120, 20);
            this.nudUplati.TabIndex = 1;
            // 
            // btnDodadiStudent
            // 
            this.btnDodadiStudent.Location = new System.Drawing.Point(12, 355);
            this.btnDodadiStudent.Name = "btnDodadiStudent";
            this.btnDodadiStudent.Size = new System.Drawing.Size(204, 29);
            this.btnDodadiStudent.TabIndex = 2;
            this.btnDodadiStudent.Text = "Dodadi Student";
            this.btnDodadiStudent.UseVisualStyleBackColor = true;
            this.btnDodadiStudent.Click += new System.EventHandler(this.btnDodadiStudent_Click);
            // 
            // btnIzbrisiUplati
            // 
            this.btnIzbrisiUplati.Location = new System.Drawing.Point(12, 390);
            this.btnIzbrisiUplati.Name = "btnIzbrisiUplati";
            this.btnIzbrisiUplati.Size = new System.Drawing.Size(204, 31);
            this.btnIzbrisiUplati.TabIndex = 3;
            this.btnIzbrisiUplati.Text = "Izbrisi uplati";
            this.btnIzbrisiUplati.UseVisualStyleBackColor = true;
            this.btnIzbrisiUplati.Click += new System.EventHandler(this.btnIzbrisiUplati_Click);
            // 
            // btnDodadiUplati
            // 
            this.btnDodadiUplati.Location = new System.Drawing.Point(241, 60);
            this.btnDodadiUplati.Name = "btnDodadiUplati";
            this.btnDodadiUplati.Size = new System.Drawing.Size(120, 29);
            this.btnDodadiUplati.TabIndex = 4;
            this.btnDodadiUplati.Text = "Dodadi uplati";
            this.btnDodadiUplati.UseVisualStyleBackColor = true;
            this.btnDodadiUplati.Click += new System.EventHandler(this.btnDodadiUplati_Click);
            // 
            // lbStudentInfo
            // 
            this.lbStudentInfo.AutoSize = true;
            this.lbStudentInfo.Location = new System.Drawing.Point(238, 112);
            this.lbStudentInfo.Name = "lbStudentInfo";
            this.lbStudentInfo.Size = new System.Drawing.Size(113, 13);
            this.lbStudentInfo.TabIndex = 5;
            this.lbStudentInfo.Text = "Informacii za studentot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.lbStudentInfo);
            this.Controls.Add(this.btnDodadiUplati);
            this.Controls.Add(this.btnIzbrisiUplati);
            this.Controls.Add(this.btnDodadiStudent);
            this.Controls.Add(this.nudUplati);
            this.Controls.Add(this.lbStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudUplati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudenti;
        private System.Windows.Forms.NumericUpDown nudUplati;
        private System.Windows.Forms.Button btnDodadiStudent;
        private System.Windows.Forms.Button btnIzbrisiUplati;
        private System.Windows.Forms.Button btnDodadiUplati;
        private System.Windows.Forms.Label lbStudentInfo;
    }
}

