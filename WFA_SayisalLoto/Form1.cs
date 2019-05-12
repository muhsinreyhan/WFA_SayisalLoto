using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void Button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control kontrol in this.Controls)
            {
                if (kontrol is ListBox)
                {
                    ListBox lst = (ListBox)kontrol;
                    lst.Items.Clear();
                }
            }

            foreach (Control ctrl in this.Controls)
            {
                for (int i = 1; i < 7; i++)
                {
                    int sayi = rnd.Next(1, 50);

                    if (ctrl is ListBox)
                    {
                        ListBox lst = (ListBox)ctrl;

                        if (lst.Items.Contains(sayi))
                        {
                            i--;
                            continue;
                        }
                        lst.Items.Add(sayi);
                    }
                }
            }
        }
    }
}
