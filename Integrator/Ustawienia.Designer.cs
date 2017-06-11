namespace Integrator
{
    partial class Ustawienia
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_baza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_haslo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_test = new System.Windows.Forms.Button();
            this.bt_zapisz = new System.Windows.Forms.Button();
            this.bt_anuluj = new System.Windows.Forms.Button();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_baza
            // 
            this.tb_baza.Location = new System.Drawing.Point(121, 45);
            this.tb_baza.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_baza.Name = "tb_baza";
            this.tb_baza.Size = new System.Drawing.Size(171, 22);
            this.tb_baza.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baza danych:";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(121, 77);
            this.tb_login.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(171, 22);
            this.tb_login.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Login:";
            // 
            // tb_haslo
            // 
            this.tb_haslo.Location = new System.Drawing.Point(121, 109);
            this.tb_haslo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.PasswordChar = '*';
            this.tb_haslo.Size = new System.Drawing.Size(171, 22);
            this.tb_haslo.TabIndex = 9;
            this.tb_haslo.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Hasło:";
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(16, 194);
            this.bt_test.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(168, 28);
            this.bt_test.TabIndex = 10;
            this.bt_test.Text = "Test połączenia";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // bt_zapisz
            // 
            this.bt_zapisz.Location = new System.Drawing.Point(192, 194);
            this.bt_zapisz.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_zapisz.Name = "bt_zapisz";
            this.bt_zapisz.Size = new System.Drawing.Size(101, 28);
            this.bt_zapisz.TabIndex = 11;
            this.bt_zapisz.Text = "Zapisz";
            this.bt_zapisz.UseVisualStyleBackColor = true;
            this.bt_zapisz.Click += new System.EventHandler(this.bt_zapisz_Click);
            // 
            // bt_anuluj
            // 
            this.bt_anuluj.Location = new System.Drawing.Point(299, 194);
            this.bt_anuluj.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_anuluj.Name = "bt_anuluj";
            this.bt_anuluj.Size = new System.Drawing.Size(101, 28);
            this.bt_anuluj.TabIndex = 12;
            this.bt_anuluj.Text = "Anuluj";
            this.bt_anuluj.UseVisualStyleBackColor = true;
            this.bt_anuluj.Click += new System.EventHandler(this.bt_anuluj_Click);
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(120, 15);
            this.tb_host.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(171, 22);
            this.tb_host.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serwer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(17, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "*Leave these fields empty if you\'re using Windows Authentication";
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_anuluj);
            this.Controls.Add(this.bt_zapisz);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.tb_haslo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_baza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_host);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ustawienia";
            this.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.Ustawienia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_baza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_haslo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Button bt_zapisz;
        private System.Windows.Forms.Button bt_anuluj;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
