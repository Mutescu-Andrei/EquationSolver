namespace WindowsFormsApp1
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
            this.camp_c = new System.Windows.Forms.TextBox();
            this.camp_b = new System.Windows.Forms.TextBox();
            this.camp_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // camp_c
            // 
            this.camp_c.BackColor = System.Drawing.Color.Red;
            this.camp_c.Location = new System.Drawing.Point(92, 345);
            this.camp_c.Name = "camp_c";
            this.camp_c.Size = new System.Drawing.Size(100, 22);
            this.camp_c.TabIndex = 0;
            this.camp_c.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // camp_b
            // 
            this.camp_b.BackColor = System.Drawing.Color.Red;
            this.camp_b.Location = new System.Drawing.Point(93, 239);
            this.camp_b.Name = "camp_b";
            this.camp_b.Size = new System.Drawing.Size(100, 22);
            this.camp_b.TabIndex = 1;
            this.camp_b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // camp_a
            // 
            this.camp_a.BackColor = System.Drawing.Color.Red;
            this.camp_a.Location = new System.Drawing.Point(93, 132);
            this.camp_a.Name = "camp_a";
            this.camp_a.Size = new System.Drawing.Size(100, 22);
            this.camp_a.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "a=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rez
            // 
            this.rez.BackColor = System.Drawing.Color.DodgerBlue;
            this.rez.Location = new System.Drawing.Point(499, 132);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(289, 202);
            this.rez.TabIndex = 4;
            this.rez.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "c=";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label4.Location = new System.Drawing.Point(193, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 77);
            this.label4.TabIndex = 7;
            this.label4.Text = "Equation system solver: ax^2+bx+c";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // But
            // 
            this.But.BackColor = System.Drawing.Color.Red;
            this.But.Location = new System.Drawing.Point(254, 194);
            this.But.Name = "But";
            this.But.Size = new System.Drawing.Size(215, 97);
            this.But.TabIndex = 8;
            this.But.Text = "x";
            this.But.UseVisualStyleBackColor = false;
            this.But.Click += new System.EventHandler(this.Rezolva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.But);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.camp_a);
            this.Controls.Add(this.camp_b);
            this.Controls.Add(this.camp_c);
            this.Name = "Form1";
            this.Text = "ec_gr_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox camp_c;
        private System.Windows.Forms.TextBox camp_b;
        private System.Windows.Forms.TextBox camp_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button But;
    }
}

