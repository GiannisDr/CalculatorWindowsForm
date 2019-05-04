namespace WindowsFormsApp2
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
            this.Seven = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.CleanUp = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.Debug = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(12, 107);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(75, 45);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(93, 158);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(75, 45);
            this.Five.TabIndex = 2;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(93, 107);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(75, 45);
            this.Eight.TabIndex = 3;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(12, 211);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(75, 45);
            this.One.TabIndex = 4;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 158);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(75, 45);
            this.Four.TabIndex = 5;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(174, 211);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(75, 45);
            this.Three.TabIndex = 6;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(174, 158);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(75, 45);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(174, 107);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(75, 45);
            this.Nine.TabIndex = 8;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(93, 211);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(75, 45);
            this.Two.TabIndex = 9;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(93, 262);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 45);
            this.Zero.TabIndex = 10;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Result.Location = new System.Drawing.Point(255, 211);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 96);
            this.Result.TabIndex = 11;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Resuslt_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Multiplication.Location = new System.Drawing.Point(12, 56);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 45);
            this.Multiplication.TabIndex = 13;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Subtraction.Location = new System.Drawing.Point(255, 56);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(75, 45);
            this.Subtraction.TabIndex = 14;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Addition.Location = new System.Drawing.Point(174, 56);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(75, 45);
            this.Addition.TabIndex = 15;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Division.Location = new System.Drawing.Point(93, 56);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 45);
            this.Division.TabIndex = 16;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DisplayBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DisplayBox.Size = new System.Drawing.Size(318, 38);
            this.DisplayBox.TabIndex = 17;
            this.DisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CleanUp
            // 
            this.CleanUp.Location = new System.Drawing.Point(12, 262);
            this.CleanUp.Name = "CleanUp";
            this.CleanUp.Size = new System.Drawing.Size(75, 45);
            this.CleanUp.TabIndex = 18;
            this.CleanUp.Text = "CE";
            this.CleanUp.UseVisualStyleBackColor = true;
            this.CleanUp.Click += new System.EventHandler(this.CleanUp_Click);
            // 
            // Comma
            // 
            this.Comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Comma.Location = new System.Drawing.Point(174, 262);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(75, 45);
            this.Comma.TabIndex = 19;
            this.Comma.Text = ",";
            this.Comma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.Click += new System.EventHandler(this.Comma_Click);
            // 
            // Debug
            // 
            this.Debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Debug.Location = new System.Drawing.Point(12, 313);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(87, 26);
            this.Debug.TabIndex = 20;
            this.Debug.Text = "DebugButton";
            this.Debug.UseVisualStyleBackColor = true;
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // Backspace
            // 
            this.Backspace.Location = new System.Drawing.Point(255, 107);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(75, 45);
            this.Backspace.TabIndex = 21;
            this.Backspace.Text = "Backspace";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 351);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.CleanUp);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Seven);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox DisplayBox;
        //private System.Windows.Forms.TextBox NewText;
        private System.Windows.Forms.Button CleanUp;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button Debug;
        private System.Windows.Forms.Button Backspace;
    }
}

