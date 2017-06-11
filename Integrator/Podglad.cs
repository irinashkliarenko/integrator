using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace Integrator
{
    partial class Podglad : Form
    {
        public Class_Data _polaczenie = null;

        private DataTable tabela = null;

        public Podglad()
        {
            InitializeComponent();            
        }

        private void Podglad_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Podlgąd bazy danych - źródło";
                               
                this.Miasto_Load();                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd podglądu bazy daych - źródło", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Miasto_Load()
        {
            try
            {               
                this._polaczenie.Read_MsSQL("SELECT * FROM [_address]");

                if (this._polaczenie.error_db != null)
                {
                    throw new Exception(this._polaczenie.error_db);
                }
                else
                {
                    tabela = new DataTable();
                    tabela.Load(this._polaczenie.read_MsSQL);
                    dgv_miasto.DataSource = tabela;                                  
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania danych - Miasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
