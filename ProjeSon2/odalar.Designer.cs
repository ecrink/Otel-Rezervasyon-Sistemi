namespace ProjeSon2
{
    partial class odalar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnodakaydet = new System.Windows.Forms.Button();
            this.btnodasil = new System.Windows.Forms.Button();
            this.txtodaNo = new System.Windows.Forms.TextBox();
            this.txtOdaFiyat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmcboxOdatur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbdoluluk = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbdoluluk);
            this.groupBox1.Controls.Add(this.cmcboxOdatur);
            this.groupBox1.Controls.Add(this.txtOdaFiyat);
            this.groupBox1.Controls.Add(this.txtodaNo);
            this.groupBox1.Controls.Add(this.btnodasil);
            this.groupBox1.Controls.Add(this.btnodakaydet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ODA EKLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oda Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oda Durumu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(820, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "ODA BİLGİLERİ";
            // 
            // btnodakaydet
            // 
            this.btnodakaydet.Location = new System.Drawing.Point(208, 342);
            this.btnodakaydet.Name = "btnodakaydet";
            this.btnodakaydet.Size = new System.Drawing.Size(145, 51);
            this.btnodakaydet.TabIndex = 4;
            this.btnodakaydet.Text = "ODA KAYDET";
            this.btnodakaydet.UseVisualStyleBackColor = true;
            this.btnodakaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnodasil
            // 
            this.btnodasil.Location = new System.Drawing.Point(208, 399);
            this.btnodasil.Name = "btnodasil";
            this.btnodasil.Size = new System.Drawing.Size(145, 57);
            this.btnodasil.TabIndex = 5;
            this.btnodasil.Text = "ODA SİL";
            this.btnodasil.UseVisualStyleBackColor = true;
            // 
            // txtodaNo
            // 
            this.txtodaNo.Location = new System.Drawing.Point(254, 85);
            this.txtodaNo.Name = "txtodaNo";
            this.txtodaNo.Size = new System.Drawing.Size(162, 26);
            this.txtodaNo.TabIndex = 7;
            this.txtodaNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOdaFiyat
            // 
            this.txtOdaFiyat.Location = new System.Drawing.Point(254, 154);
            this.txtOdaFiyat.Name = "txtOdaFiyat";
            this.txtOdaFiyat.Size = new System.Drawing.Size(162, 26);
            this.txtOdaFiyat.TabIndex = 8;
            this.txtOdaFiyat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(661, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(506, 525);
            this.dataGridView1.TabIndex = 3;
            // 
            // cmcboxOdatur
            // 
            this.cmcboxOdatur.FormattingEnabled = true;
            this.cmcboxOdatur.Items.AddRange(new object[] {
            "Tek Kişilik",
            "Çift Kişilik",
            "Üç Kişilik"});
            this.cmcboxOdatur.Location = new System.Drawing.Point(254, 217);
            this.cmcboxOdatur.Name = "cmcboxOdatur";
            this.cmcboxOdatur.Size = new System.Drawing.Size(162, 28);
            this.cmcboxOdatur.TabIndex = 12;
            this.cmcboxOdatur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1011, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "ANA MENÜ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbdoluluk
            // 
            this.cbdoluluk.FormattingEnabled = true;
            this.cbdoluluk.Items.AddRange(new object[] {
            "Dolu ",
            "Boş"});
            this.cbdoluluk.Location = new System.Drawing.Point(254, 289);
            this.cbdoluluk.Name = "cbdoluluk";
            this.cbdoluluk.Size = new System.Drawing.Size(121, 28);
            this.cbdoluluk.TabIndex = 13;
            this.cbdoluluk.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "odalar";
            this.Text = "odalar";
            this.Load += new System.EventHandler(this.odalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnodasil;
        private System.Windows.Forms.Button btnodakaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdaFiyat;
        private System.Windows.Forms.TextBox txtodaNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmcboxOdatur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbdoluluk;
    }
}