﻿
namespace Kursovaya_work
{
    partial class prosmotr_uslug
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.id_sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sr,
            this.fio_client,
            this.brand,
            this.date_time,
            this.service,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 447);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(643, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Просмотр доступных услуг";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(898, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(618, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(738, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ФИО клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Фирма телефона";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(992, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1163, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Услуга";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(995, 249);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Samsung",
            "Iphone",
            "Xiaomi",
            "Huawei",
            "LG",
            "Lenovo"});
            this.comboBox3.Location = new System.Drawing.Point(858, 248);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Диагностика мобильного телефона",
            "Замена контроллёра питания мобильного телефона",
            "Замена дисплея мобильного телефона",
            "Замена разъёма зарядки мобильного телефона",
            "Замена сим-лотка мобильного телефона",
            "Замена материнской платы мобильного телефона",
            "Переустановка операционной системы телефона",
            "Чистка мобильного телефона после попадания влаги",
            "Установка защитного стекла мобильного телефона",
            "Замена кнопок громкости мобильного телефона или планшета"});
            this.comboBox2.Location = new System.Drawing.Point(1166, 248);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(888, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 60);
            this.button3.TabIndex = 17;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_sr
            // 
            this.id_sr.HeaderText = "id";
            this.id_sr.Name = "id_sr";
            // 
            // fio_client
            // 
            this.fio_client.HeaderText = "ФИО клиента";
            this.fio_client.Name = "fio_client";
            // 
            // brand
            // 
            this.brand.HeaderText = "Фирма";
            this.brand.Name = "brand";
            // 
            // date_time
            // 
            this.date_time.HeaderText = "Дата и врeмя";
            this.date_time.Name = "date_time";
            // 
            // service
            // 
            this.service.HeaderText = "Услуга";
            this.service.Name = "service";
            this.service.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Стоимость";
            this.Column1.Name = "Column1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(888, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Стоимость услуги";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(1148, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 64);
            this.button4.TabIndex = 20;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // prosmotr_uslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1368, 447);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "prosmotr_uslug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр услуг";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.prosmotr_uslug_FormClosed);
            this.Load += new System.EventHandler(this.prosmotr_uslug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}