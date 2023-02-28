
namespace UniCalculator
{
    partial class DonemOrtalamaSonuc
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalNotTxt = new System.Windows.Forms.Label();
            this.harfPuaniTxt = new System.Windows.Forms.Label();
            this.harfKarsiligiTxt = new System.Windows.Forms.Label();
            this.gecmeDurumTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dönem Ortalama Sonuç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notunuz : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harf Puanınız : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harf Karşılığı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Geçme Durumunuz :";
            // 
            // totalNotTxt
            // 
            this.totalNotTxt.AutoSize = true;
            this.totalNotTxt.Location = new System.Drawing.Point(74, 53);
            this.totalNotTxt.Name = "totalNotTxt";
            this.totalNotTxt.Size = new System.Drawing.Size(35, 13);
            this.totalNotTxt.TabIndex = 5;
            this.totalNotTxt.Text = "label6";
            // 
            // harfPuaniTxt
            // 
            this.harfPuaniTxt.AutoSize = true;
            this.harfPuaniTxt.Location = new System.Drawing.Point(97, 81);
            this.harfPuaniTxt.Name = "harfPuaniTxt";
            this.harfPuaniTxt.Size = new System.Drawing.Size(35, 13);
            this.harfPuaniTxt.TabIndex = 7;
            this.harfPuaniTxt.Text = "label7";
            // 
            // harfKarsiligiTxt
            // 
            this.harfKarsiligiTxt.AutoSize = true;
            this.harfKarsiligiTxt.Location = new System.Drawing.Point(92, 111);
            this.harfKarsiligiTxt.Name = "harfKarsiligiTxt";
            this.harfKarsiligiTxt.Size = new System.Drawing.Size(35, 13);
            this.harfKarsiligiTxt.TabIndex = 8;
            this.harfKarsiligiTxt.Text = "label6";
            // 
            // gecmeDurumTxt
            // 
            this.gecmeDurumTxt.AutoSize = true;
            this.gecmeDurumTxt.Location = new System.Drawing.Point(122, 138);
            this.gecmeDurumTxt.Name = "gecmeDurumTxt";
            this.gecmeDurumTxt.Size = new System.Drawing.Size(35, 13);
            this.gecmeDurumTxt.TabIndex = 9;
            this.gecmeDurumTxt.Text = "label6";
            // 
            // DonemOrtalamaSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 179);
            this.Controls.Add(this.gecmeDurumTxt);
            this.Controls.Add(this.harfKarsiligiTxt);
            this.Controls.Add(this.harfPuaniTxt);
            this.Controls.Add(this.totalNotTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DonemOrtalamaSonuc";
            this.Text = "DonemOrtalamaSonuc";
            this.Load += new System.EventHandler(this.DonemOrtalamaSonuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalNotTxt;
        private System.Windows.Forms.Label harfPuaniTxt;
        private System.Windows.Forms.Label harfKarsiligiTxt;
        private System.Windows.Forms.Label gecmeDurumTxt;
    }
}