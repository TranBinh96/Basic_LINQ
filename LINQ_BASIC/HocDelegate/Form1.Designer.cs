namespace HocDelegate
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
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnEvenNumber = new System.Windows.Forms.Button();
            this.btnOddNumber = new System.Windows.Forms.Button();
            this.btnPrimeNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 25;
            this.lstSo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.lstSo.Location = new System.Drawing.Point(15, 12);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(211, 454);
            this.lstSo.TabIndex = 0;
            // 
            // btnEvenNumber
            // 
            this.btnEvenNumber.Location = new System.Drawing.Point(291, 56);
            this.btnEvenNumber.Name = "btnEvenNumber";
            this.btnEvenNumber.Size = new System.Drawing.Size(164, 68);
            this.btnEvenNumber.TabIndex = 1;
            this.btnEvenNumber.Text = "Even Number";
            this.btnEvenNumber.UseVisualStyleBackColor = true;
            this.btnEvenNumber.Click += new System.EventHandler(this.btnEvenNumber_Click);
            // 
            // btnOddNumber
            // 
            this.btnOddNumber.Location = new System.Drawing.Point(291, 164);
            this.btnOddNumber.Name = "btnOddNumber";
            this.btnOddNumber.Size = new System.Drawing.Size(164, 68);
            this.btnOddNumber.TabIndex = 1;
            this.btnOddNumber.Text = "Odd Number";
            this.btnOddNumber.UseVisualStyleBackColor = true;
            this.btnOddNumber.Click += new System.EventHandler(this.btnOddNumber_Click);
            // 
            // btnPrimeNumber
            // 
            this.btnPrimeNumber.Location = new System.Drawing.Point(291, 287);
            this.btnPrimeNumber.Name = "btnPrimeNumber";
            this.btnPrimeNumber.Size = new System.Drawing.Size(164, 68);
            this.btnPrimeNumber.TabIndex = 1;
            this.btnPrimeNumber.Text = "Prime Number";
            this.btnPrimeNumber.UseVisualStyleBackColor = true;
            this.btnPrimeNumber.Click += new System.EventHandler(this.btnPrimeNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 479);
            this.Controls.Add(this.btnPrimeNumber);
            this.Controls.Add(this.btnOddNumber);
            this.Controls.Add(this.btnEvenNumber);
            this.Controls.Add(this.lstSo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnEvenNumber;
        private System.Windows.Forms.Button btnOddNumber;
        private System.Windows.Forms.Button btnPrimeNumber;
    }
}

