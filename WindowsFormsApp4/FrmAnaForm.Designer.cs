namespace WindowsFormsApp4
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MskMaas = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CmbSehir = new System.Windows.Forms.ComboBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGRAFİKLER = new System.Windows.Forms.Button();
            this.btnİSTATİKLER = new System.Windows.Forms.Button();
            this.btnTEMİZLE = new System.Windows.Forms.Button();
            this.bnGÜNCELLE = new System.Windows.Forms.Button();
            this.btnSİL = new System.Windows.Forms.Button();
            this.btnKAYDET = new System.Windows.Forms.Button();
            this.btnLİSTELE = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_veri_tabaniDataSet2 = new WindowsFormsApp4.personel_veri_tabaniDataSet2();
            this.table_1TableAdapter = new WindowsFormsApp4.personel_veri_tabaniDataSet2TableAdapters.Table_1TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_veri_tabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMeslek);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MskMaas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.CmbSehir);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 526);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL KAYIT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(214, 282);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(121, 32);
            this.TxtMeslek.TabIndex = 3;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(214, 93);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(121, 32);
            this.TxtAd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Personel MESLEK";
            // 
            // MskMaas
            // 
            this.MskMaas.Location = new System.Drawing.Point(214, 210);
            this.MskMaas.Name = "MskMaas";
            this.MskMaas.Size = new System.Drawing.Size(121, 32);
            this.MskMaas.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Personel DURUM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Personel MAAŞ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Personel ŞEHİR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Personel SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Personel AD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Personel ID";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(285, 248);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 28);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "BEKAR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(214, 248);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 28);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EVLİ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CmbSehir
            // 
            this.CmbSehir.FormattingEnabled = true;
            this.CmbSehir.Location = new System.Drawing.Point(214, 172);
            this.CmbSehir.Name = "CmbSehir";
            this.CmbSehir.Size = new System.Drawing.Size(121, 32);
            this.CmbSehir.TabIndex = 4;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(214, 131);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(121, 32);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(214, 55);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(121, 32);
            this.TxtId.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGRAFİKLER);
            this.groupBox2.Controls.Add(this.btnİSTATİKLER);
            this.groupBox2.Controls.Add(this.btnTEMİZLE);
            this.groupBox2.Controls.Add(this.bnGÜNCELLE);
            this.groupBox2.Controls.Add(this.btnSİL);
            this.groupBox2.Controls.Add(this.btnKAYDET);
            this.groupBox2.Controls.Add(this.btnLİSTELE);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(427, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 500);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btnGRAFİKLER
            // 
            this.btnGRAFİKLER.Location = new System.Drawing.Point(147, 310);
            this.btnGRAFİKLER.Name = "btnGRAFİKLER";
            this.btnGRAFİKLER.Size = new System.Drawing.Size(135, 36);
            this.btnGRAFİKLER.TabIndex = 6;
            this.btnGRAFİKLER.Text = "GRAFİKLER";
            this.btnGRAFİKLER.UseVisualStyleBackColor = true;
            this.btnGRAFİKLER.Click += new System.EventHandler(this.btnGRAFİKLER_Click);
            // 
            // btnİSTATİKLER
            // 
            this.btnİSTATİKLER.Location = new System.Drawing.Point(147, 268);
            this.btnİSTATİKLER.Name = "btnİSTATİKLER";
            this.btnİSTATİKLER.Size = new System.Drawing.Size(135, 36);
            this.btnİSTATİKLER.TabIndex = 5;
            this.btnİSTATİKLER.Text = "İSTATİKLER";
            this.btnİSTATİKLER.UseVisualStyleBackColor = true;
            this.btnİSTATİKLER.Click += new System.EventHandler(this.btnİSTATİKLER_Click);
            // 
            // btnTEMİZLE
            // 
            this.btnTEMİZLE.Location = new System.Drawing.Point(147, 226);
            this.btnTEMİZLE.Name = "btnTEMİZLE";
            this.btnTEMİZLE.Size = new System.Drawing.Size(135, 36);
            this.btnTEMİZLE.TabIndex = 4;
            this.btnTEMİZLE.Text = "TEMİZLE";
            this.btnTEMİZLE.UseVisualStyleBackColor = true;
            this.btnTEMİZLE.Click += new System.EventHandler(this.btnTEMİZLE_Click);
            // 
            // bnGÜNCELLE
            // 
            this.bnGÜNCELLE.Location = new System.Drawing.Point(147, 184);
            this.bnGÜNCELLE.Name = "bnGÜNCELLE";
            this.bnGÜNCELLE.Size = new System.Drawing.Size(135, 36);
            this.bnGÜNCELLE.TabIndex = 3;
            this.bnGÜNCELLE.Text = "GÜNCELLE";
            this.bnGÜNCELLE.UseVisualStyleBackColor = true;
            this.bnGÜNCELLE.Click += new System.EventHandler(this.bnGÜNCELLE_Click);
            // 
            // btnSİL
            // 
            this.btnSİL.Location = new System.Drawing.Point(147, 142);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(135, 36);
            this.btnSİL.TabIndex = 2;
            this.btnSİL.Text = "SİL";
            this.btnSİL.UseVisualStyleBackColor = true;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // btnKAYDET
            // 
            this.btnKAYDET.Location = new System.Drawing.Point(147, 100);
            this.btnKAYDET.Name = "btnKAYDET";
            this.btnKAYDET.Size = new System.Drawing.Size(135, 36);
            this.btnKAYDET.TabIndex = 1;
            this.btnKAYDET.Text = "KAYDET";
            this.btnKAYDET.UseVisualStyleBackColor = true;
            this.btnKAYDET.Click += new System.EventHandler(this.btnKAYDET_Click);
            // 
            // btnLİSTELE
            // 
            this.btnLİSTELE.Location = new System.Drawing.Point(147, 58);
            this.btnLİSTELE.Name = "btnLİSTELE";
            this.btnLİSTELE.Size = new System.Drawing.Size(135, 36);
            this.btnLİSTELE.TabIndex = 0;
            this.btnLİSTELE.Text = "LİSTELE";
            this.btnLİSTELE.UseVisualStyleBackColor = true;
            this.btnLİSTELE.Click += new System.EventHandler(this.btnLİSTELE_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 566);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1213, 278);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KAYITLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1207, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.personel_veri_tabaniDataSet2;
            // 
            // personel_veri_tabaniDataSet2
            // 
            this.personel_veri_tabaniDataSet2.DataSetName = "personel_veri_tabaniDataSet2";
            this.personel_veri_tabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(787, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(854, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1273, 856);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_veri_tabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox MskMaas;
        private System.Windows.Forms.ComboBox CmbSehir;
        private System.Windows.Forms.TextBox TxtMeslek;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button btnGRAFİKLER;
        private System.Windows.Forms.Button btnİSTATİKLER;
        private System.Windows.Forms.Button btnTEMİZLE;
        private System.Windows.Forms.Button bnGÜNCELLE;
        private System.Windows.Forms.Button btnSİL;
        private System.Windows.Forms.Button btnKAYDET;
        private System.Windows.Forms.Button btnLİSTELE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private personel_veri_tabaniDataSet2 personel_veri_tabaniDataSet2;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private personel_veri_tabaniDataSet2TableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

