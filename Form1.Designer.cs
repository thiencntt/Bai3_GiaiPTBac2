namespace Bai3_GiaiPTBac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ số a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(93, 65);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(147, 26);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(93, 97);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(147, 26);
            this.txtB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hệ số b";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(93, 129);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(147, 26);
            this.txtC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hệ số c";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(21, 233);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(64, 20);
            this.lblKQ.TabIndex = 7;
            this.lblKQ.Text = "Kết quả";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(16, 170);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(224, 43);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "GIẢI PHƯƠNG TRÌNH";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 425);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnTinh;
    }
}

