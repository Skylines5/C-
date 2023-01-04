namespace calc
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
            this.calculatorScreen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.allClearBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.prevValLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculatorScreen
            // 
            this.calculatorScreen.Location = new System.Drawing.Point(12, 49);
            this.calculatorScreen.Name = "calculatorScreen";
            this.calculatorScreen.ReadOnly = true;
            this.calculatorScreen.Size = new System.Drawing.Size(318, 23);
            this.calculatorScreen.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 136);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(174, 136);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(255, 78);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(75, 23);
            this.plusBtn.TabIndex = 10;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.HandleOperation);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(255, 107);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(75, 23);
            this.minusBtn.TabIndex = 11;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.HandleOperation);
            // 
            // divideBtn
            // 
            this.divideBtn.Location = new System.Drawing.Point(255, 136);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(75, 23);
            this.divideBtn.TabIndex = 12;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.HandleOperation);
            // 
            // equalsBtn
            // 
            this.equalsBtn.Location = new System.Drawing.Point(255, 194);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(75, 23);
            this.equalsBtn.TabIndex = 13;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.EqualsBtn);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 165);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(237, 23);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 194);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(110, 23);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Clear);
            // 
            // allClearBtn
            // 
            this.allClearBtn.Location = new System.Drawing.Point(128, 194);
            this.allClearBtn.Name = "allClearBtn";
            this.allClearBtn.Size = new System.Drawing.Size(121, 23);
            this.allClearBtn.TabIndex = 16;
            this.allClearBtn.Text = "AC";
            this.allClearBtn.UseVisualStyleBackColor = true;
            this.allClearBtn.Click += new System.EventHandler(this.AllClear);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(255, 165);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(75, 23);
            this.multiplyBtn.TabIndex = 18;
            this.multiplyBtn.Text = "*";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.HandleOperation);
            // 
            // prevValLabel
            // 
            this.prevValLabel.Location = new System.Drawing.Point(12, 20);
            this.prevValLabel.Name = "prevValLabel";
            this.prevValLabel.ReadOnly = true;
            this.prevValLabel.Size = new System.Drawing.Size(318, 23);
            this.prevValLabel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 244);
            this.Controls.Add(this.prevValLabel);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.allClearBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.equalsBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calculatorScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox calculatorScreen;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button plusBtn;
        private Button minusBtn;
        private Button divideBtn;
        private Button equalsBtn;
        private Button button0;
        private Button clearBtn;
        private Button allClearBtn;
        private Button multiplyBtn;
        private TextBox prevValLabel;
    }
}