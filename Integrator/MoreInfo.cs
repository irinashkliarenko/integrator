using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Integrator
{
    public partial class MoreInfo : Form
    {
        public MoreInfo()
        {
            InitializeComponent();
        }

        public void setData1(string nazwa, string wierszy, string przeniesione, string nieprzeniesione)
        {
            nazwa1.Text = nazwa;
            wierszy1.Text = wierszy;
            przeniesione1.Text = przeniesione;
            nieprzeniesione1.Text = nieprzeniesione;
        }

        public void setData2(string nazwa, string wierszy, string przeniesione, string nieprzeniesione)
        {
            nazwa2.Text = nazwa;
            wierszy2.Text = wierszy;
            przeniesione2.Text = przeniesione;
            nieprzeniesione2.Text = nieprzeniesione;
        }
    }
}
