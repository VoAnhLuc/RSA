using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Security.Cryptography;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            buttonLmXtk.Visible = false;
            buttonLmXtck.Visible = false;
            buttonNnhan.Visible = false;
            buttonGui.Visible = false;
        }
        OpenFileDialog open;
        SaveFileDialog save;       
        static Boolean isPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int gcd(int a, int b)
        {
            // Nếu a = 0 => ucln(a,b) = b
            // Nếu b = 0 => ucln(a,b) = a
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b; // a = a - b
                }
                else
                {
                    b -= a;
                }
            }
            return a; // return a or b, bởi vì lúc này a và b bằng nhau
        }
        static int gcd_extend(int a, int b, ref int x, ref int y)
        {
            if (b == 0)
            {
                x = 1;
                y = 0;
                return a;
            }
            int x1 = 0, y1 = 0;
            int gcd = gcd_extend(b, a % b, ref x1, ref y1);
            x = y1;
            y = x1 - (a / b) * y1;
            return gcd;
        }
        static int modulo_inverse_euclidean(int n, int m)
        {
            int x = 0, y = 0;
            if (gcd_extend(n, m, ref x, ref y) != 1) return -1;
            return (x % m + m) % m;
        }
        public int modulo(int mx, int ex, int nx)
        {

            //Sử dụng thuật toán "bình phương nhân"
            //Chuyển e sang hệ nhị phân
            int[] a = new int[100];
            int k = 0;
            do
            {
                a[k] = ex % 2;
                k++;
                ex = ex / 2;
            }
            while (ex != 0);
            //Quá trình lấy dư
            int kq = 1;
            for (int i = k - 1; i >= 0; i--)
            {
                kq = (kq * kq) % nx;
                if (a[i] == 1)
                    kq = (kq * mx) % nx;
            }
            return kq;
        }
        private void buttonNn_Click(object sender, EventArgs e)
        {
            int P;
            int Q;
            do { 
                Random number = new Random();
                P = number.Next(0, 100);
                int x = P + 10;
                int y = P - 10;
                Q = number.Next(y, x);           
                textBoxP.Text = P.ToString();
                textBoxQ.Text = Q.ToString();
            }
            while (!isPrimeNumber(P) || !isPrimeNumber(Q) || P == Q || (P == 2 && Q == 3) || (P == 3 & Q == 2));               
        }

        private void buttonSk_Click(object sender, EventArgs e)
        {
            if( textBoxP.Text != "" && textBoxQ.Text != "" && ( (textBoxP.Text != "2" || textBoxQ.Text != "3") && (textBoxP.Text != "3" || textBoxQ.Text != "2") ) )
            {
                
                int P = Convert.ToInt32(textBoxP.Text);
                int Q = Convert.ToInt32(textBoxQ.Text);
                if(isPrimeNumber(P) && isPrimeNumber(Q))
                {
                    int On = (P - 1) * (Q - 1);
                    int N = P * Q;
                    List<int> maKhoa = new List<int>();
                    for (int i = 2; i < On; i++)
                    {                  
                        if( gcd(i,On) == 1 )
                        {                      
                            maKhoa.Add(i);
                        }
                    }
                    Random mk = new Random();
                    int Kbm = mk.Next(0 ,maKhoa.Count);
                    textBoxKbm.Text = maKhoa[Kbm].ToString();
                    textBoxKck.Text = modulo_inverse_euclidean(Convert.ToInt32(textBoxKbm.Text), On).ToString();
                    textBoxN.Text = N.ToString();

                    groupBox2.Enabled = true;                   
                    buttonLmkvb.Enabled = true;
                    textBoxN.ReadOnly = textBoxKck.ReadOnly = textBoxKbm.ReadOnly = textBoxP.ReadOnly = textBoxQ.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("P và Q không phải số nguyên tố!", "Thông báo",
                                MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống !", "Thông báo",
                                MessageBoxButtons.OK);
            }
        }

        private void buttonHien_Click(object sender, EventArgs e)
        {
            if(textBoxKbm.PasswordChar == '*')
            {
                buttonAn.BringToFront();
                textBoxKbm.PasswordChar = '\0';
            }
        }

        private void buttonAn_Click(object sender, EventArgs e)
        {
            if (textBoxKbm.PasswordChar == '\0')
            {
                buttonHien.BringToFront();
                textBoxKbm.PasswordChar = '*';  
            }
        }

        private void buttonKc_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "office files|*.doc;*.xls;*.ppt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                richTextBoxKvb.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void buttonXc_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "doc files (*.doc)|*.doc|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                richTextBoxXvb.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void buttonKxkq_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            save.Filter = "doc files (*.doc)|*.doc|All files (*.*)|*.*";
            save.RestoreDirectory = true;
            if(save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                write.WriteLine(richTextBoxKkq.Text);
                write.Close();
            }
        }

        private void buttonXxkq_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            save.Filter = "doc files (*.doc)|*.doc|All files (*.*)|*.*";
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                write.WriteLine(richTextBoxXkq.Text);
                write.Close();
            }
        }

        // giai ma 
        private void buttonXxt_Click(object sender, EventArgs e)
        {  
            if( (richTextBoxXvb.Text).Trim() == (richTextBoxKkq.Text).Trim() && richTextBoxXvb.Text != string.Empty)
            {
                int SoD = Convert.ToInt32(textBoxKck.Text);

                int N = Convert.ToInt32(textBoxN.Text);

                System.Text.UnicodeEncoding encoding = new System.Text.UnicodeEncoding();//Encode String to Convert to Bytes

                string[] chuoivaotach = (richTextBoxXvb.Text).Trim().Split(' ');

                byte[] giaima = new byte[chuoivaotach.Length];
                for (int i = 0; i < chuoivaotach.Length; i++)
                {
                    giaima[i] = Convert.ToByte((modulo(int.Parse(chuoivaotach[i]), SoD, N)));
                }

                string giaimachu = encoding.GetString(giaima);
                if (giaimachu == richTextBoxKvb.Text)
                {
                    MessageBox.Show("Chữ ký đúng", "Thông báo",
                                    MessageBoxButtons.OK);
                    richTextBoxXkq.Text = giaimachu;
                }              
            }
            if((richTextBoxXvb.Text).Trim() != (richTextBoxKkq.Text).Trim())
            {
                MessageBox.Show("Chữ ký sai", "Thông báo",
                                  MessageBoxButtons.OK);
                richTextBoxXkq.Text = string.Empty;
            }
        }

        // ma hoa
        private void buttonKkvb_Click(object sender, EventArgs e)
        {
            buttonNn.Enabled = buttonSk.Enabled = textBoxN.Enabled = textBoxKck.Enabled = textBoxKbm.Enabled = textBoxP.Enabled = textBoxQ.Enabled = false;

            buttonHien.Enabled = true;

            buttonAn.Enabled = true;

            int SoE = Convert.ToInt32(textBoxKbm.Text);

            int n = Convert.ToInt32(textBoxN.Text);

            System.Text.UnicodeEncoding encoding = new System.Text.UnicodeEncoding();//Encode String to Convert to Bytes

            string dauvao = richTextBoxKvb.Text ;//whatever you want to encrypt

            Byte[] dauvaocd = encoding.GetBytes(dauvao);//convert to Bytes
           
            string mahoa = "" ;
            for (int i = 0; i < dauvaocd.Length; i++)
            {
                mahoa += modulo(dauvaocd[i], SoE, n) + " ";
            }
            if( mahoa != "")
            {
                MessageBox.Show("Ký thành công", "Thông báo",
                              MessageBoxButtons.OK);
                richTextBoxKkq.Text = mahoa.ToString();
                buttonGui.Visible = true;
            }
        }

        // làm mới all
        private void buttonLmsk_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;         
            textBoxN.Enabled = textBoxKck.Enabled = textBoxKbm.Enabled = textBoxP.Enabled = textBoxQ.Enabled = buttonNn.Enabled = buttonSk.Enabled = true;
            buttonLmkvb.Enabled = buttonGui.Visible = buttonNnhan.Visible = false;
            textBoxN.Text = textBoxKck.Text = textBoxKbm.Text = textBoxP.Text = textBoxQ.Text = string.Empty;
            richTextBoxKkq.Text = richTextBoxKvb.Text =  string.Empty;
            textBoxN.ReadOnly = textBoxKck.ReadOnly = textBoxKbm.ReadOnly = textBoxP.ReadOnly = textBoxQ.ReadOnly = false;           
        }

        // làm mới phần dữ liệu
        private void buttonLmkvb_Click(object sender, EventArgs e)
        {
            richTextBoxKkq.Text = richTextBoxKvb.Text = string.Empty;
            buttonGui.Visible = false;
        }

        private void buttonNnhan_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = true;

            buttonLmkvb.Visible = false;
            buttonLmsk.Visible = false;
            buttonLmXtck.Visible = true;
            buttonLmXtk.Visible = true;
        }

        private void buttonNgui_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            buttonLmkvb.Visible = true;
            buttonLmsk.Visible = true;
            buttonLmXtck.Visible = false;
            buttonLmXtk.Visible = false;
        }

        private void buttonXtk_Click(object sender, EventArgs e)
        {
            if(textBoxXtkD.Text == textBoxKck.Text && textBoxXtkD.Text != string.Empty )
            {
                MessageBox.Show("Khóa đúng!", "Thông báo",
                              MessageBoxButtons.OK);
                groupBox3.Enabled = true;
                groupBox4.Enabled = false;
            }
            if(textBoxXtkD.Text != textBoxKck.Text)
            {
                MessageBox.Show("Nhập sai khóa nhập lại!", "Thông báo",
                              MessageBoxButtons.OK);
            }
        }

        private void buttonLmXtk_Click(object sender, EventArgs e)
        {
            textBoxXtkD.Text = string.Empty;
            richTextBoxXkq.Text = richTextBoxXvb.Text = string.Empty;
            groupBox3.Enabled = false;
            groupBox4.Enabled = true;
        }

        private void buttonLmXtck_Click(object sender, EventArgs e)
        {
            richTextBoxXkq.Text = richTextBoxXvb.Text = string.Empty;
        }

        private void buttonGui_Click(object sender, EventArgs e)
        {
            buttonNnhan.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = true;

            buttonLmkvb.Visible = false;
            buttonLmsk.Visible = false;
            buttonLmXtck.Visible = true;
            buttonLmXtk.Visible = true;
        }
    }   
}
 