
namespace sum_all_numbers
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
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.btnSumEvery = new System.Windows.Forms.Button();
            this.btnSumEven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Location = new System.Drawing.Point(201, 104);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(147, 20);
            this.txtBoxNum.TabIndex = 1;
            // 
            // btnSumEvery
            // 
            this.btnSumEvery.Location = new System.Drawing.Point(33, 157);
            this.btnSumEvery.Name = "btnSumEvery";
            this.btnSumEvery.Size = new System.Drawing.Size(143, 37);
            this.btnSumEvery.TabIndex = 2;
            this.btnSumEvery.Text = "Sum Every Number";
            this.btnSumEvery.UseVisualStyleBackColor = true;
            this.btnSumEvery.Click += new System.EventHandler(this.btnSumEvery_Click);
            // 
            // btnSumEven
            // 
            this.btnSumEven.Location = new System.Drawing.Point(201, 157);
            this.btnSumEven.Name = "btnSumEven";
            this.btnSumEven.Size = new System.Drawing.Size(147, 37);
            this.btnSumEven.TabIndex = 3;
            this.btnSumEven.Text = "Sum Even Numbers";
            this.btnSumEven.UseVisualStyleBackColor = true;
            this.btnSumEven.Click += new System.EventHandler(this.btnSumEven_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSumEven);
            this.Controls.Add(this.btnSumEvery);
            this.Controls.Add(this.txtBoxNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.Button btnSumEvery;
        private System.Windows.Forms.Button btnSumEven;
    }
}

