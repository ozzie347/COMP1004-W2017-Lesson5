namespace COMP1004_W2017_Lesson5
{
    partial class Calculator
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
            this.CalculatorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CalculatorTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculatorTableLayout
            // 
            this.CalculatorTableLayout.ColumnCount = 4;
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.Controls.Add(this.button20, 3, 4);
            this.CalculatorTableLayout.Controls.Add(this.button19, 2, 4);
            this.CalculatorTableLayout.Controls.Add(this.button18, 1, 4);
            this.CalculatorTableLayout.Controls.Add(this.button17, 0, 4);
            this.CalculatorTableLayout.Controls.Add(this.button16, 3, 3);
            this.CalculatorTableLayout.Controls.Add(this.button15, 2, 3);
            this.CalculatorTableLayout.Controls.Add(this.button14, 1, 3);
            this.CalculatorTableLayout.Controls.Add(this.button13, 0, 3);
            this.CalculatorTableLayout.Controls.Add(this.button11, 2, 2);
            this.CalculatorTableLayout.Controls.Add(this.button10, 1, 2);
            this.CalculatorTableLayout.Controls.Add(this.button9, 0, 2);
            this.CalculatorTableLayout.Controls.Add(this.button8, 3, 1);
            this.CalculatorTableLayout.Controls.Add(this.button7, 2, 1);
            this.CalculatorTableLayout.Controls.Add(this.button6, 1, 1);
            this.CalculatorTableLayout.Controls.Add(this.button5, 0, 1);
            this.CalculatorTableLayout.Controls.Add(this.button4, 3, 0);
            this.CalculatorTableLayout.Controls.Add(this.button3, 2, 0);
            this.CalculatorTableLayout.Controls.Add(this.button2, 1, 0);
            this.CalculatorTableLayout.Controls.Add(this.button1, 0, 0);
            this.CalculatorTableLayout.Controls.Add(this.button12, 3, 2);
            this.CalculatorTableLayout.Location = new System.Drawing.Point(22, 194);
            this.CalculatorTableLayout.Name = "CalculatorTableLayout";
            this.CalculatorTableLayout.RowCount = 5;
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.Size = new System.Drawing.Size(246, 213);
            this.CalculatorTableLayout.TabIndex = 2;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(186, 171);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(55, 36);
            this.button20.TabIndex = 19;
            this.button20.Tag = "Operator";
            this.button20.Text = "=";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(125, 171);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 36);
            this.button19.TabIndex = 18;
            this.button19.Tag = "Other";
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(64, 171);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(55, 36);
            this.button18.TabIndex = 17;
            this.button18.Tag = "Operand";
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(3, 171);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(55, 36);
            this.button17.TabIndex = 16;
            this.button17.Tag = "Other";
            this.button17.Text = "±";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(186, 129);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 36);
            this.button16.TabIndex = 15;
            this.button16.Tag = "Operator";
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(125, 129);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 36);
            this.button15.TabIndex = 14;
            this.button15.Tag = "Operand";
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(64, 129);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 36);
            this.button14.TabIndex = 13;
            this.button14.Tag = "Operand";
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 129);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 36);
            this.button13.TabIndex = 12;
            this.button13.Tag = "Operand";
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(125, 87);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 36);
            this.button11.TabIndex = 10;
            this.button11.Tag = "Operand";
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(64, 87);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 36);
            this.button10.TabIndex = 9;
            this.button10.Tag = "Operand";
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 36);
            this.button9.TabIndex = 8;
            this.button9.Tag = "Operand";
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(186, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 36);
            this.button8.TabIndex = 7;
            this.button8.Tag = "Operator";
            this.button8.Text = "x";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(125, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 36);
            this.button7.TabIndex = 6;
            this.button7.Tag = "Operand";
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(64, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 36);
            this.button6.TabIndex = 5;
            this.button6.Tag = "Operand";
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 36);
            this.button5.TabIndex = 4;
            this.button5.Tag = "Operand";
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 36);
            this.button4.TabIndex = 3;
            this.button4.Tag = "Operator";
            this.button4.Text = "÷";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 36);
            this.button3.TabIndex = 2;
            this.button3.Tag = "Other";
            this.button3.Text = "←";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 36);
            this.button2.TabIndex = 1;
            this.button2.Tag = "Other";
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 36);
            this.button1.TabIndex = 0;
            this.button1.Tag = "Other";
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(186, 87);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 36);
            this.button12.TabIndex = 11;
            this.button12.Tag = "Operator";
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this._CalculatorButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(22, 127);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResultTextBox.Size = new System.Drawing.Size(246, 64);
            this.ResultTextBox.TabIndex = 3;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::COMP1004_W2017_Lesson5.Properties.Resources.CalculatorLogo;
            this.LogoPictureBox.Location = new System.Drawing.Point(1, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(300, 90);
            this.LogoPictureBox.TabIndex = 4;
            this.LogoPictureBox.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CalculatorTableLayout);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.CalculatorTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayout;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}