
namespace UniCalculator
{
    partial class TekDersOrtalama
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
            this.vizeTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.finalTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.totalNotTXT = new System.Windows.Forms.Label();
            this.harfPuaniTXT = new System.Windows.Forms.Label();
            this.harfKarsiligiTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize Notunuz : ";
            // 
            // vizeTxtBox
            // 
            this.vizeTxtBox.Location = new System.Drawing.Point(97, 6);
            this.vizeTxtBox.Name = "vizeTxtBox";
            this.vizeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.vizeTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Notunuz :";
            // 
            // finalTxtBox
            // 
            this.finalTxtBox.Location = new System.Drawing.Point(96, 55);
            this.finalTxtBox.Name = "finalTxtBox";
            this.finalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.finalTxtBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalNotTXT
            // 
            this.totalNotTXT.AutoSize = true;
            this.totalNotTXT.Location = new System.Drawing.Point(12, 145);
            this.totalNotTXT.Name = "totalNotTXT";
            this.totalNotTXT.Size = new System.Drawing.Size(51, 13);
            this.totalNotTXT.TabIndex = 5;
            this.totalNotTXT.Text = "Total Not";
            // 
            // harfPuaniTXT
            // 
            this.harfPuaniTXT.AutoSize = true;
            this.harfPuaniTXT.Location = new System.Drawing.Point(12, 175);
            this.harfPuaniTXT.Name = "harfPuaniTXT";
            this.harfPuaniTXT.Size = new System.Drawing.Size(57, 13);
            this.harfPuaniTXT.TabIndex = 6;
            this.harfPuaniTXT.Text = "Harf Puanı";
            // 
            // harfKarsiligiTXT
            // 
            this.harfKarsiligiTXT.AutoSize = true;
            this.harfKarsiligiTXT.Location = new System.Drawing.Point(12, 208);
            this.harfKarsiligiTXT.Name = "harfKarsiligiTXT";
            this.harfKarsiligiTXT.Size = new System.Drawing.Size(65, 13);
            this.harfKarsiligiTXT.TabIndex = 7;
            this.harfKarsiligiTXT.Text = "Harf Karşılığı";
            // 
            // TekDersOrtalama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 265);
            this.Controls.Add(this.harfKarsiligiTXT);
            this.Controls.Add(this.harfPuaniTXT);
            this.Controls.Add(this.totalNotTXT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vizeTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "TekDersOrtalama";
            this.Text = "TekDersOrtalama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vizeTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox finalTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalNotTXT;
        private System.Windows.Forms.Label harfPuaniTXT;
        private System.Windows.Forms.Label harfKarsiligiTXT;
    }
}