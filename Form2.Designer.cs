﻿
namespace MyApp
{
    partial class Form2
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
            this.textBoxGetByNameOrSurname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonGetSmallerGrades = new System.Windows.Forms.RadioButton();
            this.btnGetByLinq = new System.Windows.Forms.Button();
            this.radioButtonGetByName = new System.Windows.Forms.RadioButton();
            this.radioButtonGetByTextBox = new System.Windows.Forms.RadioButton();
            this.radioButtonGetBySurname = new System.Windows.Forms.RadioButton();
            this.radioButtonGetByBiggerNameSmallSurname = new System.Windows.Forms.RadioButton();
            this.radioButtonConditionalSelect = new System.Windows.Forms.RadioButton();
            this.radioButtonPassOrFail = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxGetByNameOrSurname
            // 
            this.textBoxGetByNameOrSurname.Location = new System.Drawing.Point(263, 247);
            this.textBoxGetByNameOrSurname.MaxLength = 5000;
            this.textBoxGetByNameOrSurname.Name = "textBoxGetByNameOrSurname";
            this.textBoxGetByNameOrSurname.Size = new System.Drawing.Size(82, 20);
            this.textBoxGetByNameOrSurname.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 250);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Adı veya SoyAdı:";
            // 
            // radioButtonGetSmallerGrades
            // 
            this.radioButtonGetSmallerGrades.AutoSize = true;
            this.radioButtonGetSmallerGrades.Location = new System.Drawing.Point(13, 202);
            this.radioButtonGetSmallerGrades.Name = "radioButtonGetSmallerGrades";
            this.radioButtonGetSmallerGrades.Size = new System.Drawing.Size(166, 17);
            this.radioButtonGetSmallerGrades.TabIndex = 35;
            this.radioButtonGetSmallerGrades.TabStop = true;
            this.radioButtonGetSmallerGrades.Text = "1. Sınavı 50\'den Küçük Notlar";
            this.radioButtonGetSmallerGrades.UseVisualStyleBackColor = true;
            // 
            // btnGetByLinq
            // 
            this.btnGetByLinq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetByLinq.Location = new System.Drawing.Point(12, 397);
            this.btnGetByLinq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetByLinq.Name = "btnGetByLinq";
            this.btnGetByLinq.Size = new System.Drawing.Size(194, 47);
            this.btnGetByLinq.TabIndex = 34;
            this.btnGetByLinq.Text = "Linq Entity";
            this.btnGetByLinq.UseVisualStyleBackColor = true;
            this.btnGetByLinq.Click += new System.EventHandler(this.btnGetByLinq_Click);
            // 
            // radioButtonGetByName
            // 
            this.radioButtonGetByName.AutoSize = true;
            this.radioButtonGetByName.Location = new System.Drawing.Point(13, 225);
            this.radioButtonGetByName.Name = "radioButtonGetByName";
            this.radioButtonGetByName.Size = new System.Drawing.Size(99, 17);
            this.radioButtonGetByName.TabIndex = 38;
            this.radioButtonGetByName.TabStop = true;
            this.radioButtonGetByName.Text = "Adı Ferit Olanlar";
            this.radioButtonGetByName.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetByTextBox
            // 
            this.radioButtonGetByTextBox.AutoSize = true;
            this.radioButtonGetByTextBox.Location = new System.Drawing.Point(13, 248);
            this.radioButtonGetByTextBox.Name = "radioButtonGetByTextBox";
            this.radioButtonGetByTextBox.Size = new System.Drawing.Size(150, 17);
            this.radioButtonGetByTextBox.TabIndex = 39;
            this.radioButtonGetByTextBox.TabStop = true;
            this.radioButtonGetByTextBox.Text = "Textten Gelen Veriye Göre";
            this.radioButtonGetByTextBox.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetBySurname
            // 
            this.radioButtonGetBySurname.AutoSize = true;
            this.radioButtonGetBySurname.Location = new System.Drawing.Point(13, 271);
            this.radioButtonGetBySurname.Name = "radioButtonGetBySurname";
            this.radioButtonGetBySurname.Size = new System.Drawing.Size(95, 17);
            this.radioButtonGetBySurname.TabIndex = 40;
            this.radioButtonGetBySurname.TabStop = true;
            this.radioButtonGetBySurname.Text = "Soyadına Göre";
            this.radioButtonGetBySurname.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetByBiggerNameSmallSurname
            // 
            this.radioButtonGetByBiggerNameSmallSurname.AutoSize = true;
            this.radioButtonGetByBiggerNameSmallSurname.Location = new System.Drawing.Point(12, 294);
            this.radioButtonGetByBiggerNameSmallSurname.Name = "radioButtonGetByBiggerNameSmallSurname";
            this.radioButtonGetByBiggerNameSmallSurname.Size = new System.Drawing.Size(138, 17);
            this.radioButtonGetByBiggerNameSmallSurname.TabIndex = 41;
            this.radioButtonGetByBiggerNameSmallSurname.TabStop = true;
            this.radioButtonGetByBiggerNameSmallSurname.Text = "Ad Büyük Soyad Küçük";
            this.radioButtonGetByBiggerNameSmallSurname.UseVisualStyleBackColor = true;
            // 
            // radioButtonConditionalSelect
            // 
            this.radioButtonConditionalSelect.AutoSize = true;
            this.radioButtonConditionalSelect.Location = new System.Drawing.Point(12, 317);
            this.radioButtonConditionalSelect.Name = "radioButtonConditionalSelect";
            this.radioButtonConditionalSelect.Size = new System.Drawing.Size(80, 17);
            this.radioButtonConditionalSelect.TabIndex = 42;
            this.radioButtonConditionalSelect.TabStop = true;
            this.radioButtonConditionalSelect.Text = "Şartlı Seçim";
            this.radioButtonConditionalSelect.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassOrFail
            // 
            this.radioButtonPassOrFail.AutoSize = true;
            this.radioButtonPassOrFail.Location = new System.Drawing.Point(12, 340);
            this.radioButtonPassOrFail.Name = "radioButtonPassOrFail";
            this.radioButtonPassOrFail.Size = new System.Drawing.Size(102, 17);
            this.radioButtonPassOrFail.TabIndex = 43;
            this.radioButtonPassOrFail.TabStop = true;
            this.radioButtonPassOrFail.Text = "Geçti mi Kaldı mı";
            this.radioButtonPassOrFail.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonPassOrFail);
            this.Controls.Add(this.radioButtonConditionalSelect);
            this.Controls.Add(this.radioButtonGetByBiggerNameSmallSurname);
            this.Controls.Add(this.radioButtonGetBySurname);
            this.Controls.Add(this.radioButtonGetByTextBox);
            this.Controls.Add(this.radioButtonGetByName);
            this.Controls.Add(this.textBoxGetByNameOrSurname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioButtonGetSmallerGrades);
            this.Controls.Add(this.btnGetByLinq);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxGetByNameOrSurname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButtonGetSmallerGrades;
        private System.Windows.Forms.Button btnGetByLinq;
        private System.Windows.Forms.RadioButton radioButtonGetByName;
        private System.Windows.Forms.RadioButton radioButtonGetByTextBox;
        private System.Windows.Forms.RadioButton radioButtonGetBySurname;
        private System.Windows.Forms.RadioButton radioButtonGetByBiggerNameSmallSurname;
        private System.Windows.Forms.RadioButton radioButtonConditionalSelect;
        private System.Windows.Forms.RadioButton radioButtonPassOrFail;
    }
}