namespace DBSecimProje
{
    partial class FRMGRAFIKLER
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PRGSAPARTI = new System.Windows.Forms.ProgressBar();
            this.PRGSBPARTI = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PRGSCPARTI = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PRGSDPARTI = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.PRGSEPARTI = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLAPARTI = new System.Windows.Forms.Label();
            this.LBLBPARTI = new System.Windows.Forms.Label();
            this.LBLCPARTI = new System.Windows.Forms.Label();
            this.LBLDPARTI = new System.Windows.Forms.Label();
            this.LBLEPARTI = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRAFİKLER";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(560, 160);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBLEPARTI);
            this.groupBox2.Controls.Add(this.LBLDPARTI);
            this.groupBox2.Controls.Add(this.LBLCPARTI);
            this.groupBox2.Controls.Add(this.LBLBPARTI);
            this.groupBox2.Controls.Add(this.LBLAPARTI);
            this.groupBox2.Controls.Add(this.PRGSEPARTI);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PRGSDPARTI);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PRGSCPARTI);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PRGSBPARTI);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PRGSAPARTI);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İLÇE DEĞERLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE SEÇİN ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "APARTI";
            // 
            // PRGSAPARTI
            // 
            this.PRGSAPARTI.Location = new System.Drawing.Point(106, 72);
            this.PRGSAPARTI.Name = "PRGSAPARTI";
            this.PRGSAPARTI.Size = new System.Drawing.Size(295, 23);
            this.PRGSAPARTI.TabIndex = 3;
            // 
            // PRGSBPARTI
            // 
            this.PRGSBPARTI.Location = new System.Drawing.Point(106, 101);
            this.PRGSBPARTI.Name = "PRGSBPARTI";
            this.PRGSBPARTI.Size = new System.Drawing.Size(295, 23);
            this.PRGSBPARTI.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "BPARTI";
            // 
            // PRGSCPARTI
            // 
            this.PRGSCPARTI.Location = new System.Drawing.Point(106, 130);
            this.PRGSCPARTI.Name = "PRGSCPARTI";
            this.PRGSCPARTI.Size = new System.Drawing.Size(295, 23);
            this.PRGSCPARTI.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPARTI";
            // 
            // PRGSDPARTI
            // 
            this.PRGSDPARTI.Location = new System.Drawing.Point(106, 159);
            this.PRGSDPARTI.Name = "PRGSDPARTI";
            this.PRGSDPARTI.Size = new System.Drawing.Size(295, 23);
            this.PRGSDPARTI.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "DPARTI";
            // 
            // PRGSEPARTI
            // 
            this.PRGSEPARTI.Location = new System.Drawing.Point(106, 188);
            this.PRGSEPARTI.Name = "PRGSEPARTI";
            this.PRGSEPARTI.Size = new System.Drawing.Size(295, 23);
            this.PRGSEPARTI.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "EPARTI";
            // 
            // LBLAPARTI
            // 
            this.LBLAPARTI.AutoSize = true;
            this.LBLAPARTI.Location = new System.Drawing.Point(418, 77);
            this.LBLAPARTI.Name = "LBLAPARTI";
            this.LBLAPARTI.Size = new System.Drawing.Size(16, 18);
            this.LBLAPARTI.TabIndex = 12;
            this.LBLAPARTI.Text = "0";
            // 
            // LBLBPARTI
            // 
            this.LBLBPARTI.AutoSize = true;
            this.LBLBPARTI.Location = new System.Drawing.Point(418, 106);
            this.LBLBPARTI.Name = "LBLBPARTI";
            this.LBLBPARTI.Size = new System.Drawing.Size(16, 18);
            this.LBLBPARTI.TabIndex = 13;
            this.LBLBPARTI.Text = "0";
            // 
            // LBLCPARTI
            // 
            this.LBLCPARTI.AutoSize = true;
            this.LBLCPARTI.Location = new System.Drawing.Point(418, 135);
            this.LBLCPARTI.Name = "LBLCPARTI";
            this.LBLCPARTI.Size = new System.Drawing.Size(16, 18);
            this.LBLCPARTI.TabIndex = 14;
            this.LBLCPARTI.Text = "0";
            // 
            // LBLDPARTI
            // 
            this.LBLDPARTI.AutoSize = true;
            this.LBLDPARTI.Location = new System.Drawing.Point(418, 164);
            this.LBLDPARTI.Name = "LBLDPARTI";
            this.LBLDPARTI.Size = new System.Drawing.Size(16, 18);
            this.LBLDPARTI.TabIndex = 15;
            this.LBLDPARTI.Text = "0";
            // 
            // LBLEPARTI
            // 
            this.LBLEPARTI.AutoSize = true;
            this.LBLEPARTI.Location = new System.Drawing.Point(418, 188);
            this.LBLEPARTI.Name = "LBLEPARTI";
            this.LBLEPARTI.Size = new System.Drawing.Size(16, 18);
            this.LBLEPARTI.TabIndex = 16;
            this.LBLEPARTI.Text = "0";
            // 
            // FRMGRAFIKLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(621, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMGRAFIKLER";
            this.Text = "VTGS";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBLEPARTI;
        private System.Windows.Forms.Label LBLDPARTI;
        private System.Windows.Forms.Label LBLCPARTI;
        private System.Windows.Forms.Label LBLBPARTI;
        private System.Windows.Forms.Label LBLAPARTI;
        private System.Windows.Forms.ProgressBar PRGSEPARTI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar PRGSDPARTI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar PRGSCPARTI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PRGSBPARTI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PRGSAPARTI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}