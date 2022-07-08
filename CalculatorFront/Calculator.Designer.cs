namespace CalculatorFront
{
    partial class Calculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Dot = new System.Windows.Forms.Button();
            this.BackArrow = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Equation = new System.Windows.Forms.TextBox();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.LeftParenthesis = new System.Windows.Forms.Button();
            this.RightParenthesis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.Location = new System.Drawing.Point(173, 472);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(50, 60);
            this.Dot.TabIndex = 4;
            this.Dot.Tag = "\".\"";
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.ButtonClick);
            // 
            // BackArrow
            // 
            this.BackArrow.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackArrow.Location = new System.Drawing.Point(244, 236);
            this.BackArrow.Name = "BackArrow";
            this.BackArrow.Size = new System.Drawing.Size(50, 60);
            this.BackArrow.TabIndex = 11;
            this.BackArrow.Tag = "\"←\"";
            this.BackArrow.Text = "←";
            this.BackArrow.UseVisualStyleBackColor = true;
            this.BackArrow.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(311, 236);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 60);
            this.Clear.TabIndex = 12;
            this.Clear.Tag = "\"C\"";
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(244, 312);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 60);
            this.Divide.TabIndex = 13;
            this.Divide.Tag = "\"÷\"";
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Multiply
            // 
            this.Multiply.Cursor = System.Windows.Forms.Cursors.Default;
            this.Multiply.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(311, 312);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(50, 60);
            this.Multiply.TabIndex = 14;
            this.Multiply.Tag = "\"×\"";
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(311, 393);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 60);
            this.Minus.TabIndex = 16;
            this.Minus.Tag = "\"-\"";
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(311, 472);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(50, 60);
            this.Equal.TabIndex = 17;
            this.Equal.Tag = "\"=\"";
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Result
            // 
            this.Result.AutoEllipsis = true;
            this.Result.BackColor = System.Drawing.SystemColors.Window;
            this.Result.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Result.ForeColor = System.Drawing.Color.Black;
            this.Result.Location = new System.Drawing.Point(105, 114);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(281, 24);
            this.Result.TabIndex = 19;
            this.Result.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Equation
            // 
            this.Equation.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Equation.Location = new System.Drawing.Point(40, 46);
            this.Equation.Multiline = true;
            this.Equation.Name = "Equation";
            this.Equation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Equation.Size = new System.Drawing.Size(355, 101);
            this.Equation.TabIndex = 18;
            this.Equation.Text = "0";
            this.Equation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClearEntry
            // 
            this.ClearEntry.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntry.Location = new System.Drawing.Point(244, 472);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(50, 60);
            this.ClearEntry.TabIndex = 20;
            this.ClearEntry.Tag = "\"CE\"";
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = true;
            this.ClearEntry.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(244, 395);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(50, 60);
            this.Plus.TabIndex = 15;
            this.Plus.Tag = "\"+\"";
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(40, 236);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(50, 60);
            this.Seven.TabIndex = 10;
            this.Seven.Tag = "7";
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(105, 236);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(50, 60);
            this.Eight.TabIndex = 9;
            this.Eight.Tag = "8";
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(173, 236);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(50, 60);
            this.Nine.TabIndex = 8;
            this.Nine.Tag = "9";
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(40, 312);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(50, 60);
            this.Four.TabIndex = 7;
            this.Four.Tag = "4";
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(105, 312);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(50, 60);
            this.Five.TabIndex = 6;
            this.Five.Tag = "5";
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(173, 312);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(50, 60);
            this.Six.TabIndex = 5;
            this.Six.Tag = "6";
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(173, 395);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(50, 60);
            this.Three.TabIndex = 3;
            this.Three.Tag = "3";
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(105, 395);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(50, 60);
            this.Two.TabIndex = 2;
            this.Two.Tag = "2";
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(40, 472);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(120, 60);
            this.Zero.TabIndex = 1;
            this.Zero.Tag = "0";
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.ButtonClick);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(40, 395);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(50, 60);
            this.One.TabIndex = 0;
            this.One.Tag = "1";
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.ButtonClick);
            // 
            // SqrtButton
            // 
            this.SqrtButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqrtButton.Location = new System.Drawing.Point(380, 236);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(50, 60);
            this.SqrtButton.TabIndex = 21;
            this.SqrtButton.Tag = "\"√\"";
            this.SqrtButton.Text = "√";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // LeftParenthesis
            // 
            this.LeftParenthesis.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftParenthesis.Location = new System.Drawing.Point(380, 312);
            this.LeftParenthesis.Name = "LeftParenthesis";
            this.LeftParenthesis.Size = new System.Drawing.Size(50, 60);
            this.LeftParenthesis.TabIndex = 22;
            this.LeftParenthesis.Tag = "\"(\"";
            this.LeftParenthesis.Text = "(";
            this.LeftParenthesis.UseVisualStyleBackColor = true;
            this.LeftParenthesis.Click += new System.EventHandler(this.ButtonClick);
            // 
            // RightParenthesis
            // 
            this.RightParenthesis.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightParenthesis.Location = new System.Drawing.Point(380, 393);
            this.RightParenthesis.Name = "RightParenthesis";
            this.RightParenthesis.Size = new System.Drawing.Size(50, 60);
            this.RightParenthesis.TabIndex = 23;
            this.RightParenthesis.Tag = "\")\"";
            this.RightParenthesis.Text = ")";
            this.RightParenthesis.UseVisualStyleBackColor = true;
            this.RightParenthesis.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.RightParenthesis);
            this.Controls.Add(this.LeftParenthesis);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Equation);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BackArrow);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.One);
            this.Name = "Calculator";
            this.Text = "小算盤";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button BackArrow;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Equation;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button SqrtButton;
        private System.Windows.Forms.Button LeftParenthesis;
        private System.Windows.Forms.Button RightParenthesis;
    }
}

