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
                l_autor.Text = "Iryna Shkliarenko";
                l_indeks.Text = "198039";
                l_rok.Text = "2016/2017";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd okna - O programie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }               
    }
}
