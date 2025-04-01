namespace Aplikasi1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtHasil = new TextBox();
            lblHasil = new Label();
            btnJumlah = new Button();
            txtB = new TextBox();
            txtA = new TextBox();
            lblB = new Label();
            lblA = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHasil);
            groupBox1.Controls.Add(lblHasil);
            groupBox1.Controls.Add(btnJumlah);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(lblB);
            groupBox1.Controls.Add(lblA);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(254, 160);
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(150, 31);
            txtHasil.TabIndex = 6;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Location = new Point(30, 160);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(198, 25);
            lblHasil.TabIndex = 5;
            lblHasil.Text = "Hasil Nilai A + B Adalah";
            // 
            // btnJumlah
            // 
            btnJumlah.Location = new Point(451, 40);
            btnJumlah.Name = "btnJumlah";
            btnJumlah.Size = new Size(139, 151);
            btnJumlah.TabIndex = 4;
            btnJumlah.Text = "Jumlahkan";
            btnJumlah.UseVisualStyleBackColor = true;
            btnJumlah.Click += btnJumlah_Click;
            // 
            // txtB
            // 
            txtB.Location = new Point(254, 104);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(254, 40);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 2;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(28, 104);
            lblB.Name = "lblB";
            lblB.Size = new Size(137, 25);
            lblB.TabIndex = 1;
            lblB.Text = "Masukan Nilai B";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(28, 40);
            lblA.Name = "lblA";
            lblA.Size = new Size(139, 25);
            lblA.TabIndex = 0;
            lblA.Text = "Masukan Nilai A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 260);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Aplikasi Perhitungan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblB;
        private Label lblA;
        private Button btnJumlah;
        private TextBox txtB;
        private TextBox txtA;
        private TextBox txtHasil;
        private Label lblHasil;
    }
}
