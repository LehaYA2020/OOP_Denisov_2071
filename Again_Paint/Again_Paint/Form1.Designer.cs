namespace Again_Paint
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
            this.bttnRectangle = new System.Windows.Forms.Button();
            this.bttnClean = new System.Windows.Forms.Button();
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.button_Color = new System.Windows.Forms.Button();
            this.HeightValue = new System.Windows.Forms.NumericUpDown();
            this.RadiusValue = new System.Windows.Forms.NumericUpDown();
            this.bttnPaint = new System.Windows.Forms.Button();
            this.coordinatesX = new System.Windows.Forms.TextBox();
            this.coordinatesY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValue)).BeginInit();
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
            this.Circle.Location = new System.Drawing.Point(230, 405);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(75, 23);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // bttnRectangle
            // 
            this.bttnRectangle.Location = new System.Drawing.Point(230, 434);
            this.bttnRectangle.Name = "bttnRectangle";
            this.bttnRectangle.Size = new System.Drawing.Size(75, 23);
            this.bttnRectangle.TabIndex = 2;
            this.bttnRectangle.Text = "Квадрат";
            this.bttnRectangle.UseVisualStyleBackColor = true;
            this.bttnRectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // bttnClean
            // 
            this.bttnClean.Location = new System.Drawing.Point(311, 405);
            this.bttnClean.Name = "bttnClean";
            this.bttnClean.Size = new System.Drawing.Size(75, 23);
            this.bttnClean.TabIndex = 3;
            this.bttnClean.Text = "Очистить";
            this.bttnClean.UseVisualStyleBackColor = true;
            this.bttnClean.Click += new System.EventHandler(this.bttnClean_Click);
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(12, 437);
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
            this.button_Color.Location = new System.Drawing.Point(187, 434);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(37, 23);
            this.button_Color.TabIndex = 5;
            this.button_Color.UseVisualStyleBackColor = false;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(75, 437);
            this.HeightValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(45, 20);
            this.HeightValue.TabIndex = 6;
            this.HeightValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.HeightValue.ValueChanged += new System.EventHandler(this.HeightValue_ValueChanged);
            // 
            // RadiusValue
            // 
            this.RadiusValue.Location = new System.Drawing.Point(126, 437);
            this.RadiusValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RadiusValue.Name = "RadiusValue";
            this.RadiusValue.Size = new System.Drawing.Size(41, 20);
            this.RadiusValue.TabIndex = 7;
            this.RadiusValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RadiusValue.ValueChanged += new System.EventHandler(this.RadiusValue_ValueChanged);
            // 
            // bttnPaint
            // 
            this.bttnPaint.Location = new System.Drawing.Point(311, 434);
            this.bttnPaint.Name = "bttnPaint";
            this.bttnPaint.Size = new System.Drawing.Size(90, 23);
            this.bttnPaint.TabIndex = 8;
            this.bttnPaint.Text = "Нарисовать";
            this.bttnPaint.UseVisualStyleBackColor = true;
            this.bttnPaint.Click += new System.EventHandler(this.bttnPaint_Click);
            // 
            // coordinatesX
            // 
            this.coordinatesX.Location = new System.Drawing.Point(515, 398);
            this.coordinatesX.Name = "coordinatesX";
            this.coordinatesX.Size = new System.Drawing.Size(100, 20);
            this.coordinatesX.TabIndex = 9;
            // 
            // coordinatesY
            // 
            this.coordinatesY.Location = new System.Drawing.Point(515, 436);
            this.coordinatesY.Name = "coordinatesY";
            this.coordinatesY.Size = new System.Drawing.Size(100, 20);
            this.coordinatesY.TabIndex = 10;
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 469);
            this.Controls.Add(this.coordinatesY);
            this.Controls.Add(this.coordinatesX);
            this.Controls.Add(this.bttnPaint);
            this.Controls.Add(this.RadiusValue);
            this.Controls.Add(this.HeightValue);
            this.Controls.Add(this.button_Color);
            this.Controls.Add(this.WidthValue);
            this.Controls.Add(this.bttnClean);
            this.Controls.Add(this.bttnRectangle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button bttnRectangle;
        private System.Windows.Forms.Button bttnClean;
        private System.Windows.Forms.NumericUpDown WidthValue;
        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.NumericUpDown HeightValue;
        private System.Windows.Forms.NumericUpDown RadiusValue;
        private System.Windows.Forms.Button bttnPaint;
        private System.Windows.Forms.TextBox coordinatesX;
        private System.Windows.Forms.TextBox coordinatesY;
    }
}

