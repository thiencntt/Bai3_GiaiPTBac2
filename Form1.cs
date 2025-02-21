using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_GiaiPTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, delta;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            if (a == 0)
            { // Biện luận giải phương trình bậc 1: bx + c = 0
                if (b == 0)
                {
                    if (c != 0)
                    {
                        // cout << "Phuong trinh vo nghiem";
                        lblKQ.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        // cout << "Phuong trinh co vo so nghiem";
                        lblKQ.Text = "Phương trình vô số nghiệm";
                    }
                }
                else
                {
                    x1 = x2 = -c / b;
                    // cout << "Phuong trinh co nghiem x = " << x1;
                    lblKQ.Text = "Phương trình có nghiệm x = " + x1;
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblKQ.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    // cout << "Phuong trinh co nghiem kep x1 = x2 = " << x1;
                    lblKQ.Text = "Phương trình có nghiệm kép x1 = x2 = " + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    /// cout << "Phuong trinh co 2 nghiem phan biet";
                    // cout << "\nx1 = " << x1;
                    // cout << "\nx2 = " << x2;
                    lblKQ.Text = "Phương trình có 2 nghiệm phân biệt";
                    lblKQ.Text += "\nx1 = " + x1;
                    lblKQ.Text += "\nx2 = " + x2;

                }
            }

            /*

    if (a == 0) { // Biện luận giải phương trình bậc 1: bx + c = 0
        if (b == 0) {
            if (c != 0) {
                cout << "Phuong trinh vo nghiem";
            }
            else {
                cout << "Phuong trinh co vo so nghiem";
            }
        } else {
            x1 = x2 = -c / b;
            cout << "Phuong trinh co nghiem x = " << x1;
        }
    } else {
        delta = b * b - 4 * a * c;
        if (delta < 0) {
            cout << "Phuong trinh vo nghiem";
        }
        else if (delta == 0) {
            x1 = x2 = -b / (2 * a);
            cout << "Phuong trinh co nghiem kep x1 = x2 = " << x1;
        }
        else {
            x1 = (-b + sqrt(delta)) / (2 * a);
            x2 = (-b - sqrt(delta)) / (2 * a);
            cout << "Phuong trinh co 2 nghiem phan biet";
            cout << "\nx1 = " << x1;
            cout << "\nx2 = " << x2;
        }
    }
             
             */
        }
    }
}
