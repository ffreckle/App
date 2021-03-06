﻿namespace App
{
    partial class ConstructorForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tkaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet1 = new App.ShopDataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new App.ShopDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.furnitureTableAdapter = new App.ShopDataSetTableAdapters.furnitureTableAdapter();
            this.tkaniTableAdapter = new App.ShopDataSet1TableAdapters.tkaniTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название изделия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип ткани";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tkaniBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id";
            // 
            // tkaniBindingSource
            // 
            this.tkaniBindingSource.DataMember = "tkani";
            this.tkaniBindingSource.DataSource = this.shopDataSet1;
            // 
            // shopDataSet1
            // 
            this.shopDataSet1.DataSetName = "ShopDataSet1";
            this.shopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Длина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ширина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Тип фурнитуры";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.furnitureBindingSource;
            this.comboBox2.DisplayMember = "Наименование";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "id";
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "furniture";
            this.furnitureBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(198, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 367);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Схема изделия";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // tkaniTableAdapter
            // 
            this.tkaniTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Просмотр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Добавить ткань";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ConstructorForm";
            this.Text = "KonstructorForm";
            this.Load += new System.EventHandler(this.ConstructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private ShopDataSetTableAdapters.furnitureTableAdapter furnitureTableAdapter;
        private ShopDataSet1 shopDataSet1;
        private System.Windows.Forms.BindingSource tkaniBindingSource;
        private ShopDataSet1TableAdapters.tkaniTableAdapter tkaniTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}