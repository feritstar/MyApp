
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
            this.radioButtonJoin = new System.Windows.Forms.RadioButton();
            this.radioButtonGetFirstThree = new System.Windows.Forms.RadioButton();
            this.radioButtonGetLastThree = new System.Windows.Forms.RadioButton();
            this.radioButtonSkipFirstFive = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderByName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1172, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxGetByNameOrSurname
            // 
            this.textBoxGetByNameOrSurname.Location = new System.Drawing.Point(394, 591);
            this.textBoxGetByNameOrSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxGetByNameOrSurname.MaxLength = 5000;
            this.textBoxGetByNameOrSurname.Name = "textBoxGetByNameOrSurname";
            this.textBoxGetByNameOrSurname.Size = new System.Drawing.Size(121, 26);
            this.textBoxGetByNameOrSurname.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 595);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Adı veya SoyAdı:";
            // 
            // radioButtonGetSmallerGrades
            // 
            this.radioButtonGetSmallerGrades.AutoSize = true;
            this.radioButtonGetSmallerGrades.Location = new System.Drawing.Point(20, 522);
            this.radioButtonGetSmallerGrades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGetSmallerGrades.Name = "radioButtonGetSmallerGrades";
            this.radioButtonGetSmallerGrades.Size = new System.Drawing.Size(232, 24);
            this.radioButtonGetSmallerGrades.TabIndex = 35;
            this.radioButtonGetSmallerGrades.TabStop = true;
            this.radioButtonGetSmallerGrades.Text = "1. Sınavı 50\'den Küçük Notlar";
            this.radioButtonGetSmallerGrades.UseVisualStyleBackColor = true;
            // 
            // btnGetByLinq
            // 
            this.btnGetByLinq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetByLinq.Location = new System.Drawing.Point(18, 665);
            this.btnGetByLinq.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGetByLinq.Name = "btnGetByLinq";
            this.btnGetByLinq.Size = new System.Drawing.Size(291, 72);
            this.btnGetByLinq.TabIndex = 34;
            this.btnGetByLinq.Text = "Linq Entity";
            this.btnGetByLinq.UseVisualStyleBackColor = true;
            this.btnGetByLinq.Click += new System.EventHandler(this.btnGetByLinq_Click);
            // 
            // radioButtonGetByName
            // 
            this.radioButtonGetByName.AutoSize = true;
            this.radioButtonGetByName.Location = new System.Drawing.Point(20, 557);
            this.radioButtonGetByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGetByName.Name = "radioButtonGetByName";
            this.radioButtonGetByName.Size = new System.Drawing.Size(140, 24);
            this.radioButtonGetByName.TabIndex = 38;
            this.radioButtonGetByName.TabStop = true;
            this.radioButtonGetByName.Text = "Adı Ferit Olanlar";
            this.radioButtonGetByName.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetByTextBox
            // 
            this.radioButtonGetByTextBox.AutoSize = true;
            this.radioButtonGetByTextBox.Location = new System.Drawing.Point(20, 592);
            this.radioButtonGetByTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGetByTextBox.Name = "radioButtonGetByTextBox";
            this.radioButtonGetByTextBox.Size = new System.Drawing.Size(215, 24);
            this.radioButtonGetByTextBox.TabIndex = 39;
            this.radioButtonGetByTextBox.TabStop = true;
            this.radioButtonGetByTextBox.Text = "Textten Gelen Veriye Göre";
            this.radioButtonGetByTextBox.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetBySurname
            // 
            this.radioButtonGetBySurname.AutoSize = true;
            this.radioButtonGetBySurname.Location = new System.Drawing.Point(20, 628);
            this.radioButtonGetBySurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGetBySurname.Name = "radioButtonGetBySurname";
            this.radioButtonGetBySurname.Size = new System.Drawing.Size(133, 24);
            this.radioButtonGetBySurname.TabIndex = 40;
            this.radioButtonGetBySurname.TabStop = true;
            this.radioButtonGetBySurname.Text = "Soyadına Göre";
            this.radioButtonGetBySurname.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetByBiggerNameSmallSurname
            // 
            this.radioButtonGetByBiggerNameSmallSurname.AutoSize = true;
            this.radioButtonGetByBiggerNameSmallSurname.Location = new System.Drawing.Point(576, 522);
            this.radioButtonGetByBiggerNameSmallSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGetByBiggerNameSmallSurname.Name = "radioButtonGetByBiggerNameSmallSurname";
            this.radioButtonGetByBiggerNameSmallSurname.Size = new System.Drawing.Size(192, 24);
            this.radioButtonGetByBiggerNameSmallSurname.TabIndex = 41;
            this.radioButtonGetByBiggerNameSmallSurname.TabStop = true;
            this.radioButtonGetByBiggerNameSmallSurname.Text = "Ad Büyük Soyad Küçük";
            this.radioButtonGetByBiggerNameSmallSurname.UseVisualStyleBackColor = true;
            // 
            // radioButtonConditionalSelect
            // 
            this.radioButtonConditionalSelect.AutoSize = true;
            this.radioButtonConditionalSelect.Location = new System.Drawing.Point(576, 557);
            this.radioButtonConditionalSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonConditionalSelect.Name = "radioButtonConditionalSelect";
            this.radioButtonConditionalSelect.Size = new System.Drawing.Size(111, 24);
            this.radioButtonConditionalSelect.TabIndex = 42;
            this.radioButtonConditionalSelect.TabStop = true;
            this.radioButtonConditionalSelect.Text = "Şartlı Seçim";
            this.radioButtonConditionalSelect.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassOrFail
            // 
            this.radioButtonPassOrFail.AutoSize = true;
            this.radioButtonPassOrFail.Location = new System.Drawing.Point(576, 593);
            this.radioButtonPassOrFail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPassOrFail.Name = "radioButtonPassOrFail";
            this.radioButtonPassOrFail.Size = new System.Drawing.Size(143, 24);
            this.radioButtonPassOrFail.TabIndex = 43;
            this.radioButtonPassOrFail.TabStop = true;
            this.radioButtonPassOrFail.Text = "Geçti mi Kaldı mı";
            this.radioButtonPassOrFail.UseVisualStyleBackColor = true;
            // 
            // radioButtonJoin
            // 
            this.radioButtonJoin.AutoSize = true;
            this.radioButtonJoin.Location = new System.Drawing.Point(578, 628);
            this.radioButtonJoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonJoin.Name = "radioButtonJoin";
            this.radioButtonJoin.Size = new System.Drawing.Size(79, 24);
            this.radioButtonJoin.TabIndex = 44;
            this.radioButtonJoin.TabStop = true;
            this.radioButtonJoin.Text = "Birleştir";
            this.radioButtonJoin.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetFirstThree
            // 
            this.radioButtonGetFirstThree.AutoSize = true;
            this.radioButtonGetFirstThree.Location = new System.Drawing.Point(818, 522);
            this.radioButtonGetFirstThree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGetFirstThree.Name = "radioButtonGetFirstThree";
            this.radioButtonGetFirstThree.Size = new System.Drawing.Size(136, 24);
            this.radioButtonGetFirstThree.TabIndex = 45;
            this.radioButtonGetFirstThree.TabStop = true;
            this.radioButtonGetFirstThree.Text = "İlk Üç Değeri Al";
            this.radioButtonGetFirstThree.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetLastThree
            // 
            this.radioButtonGetLastThree.AutoSize = true;
            this.radioButtonGetLastThree.Location = new System.Drawing.Point(818, 556);
            this.radioButtonGetLastThree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonGetLastThree.Name = "radioButtonGetLastThree";
            this.radioButtonGetLastThree.Size = new System.Drawing.Size(149, 24);
            this.radioButtonGetLastThree.TabIndex = 46;
            this.radioButtonGetLastThree.TabStop = true;
            this.radioButtonGetLastThree.Text = "Son Üç Değeri Al";
            this.radioButtonGetLastThree.UseVisualStyleBackColor = true;
            // 
            // radioButtonSkipFirstFive
            // 
            this.radioButtonSkipFirstFive.AutoSize = true;
            this.radioButtonSkipFirstFive.Location = new System.Drawing.Point(818, 590);
            this.radioButtonSkipFirstFive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSkipFirstFive.Name = "radioButtonSkipFirstFive";
            this.radioButtonSkipFirstFive.Size = new System.Drawing.Size(158, 24);
            this.radioButtonSkipFirstFive.TabIndex = 47;
            this.radioButtonSkipFirstFive.TabStop = true;
            this.radioButtonSkipFirstFive.Text = "İlk Beş Değeri Atla";
            this.radioButtonSkipFirstFive.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrderByName
            // 
            this.radioButtonOrderByName.AutoSize = true;
            this.radioButtonOrderByName.Location = new System.Drawing.Point(818, 624);
            this.radioButtonOrderByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOrderByName.Name = "radioButtonOrderByName";
            this.radioButtonOrderByName.Size = new System.Drawing.Size(140, 24);
            this.radioButtonOrderByName.TabIndex = 48;
            this.radioButtonOrderByName.TabStop = true;
            this.radioButtonOrderByName.Text = "Ada Göre Sırala";
            this.radioButtonOrderByName.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 749);
            this.Controls.Add(this.radioButtonOrderByName);
            this.Controls.Add(this.radioButtonSkipFirstFive);
            this.Controls.Add(this.radioButtonGetLastThree);
            this.Controls.Add(this.radioButtonGetFirstThree);
            this.Controls.Add(this.radioButtonJoin);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.RadioButton radioButtonJoin;
        private System.Windows.Forms.RadioButton radioButtonGetFirstThree;
        private System.Windows.Forms.RadioButton radioButtonGetLastThree;
        private System.Windows.Forms.RadioButton radioButtonSkipFirstFive;
        private System.Windows.Forms.RadioButton radioButtonOrderByName;
    }
}