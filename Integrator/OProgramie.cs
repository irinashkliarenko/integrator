using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Integrator
{
    partial class OProgramie : Form
    {
        public OProgramie()
        {
            InitializeComponent();            
        }
        
        private void OProgramie_Load(object sender, EventArgs e)
        {
            try
            {
                l_przedmiot.Text = "Platforma .NET";
                l_autor.Text = "Adrian Królik";
                l_indeks.Text = "123456";
                l_rok.Text = "2015/2016";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd okna - O programie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }               
    }
}
