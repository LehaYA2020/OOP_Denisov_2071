﻿namespace Again_Paint
{
    partial class Paint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Circle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.bttnClean = new System.Windows.Forms.Button();
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.button_Color = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 392);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(134, 405);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(75, 23);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(134, 434);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(75, 23);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.Text = "Квадрат";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // bttnClean
            // 
            this.bttnClean.Location = new System.Drawing.Point(215, 405);
            this.bttnClean.Name = "bttnClean";
            this.bttnClean.Size = new System.Drawing.Size(75, 23);
            this.bttnClean.TabIndex = 3;
            this.bttnClean.Text = "Очистить";
            this.bttnClean.UseVisualStyleBackColor = true;
            this.bttnClean.Click += new System.EventHandler(this.bttnClean_Click);
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(55, 408);
            this.WidthValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.WidthValue.Name = "WidthValue";
            this.WidthValue.Size = new System.Drawing.Size(45, 20);
            this.WidthValue.TabIndex = 4;
            this.WidthValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.WidthValue.ValueChanged += new System.EventHandler(this.WidthValue_ValueChanged);
            // 
            // button_Color
            // 
            this.button_Color.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Color.Location = new System.Drawing.Point(43, 434);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(75, 23);
            this.button_Color.TabIndex = 5;
            this.button_Color.UseVisualStyleBackColor = false;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 469);
            this.Controls.Add(this.button_Color);
            this.Controls.Add(this.WidthValue);
            this.Controls.Add(this.bttnClean);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button bttnClean;
        private System.Windows.Forms.NumericUpDown WidthValue;
        private System.Windows.Forms.Button button_Color;
    }
}

