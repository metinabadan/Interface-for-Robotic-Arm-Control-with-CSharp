﻿
namespace Robotik_Kol___2
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbl_comport = new System.Windows.Forms.Label();
            this.combobox_comport = new System.Windows.Forms.ComboBox();
            this.lbl_bauderate = new System.Windows.Forms.Label();
            this.lbl_databit = new System.Windows.Forms.Label();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.btn_baglantikes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_baglantidurumu = new System.Windows.Forms.Label();
            this.btn_baglantidurumu = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.lbl_anlikveri = new System.Windows.Forms.Label();
            this.txtbox_anlikveri = new System.Windows.Forms.TextBox();
            this.btn_kontrolubaslat = new System.Windows.Forms.Button();
            this.btn_s1_sol = new System.Windows.Forms.Button();
            this.btn_s1_sag = new System.Windows.Forms.Button();
            this.btn_s2_sag = new System.Windows.Forms.Button();
            this.btn_s2_sol = new System.Windows.Forms.Button();
            this.btn_s4_sag = new System.Windows.Forms.Button();
            this.btn_s4_sol = new System.Windows.Forms.Button();
            this.btn_s3_sag = new System.Windows.Forms.Button();
            this.btn_s3_sol = new System.Windows.Forms.Button();
            this.btn_s6_sag = new System.Windows.Forms.Button();
            this.btn_s6_sol = new System.Windows.Forms.Button();
            this.btn_s5_sag = new System.Windows.Forms.Button();
            this.btn_s5_sol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_comport
            // 
            this.lbl_comport.AutoSize = true;
            this.lbl_comport.Location = new System.Drawing.Point(25, 9);
            this.lbl_comport.Name = "lbl_comport";
            this.lbl_comport.Size = new System.Drawing.Size(92, 20);
            this.lbl_comport.TabIndex = 0;
            this.lbl_comport.Text = "COM PORT";
            // 
            // combobox_comport
            // 
            this.combobox_comport.FormattingEnabled = true;
            this.combobox_comport.Location = new System.Drawing.Point(12, 32);
            this.combobox_comport.Name = "combobox_comport";
            this.combobox_comport.Size = new System.Drawing.Size(121, 28);
            this.combobox_comport.TabIndex = 1;
            // 
            // lbl_bauderate
            // 
            this.lbl_bauderate.AutoSize = true;
            this.lbl_bauderate.Location = new System.Drawing.Point(147, 9);
            this.lbl_bauderate.Name = "lbl_bauderate";
            this.lbl_bauderate.Size = new System.Drawing.Size(162, 20);
            this.lbl_bauderate.TabIndex = 2;
            this.lbl_bauderate.Text = "BAUDE RATE - 9600";
            // 
            // lbl_databit
            // 
            this.lbl_databit.AutoSize = true;
            this.lbl_databit.Location = new System.Drawing.Point(325, 9);
            this.lbl_databit.Name = "lbl_databit";
            this.lbl_databit.Size = new System.Drawing.Size(103, 20);
            this.lbl_databit.TabIndex = 3;
            this.lbl_databit.Text = "DATA BIT - 8";
            // 
            // btn_baglan
            // 
            this.btn_baglan.Location = new System.Drawing.Point(853, 4);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(146, 30);
            this.btn_baglan.TabIndex = 4;
            this.btn_baglan.Text = "BAĞLAN";
            this.btn_baglan.UseVisualStyleBackColor = true;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // btn_baglantikes
            // 
            this.btn_baglantikes.Location = new System.Drawing.Point(1005, 4);
            this.btn_baglantikes.Name = "btn_baglantikes";
            this.btn_baglantikes.Size = new System.Drawing.Size(163, 30);
            this.btn_baglantikes.TabIndex = 5;
            this.btn_baglantikes.Text = "BAĞLANTIYI KES";
            this.btn_baglantikes.UseVisualStyleBackColor = true;
            this.btn_baglantikes.Click += new System.EventHandler(this.btn_baglantikes_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_baglantidurumu
            // 
            this.lbl_baglantidurumu.AutoSize = true;
            this.lbl_baglantidurumu.Location = new System.Drawing.Point(849, 40);
            this.lbl_baglantidurumu.Name = "lbl_baglantidurumu";
            this.lbl_baglantidurumu.Size = new System.Drawing.Size(166, 20);
            this.lbl_baglantidurumu.TabIndex = 6;
            this.lbl_baglantidurumu.Text = "BAĞLANTI DURUMU";
            // 
            // btn_baglantidurumu
            // 
            this.btn_baglantidurumu.Location = new System.Drawing.Point(1056, 40);
            this.btn_baglantidurumu.Name = "btn_baglantidurumu";
            this.btn_baglantidurumu.Size = new System.Drawing.Size(75, 23);
            this.btn_baglantidurumu.TabIndex = 7;
            this.btn_baglantidurumu.Text = "                      ";
            this.btn_baglantidurumu.UseVisualStyleBackColor = true;
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(12, 67);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 32);
            this.btn_yenile.TabIndex = 0;
            this.btn_yenile.Text = "YENİLE";
            this.btn_yenile.UseMnemonic = false;
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // lbl_anlikveri
            // 
            this.lbl_anlikveri.AutoSize = true;
            this.lbl_anlikveri.Location = new System.Drawing.Point(492, 79);
            this.lbl_anlikveri.Name = "lbl_anlikveri";
            this.lbl_anlikveri.Size = new System.Drawing.Size(98, 20);
            this.lbl_anlikveri.TabIndex = 8;
            this.lbl_anlikveri.Text = "ANLIK VERİ";
            // 
            // txtbox_anlikveri
            // 
            this.txtbox_anlikveri.Location = new System.Drawing.Point(490, 102);
            this.txtbox_anlikveri.Name = "txtbox_anlikveri";
            this.txtbox_anlikveri.Size = new System.Drawing.Size(100, 26);
            this.txtbox_anlikveri.TabIndex = 9;
            // 
            // btn_kontrolubaslat
            // 
            this.btn_kontrolubaslat.Location = new System.Drawing.Point(469, 387);
            this.btn_kontrolubaslat.Name = "btn_kontrolubaslat";
            this.btn_kontrolubaslat.Size = new System.Drawing.Size(146, 103);
            this.btn_kontrolubaslat.TabIndex = 10;
            this.btn_kontrolubaslat.Text = "KONTROLÜ BAŞLAT";
            this.btn_kontrolubaslat.UseVisualStyleBackColor = true;
            this.btn_kontrolubaslat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_kontrolubaslat_KeyDown);
            // 
            // btn_s1_sol
            // 
            this.btn_s1_sol.Location = new System.Drawing.Point(12, 154);
            this.btn_s1_sol.Name = "btn_s1_sol";
            this.btn_s1_sol.Size = new System.Drawing.Size(85, 32);
            this.btn_s1_sol.TabIndex = 11;
            this.btn_s1_sol.Text = "S1-SOL";
            this.btn_s1_sol.UseVisualStyleBackColor = true;
            this.btn_s1_sol.Click += new System.EventHandler(this.btn_s1_sol_Click);
            // 
            // btn_s1_sag
            // 
            this.btn_s1_sag.Location = new System.Drawing.Point(103, 154);
            this.btn_s1_sag.Name = "btn_s1_sag";
            this.btn_s1_sag.Size = new System.Drawing.Size(83, 32);
            this.btn_s1_sag.TabIndex = 12;
            this.btn_s1_sag.Text = "S1-SAG";
            this.btn_s1_sag.UseVisualStyleBackColor = true;
            this.btn_s1_sag.Click += new System.EventHandler(this.btn_s1_sag_Click);
            // 
            // btn_s2_sag
            // 
            this.btn_s2_sag.Location = new System.Drawing.Point(103, 192);
            this.btn_s2_sag.Name = "btn_s2_sag";
            this.btn_s2_sag.Size = new System.Drawing.Size(83, 33);
            this.btn_s2_sag.TabIndex = 15;
            this.btn_s2_sag.Text = "S2-SAG";
            this.btn_s2_sag.UseVisualStyleBackColor = true;
            this.btn_s2_sag.Click += new System.EventHandler(this.btn_s2_sag_Click);
            // 
            // btn_s2_sol
            // 
            this.btn_s2_sol.Location = new System.Drawing.Point(12, 192);
            this.btn_s2_sol.Name = "btn_s2_sol";
            this.btn_s2_sol.Size = new System.Drawing.Size(85, 33);
            this.btn_s2_sol.TabIndex = 14;
            this.btn_s2_sol.Text = "S2-SOL";
            this.btn_s2_sol.UseVisualStyleBackColor = true;
            this.btn_s2_sol.Click += new System.EventHandler(this.btn_s2_sol_Click);
            // 
            // btn_s4_sag
            // 
            this.btn_s4_sag.Location = new System.Drawing.Point(103, 269);
            this.btn_s4_sag.Name = "btn_s4_sag";
            this.btn_s4_sag.Size = new System.Drawing.Size(83, 33);
            this.btn_s4_sag.TabIndex = 19;
            this.btn_s4_sag.Text = "S4-SAG";
            this.btn_s4_sag.UseVisualStyleBackColor = true;
            this.btn_s4_sag.Click += new System.EventHandler(this.btn_s4_sag_Click);
            // 
            // btn_s4_sol
            // 
            this.btn_s4_sol.Location = new System.Drawing.Point(12, 269);
            this.btn_s4_sol.Name = "btn_s4_sol";
            this.btn_s4_sol.Size = new System.Drawing.Size(85, 33);
            this.btn_s4_sol.TabIndex = 18;
            this.btn_s4_sol.Text = "S4-SOL";
            this.btn_s4_sol.UseVisualStyleBackColor = true;
            this.btn_s4_sol.Click += new System.EventHandler(this.btn_s4_sol_Click);
            // 
            // btn_s3_sag
            // 
            this.btn_s3_sag.Location = new System.Drawing.Point(103, 231);
            this.btn_s3_sag.Name = "btn_s3_sag";
            this.btn_s3_sag.Size = new System.Drawing.Size(83, 32);
            this.btn_s3_sag.TabIndex = 17;
            this.btn_s3_sag.Text = "S3-SAG";
            this.btn_s3_sag.UseVisualStyleBackColor = true;
            this.btn_s3_sag.Click += new System.EventHandler(this.btn_s3_sag_Click);
            // 
            // btn_s3_sol
            // 
            this.btn_s3_sol.Location = new System.Drawing.Point(12, 231);
            this.btn_s3_sol.Name = "btn_s3_sol";
            this.btn_s3_sol.Size = new System.Drawing.Size(85, 32);
            this.btn_s3_sol.TabIndex = 16;
            this.btn_s3_sol.Text = "S3-SOL";
            this.btn_s3_sol.UseVisualStyleBackColor = true;
            this.btn_s3_sol.Click += new System.EventHandler(this.btn_s3_sol_Click);
            // 
            // btn_s6_sag
            // 
            this.btn_s6_sag.Location = new System.Drawing.Point(103, 347);
            this.btn_s6_sag.Name = "btn_s6_sag";
            this.btn_s6_sag.Size = new System.Drawing.Size(83, 30);
            this.btn_s6_sag.TabIndex = 23;
            this.btn_s6_sag.Text = "S6-SAG";
            this.btn_s6_sag.UseVisualStyleBackColor = true;
            this.btn_s6_sag.Click += new System.EventHandler(this.btn_s6_sag_Click);
            // 
            // btn_s6_sol
            // 
            this.btn_s6_sol.Location = new System.Drawing.Point(12, 347);
            this.btn_s6_sol.Name = "btn_s6_sol";
            this.btn_s6_sol.Size = new System.Drawing.Size(85, 30);
            this.btn_s6_sol.TabIndex = 22;
            this.btn_s6_sol.Text = "S6-SOL";
            this.btn_s6_sol.UseVisualStyleBackColor = true;
            this.btn_s6_sol.Click += new System.EventHandler(this.btn_s6_sol_Click);
            // 
            // btn_s5_sag
            // 
            this.btn_s5_sag.Location = new System.Drawing.Point(103, 308);
            this.btn_s5_sag.Name = "btn_s5_sag";
            this.btn_s5_sag.Size = new System.Drawing.Size(83, 33);
            this.btn_s5_sag.TabIndex = 21;
            this.btn_s5_sag.Text = "S5-SAG";
            this.btn_s5_sag.UseVisualStyleBackColor = true;
            this.btn_s5_sag.Click += new System.EventHandler(this.btn_s5_sag_Click);
            // 
            // btn_s5_sol
            // 
            this.btn_s5_sol.Location = new System.Drawing.Point(12, 308);
            this.btn_s5_sol.Name = "btn_s5_sol";
            this.btn_s5_sol.Size = new System.Drawing.Size(85, 33);
            this.btn_s5_sol.TabIndex = 20;
            this.btn_s5_sol.Text = "S5-SOL";
            this.btn_s5_sol.UseVisualStyleBackColor = true;
            this.btn_s5_sol.Click += new System.EventHandler(this.btn_s5_sol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 520);
            this.Controls.Add(this.btn_s6_sag);
            this.Controls.Add(this.btn_s6_sol);
            this.Controls.Add(this.btn_s5_sag);
            this.Controls.Add(this.btn_s5_sol);
            this.Controls.Add(this.btn_s4_sag);
            this.Controls.Add(this.btn_s4_sol);
            this.Controls.Add(this.btn_s3_sag);
            this.Controls.Add(this.btn_s3_sol);
            this.Controls.Add(this.btn_s2_sag);
            this.Controls.Add(this.btn_s2_sol);
            this.Controls.Add(this.btn_s1_sag);
            this.Controls.Add(this.btn_s1_sol);
            this.Controls.Add(this.btn_kontrolubaslat);
            this.Controls.Add(this.txtbox_anlikveri);
            this.Controls.Add(this.lbl_anlikveri);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_baglantidurumu);
            this.Controls.Add(this.lbl_baglantidurumu);
            this.Controls.Add(this.btn_baglantikes);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.lbl_databit);
            this.Controls.Add(this.lbl_bauderate);
            this.Controls.Add(this.combobox_comport);
            this.Controls.Add(this.lbl_comport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl_comport;
        private System.Windows.Forms.ComboBox combobox_comport;
        private System.Windows.Forms.Label lbl_bauderate;
        private System.Windows.Forms.Label lbl_databit;
        private System.Windows.Forms.Button btn_baglan;
        private System.Windows.Forms.Button btn_baglantikes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_baglantidurumu;
        private System.Windows.Forms.Button btn_baglantidurumu;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Label lbl_anlikveri;
        private System.Windows.Forms.TextBox txtbox_anlikveri;
        private System.Windows.Forms.Button btn_kontrolubaslat;
        private System.Windows.Forms.Button btn_s1_sol;
        private System.Windows.Forms.Button btn_s1_sag;
        private System.Windows.Forms.Button btn_s2_sag;
        private System.Windows.Forms.Button btn_s2_sol;
        private System.Windows.Forms.Button btn_s4_sag;
        private System.Windows.Forms.Button btn_s4_sol;
        private System.Windows.Forms.Button btn_s3_sag;
        private System.Windows.Forms.Button btn_s3_sol;
        private System.Windows.Forms.Button btn_s6_sag;
        private System.Windows.Forms.Button btn_s6_sol;
        private System.Windows.Forms.Button btn_s5_sag;
        private System.Windows.Forms.Button btn_s5_sol;
    }
}
