using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using ustawienia = Integrator.Properties.Settings; 

namespace Integrator
{
    partial class Ustawienia : Form
    {
        private Class_Data _polaczenie = null;
        private string v;


        public Ustawienia(string v)
        {
            InitializeComponent();
            this.v = v;     
        }

        private void Ustawienia_Load(object sender, EventArgs e)
        {
            try
            {
                bt_zapisz.Enabled = false;
                this.Text = "Ustawienia bazy danych - " + v;
                if (v=="źródło") {
                    tb_host.Text = ustawienia.Default.zrodlo_host;
                    tb_baza.Text = ustawienia.Default.zrodlo_baza;
                    tb_login.Text = ustawienia.Default.zrodlo_login;
                    tb_haslo.Text = ustawienia.Default.zrodlo_haslo;
                }
                else {
                    tb_host.Text = ustawienia.Default.cel_host;
                    tb_baza.Text = ustawienia.Default.cel_baza;
                    tb_login.Text = ustawienia.Default.cel_login;
                    tb_haslo.Text = ustawienia.Default.cel_haslo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ustawień bazy danych - " + v, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            try
            {
                this._polaczenie = new Class_Data();

                this._polaczenie.Connect_MsSQL(tb_host.Text, tb_baza.Text, tb_login.Text, tb_haslo.Text);

                if (this._polaczenie.error_db != null)
                {
                    throw new Exception(this._polaczenie.error_db);
                }
                else
                {
                    MessageBox.Show("Połączenie powiodło się !", "Testu połączenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bt_zapisz.Enabled = true;

                    if (this._polaczenie.isOpen_MsSQL())
                    {
                        this._polaczenie.Close_MsSQL();
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd testu połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_zapisz_Click(object sender, EventArgs e)
        {
            try
            {   if (v == "źródło") {
                    ustawienia.Default.zrodlo_host = tb_host.Text;
                    ustawienia.Default.zrodlo_baza = tb_baza.Text;
                    ustawienia.Default.zrodlo_login = tb_login.Text;
                    ustawienia.Default.zrodlo_haslo = tb_haslo.Text;
                } else {
                    ustawienia.Default.cel_host = tb_host.Text;
                    ustawienia.Default.cel_baza = tb_baza.Text;
                    ustawienia.Default.cel_login = tb_login.Text;
                    ustawienia.Default.cel_haslo = tb_haslo.Text;
                }       
                ustawienia.Default.Save();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_anuluj_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd anulowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
