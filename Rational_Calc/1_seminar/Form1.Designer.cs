namespace _1_seminar
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
            this.bttnSum = new System.Windows.Forms.Button();
            this.bttnSubtraction = new System.Windows.Forms.Button();
            this.bttnMult = new System.Windows.Forms.Button();
            this.bttnDiv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnClean = new System.Windows.Forms.Button();
            this.bttnEquality = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnSum
            // 
            this.bttnSum.Location = new System.Drawing.Point(12, 82);
            this.bttnSum.Name = "bttnSum";
            this.bttnSum.Size = new System.Drawing.Size(75, 23);
            this.bttnSum.TabIndex = 0;
            this.bttnSum.Text = "+";
            this.bttnSum.UseVisualStyleBackColor = true;
            this.bttnSum.Click += new System.EventHandler(this.bttnSum_Click);
            // 
            // bttnSubtraction
            // 
            this.bttnSubtraction.Location = new System.Drawing.Point(12, 111);
            this.bttnSubtraction.Name = "bttnSubtraction";
            this.bttnSubtraction.Size = new System.Drawing.Size(75, 23);
            this.bttnSubtraction.TabIndex = 1;
            this.bttnSubtraction.Text = "-";
            this.bttnSubtraction.UseVisualStyleBackColor = true;
            this.bttnSubtraction.Click += new System.EventHandler(this.bttnSubtraction_Click);
            // 
            // bttnMult
            // 
            this.bttnMult.Location = new System.Drawing.Point(93, 82);
            this.bttnMult.Name = "bttnMult";
            this.bttnMult.Size = new System.Drawing.Size(75, 23);
            this.bttnMult.TabIndex = 2;
            this.bttnMult.Text = "*";
            this.bttnMult.UseVisualStyleBackColor = true;
            this.bttnMult.Click += new System.EventHandler(this.bttnMult_Click);
            // 
            // bttnDiv
            // 
            this.bttnDiv.Location = new System.Drawing.Point(91, 111);
            this.bttnDiv.Name = "bttnDiv";
            this.bttnDiv.Size = new System.Drawing.Size(75, 23);
            this.bttnDiv.TabIndex = 3;
            this.bttnDiv.Text = "/";
            this.bttnDiv.UseVisualStyleBackColor = true;
            this.bttnDiv.Click += new System.EventHandler(this.bttnDiv_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(74, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            // 
            // bttnClean
            // 
            this.bttnClean.Location = new System.Drawing.Point(57, 169);
            this.bttnClean.Name = "bttnClean";
            this.bttnClean.Size = new System.Drawing.Size(75, 23);
            this.bttnClean.TabIndex = 11;
            this.bttnClean.Text = "Clean";
            this.bttnClean.UseVisualStyleBackColor = true;
            this.bttnClean.Click += new System.EventHandler(this.bttnClean_Click);
            // 
            // bttnEquality
            // 
            this.bttnEquality.Location = new System.Drawing.Point(57, 140);
            this.bttnEquality.Name = "bttnEquality";
            this.bttnEquality.Size = new System.Drawing.Size(75, 23);
            this.bttnEquality.TabIndex = 12;
            this.bttnEquality.Text = "=";
            this.bttnEquality.UseVisualStyleBackColor = true;
            this.bttnEquality.Click += new System.EventHandler(this.bttnEquality_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 202);
            this.Controls.Add(this.bttnEquality);
            this.Controls.Add(this.bttnClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttnDiv);
            this.Controls.Add(this.bttnMult);
            this.Controls.Add(this.bttnSubtraction);
            this.Controls.Add(this.bttnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnSum;
        private System.Windows.Forms.Button bttnSubtraction;
        private System.Windows.Forms.Button bttnMult;
        private System.Windows.Forms.Button bttnDiv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnClean;
        private System.Windows.Forms.Button bttnEquality;
    }
}

