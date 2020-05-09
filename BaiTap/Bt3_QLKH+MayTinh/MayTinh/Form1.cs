using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Form1 : Form
    {
        private double ketqua;
        private double giatrinho;
        private double giatrinhoM;
        private bool co; // cờ kiểm tra
        char pheptoan;

        public Form1()
        {
            InitializeComponent();
            ketqua = 0;
            co = false;
            giatrinho = 0;
            giatrinhoM = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketqua = 0;
            co = false;
            giatrinho = 0;
            giatrinhoM = 0;
            tbKetqua.Clear();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 1;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 2;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 3;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt4_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 4;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt5_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 5;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt6_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 6;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt7_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 7;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt8_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 8;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt9_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 9;
            tbKetqua.Text = ketqua.ToString();

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            ketqua = ketqua * 10 + 0;
            tbKetqua.Text = ketqua.ToString();

        }

        private void cong_Click(object sender, EventArgs e)
        {
            if (!co)
            {
                giatrinho = ketqua;
                ketqua = 0;
                co = true; // có nhớ giá trị
                pheptoan = '+';
            }
            else
            {
                ketqua += giatrinho;
                tbKetqua.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void tru_Click(object sender, EventArgs e)
        {
            if (!co)
            {
                giatrinho = ketqua;
                ketqua = 0;
                co = true; // có nhớ giá trị
                pheptoan = '-';
            }
            else
            {
                ketqua -= giatrinho;
                tbKetqua.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void nhan_Click(object sender, EventArgs e)
        {
            if (!co)
            {
                giatrinho = ketqua;
                ketqua = 0;
                co = true; // có nhớ giá trị
                pheptoan = '*';
            }
            else
            {
                ketqua *= giatrinho;
                tbKetqua.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void chia_Click(object sender, EventArgs e)
        {
            if (!co)
            {
                giatrinho = ketqua;
                ketqua = 0;
                co = true; // có nhớ giá trị
                pheptoan = '/';
            }
            else
            {
                ketqua /= giatrinho;
                tbKetqua.Text = ketqua.ToString();
                giatrinho = ketqua;
                ketqua = 0;
            }

        }

        private void btct_Click(object sender, EventArgs e)
        {
            if ((co == true) && (ketqua == 0))
            {
                giatrinho = -giatrinho;
                ketqua = giatrinho;
                tbKetqua.Text = ketqua.ToString();
                ketqua = 0;
            }
            else
            {
                ketqua = -ketqua;
                tbKetqua.Text = ketqua.ToString();
            }

        }

        private void btbang_Click(object sender, EventArgs e)
        {
            if (co)
            {
                switch (pheptoan)
                {
                    case '+':
                        ketqua += giatrinho;
                        tbKetqua.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '-':
                        ketqua = giatrinho - ketqua;
                        tbKetqua.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '*':
                        ketqua = giatrinho * ketqua;
                        tbKetqua.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                    case '/':
                        ketqua = giatrinho / ketqua;
                        tbKetqua.Text = ketqua.ToString();
                        giatrinho = 0;
                        co = false;
                        break;
                }
            }

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            ketqua = Math.Sqrt(ketqua);
            tbKetqua.Text = ketqua.ToString();
            ketqua = 0;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 96:
                    bt0_Click(sender, e);
                    break;
                case 97:
                    bt1_Click(sender, e);
                    break;
                case 98:
                    bt2_Click(sender, e);
                    break;
                case 99:
                    bt3_Click(sender, e);
                    break;
                case 100:
                    bt4_Click(sender, e);
                    break;
                case 101:
                    bt5_Click(sender, e);
                    break;
                case 102:
                    bt6_Click(sender, e);
                    break;
                case 103:
                    bt7_Click(sender, e);
                    break;
                case 104:
                    bt8_Click(sender, e);
                    break;
                case 105:
                    bt9_Click(sender, e);
                    break;
                case 107:
                    cong_Click(sender, e);
                    break;
                case 109:
                    tru_Click(sender, e);
                    break;
                case 106:
                    nhan_Click(sender, e);
                    break;
                case 111:
                    chia_Click(sender, e);
                    break;
                case 13:
                    btbang_Click(sender, e);
                    break;
                case 8:
                    button4_Click(sender, e);
                    break;
                case 46:
                    button4_Click(sender, e);
                    break;
                case 48:
                    bt0_Click(sender, e);
                    break;
                case 49:
                    bt1_Click(sender, e);
                    break;
                case 50:
                    bt2_Click(sender, e);
                    break;
                case 51:
                    bt3_Click(sender, e);
                    break;
                case 52:
                    bt4_Click(sender, e);
                    break;
                case 53:
                    bt5_Click(sender, e);
                    break;
                case 54:
                    bt6_Click(sender, e);
                    break;
                case 55:
                    bt7_Click(sender, e);
                    break;
                case 56:
                    bt8_Click(sender, e);
                    break;
                case 57:
                    bt9_Click(sender, e);
                    break;
                case 43:
                    cong_Click(sender, e);
                    break;
                case 45:
                    tru_Click(sender, e);
                    break;
                case 42:
                    nhan_Click(sender, e);
                    break;
                case 47:
                    chia_Click(sender, e);
                    break;
                case 61:
                    btbang_Click(sender, e);
                    break;
                case 83:
                    sqrt_Click(sender, e);
                    break;
                case 115:
                    sqrt_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void bt1_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void tbKetqua_KeyDown(object sender, KeyEventArgs e)
        {
        
        }
    }
}
