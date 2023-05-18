namespace ПР4
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
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlusLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlusRight = new System.Windows.Forms.Label();
            this.numericUpDownSum = new System.Windows.Forms.NumericUpDown();
            this.labelMinusLeft = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMinusRight = new System.Windows.Forms.Label();
            this.labelTimesLeft = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTimesRight = new System.Windows.Forms.Label();
            this.labelDividedLeft = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelDividedRight = new System.Windows.Forms.Label();
            this.numericUpDownDifference = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownProduct = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuotient = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuotient)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelTime.Location = new System.Drawing.Point(272, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(200, 30);
            this.labelTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оставшееся время";
            // 
            // labelPlusLeft
            // 
            this.labelPlusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelPlusLeft.Location = new System.Drawing.Point(50, 60);
            this.labelPlusLeft.Name = "labelPlusLeft";
            this.labelPlusLeft.Size = new System.Drawing.Size(60, 50);
            this.labelPlusLeft.TabIndex = 2;
            this.labelPlusLeft.Text = "?";
            this.labelPlusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(125, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(275, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlusRight
            // 
            this.labelPlusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelPlusRight.Location = new System.Drawing.Point(200, 60);
            this.labelPlusRight.Name = "labelPlusRight";
            this.labelPlusRight.Size = new System.Drawing.Size(60, 50);
            this.labelPlusRight.TabIndex = 5;
            this.labelPlusRight.Text = "?";
            this.labelPlusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.numericUpDownSum.Location = new System.Drawing.Point(341, 69);
            this.numericUpDownSum.Name = "numericUpDownSum";
            this.numericUpDownSum.Size = new System.Drawing.Size(100, 35);
            this.numericUpDownSum.TabIndex = 1;
            this.numericUpDownSum.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // labelMinusLeft
            // 
            this.labelMinusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelMinusLeft.Location = new System.Drawing.Point(50, 125);
            this.labelMinusLeft.Name = "labelMinusLeft";
            this.labelMinusLeft.Size = new System.Drawing.Size(60, 50);
            this.labelMinusLeft.TabIndex = 7;
            this.labelMinusLeft.Text = "?";
            this.labelMinusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(125, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinusRight
            // 
            this.labelMinusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelMinusRight.Location = new System.Drawing.Point(200, 125);
            this.labelMinusRight.Name = "labelMinusRight";
            this.labelMinusRight.Size = new System.Drawing.Size(60, 50);
            this.labelMinusRight.TabIndex = 9;
            this.labelMinusRight.Text = "?";
            this.labelMinusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimesLeft
            // 
            this.labelTimesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTimesLeft.Location = new System.Drawing.Point(50, 190);
            this.labelTimesLeft.Name = "labelTimesLeft";
            this.labelTimesLeft.Size = new System.Drawing.Size(60, 50);
            this.labelTimesLeft.TabIndex = 11;
            this.labelTimesLeft.Text = "?";
            this.labelTimesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.Location = new System.Drawing.Point(125, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 12;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimesRight
            // 
            this.labelTimesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTimesRight.Location = new System.Drawing.Point(200, 190);
            this.labelTimesRight.Name = "labelTimesRight";
            this.labelTimesRight.Size = new System.Drawing.Size(60, 50);
            this.labelTimesRight.TabIndex = 13;
            this.labelTimesRight.Text = "?";
            this.labelTimesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDividedLeft
            // 
            this.labelDividedLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelDividedLeft.Location = new System.Drawing.Point(50, 255);
            this.labelDividedLeft.Name = "labelDividedLeft";
            this.labelDividedLeft.Size = new System.Drawing.Size(60, 50);
            this.labelDividedLeft.TabIndex = 15;
            this.labelDividedLeft.Text = "?";
            this.labelDividedLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label13.Location = new System.Drawing.Point(125, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 16;
            this.label13.Text = "/";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDividedRight
            // 
            this.labelDividedRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelDividedRight.Location = new System.Drawing.Point(200, 255);
            this.labelDividedRight.Name = "labelDividedRight";
            this.labelDividedRight.Size = new System.Drawing.Size(60, 50);
            this.labelDividedRight.TabIndex = 17;
            this.labelDividedRight.Text = "?";
            this.labelDividedRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownDifference
            // 
            this.numericUpDownDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.numericUpDownDifference.Location = new System.Drawing.Point(341, 134);
            this.numericUpDownDifference.Name = "numericUpDownDifference";
            this.numericUpDownDifference.Size = new System.Drawing.Size(100, 35);
            this.numericUpDownDifference.TabIndex = 2;
            this.numericUpDownDifference.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDownDifference.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // numericUpDownProduct
            // 
            this.numericUpDownProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.numericUpDownProduct.Location = new System.Drawing.Point(341, 199);
            this.numericUpDownProduct.Name = "numericUpDownProduct";
            this.numericUpDownProduct.Size = new System.Drawing.Size(100, 35);
            this.numericUpDownProduct.TabIndex = 3;
            this.numericUpDownProduct.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // numericUpDownQuotient
            // 
            this.numericUpDownQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.numericUpDownQuotient.Location = new System.Drawing.Point(341, 264);
            this.numericUpDownQuotient.Name = "numericUpDownQuotient";
            this.numericUpDownQuotient.Size = new System.Drawing.Size(100, 35);
            this.numericUpDownQuotient.TabIndex = 4;
            this.numericUpDownQuotient.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(275, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 22;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label11.Location = new System.Drawing.Point(275, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 23;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label15.Location = new System.Drawing.Point(275, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 24;
            this.label15.Text = "=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonStart.Location = new System.Drawing.Point(165, 310);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(130, 35);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начать тест";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownQuotient);
            this.Controls.Add(this.numericUpDownProduct);
            this.Controls.Add(this.numericUpDownDifference);
            this.Controls.Add(this.labelDividedRight);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelDividedLeft);
            this.Controls.Add(this.labelTimesRight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTimesLeft);
            this.Controls.Add(this.labelMinusRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMinusLeft);
            this.Controls.Add(this.numericUpDownSum);
            this.Controls.Add(this.labelPlusRight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPlusLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Математический тест";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlusLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlusRight;
        private System.Windows.Forms.NumericUpDown numericUpDownSum;
        private System.Windows.Forms.Label labelMinusLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMinusRight;
        private System.Windows.Forms.Label labelTimesLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTimesRight;
        private System.Windows.Forms.Label labelDividedLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelDividedRight;
        private System.Windows.Forms.NumericUpDown numericUpDownDifference;
        private System.Windows.Forms.NumericUpDown numericUpDownProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownQuotient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

