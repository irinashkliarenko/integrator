namespace Integrator
{
    partial class Podglad
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
            this.tb_podglad = new System.Windows.Forms.TabControl();
            this.tp_miasto = new System.Windows.Forms.TabPage();
            this.dgv_miasto = new System.Windows.Forms.DataGridView();
            this.tb_podglad.SuspendLayout();
            this.tp_miasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_miasto)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_podglad
            // 
            this.tb_podglad.Controls.Add(this.tp_miasto);
            this.tb_podglad.Location = new System.Drawing.Point(16, 15);
            this.tb_podglad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_podglad.Name = "tb_podglad";
            this.tb_podglad.SelectedIndex = 0;
            this.tb_podglad.Size = new System.Drawing.Size(548, 319);
            this.tb_podglad.TabIndex = 0;
            // 
            // tp_miasto
            // 
            this.tp_miasto.Controls.Add(this.dgv_miasto);
            this.tp_miasto.Location = new System.Drawing.Point(4, 25);
            this.tp_miasto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_miasto.Name = "tp_miasto";
            this.tp_miasto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_miasto.Size = new System.Drawing.Size(540, 290);
            this.tp_miasto.TabIndex = 0;
            this.tp_miasto.Text = "Miasto";
            this.tp_miasto.UseVisualStyleBackColor = true;
            // 
            // dgv_miasto
            // 
            this.dgv_miasto.AllowUserToAddRows = false;
            this.dgv_miasto.AllowUserToDeleteRows = false;
            this.dgv_miasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_miasto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_miasto.Location = new System.Drawing.Point(4, 4);
            this.dgv_miasto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_miasto.Name = "dgv_miasto";
            this.dgv_miasto.ReadOnly = true;
            this.dgv_miasto.Size = new System.Drawing.Size(532, 282);
            this.dgv_miasto.TabIndex = 0;
            // 
            // Podglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 348);
            this.Controls.Add(this.tb_podglad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Podglad";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Podglad";
            this.Load += new System.EventHandler(this.Podglad_Load);
            this.tb_podglad.ResumeLayout(false);
            this.tp_miasto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_miasto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_podglad;
        private System.Windows.Forms.TabPage tp_miasto;
        private System.Windows.Forms.DataGridView dgv_miasto;

    }
}
