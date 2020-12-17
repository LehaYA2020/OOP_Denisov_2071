
namespace calendar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMnth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setDateBttn = new System.Windows.Forms.Button();
            this.nextDateBttn = new System.Windows.Forms.Button();
            this.bttnSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(34, 25);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(33, 20);
            this.textBoxDay.TabIndex = 0;
            this.textBoxDay.TextChanged += new System.EventHandler(this.textBoxDay_TextChanged);
            // 
            // textBoxMnth
            // 
            this.textBoxMnth.Location = new System.Drawing.Point(73, 25);
            this.textBoxMnth.Name = "textBoxMnth";
            this.textBoxMnth.Size = new System.Drawing.Size(33, 20);
            this.textBoxMnth.TabIndex = 1;
            this.textBoxMnth.TextChanged += new System.EventHandler(this.textBoxMnth_TextChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(112, 25);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(33, 20);
            this.textBoxYear.TabIndex = 2;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "День";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Месяц";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Год";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // setDateBttn
            // 
            this.setDateBttn.Location = new System.Drawing.Point(16, 62);
            this.setDateBttn.Name = "setDateBttn";
            this.setDateBttn.Size = new System.Drawing.Size(75, 34);
            this.setDateBttn.TabIndex = 6;
            this.setDateBttn.Text = "Сегодня";
            this.setDateBttn.UseVisualStyleBackColor = true;
            this.setDateBttn.Click += new System.EventHandler(this.setDateBttn_Click);
            // 
            // nextDateBttn
            // 
            this.nextDateBttn.Location = new System.Drawing.Point(97, 62);
            this.nextDateBttn.Name = "nextDateBttn";
            this.nextDateBttn.Size = new System.Drawing.Size(75, 34);
            this.nextDateBttn.TabIndex = 7;
            this.nextDateBttn.Text = "Следующий день";
            this.nextDateBttn.UseVisualStyleBackColor = true;
            this.nextDateBttn.Click += new System.EventHandler(this.nextDateBttn_Click);
            // 
            // bttnSet
            // 
            this.bttnSet.Location = new System.Drawing.Point(178, 62);
            this.bttnSet.Name = "bttnSet";
            this.bttnSet.Size = new System.Drawing.Size(75, 34);
            this.bttnSet.TabIndex = 8;
            this.bttnSet.Text = "Set date";
            this.bttnSet.UseVisualStyleBackColor = true;
            this.bttnSet.Click += new System.EventHandler(this.bttnSet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnSet);
            this.Controls.Add(this.nextDateBttn);
            this.Controls.Add(this.setDateBttn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMnth);
            this.Controls.Add(this.textBoxDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMnth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setDateBttn;
        private System.Windows.Forms.Button nextDateBttn;
        private System.Windows.Forms.Button bttnSet;
        private System.Windows.Forms.Label label4;
    }
}

