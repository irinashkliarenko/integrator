namespace Integrator
{
    partial class MoreInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nazwa1 = new System.Windows.Forms.TextBox();
            this.wierszy1 = new System.Windows.Forms.TextBox();
            this.przeniesione1 = new System.Windows.Forms.TextBox();
            this.nieprzeniesione1 = new System.Windows.Forms.TextBox();
            this.nazwa2 = new System.Windows.Forms.TextBox();
            this.wierszy2 = new System.Windows.Forms.TextBox();
            this.przeniesione2 = new System.Windows.Forms.TextBox();
            this.nieprzeniesione2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nazwa1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wierszy1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.przeniesione1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nieprzeniesione1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nazwa2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.wierszy2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.przeniesione2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.nieprzeniesione2, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 331);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa tabeli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ilość wierszy w danej tabeli";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilość przeniesionych danych";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ilość nie przeniesionych danych";
            // 
            // nazwa1
            // 
            this.nazwa1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nazwa1.Location = new System.Drawing.Point(184, 20);
            this.nazwa1.Name = "nazwa1";
            this.nazwa1.ReadOnly = true;
            this.nazwa1.Size = new System.Drawing.Size(100, 22);
            this.nazwa1.TabIndex = 4;
            // 
            // wierszy1
            // 
            this.wierszy1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wierszy1.Location = new System.Drawing.Point(184, 99);
            this.wierszy1.Name = "wierszy1";
            this.wierszy1.ReadOnly = true;
            this.wierszy1.Size = new System.Drawing.Size(100, 22);
            this.wierszy1.TabIndex = 5;
            // 
            // przeniesione1
            // 
            this.przeniesione1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.przeniesione1.Location = new System.Drawing.Point(184, 190);
            this.przeniesione1.Name = "przeniesione1";
            this.przeniesione1.ReadOnly = true;
            this.przeniesione1.Size = new System.Drawing.Size(100, 22);
            this.przeniesione1.TabIndex = 6;
            // 
            // nieprzeniesione1
            // 
            this.nieprzeniesione1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nieprzeniesione1.Location = new System.Drawing.Point(184, 276);
            this.nieprzeniesione1.Name = "nieprzeniesione1";
            this.nieprzeniesione1.ReadOnly = true;
            this.nieprzeniesione1.Size = new System.Drawing.Size(100, 22);
            this.nieprzeniesione1.TabIndex = 7;
            // 
            // nazwa2
            // 
            this.nazwa2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nazwa2.Location = new System.Drawing.Point(337, 20);
            this.nazwa2.Name = "nazwa2";
            this.nazwa2.ReadOnly = true;
            this.nazwa2.Size = new System.Drawing.Size(100, 22);
            this.nazwa2.TabIndex = 8;
            // 
            // wierszy2
            // 
            this.wierszy2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wierszy2.Location = new System.Drawing.Point(337, 99);
            this.wierszy2.Name = "wierszy2";
            this.wierszy2.ReadOnly = true;
            this.wierszy2.Size = new System.Drawing.Size(100, 22);
            this.wierszy2.TabIndex = 9;
            // 
            // przeniesione2
            // 
            this.przeniesione2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.przeniesione2.Location = new System.Drawing.Point(337, 190);
            this.przeniesione2.Name = "przeniesione2";
            this.przeniesione2.ReadOnly = true;
            this.przeniesione2.Size = new System.Drawing.Size(100, 22);
            this.przeniesione2.TabIndex = 10;
            // 
            // nieprzeniesione2
            // 
            this.nieprzeniesione2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nieprzeniesione2.Location = new System.Drawing.Point(337, 276);
            this.nieprzeniesione2.Name = "nieprzeniesione2";
            this.nieprzeniesione2.ReadOnly = true;
            this.nieprzeniesione2.Size = new System.Drawing.Size(100, 22);
            this.nieprzeniesione2.TabIndex = 11;
            // 
            // MoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MoreInfo";
            this.Text = "Raport";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nazwa1;
        private System.Windows.Forms.TextBox wierszy1;
        private System.Windows.Forms.TextBox przeniesione1;
        private System.Windows.Forms.TextBox nieprzeniesione1;
        private System.Windows.Forms.TextBox nazwa2;
        private System.Windows.Forms.TextBox wierszy2;
        private System.Windows.Forms.TextBox przeniesione2;
        private System.Windows.Forms.TextBox nieprzeniesione2;
    }
}