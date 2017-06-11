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

        private DataTable tabela_miasto = null;

        private DataTable tabela_uzytkownik = null;

        public Podglad()
        {
            InitializeComponent();            
        }

        private void Podglad_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Podlgąd bazy danych";
                               
                this.Miasto_Load();

                this.Uzytkownik_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd podglądu bazy daych", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    tabela_miasto = new DataTable();
                    tabela_miasto.Load(this._polaczenie.read_MsSQL);
                    dgv_miasto.DataSource = tabela_miasto;                                  
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania danych - Miasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Uzytkownik_Load()
        {
            try
            {
                this._polaczenie.Read_MsSQL("SELECT * FROM [_user]");

                if (this._polaczenie.error_db != null)
                {
                    throw new Exception(this._polaczenie.error_db);
                }
                else
                {
                    tabela_uzytkownik = new DataTable();
                    tabela_uzytkownik.Load(this._polaczenie.read_MsSQL);
                    dgv_uzytkownik.DataSource = tabela_uzytkownik;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania danych - Miasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
