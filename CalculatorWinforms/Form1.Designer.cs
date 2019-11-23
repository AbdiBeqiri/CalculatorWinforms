namespace CalculatorWinforms
{
    partial class Form1
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
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtFirstOperand = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtSecondOperand = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 541);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(206, 100);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 435);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(118, 435);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(224, 435);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 329);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(118, 329);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(224, 329);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 223);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(118, 223);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(224, 223);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(330, 223);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(100, 100);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(330, 329);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 100);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(330, 435);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(100, 100);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(330, 541);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(100, 100);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(436, 435);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(100, 206);
            this.btnEquals.TabIndex = 14;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(436, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 100);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(436, 223);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(100, 100);
            this.btnClearAll.TabIndex = 16;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 117);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResult.Size = new System.Drawing.Size(524, 100);
            this.txtResult.TabIndex = 17;
            // 
            // txtFirstOperand
            // 
            this.txtFirstOperand.Location = new System.Drawing.Point(12, 12);
            this.txtFirstOperand.Multiline = true;
            this.txtFirstOperand.Name = "txtFirstOperand";
            this.txtFirstOperand.ReadOnly = true;
            this.txtFirstOperand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstOperand.Size = new System.Drawing.Size(206, 100);
            this.txtFirstOperand.TabIndex = 18;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(224, 12);
            this.txtOperator.Multiline = true;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.ReadOnly = true;
            this.txtOperator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOperator.Size = new System.Drawing.Size(100, 100);
            this.txtOperator.TabIndex = 19;
            // 
            // txtSecondOperand
            // 
            this.txtSecondOperand.Location = new System.Drawing.Point(330, 12);
            this.txtSecondOperand.Multiline = true;
            this.txtSecondOperand.Name = "txtSecondOperand";
            this.txtSecondOperand.ReadOnly = true;
            this.txtSecondOperand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSecondOperand.Size = new System.Drawing.Size(206, 100);
            this.txtSecondOperand.TabIndex = 20;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(224, 541);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 100);
            this.button18.TabIndex = 21;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 656);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.txtSecondOperand);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtFirstOperand);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtFirstOperand;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtSecondOperand;
        private System.Windows.Forms.Button button18;
    }
}

