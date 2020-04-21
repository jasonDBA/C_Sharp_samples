namespace Jabin_Choi_Sec004_Excercise01
{
    partial class JabinChoi_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsync = new System.Windows.Forms.Button();
            this.txtInputAsync = new System.Windows.Forms.TextBox();
            this.outputLabelAsync = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputLabelOdd = new System.Windows.Forms.Label();
            this.btnEvenOdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputEvenOdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputLabelEven = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOutputIndex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtHighIndex = new System.Windows.Forms.TextBox();
            this.txtLowIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.radioChar = new System.Windows.Forms.RadioButton();
            this.radioDouble = new System.Windows.Forms.RadioButton();
            this.radioInt = new System.Windows.Forms.RadioButton();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsync);
            this.groupBox1.Controls.Add(this.txtInputAsync);
            this.groupBox1.Controls.Add(this.outputLabelAsync);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Calculate Asynchronously";
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(66, 69);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(75, 23);
            this.btnAsync.TabIndex = 3;
            this.btnAsync.Text = "Calculate";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // txtInputAsync
            // 
            this.txtInputAsync.Location = new System.Drawing.Point(95, 32);
            this.txtInputAsync.Name = "txtInputAsync";
            this.txtInputAsync.Size = new System.Drawing.Size(100, 20);
            this.txtInputAsync.TabIndex = 2;
            // 
            // outputLabelAsync
            // 
            this.outputLabelAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLabelAsync.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabelAsync.Location = new System.Drawing.Point(10, 111);
            this.outputLabelAsync.Name = "outputLabelAsync";
            this.outputLabelAsync.Size = new System.Drawing.Size(197, 21);
            this.outputLabelAsync.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial of:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.outputLabelOdd);
            this.groupBox2.Controls.Add(this.btnEvenOdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtInputEvenOdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2) Check for Even/Odd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Is the number Odd?";
            // 
            // outputLabelOdd
            // 
            this.outputLabelOdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLabelOdd.AutoSize = true;
            this.outputLabelOdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabelOdd.Location = new System.Drawing.Point(117, 146);
            this.outputLabelOdd.Name = "outputLabelOdd";
            this.outputLabelOdd.Size = new System.Drawing.Size(2, 15);
            this.outputLabelOdd.TabIndex = 6;
            // 
            // btnEvenOdd
            // 
            this.btnEvenOdd.Location = new System.Drawing.Point(36, 67);
            this.btnEvenOdd.Name = "btnEvenOdd";
            this.btnEvenOdd.Size = new System.Drawing.Size(140, 23);
            this.btnEvenOdd.TabIndex = 4;
            this.btnEvenOdd.Text = "Check for Even or Odd";
            this.btnEvenOdd.UseVisualStyleBackColor = true;
            this.btnEvenOdd.Click += new System.EventHandler(this.btnEvenOdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Is the number Even?";
            // 
            // txtInputEvenOdd
            // 
            this.txtInputEvenOdd.Location = new System.Drawing.Point(95, 27);
            this.txtInputEvenOdd.Name = "txtInputEvenOdd";
            this.txtInputEvenOdd.Size = new System.Drawing.Size(100, 20);
            this.txtInputEvenOdd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Number:";
            // 
            // outputLabelEven
            // 
            this.outputLabelEven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLabelEven.AutoSize = true;
            this.outputLabelEven.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabelEven.Location = new System.Drawing.Point(130, 290);
            this.outputLabelEven.Name = "outputLabelEven";
            this.outputLabelEven.Size = new System.Drawing.Size(2, 15);
            this.outputLabelEven.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOutputIndex);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnDisplay);
            this.groupBox3.Controls.Add(this.txtHighIndex);
            this.groupBox3.Controls.Add(this.txtLowIndex);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Controls.Add(this.radioChar);
            this.groupBox3.Controls.Add(this.radioDouble);
            this.groupBox3.Controls.Add(this.radioInt);
            this.groupBox3.Controls.Add(this.outputListBox);
            this.groupBox3.Location = new System.Drawing.Point(232, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 353);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Display List of Values and Search";
            // 
            // txtOutputIndex
            // 
            this.txtOutputIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputIndex.Cursor = System.Windows.Forms.Cursors.No;
            this.txtOutputIndex.Location = new System.Drawing.Point(154, 289);
            this.txtOutputIndex.Multiline = true;
            this.txtOutputIndex.Name = "txtOutputIndex";
            this.txtOutputIndex.Size = new System.Drawing.Size(245, 39);
            this.txtOutputIndex.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Output of values between Low and High";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(324, 193);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 12;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtHighIndex
            // 
            this.txtHighIndex.Location = new System.Drawing.Point(244, 208);
            this.txtHighIndex.Name = "txtHighIndex";
            this.txtHighIndex.Size = new System.Drawing.Size(57, 20);
            this.txtHighIndex.TabIndex = 11;
            // 
            // txtLowIndex
            // 
            this.txtLowIndex.Location = new System.Drawing.Point(243, 182);
            this.txtLowIndex.Name = "txtLowIndex";
            this.txtLowIndex.Size = new System.Drawing.Size(58, 20);
            this.txtLowIndex.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Input High Index:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Input Low Index:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(324, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(243, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(58, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Input Value for Search:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(249, 35);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(116, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Values";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // radioChar
            // 
            this.radioChar.AutoSize = true;
            this.radioChar.Location = new System.Drawing.Point(157, 34);
            this.radioChar.Name = "radioChar";
            this.radioChar.Size = new System.Drawing.Size(47, 17);
            this.radioChar.TabIndex = 3;
            this.radioChar.TabStop = true;
            this.radioChar.Text = "Char";
            this.radioChar.UseVisualStyleBackColor = true;
            // 
            // radioDouble
            // 
            this.radioDouble.AutoSize = true;
            this.radioDouble.Location = new System.Drawing.Point(88, 34);
            this.radioDouble.Name = "radioDouble";
            this.radioDouble.Size = new System.Drawing.Size(64, 17);
            this.radioDouble.TabIndex = 2;
            this.radioDouble.TabStop = true;
            this.radioDouble.Text = "Doubles";
            this.radioDouble.UseVisualStyleBackColor = true;
            // 
            // radioInt
            // 
            this.radioInt.AutoSize = true;
            this.radioInt.Location = new System.Drawing.Point(19, 34);
            this.radioInt.Name = "radioInt";
            this.radioInt.Size = new System.Drawing.Size(63, 17);
            this.radioInt.TabIndex = 1;
            this.radioInt.TabStop = true;
            this.radioInt.Text = "Integers";
            this.radioInt.UseVisualStyleBackColor = true;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(19, 83);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(95, 264);
            this.outputListBox.TabIndex = 0;
            // 
            // JabinChoi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.outputLabelEven);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "JabinChoi_Form";
            this.Text = "Asynchronous Prgramming App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.TextBox txtInputAsync;
        private System.Windows.Forms.Label outputLabelAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEvenOdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputEvenOdd;
        private System.Windows.Forms.Label outputLabelEven;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputLabelOdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton radioChar;
        private System.Windows.Forms.RadioButton radioDouble;
        private System.Windows.Forms.RadioButton radioInt;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtHighIndex;
        private System.Windows.Forms.TextBox txtLowIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

