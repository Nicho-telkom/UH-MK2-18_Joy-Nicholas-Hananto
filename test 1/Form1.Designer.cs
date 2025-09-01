namespace test_1
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
            lblJudul = new Label();
            grpInput = new GroupBox();
            btnHitung = new Button();
            txtTinggi = new TextBox();
            lblTinggi = new Label();
            txtBerat = new TextBox();
            lblBerat = new Label();
            grpHasil = new GroupBox();
            lblHasil = new Label();
            grpInput.SuspendLayout();
            grpHasil.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(295, 49);
            lblJudul.Name = "lblJudul";
            lblJudul.RightToLeft = RightToLeft.Yes;
            lblJudul.Size = new Size(163, 31);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "BMI Calculator";
            lblJudul.Click += lblJudul_Click;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnHitung);
            grpInput.Controls.Add(txtTinggi);
            grpInput.Controls.Add(lblTinggi);
            grpInput.Controls.Add(txtBerat);
            grpInput.Controls.Add(lblBerat);
            grpInput.Location = new Point(173, 99);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(390, 180);
            grpInput.TabIndex = 1;
            grpInput.TabStop = false;
            grpInput.Text = "Masukan Data";
            grpInput.Enter += groupBox1_Enter;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(111, 125);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(94, 29);
            btnHitung.TabIndex = 4;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // txtTinggi
            // 
            txtTinggi.Location = new Point(111, 76);
            txtTinggi.Name = "txtTinggi";
            txtTinggi.Size = new Size(240, 27);
            txtTinggi.TabIndex = 3;
            txtTinggi.TabStop = false;
            // 
            // lblTinggi
            // 
            lblTinggi.AutoSize = true;
            lblTinggi.Location = new Point(6, 77);
            lblTinggi.Name = "lblTinggi";
            lblTinggi.Size = new Size(83, 20);
            lblTinggi.TabIndex = 2;
            lblTinggi.Text = "Tinggi(CM)";
            // 
            // txtBerat
            // 
            txtBerat.Location = new Point(111, 31);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(240, 27);
            txtBerat.TabIndex = 1;
            txtBerat.TabStop = false;
            // 
            // lblBerat
            // 
            lblBerat.AutoSize = true;
            lblBerat.Location = new Point(6, 34);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(72, 20);
            lblBerat.TabIndex = 0;
            lblBerat.Text = "Berat(KG)";
            lblBerat.Click += label2_Click;
            // 
            // grpHasil
            // 
            grpHasil.Controls.Add(lblHasil);
            grpHasil.Location = new Point(173, 295);
            grpHasil.Name = "grpHasil";
            grpHasil.Size = new Size(390, 86);
            grpHasil.TabIndex = 2;
            grpHasil.TabStop = false;
            grpHasil.Text = "Hasil";
            grpHasil.Enter += this.grpHasil_Enter;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHasil.Location = new Point(6, 33);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(42, 20);
            lblHasil.TabIndex = 0;
            lblHasil.Text = "Hasil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpHasil);
            Controls.Add(grpInput);
            Controls.Add(lblJudul);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpHasil.ResumeLayout(false);
            grpHasil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private GroupBox grpInput;
        private Label lblBerat;
        private Button btnHitung;
        private TextBox txtTinggi;
        private Label lblTinggi;
        private TextBox txtBerat;
        private GroupBox grpHasil;
        private Label lblHasil;
    }
}
