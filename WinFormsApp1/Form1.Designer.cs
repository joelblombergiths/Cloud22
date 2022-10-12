namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCounter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.txtCase = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLoop = new System.Windows.Forms.Button();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCounterMax = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.calcOp = new System.Windows.Forms.ComboBox();
            this.lblCalcSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calcNum2 = new System.Windows.Forms.NumericUpDown();
            this.calcNum1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtReverse2 = new System.Windows.Forms.TextBox();
            this.txtReverse1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcNum1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(11, 24);
            this.btnCounter.Margin = new System.Windows.Forms.Padding(2);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(79, 24);
            this.btnCounter.TabIndex = 0;
            this.btnCounter.Text = "0";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCounter);
            this.groupBox1.Location = new System.Drawing.Point(199, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(118, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "132. Counter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLower);
            this.groupBox2.Controls.Add(this.btnUpper);
            this.groupBox2.Controls.Add(this.txtCase);
            this.groupBox2.Location = new System.Drawing.Point(321, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(211, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "133. Case";
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(116, 102);
            this.btnLower.Margin = new System.Windows.Forms.Padding(2);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(80, 28);
            this.btnLower.TabIndex = 2;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(4, 102);
            this.btnUpper.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(84, 28);
            this.btnUpper.TabIndex = 1;
            this.btnUpper.Text = "Upper";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // txtCase
            // 
            this.txtCase.Location = new System.Drawing.Point(4, 18);
            this.txtCase.Margin = new System.Windows.Forms.Padding(2);
            this.txtCase.Multiline = true;
            this.txtCase.Name = "txtCase";
            this.txtCase.Size = new System.Drawing.Size(192, 82);
            this.txtCase.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTwo);
            this.groupBox3.Controls.Add(this.btnOne);
            this.groupBox3.Location = new System.Drawing.Point(8, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(186, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "131 Disable/Enable";
            // 
            // btnTwo
            // 
            this.btnTwo.Enabled = false;
            this.btnTwo.Location = new System.Drawing.Point(94, 24);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(88, 24);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "Two";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnUpLow_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 24);
            this.btnOne.Margin = new System.Windows.Forms.Padding(2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(78, 24);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "One";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnUpLow_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLoop);
            this.groupBox4.Controls.Add(this.txtWords);
            this.groupBox4.Location = new System.Drawing.Point(8, 91);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(297, 56);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "134. Loop";
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(179, 20);
            this.btnLoop.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(100, 25);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(4, 22);
            this.txtWords.Margin = new System.Windows.Forms.Padding(2);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(170, 23);
            this.txtWords.TabIndex = 0;
            this.txtWords.TextChanged += new System.EventHandler(this.txtWords_TextChanged);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(13, 22);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(73, 23);
            this.num1.TabIndex = 8;
            this.num1.ValueChanged += new System.EventHandler(this.numericChanged_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCounterMax);
            this.groupBox5.Controls.Add(this.num2);
            this.groupBox5.Controls.Add(this.num1);
            this.groupBox5.Location = new System.Drawing.Point(8, 152);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 85);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "135.  numcounter";
            // 
            // lblCounterMax
            // 
            this.lblCounterMax.AutoSize = true;
            this.lblCounterMax.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCounterMax.Location = new System.Drawing.Point(63, 48);
            this.lblCounterMax.Name = "lblCounterMax";
            this.lblCounterMax.Size = new System.Drawing.Size(23, 28);
            this.lblCounterMax.TabIndex = 10;
            this.lblCounterMax.Text = "0";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(92, 22);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(74, 23);
            this.num2.TabIndex = 9;
            this.num2.ValueChanged += new System.EventHandler(this.numericChanged_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.calcOp);
            this.groupBox6.Controls.Add(this.lblCalcSum);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.calcNum2);
            this.groupBox6.Controls.Add(this.calcNum1);
            this.groupBox6.Location = new System.Drawing.Point(557, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(301, 81);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "136. Calc";
            // 
            // calcOp
            // 
            this.calcOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calcOp.FormattingEnabled = true;
            this.calcOp.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.calcOp.Location = new System.Drawing.Point(89, 26);
            this.calcOp.Name = "calcOp";
            this.calcOp.Size = new System.Drawing.Size(46, 23);
            this.calcOp.TabIndex = 14;
            this.calcOp.SelectedIndexChanged += new System.EventHandler(this.calcUpdate_ValueChanged);
            // 
            // lblCalcSum
            // 
            this.lblCalcSum.AutoSize = true;
            this.lblCalcSum.Location = new System.Drawing.Point(246, 32);
            this.lblCalcSum.Name = "lblCalcSum";
            this.lblCalcSum.Size = new System.Drawing.Size(13, 15);
            this.lblCalcSum.TabIndex = 13;
            this.lblCalcSum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "=";
            // 
            // calcNum2
            // 
            this.calcNum2.Location = new System.Drawing.Point(141, 27);
            this.calcNum2.Name = "calcNum2";
            this.calcNum2.Size = new System.Drawing.Size(74, 23);
            this.calcNum2.TabIndex = 11;
            this.calcNum2.ValueChanged += new System.EventHandler(this.calcUpdate_ValueChanged);
            // 
            // calcNum1
            // 
            this.calcNum1.Location = new System.Drawing.Point(6, 27);
            this.calcNum1.Name = "calcNum1";
            this.calcNum1.Size = new System.Drawing.Size(73, 23);
            this.calcNum1.TabIndex = 10;
            this.calcNum1.ValueChanged += new System.EventHandler(this.calcUpdate_ValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtReverse2);
            this.groupBox7.Controls.Add(this.txtReverse1);
            this.groupBox7.Location = new System.Drawing.Point(192, 152);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(234, 59);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "137. Reverse";
            // 
            // txtReverse2
            // 
            this.txtReverse2.Location = new System.Drawing.Point(119, 22);
            this.txtReverse2.Name = "txtReverse2";
            this.txtReverse2.Size = new System.Drawing.Size(100, 23);
            this.txtReverse2.TabIndex = 1;
            this.txtReverse2.TextChanged += new System.EventHandler(this.txtReverse2_TextChanged);
            // 
            // txtReverse1
            // 
            this.txtReverse1.Location = new System.Drawing.Point(13, 22);
            this.txtReverse1.Name = "txtReverse1";
            this.txtReverse1.Size = new System.Drawing.Size(100, 23);
            this.txtReverse1.TabIndex = 0;
            this.txtReverse1.TextChanged += new System.EventHandler(this.txtReverse1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 422);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcNum1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCounter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnLower;
        private Button btnUpper;
        private TextBox txtCase;
        private GroupBox groupBox3;
        private Button btnTwo;
        private Button btnOne;
        private GroupBox groupBox4;
        private Button btnLoop;
        private TextBox txtWords;
        private NumericUpDown num1;
        private GroupBox groupBox5;
        private Label lblCounterMax;
        private NumericUpDown num2;
        private GroupBox groupBox6;
        private ComboBox calcOp;
        private Label lblCalcSum;
        private Label label1;
        private NumericUpDown calcNum2;
        private NumericUpDown calcNum1;
        private GroupBox groupBox7;
        private TextBox txtReverse2;
        private TextBox txtReverse1;
    }
}