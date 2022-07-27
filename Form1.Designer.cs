
namespace RSA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonHien = new System.Windows.Forms.Button();
            this.buttonAn = new System.Windows.Forms.Button();
            this.buttonSk = new System.Windows.Forms.Button();
            this.buttonNn = new System.Windows.Forms.Button();
            this.textBoxKck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKbm = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonXtk = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxXtkD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGui = new System.Windows.Forms.Button();
            this.richTextBoxKkq = new System.Windows.Forms.RichTextBox();
            this.richTextBoxKvb = new System.Windows.Forms.RichTextBox();
            this.buttonKkvb = new System.Windows.Forms.Button();
            this.buttonKc = new System.Windows.Forms.Button();
            this.buttonKxkq = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxXkq = new System.Windows.Forms.RichTextBox();
            this.richTextBoxXvb = new System.Windows.Forms.RichTextBox();
            this.buttonXxt = new System.Windows.Forms.Button();
            this.buttonXc = new System.Windows.Forms.Button();
            this.buttonXxkq = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLmsk = new System.Windows.Forms.Button();
            this.buttonLmkvb = new System.Windows.Forms.Button();
            this.buttonNnhan = new System.Windows.Forms.Button();
            this.buttonNgui = new System.Windows.Forms.Button();
            this.buttonLmXtk = new System.Windows.Forms.Button();
            this.buttonLmXtck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonHien);
            this.groupBox1.Controls.Add(this.buttonAn);
            this.groupBox1.Controls.Add(this.buttonSk);
            this.groupBox1.Controls.Add(this.buttonNn);
            this.groupBox1.Controls.Add(this.textBoxKck);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxKbm);
            this.groupBox1.Controls.Add(this.textBoxQ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(527, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sinh Khóa";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(221, 87);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(125, 30);
            this.textBoxN.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(32, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "2. Số modul công khai n:";
            // 
            // buttonHien
            // 
            this.buttonHien.Location = new System.Drawing.Point(352, 136);
            this.buttonHien.Name = "buttonHien";
            this.buttonHien.Size = new System.Drawing.Size(81, 27);
            this.buttonHien.TabIndex = 12;
            this.buttonHien.Text = "Hiện";
            this.buttonHien.UseVisualStyleBackColor = true;
            this.buttonHien.Click += new System.EventHandler(this.buttonHien_Click);
            // 
            // buttonAn
            // 
            this.buttonAn.Location = new System.Drawing.Point(352, 136);
            this.buttonAn.Name = "buttonAn";
            this.buttonAn.Size = new System.Drawing.Size(81, 27);
            this.buttonAn.TabIndex = 11;
            this.buttonAn.Text = "Ẩn";
            this.buttonAn.UseVisualStyleBackColor = true;
            this.buttonAn.Click += new System.EventHandler(this.buttonAn_Click);
            // 
            // buttonSk
            // 
            this.buttonSk.Location = new System.Drawing.Point(539, 187);
            this.buttonSk.Name = "buttonSk";
            this.buttonSk.Size = new System.Drawing.Size(125, 29);
            this.buttonSk.TabIndex = 10;
            this.buttonSk.Text = "Sinh khóa";
            this.buttonSk.UseVisualStyleBackColor = true;
            this.buttonSk.Click += new System.EventHandler(this.buttonSk_Click);
            // 
            // buttonNn
            // 
            this.buttonNn.Location = new System.Drawing.Point(382, 187);
            this.buttonNn.Name = "buttonNn";
            this.buttonNn.Size = new System.Drawing.Size(125, 29);
            this.buttonNn.TabIndex = 9;
            this.buttonNn.Text = "Ngẫu nhiên";
            this.buttonNn.UseVisualStyleBackColor = true;
            this.buttonNn.Click += new System.EventHandler(this.buttonNn_Click);
            // 
            // textBoxKck
            // 
            this.textBoxKck.Location = new System.Drawing.Point(539, 87);
            this.textBoxKck.Name = "textBoxKck";
            this.textBoxKck.Size = new System.Drawing.Size(125, 30);
            this.textBoxKck.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(399, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Khóa công khai d:";
            // 
            // textBoxKbm
            // 
            this.textBoxKbm.Location = new System.Drawing.Point(221, 136);
            this.textBoxKbm.Name = "textBoxKbm";
            this.textBoxKbm.PasswordChar = '*';
            this.textBoxKbm.Size = new System.Drawing.Size(125, 30);
            this.textBoxKbm.TabIndex = 5;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(539, 40);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(125, 30);
            this.textBoxQ.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(510, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Q:";
            // 
            // textBoxP
            // 
            this.textBoxP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxP.ForeColor = System.Drawing.Color.Black;
            this.textBoxP.Location = new System.Drawing.Point(221, 40);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(125, 30);
            this.textBoxP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(32, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "3. Khóa bí mật e:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Chọn 2 số nguyên tố   P:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.buttonXtk);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBoxXtkD);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(527, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(697, 245);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xác thực khóa";
            // 
            // buttonXtk
            // 
            this.buttonXtk.Location = new System.Drawing.Point(496, 55);
            this.buttonXtk.Name = "buttonXtk";
            this.buttonXtk.Size = new System.Drawing.Size(125, 29);
            this.buttonXtk.TabIndex = 16;
            this.buttonXtk.Text = "Xác thực";
            this.buttonXtk.UseVisualStyleBackColor = true;
            this.buttonXtk.Click += new System.EventHandler(this.buttonXtk_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(51, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Khóa công khai d:";
            // 
            // textBoxXtkD
            // 
            this.textBoxXtkD.Location = new System.Drawing.Point(231, 55);
            this.textBoxXtkD.Name = "textBoxXtkD";
            this.textBoxXtkD.Size = new System.Drawing.Size(125, 30);
            this.textBoxXtkD.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.buttonGui);
            this.groupBox2.Controls.Add(this.richTextBoxKkq);
            this.groupBox2.Controls.Add(this.richTextBoxKvb);
            this.groupBox2.Controls.Add(this.buttonKkvb);
            this.groupBox2.Controls.Add(this.buttonKc);
            this.groupBox2.Controls.Add(this.buttonKxkq);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(527, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 273);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ký văn bản";
            // 
            // buttonGui
            // 
            this.buttonGui.Location = new System.Drawing.Point(570, 144);
            this.buttonGui.Name = "buttonGui";
            this.buttonGui.Size = new System.Drawing.Size(95, 29);
            this.buttonGui.TabIndex = 16;
            this.buttonGui.Text = "Gửi đi";
            this.buttonGui.UseVisualStyleBackColor = true;
            this.buttonGui.Click += new System.EventHandler(this.buttonGui_Click);
            // 
            // richTextBoxKkq
            // 
            this.richTextBoxKkq.Location = new System.Drawing.Point(154, 144);
            this.richTextBoxKkq.Name = "richTextBoxKkq";
            this.richTextBoxKkq.Size = new System.Drawing.Size(391, 77);
            this.richTextBoxKkq.TabIndex = 14;
            this.richTextBoxKkq.Text = "";
            // 
            // richTextBoxKvb
            // 
            this.richTextBoxKvb.Location = new System.Drawing.Point(154, 44);
            this.richTextBoxKvb.Name = "richTextBoxKvb";
            this.richTextBoxKvb.Size = new System.Drawing.Size(391, 77);
            this.richTextBoxKvb.TabIndex = 13;
            this.richTextBoxKvb.Text = "";
            // 
            // buttonKkvb
            // 
            this.buttonKkvb.Location = new System.Drawing.Point(540, 244);
            this.buttonKkvb.Name = "buttonKkvb";
            this.buttonKkvb.Size = new System.Drawing.Size(125, 29);
            this.buttonKkvb.TabIndex = 11;
            this.buttonKkvb.Text = "Ký văn bản";
            this.buttonKkvb.UseVisualStyleBackColor = true;
            this.buttonKkvb.Click += new System.EventHandler(this.buttonKkvb_Click);
            // 
            // buttonKc
            // 
            this.buttonKc.Location = new System.Drawing.Point(570, 47);
            this.buttonKc.Name = "buttonKc";
            this.buttonKc.Size = new System.Drawing.Size(94, 29);
            this.buttonKc.TabIndex = 10;
            this.buttonKc.Text = "Chọn";
            this.buttonKc.UseVisualStyleBackColor = true;
            this.buttonKc.Click += new System.EventHandler(this.buttonKc_Click);
            // 
            // buttonKxkq
            // 
            this.buttonKxkq.Location = new System.Drawing.Point(409, 244);
            this.buttonKxkq.Name = "buttonKxkq";
            this.buttonKxkq.Size = new System.Drawing.Size(125, 29);
            this.buttonKxkq.TabIndex = 9;
            this.buttonKxkq.Text = "Xuất kết quả";
            this.buttonKxkq.UseVisualStyleBackColor = true;
            this.buttonKxkq.Click += new System.EventHandler(this.buttonKxkq_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(32, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kết quả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(30, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Văn bản";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.richTextBoxXkq);
            this.groupBox3.Controls.Add(this.richTextBoxXvb);
            this.groupBox3.Controls.Add(this.buttonXxt);
            this.groupBox3.Controls.Add(this.buttonXc);
            this.groupBox3.Controls.Add(this.buttonXxkq);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(527, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(697, 273);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xác thực chữ ký";
            // 
            // richTextBoxXkq
            // 
            this.richTextBoxXkq.Location = new System.Drawing.Point(154, 147);
            this.richTextBoxXkq.Name = "richTextBoxXkq";
            this.richTextBoxXkq.Size = new System.Drawing.Size(391, 77);
            this.richTextBoxXkq.TabIndex = 15;
            this.richTextBoxXkq.Text = "";
            // 
            // richTextBoxXvb
            // 
            this.richTextBoxXvb.Location = new System.Drawing.Point(154, 47);
            this.richTextBoxXvb.Name = "richTextBoxXvb";
            this.richTextBoxXvb.Size = new System.Drawing.Size(391, 77);
            this.richTextBoxXvb.TabIndex = 14;
            this.richTextBoxXvb.Text = "";
            // 
            // buttonXxt
            // 
            this.buttonXxt.Location = new System.Drawing.Point(538, 244);
            this.buttonXxt.Name = "buttonXxt";
            this.buttonXxt.Size = new System.Drawing.Size(125, 29);
            this.buttonXxt.TabIndex = 11;
            this.buttonXxt.Text = "Xác thực";
            this.buttonXxt.UseVisualStyleBackColor = true;
            this.buttonXxt.Click += new System.EventHandler(this.buttonXxt_Click);
            // 
            // buttonXc
            // 
            this.buttonXc.Location = new System.Drawing.Point(569, 47);
            this.buttonXc.Name = "buttonXc";
            this.buttonXc.Size = new System.Drawing.Size(94, 29);
            this.buttonXc.TabIndex = 10;
            this.buttonXc.Text = "Chọn";
            this.buttonXc.UseVisualStyleBackColor = true;
            this.buttonXc.Click += new System.EventHandler(this.buttonXc_Click);
            // 
            // buttonXxkq
            // 
            this.buttonXxkq.Location = new System.Drawing.Point(407, 244);
            this.buttonXxkq.Name = "buttonXxkq";
            this.buttonXxkq.Size = new System.Drawing.Size(125, 29);
            this.buttonXxkq.TabIndex = 9;
            this.buttonXxkq.Text = "Xuất kết quả";
            this.buttonXxkq.UseVisualStyleBackColor = true;
            this.buttonXxkq.Click += new System.EventHandler(this.buttonXxkq_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(30, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kết quả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(30, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Văn bản";
            // 
            // buttonLmsk
            // 
            this.buttonLmsk.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonLmsk.Location = new System.Drawing.Point(1377, 46);
            this.buttonLmsk.Name = "buttonLmsk";
            this.buttonLmsk.Size = new System.Drawing.Size(125, 29);
            this.buttonLmsk.TabIndex = 13;
            this.buttonLmsk.Text = "Làm mới";
            this.buttonLmsk.UseVisualStyleBackColor = true;
            this.buttonLmsk.Click += new System.EventHandler(this.buttonLmsk_Click);
            // 
            // buttonLmkvb
            // 
            this.buttonLmkvb.Enabled = false;
            this.buttonLmkvb.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonLmkvb.Location = new System.Drawing.Point(1377, 346);
            this.buttonLmkvb.Name = "buttonLmkvb";
            this.buttonLmkvb.Size = new System.Drawing.Size(125, 29);
            this.buttonLmkvb.TabIndex = 14;
            this.buttonLmkvb.Text = "Làm mới";
            this.buttonLmkvb.UseVisualStyleBackColor = true;
            this.buttonLmkvb.Click += new System.EventHandler(this.buttonLmkvb_Click);
            // 
            // buttonNnhan
            // 
            this.buttonNnhan.Location = new System.Drawing.Point(223, 40);
            this.buttonNnhan.Name = "buttonNnhan";
            this.buttonNnhan.Size = new System.Drawing.Size(127, 40);
            this.buttonNnhan.TabIndex = 15;
            this.buttonNnhan.Text = "Người nhận";
            this.buttonNnhan.UseVisualStyleBackColor = true;
            this.buttonNnhan.Click += new System.EventHandler(this.buttonNnhan_Click);
            // 
            // buttonNgui
            // 
            this.buttonNgui.Location = new System.Drawing.Point(70, 40);
            this.buttonNgui.Name = "buttonNgui";
            this.buttonNgui.Size = new System.Drawing.Size(127, 40);
            this.buttonNgui.TabIndex = 16;
            this.buttonNgui.Text = "Người gửi";
            this.buttonNgui.UseVisualStyleBackColor = true;
            this.buttonNgui.Click += new System.EventHandler(this.buttonNgui_Click);
            // 
            // buttonLmXtk
            // 
            this.buttonLmXtk.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonLmXtk.Location = new System.Drawing.Point(1377, 46);
            this.buttonLmXtk.Name = "buttonLmXtk";
            this.buttonLmXtk.Size = new System.Drawing.Size(125, 29);
            this.buttonLmXtk.TabIndex = 18;
            this.buttonLmXtk.Text = "Làm mới ";
            this.buttonLmXtk.UseVisualStyleBackColor = true;
            this.buttonLmXtk.Click += new System.EventHandler(this.buttonLmXtk_Click);
            // 
            // buttonLmXtck
            // 
            this.buttonLmXtck.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonLmXtck.Location = new System.Drawing.Point(1377, 346);
            this.buttonLmXtck.Name = "buttonLmXtck";
            this.buttonLmXtck.Size = new System.Drawing.Size(125, 29);
            this.buttonLmXtck.TabIndex = 19;
            this.buttonLmXtck.Text = "Làm mới ";
            this.buttonLmXtck.UseVisualStyleBackColor = true;
            this.buttonLmXtck.Click += new System.EventHandler(this.buttonLmXtck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1786, 1055);
            this.Controls.Add(this.buttonLmXtck);
            this.Controls.Add(this.buttonLmXtk);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonNgui);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonNnhan);
            this.Controls.Add(this.buttonLmkvb);
            this.Controls.Add(this.buttonLmsk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "RSA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKbm;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKck;
        private System.Windows.Forms.Button buttonSk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonKkvb;
        private System.Windows.Forms.Button buttonKc;
        private System.Windows.Forms.Button buttonKxkq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonXxt;
        private System.Windows.Forms.Button buttonXc;
        private System.Windows.Forms.Button buttonXxkq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonNn;
        private System.Windows.Forms.Button buttonHien;
        private System.Windows.Forms.Button buttonAn;
        private System.Windows.Forms.RichTextBox richTextBoxKvb;
        private System.Windows.Forms.RichTextBox richTextBoxKkq;
        private System.Windows.Forms.RichTextBox richTextBoxXkq;
        private System.Windows.Forms.RichTextBox richTextBoxXvb;
        private System.Windows.Forms.Button buttonLmsk;
        private System.Windows.Forms.Button buttonLmkvb;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonNnhan;
        private System.Windows.Forms.Button buttonNgui;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxXtkD;
        private System.Windows.Forms.Button buttonXtk;
        private System.Windows.Forms.Button buttonLmXtk;
        private System.Windows.Forms.Button buttonLmXtck;
        private System.Windows.Forms.Button buttonGui;
    }
}

