
namespace UniCalculator
{
    partial class DonemOrtalama
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
            this.dersSayiNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gecmeNotTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dersSayiNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // dersSayiNumeric
            // 
            this.dersSayiNumeric.Location = new System.Drawing.Point(84, 12);
            this.dersSayiNumeric.Name = "dersSayiNumeric";
            this.dersSayiNumeric.Size = new System.Drawing.Size(120, 20);
            this.dersSayiNumeric.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders sayisi : ";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(223, 9);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "HESAPLA";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gecme Notu : ";
            // 
            // gecmeNotTXT
            // 
            this.gecmeNotTXT.Location = new System.Drawing.Point(84, 41);
            this.gecmeNotTXT.Name = "gecmeNotTXT";
            this.gecmeNotTXT.Size = new System.Drawing.Size(100, 20);
            this.gecmeNotTXT.TabIndex = 4;
            // 
            // DonemOrtalama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(336, 83);
            this.Controls.Add(this.gecmeNotTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dersSayiNumeric);
            this.Name = "DonemOrtalama";
            this.Text = "DonemOrtalama";
            ((System.ComponentModel.ISupportInitialize)(this.dersSayiNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown dersSayiNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gecmeNotTXT;
    }
}