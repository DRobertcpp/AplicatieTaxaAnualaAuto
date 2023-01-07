using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieTaxaAnualaAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcul_Click(object sender, EventArgs e)
        {
            string n, v;
            n = norma.Text;
            v = vechime.Text;
            uint A, C, B, E;
            double D, taxa;
            A = Convert.ToUInt32(emisie.Text);
            C = Convert.ToUInt32(cc.Text);
            switch (n)
            {
                case "Hibrid":
                    B = 0;
                    D = 0;
                    break;
                case "Electric":
                    B = 0;
                    D = 0;
                    break;
                case "Euro 6":
                    B = 0;
                    D = 0;
                    break;
                case "Euro 5":
                    if (A <= 120)
                        B = 0;
                    else if (A <= 210)
                        B = 1;
                    else if (A <= 270)
                        B = 4;
                    else
                        B = 8;
                    if (C <= 2000)
                        D = 1.3;
                    else
                        D = 0.39;
                    break;
                case "Euro 4":
                    if (A <= 120)
                        B = 0;
                    else if (A <= 210)
                        B = 1;
                    else if (A <= 270)
                        B = 4;
                    else
                        B = 8;
                    if (C <= 2000)
                        D = 0.13;
                    else
                        D = 3;
                    break;
                case "Euro 3":
                    if (A <= 120)
                        B = 0;
                    else if (A <= 210)
                        B = 1;
                    else if (A <= 270)
                        B = 4;
                    else
                        B = 8;
                    if (C <= 2000)
                        D = 9;
                    else
                        D = 16;
                    break;
                default:
                    B = 16;
                    if (C <= 2000)
                        D = 9;
                    else
                        D = 16;
                    break;
            }
            switch (v)
            {
                case "nou":
                    E = 0;
                    break;
                case "<1 an":
                    E = 10;
                    break;
                case "<3 ani":
                    E = 30;
                    break;
                case "<5 ani":
                    E = 40;
                    break;
                case "<10 ani":
                    E = 60;
                    break;
                default:
                    E = 80;
                    break;
            }
            taxa = (((A * B * 3 / 10) + (C * D * 7 / 10)) * (100 - E) / 100) / 100;
            rez.Text = Convert.ToString(taxa);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
