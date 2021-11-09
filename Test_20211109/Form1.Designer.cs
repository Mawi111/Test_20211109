namespace Test_20211109
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jmeno = new System.Windows.Forms.Label();
            this.stavk = new System.Windows.Forms.Label();
            this.vlozv = new System.Windows.Forms.DomainUpDown();
            this.vyber = new System.Windows.Forms.DomainUpDown();
            this.btnVlozit = new System.Windows.Forms.Button();
            this.btnVybrat = new System.Windows.Forms.Button();
            this.platbav = new System.Windows.Forms.DomainUpDown();
            this.btnPlatba = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlatba);
            this.groupBox1.Controls.Add(this.platbav);
            this.groupBox1.Controls.Add(this.btnVybrat);
            this.groupBox1.Controls.Add(this.btnVlozit);
            this.groupBox1.Controls.Add(this.vyber);
            this.groupBox1.Controls.Add(this.vlozv);
            this.groupBox1.Controls.Add(this.stavk);
            this.groupBox1.Controls.Add(this.jmeno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(209, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jmeno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stav";
            // 
            // jmeno
            // 
            this.jmeno.AutoSize = true;
            this.jmeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jmeno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jmeno.Location = new System.Drawing.Point(88, 49);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(91, 15);
            this.jmeno.TabIndex = 2;
            this.jmeno.Text = "Tady bude jmeno";
            // 
            // stavk
            // 
            this.stavk.AutoSize = true;
            this.stavk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stavk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stavk.Location = new System.Drawing.Point(88, 77);
            this.stavk.Name = "stavk";
            this.stavk.Size = new System.Drawing.Size(113, 15);
            this.stavk.TabIndex = 3;
            this.stavk.Text = "Tady bude stav konta";
            // 
            // vlozv
            // 
            this.vlozv.Location = new System.Drawing.Point(6, 154);
            this.vlozv.Name = "vlozv";
            this.vlozv.Size = new System.Drawing.Size(94, 20);
            this.vlozv.TabIndex = 4;
            this.vlozv.Text = "Vlotiž";
            // 
            // vyber
            // 
            this.vyber.Location = new System.Drawing.Point(6, 180);
            this.vyber.Name = "vyber";
            this.vyber.Size = new System.Drawing.Size(94, 20);
            this.vyber.TabIndex = 5;
            this.vyber.Text = "Výběr";
            // 
            // btnVlozit
            // 
            this.btnVlozit.Location = new System.Drawing.Point(106, 151);
            this.btnVlozit.Name = "btnVlozit";
            this.btnVlozit.Size = new System.Drawing.Size(75, 23);
            this.btnVlozit.TabIndex = 6;
            this.btnVlozit.Text = "Vlozit";
            this.btnVlozit.UseVisualStyleBackColor = true;
            this.btnVlozit.Click += new System.EventHandler(this.btnVlozit_Click);
            // 
            // btnVybrat
            // 
            this.btnVybrat.Location = new System.Drawing.Point(106, 177);
            this.btnVybrat.Name = "btnVybrat";
            this.btnVybrat.Size = new System.Drawing.Size(75, 23);
            this.btnVybrat.TabIndex = 7;
            this.btnVybrat.Text = "Vybrat";
            this.btnVybrat.UseVisualStyleBackColor = true;
            this.btnVybrat.Click += new System.EventHandler(this.btnVybrat_Click);
            // 
            // platbav
            // 
            this.platbav.Location = new System.Drawing.Point(6, 206);
            this.platbav.Name = "platbav";
            this.platbav.Size = new System.Drawing.Size(94, 20);
            this.platbav.TabIndex = 8;
            this.platbav.Text = "Platba";
            // 
            // btnPlatba
            // 
            this.btnPlatba.Location = new System.Drawing.Point(106, 203);
            this.btnPlatba.Name = "btnPlatba";
            this.btnPlatba.Size = new System.Drawing.Size(75, 23);
            this.btnPlatba.TabIndex = 9;
            this.btnPlatba.Text = "Platba";
            this.btnPlatba.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label stavk;
        private System.Windows.Forms.Label jmeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown vyber;
        private System.Windows.Forms.DomainUpDown vlozv;
        private System.Windows.Forms.Button btnVybrat;
        private System.Windows.Forms.Button btnVlozit;
        private System.Windows.Forms.Button btnPlatba;
        private System.Windows.Forms.DomainUpDown platbav;
    }
}

