namespace TicTacToe
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
            this.R1C1 = new System.Windows.Forms.Button();
            this.R1C2 = new System.Windows.Forms.Button();
            this.R1C3 = new System.Windows.Forms.Button();
            this.R2C1 = new System.Windows.Forms.Button();
            this.R2C2 = new System.Windows.Forms.Button();
            this.R2C3 = new System.Windows.Forms.Button();
            this.R3C1 = new System.Windows.Forms.Button();
            this.R3C2 = new System.Windows.Forms.Button();
            this.R3C3 = new System.Windows.Forms.Button();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.X_winLabel = new System.Windows.Forms.Label();
            this.O_winLabel = new System.Windows.Forms.Label();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.ResetAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // R1C1
            // 
            this.R1C1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1C1.Location = new System.Drawing.Point(43, 54);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(75, 67);
            this.R1C1.TabIndex = 0;
            this.R1C1.UseVisualStyleBackColor = true;
            this.R1C1.Click += new System.EventHandler(this.Button_Click);
            // 
            // R1C2
            // 
            this.R1C2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1C2.Location = new System.Drawing.Point(124, 54);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(75, 67);
            this.R1C2.TabIndex = 1;
            this.R1C2.UseVisualStyleBackColor = true;
            this.R1C2.Click += new System.EventHandler(this.Button_Click);
            // 
            // R1C3
            // 
            this.R1C3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1C3.Location = new System.Drawing.Point(205, 54);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(75, 67);
            this.R1C3.TabIndex = 2;
            this.R1C3.UseVisualStyleBackColor = true;
            this.R1C3.Click += new System.EventHandler(this.Button_Click);
            // 
            // R2C1
            // 
            this.R2C1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2C1.Location = new System.Drawing.Point(43, 127);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(75, 67);
            this.R2C1.TabIndex = 3;
            this.R2C1.UseVisualStyleBackColor = true;
            this.R2C1.Click += new System.EventHandler(this.Button_Click);
            // 
            // R2C2
            // 
            this.R2C2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2C2.Location = new System.Drawing.Point(124, 127);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(75, 67);
            this.R2C2.TabIndex = 4;
            this.R2C2.UseVisualStyleBackColor = true;
            this.R2C2.Click += new System.EventHandler(this.Button_Click);
            // 
            // R2C3
            // 
            this.R2C3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2C3.Location = new System.Drawing.Point(205, 127);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(75, 67);
            this.R2C3.TabIndex = 5;
            this.R2C3.UseVisualStyleBackColor = true;
            this.R2C3.Click += new System.EventHandler(this.Button_Click);
            // 
            // R3C1
            // 
            this.R3C1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3C1.Location = new System.Drawing.Point(43, 200);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(75, 67);
            this.R3C1.TabIndex = 6;
            this.R3C1.UseVisualStyleBackColor = true;
            this.R3C1.Click += new System.EventHandler(this.Button_Click);
            // 
            // R3C2
            // 
            this.R3C2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3C2.Location = new System.Drawing.Point(124, 200);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(75, 67);
            this.R3C2.TabIndex = 7;
            this.R3C2.UseVisualStyleBackColor = true;
            this.R3C2.Click += new System.EventHandler(this.Button_Click);
            // 
            // R3C3
            // 
            this.R3C3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3C3.Location = new System.Drawing.Point(205, 200);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(75, 67);
            this.R3C3.TabIndex = 8;
            this.R3C3.UseVisualStyleBackColor = true;
            this.R3C3.Click += new System.EventHandler(this.Button_Click);
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Location = new System.Drawing.Point(43, 289);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(37, 15);
            this.TurnLabel.TabIndex = 9;
            this.TurnLabel.Text = "Turn: ";
            // 
            // X_winLabel
            // 
            this.X_winLabel.AutoSize = true;
            this.X_winLabel.Location = new System.Drawing.Point(43, 9);
            this.X_winLabel.Name = "X_winLabel";
            this.X_winLabel.Size = new System.Drawing.Size(23, 15);
            this.X_winLabel.TabIndex = 10;
            this.X_winLabel.Text = "X : ";
            // 
            // O_winLabel
            // 
            this.O_winLabel.AutoSize = true;
            this.O_winLabel.Location = new System.Drawing.Point(264, 9);
            this.O_winLabel.Name = "O_winLabel";
            this.O_winLabel.Size = new System.Drawing.Size(25, 15);
            this.O_winLabel.TabIndex = 11;
            this.O_winLabel.Text = "O : ";
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(221, 289);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(59, 52);
            this.NewGameBtn.TabIndex = 12;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Location = new System.Drawing.Point(139, 36);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(0, 15);
            this.WinnerLabel.TabIndex = 14;
            // 
            // ResetAllBtn
            // 
            this.ResetAllBtn.Location = new System.Drawing.Point(286, 289);
            this.ResetAllBtn.Name = "ResetAllBtn";
            this.ResetAllBtn.Size = new System.Drawing.Size(59, 52);
            this.ResetAllBtn.TabIndex = 15;
            this.ResetAllBtn.Text = "Reset All";
            this.ResetAllBtn.UseVisualStyleBackColor = true;
            this.ResetAllBtn.Click += new System.EventHandler(this.ResetAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 362);
            this.Controls.Add(this.ResetAllBtn);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.O_winLabel);
            this.Controls.Add(this.X_winLabel);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.R3C3);
            this.Controls.Add(this.R3C2);
            this.Controls.Add(this.R3C1);
            this.Controls.Add(this.R2C3);
            this.Controls.Add(this.R2C2);
            this.Controls.Add(this.R2C1);
            this.Controls.Add(this.R1C3);
            this.Controls.Add(this.R1C2);
            this.Controls.Add(this.R1C1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button R1C1;
        private Button R1C2;
        private Button R1C3;
        private Button R2C1;
        private Button R2C2;
        private Button R2C3;
        private Button R3C1;
        private Button R3C2;
        private Button R3C3;
        private Label TurnLabel;
        private Label X_winLabel;
        private Label O_winLabel;
        private Button NewGameBtn;
        private Label WinnerLabel;
        private Button ResetAllBtn;
    }
}