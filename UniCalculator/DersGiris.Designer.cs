
namespace UniCalculator
{
    partial class DersGiris
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
            this.dersAdiTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vizeNotTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.finalNotTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.krediTxtBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dersin Adi :";
            // 
            // dersAdiTxtBox
            // 
            this.dersAdiTxtBox.Location = new System.Drawing.Point(79, 15);
            this.dersAdiTxtBox.Name = "dersAdiTxtBox";
            this.dersAdiTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dersAdiTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vize Notunuz :";
            // 
            // vizeNotTxtBox
            // 
            this.vizeNotTxtBox.Location = new System.Drawing.Point(294, 15);
            this.vizeNotTxtBox.Name = "vizeNotTxtBox";
            this.vizeNotTxtBox.Size = new System.Drawing.Size(100, 20);
            this.vizeNotTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Final Notunuz :";
            // 
            // finalNotTxtBox
            // 
            this.finalNotTxtBox.Location = new System.Drawing.Point(96, 56);
            this.finalNotTxtBox.Name = "finalNotTxtBox";
            this.finalNotTxtBox.Size = new System.Drawing.Size(100, 20);
            this.finalNotTxtBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kredi Notu : ";
            // 
            // krediTxtBox
            // 
            this.krediTxtBox.Location = new System.Drawing.Point(284, 56);
            this.krediTxtBox.Name = "krediTxtBox";
            this.krediTxtBox.Size = new System.Drawing.Size(100, 20);
            this.krediTxtBox.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(319, 95);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "KAYDET";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // DersGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 130);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.krediTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finalNotTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vizeNotTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dersAdiTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "DersGiris";
            this.Text = "DersGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dersAdiTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vizeNotTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox finalNotTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox krediTxtBox;
        private System.Windows.Forms.Button saveBtn;
    }
}