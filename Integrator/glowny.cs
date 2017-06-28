using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using ustawienia = Integrator.Properties.Settings;

namespace Integrator
{
    public partial class glowny : Form
    {
        Class_Data _zrodlo = null;
        Class_Data _cel = null;

        public glowny()
        {
            InitializeComponent();
        }

        private void glowny_Load(object sender, EventArgs e)
        {
            try
            {
                this._zrodlo = new Class_Data();

                this._cel = new Class_Data();

                this.bt_integruj.Enabled = false;

                this.bt_podglad_zrodlo.Enabled = false;

                this.bt_poglad_cel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania głównego okna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd zamykania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_polacz_zrodlo_Click(object sender, EventArgs e)
        {
            if (bt_polacz_zrodlo.Text == "Połącz")
            {
                try
                {
                    this._zrodlo.Connect_MsSQL(ustawienia.Default.zrodlo_host, ustawienia.Default.zrodlo_baza, ustawienia.Default.zrodlo_login, ustawienia.Default.zrodlo_haslo);

                    if (this._zrodlo.error_db != null)
                    {
                        throw new Exception(this._zrodlo.error_db);
                    }
                    else
                    {
                        this.bt_podglad_zrodlo.Enabled = true;
                        if (this.bt_poglad_cel.Enabled == true)
                        {
                            this.bt_integruj.Enabled = true;
                        }
                    }
                    bt_polacz_zrodlo.Text = "Rozłącz";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd połączenia - źródło", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bt_polacz_zrodlo.Text == "Rozłącz")
            {
                try
                {
                    this._zrodlo.Close_MsSQL();
                    if (this._zrodlo.error_db != null)
                    {
                        throw new Exception(this._zrodlo.error_db);
                    }
                    else
                    {
                        this.bt_podglad_zrodlo.Enabled = false;
                        this.bt_integruj.Enabled = false ;
                        
                        bt_polacz_zrodlo.Text = "Połącz";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd rozłączenia - źródło", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_podglad_zrodlo_Click(object sender, EventArgs e)
        {
            try
            {
                Podglad _okno = new Podglad();
                _okno._polaczenie = this._zrodlo;
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd otwierania okna - Podlgądu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_polacz_cel_Click(object sender, EventArgs e)
        {
            if (bt_polacz_cel.Text == "Połącz")
            {
                try
                {
                    this._cel.Connect_MsSQL(ustawienia.Default.cel_host, ustawienia.Default.cel_baza, ustawienia.Default.cel_login, ustawienia.Default.cel_haslo);

                    if (this._cel.error_db != null)
                    {
                        throw new Exception(this._cel.error_db);
                    }
                    else
                    {
                        this.bt_poglad_cel.Enabled = true;

                        if (this.bt_podglad_zrodlo.Enabled == true)
                        {
                            this.bt_integruj.Enabled = true;
                        }
                        bt_polacz_cel.Text = "Rozłącz";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd połączenia - cel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bt_polacz_cel.Text == "Rozłącz")
            {
                try
                {
                    this._cel.Close_MsSQL();
                    if (this._cel.error_db != null)
                    {
                        throw new Exception(this._cel.error_db);
                    }
                    else
                    {
                        this.bt_poglad_cel.Enabled = false;
                        this.bt_integruj.Enabled = false;

                        bt_polacz_cel.Text = "Połącz";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd rozłączenia - cel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_poglad_cel_Click(object sender, EventArgs e)
        {
            try
            {
                Podglad _okno = new Podglad();
                _okno._polaczenie = this._cel;
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd otwierania okna - Podlgądu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BazaDanychZrodloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Ustawienia _okno = new Ustawienia("źródło");
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd otwierania okna - Ustawienia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BazaDanychCelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Ustawienia _okno = new Ustawienia("cel");
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd otwierania okna - Ustawienia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OProgramie _okno = new OProgramie();
                _okno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd otwierania okna - O programie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable find_difference(DataTable dt1, DataTable dt2)
        {
            var differences =
                dt1.AsEnumerable().Except(dt2.AsEnumerable(),
                                                    DataRowComparer.Default);

            return differences.Any() ? differences.CopyToDataTable() : new DataTable();
        }


        public void merge()
        {
            string query = null;
            DataTable diff_address = find_difference(_zrodlo.ds_zrodlo_MsSQL.Tables[0], _cel.ds_cel_MsSQL.Tables[0]);
            DataTable diff_user = find_difference(_zrodlo.ds_zrodlo_MsSQL.Tables[1], _cel.ds_cel_MsSQL.Tables[1]);

            create_report(diff_address.Rows.Count, diff_user.Rows.Count);

            for (int curRow = 0; curRow < diff_address.Rows.Count; curRow++)
            {
                query = "INSERT INTO _ADDRESS (COUNTRY, CITY) VALUES ('" + diff_address.Rows[curRow]["COUNTRY"].ToString().Trim()
                    + "', '" + diff_address.Rows[curRow]["CITY"].ToString().Trim() + "');";
                _cel.execute_sql_transaction(query);
            }

            for (int curRow = 0; curRow < diff_user.Rows.Count; curRow++)
            {
                query = "INSERT INTO _USER (NAME, SURNAME, AGE) VALUES ('" + diff_user.Rows[curRow]["NAME"].ToString().Trim()
                    + "', '" + diff_user.Rows[curRow]["SURNAME"].ToString().Trim() + "', " + diff_user.Rows[curRow]["AGE"].ToString().Trim() + ");";
                _cel.execute_sql_transaction(query);
            }


            //for (int curRow = 0; curRow < diff_address.Rows.Count; curRow++)
            //{
            //    for (int curCol = 0; curCol < diff_address.Columns.Count; curCol++)
            //    {
            //        System.Diagnostics.Debug.Write(diff_address.Rows[curRow][curCol].ToString().Trim() + "\t");
            //    }
            //    System.Diagnostics.Debug.WriteLine("");
            //}

            //for (int curRow = 0; curRow < diff_user.Rows.Count; curRow++)
            //{
            //    for (int curCol = 0; curCol < diff_user.Columns.Count; curCol++)
            //    {
            //        System.Diagnostics.Debug.Write(diff_user.Rows[curRow][curCol].ToString().Trim() + "\t");
            //    }
            //    System.Diagnostics.Debug.WriteLine("");
            //}
        }

        public void create_report(int copied_data1, int copied_data2)
        {
            MoreInfo report = new MoreInfo();
            int non_copied_data1 = _zrodlo.ds_zrodlo_MsSQL.Tables[0].Rows.Count - copied_data1;
            int non_copied_data2 = _zrodlo.ds_zrodlo_MsSQL.Tables[1].Rows.Count - copied_data2;

            report.setData1("ADDRESS", _zrodlo.ds_zrodlo_MsSQL.Tables[0].Rows.Count.ToString(), copied_data1.ToString(), non_copied_data1.ToString());
            report.setData2("USER", _zrodlo.ds_zrodlo_MsSQL.Tables[1].Rows.Count.ToString(), copied_data2.ToString(), non_copied_data2.ToString());
            report.Show();
        }

        private void bt_integruj_Click(object sender, EventArgs e)
        {
            _zrodlo.DS_zrodlo_MsSQL("select * from _ADDRESS", "address_source");
            _zrodlo.DS_zrodlo_MsSQL("select * from _USER", "user_source");
            _cel.DS_cel_MsSQL("select * from _ADDRESS", "address_target");
            _cel.DS_cel_MsSQL("select * from _USER", "user_target");
            merge();
            
            
            try
            {
                int min = 0;
                int max = 100;
                int zwieksz = 1;
                int i = 1;

                int sum_rows = 4;

                zwieksz = Convert.ToInt32(max / sum_rows);

                while (i <= sum_rows)
                {
                    this.pb_integruj_Load(ref min, max, zwieksz, sum_rows, i);

                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd integracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_integruj_Load(ref int min, int max, int zwieksz, int sum_rows, int krok)
        {
            try
            {
                min = min + zwieksz;

                if (min > max)
                {
                    min = 100;
                }
                else if (krok == sum_rows)
                {
                    min = 100;
                }

                pb_integruj.Value = min;

                lb_postep.Text = min.ToString() + " %";

                Thread.Sleep(1000);

                lb_postep.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania paska postępu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
