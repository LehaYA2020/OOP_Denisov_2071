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
            this.bttnClean = new System.Windows.Forms.Button();
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.button_Color = new System.Windows.Forms.Button();
            this.HeightValue = new System.Windows.Forms.NumericUpDown();
            this.RadiusValue = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.WeightSumVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRec = new System.Windows.Forms.Panel();
            this.panelCir = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panelTrain = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lengthValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.NumericUpDown();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.unloadBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValue)).BeginInit();
            this.panelRec.SuspendLayout();
            this.panelCir.SuspendLayout();
            this.panelTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lValue)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnClean
            // 
            this.bttnClean.Location = new System.Drawing.Point(575, 442);
            this.bttnClean.Name = "bttnClean";
            this.bttnClean.Size = new System.Drawing.Size(75, 23);
            this.bttnClean.TabIndex = 3;
            this.bttnClean.Text = "Очистить";
            this.bttnClean.UseVisualStyleBackColor = true;
            this.bttnClean.Click += new System.EventHandler(this.bttnClean_Click);
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(6, 18);
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
            // 
            // button_Color
            // 
            this.button_Color.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Color.Location = new System.Drawing.Point(295, 439);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(37, 23);
            this.button_Color.TabIndex = 5;
            this.button_Color.UseVisualStyleBackColor = false;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(72, 21);
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
            // 
            // RadiusValue
            // 
            this.RadiusValue.Location = new System.Drawing.Point(3, 21);
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WeightSumVal
            // 
            this.WeightSumVal.Location = new System.Drawing.Point(507, 420);
            this.WeightSumVal.Name = "WeightSumVal";
            this.WeightSumVal.Size = new System.Drawing.Size(143, 20);
            this.WeightSumVal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Длина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Радиус";
            // 
            // panelRec
            // 
            this.panelRec.Controls.Add(this.WidthValue);
            this.panelRec.Controls.Add(this.HeightValue);
            this.panelRec.Controls.Add(this.label2);
            this.panelRec.Controls.Add(this.label1);
            this.panelRec.Location = new System.Drawing.Point(0, 419);
            this.panelRec.Name = "panelRec";
            this.panelRec.Size = new System.Drawing.Size(120, 44);
            this.panelRec.TabIndex = 16;
            this.panelRec.Visible = false;
            // 
            // panelCir
            // 
            this.panelCir.Controls.Add(this.RadiusValue);
            this.panelCir.Controls.Add(this.label3);
            this.panelCir.Location = new System.Drawing.Point(126, 419);
            this.panelCir.Name = "panelCir";
            this.panelCir.Size = new System.Drawing.Size(55, 44);
            this.panelCir.TabIndex = 17;
            this.panelCir.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 389);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(338, 396);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Круг";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(338, 417);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Прямоугольник";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(449, 419);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Move";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(338, 440);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Вагон";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton4_MouseClick);
            // 
            // panelTrain
            // 
            this.panelTrain.Controls.Add(this.label5);
            this.panelTrain.Controls.Add(this.lengthValue);
            this.panelTrain.Controls.Add(this.label4);
            this.panelTrain.Controls.Add(this.lValue);
            this.panelTrain.Location = new System.Drawing.Point(187, 419);
            this.panelTrain.Name = "panelTrain";
            this.panelTrain.Size = new System.Drawing.Size(102, 44);
            this.panelTrain.TabIndex = 21;
            this.panelTrain.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Длина";
            // 
            // lengthValue
            // 
            this.lengthValue.Location = new System.Drawing.Point(50, 21);
            this.lengthValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lengthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthValue.Name = "lengthValue";
            this.lengthValue.Size = new System.Drawing.Size(49, 20);
            this.lengthValue.TabIndex = 17;
            this.lengthValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "L";
            // 
            // lValue
            // 
            this.lValue.Location = new System.Drawing.Point(3, 21);
            this.lValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(40, 20);
            this.lValue.TabIndex = 0;
            this.lValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(449, 396);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(57, 17);
            this.radioButton5.TabIndex = 22;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Поезд";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton5_MouseClick);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(449, 439);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(44, 17);
            this.AddRadioButton.TabIndex = 23;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Add";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // unloadBttn
            // 
            this.unloadBttn.Location = new System.Drawing.Point(575, 472);
            this.unloadBttn.Name = "unloadBttn";
            this.unloadBttn.Size = new System.Drawing.Size(75, 23);
            this.unloadBttn.TabIndex = 25;
            this.unloadBttn.Text = "Unload";
            this.unloadBttn.UseVisualStyleBackColor = true;
            this.unloadBttn.Click += new System.EventHandler(this.unloadBttn_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 507);
            this.Controls.Add(this.unloadBttn);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.panelTrain);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCir);
            this.Controls.Add(this.panelRec);
            this.Controls.Add(this.WeightSumVal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Color);
            this.Controls.Add(this.bttnClean);
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValue)).EndInit();
            this.panelRec.ResumeLayout(false);
            this.panelRec.PerformLayout();
            this.panelCir.ResumeLayout(false);
            this.panelCir.PerformLayout();
            this.panelTrain.ResumeLayout(false);
            this.panelTrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnClean;
        private System.Windows.Forms.NumericUpDown WidthValue;
        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.NumericUpDown HeightValue;
        private System.Windows.Forms.NumericUpDown RadiusValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WeightSumVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelRec;
        private System.Windows.Forms.Panel panelCir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panelTrain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lValue;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown lengthValue;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.Button unloadBttn;
    }
}

