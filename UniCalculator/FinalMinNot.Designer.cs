
namespace UniCalculator
{
    partial class FinalMinNot
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
            this.vizeNotTxt = new System.Windows.Forms.TextBox();
            this.gecmeNotTxt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.minNotTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize Not :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gecme Not :";
            // 
            // vizeNotTxt
            // 
            this.vizeNotTxt.Location = new System.Drawing.Point(71, 19);
            this.vizeNotTxt.Name = "vizeNotTxt";
            this.vizeNotTxt.Size = new System.Drawing.Size(100, 20);
            this.vizeNotTxt.TabIndex = 2;
            // 
            // gecmeNotTxt
            // 
            this.gecmeNotTxt.Location = new System.Drawing.Point(85, 52);
            this.gecmeNotTxt.Name = "gecmeNotTxt";
            this.gecmeNotTxt.Size = new System.Drawing.Size(100, 20);
            this.gecmeNotTxt.TabIndex = 3;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(134, 90);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "Hesapla";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // minNotTxt
            // 
            this.minNotTxt.AutoSize = true;
            this.minNotTxt.Location = new System.Drawing.Point(68, 156);
            this.minNotTxt.Name = "minNotTxt";
            this.minNotTxt.Size = new System.Drawing.Size(68, 13);
            this.minNotTxt.TabIndex = 5;
            this.minNotTxt.Text = "Gereken Not";
            // 
            // FinalMinNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 213);
            this.Controls.Add(this.minNotTxt);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.gecmeNotTxt);
            this.Controls.Add(this.vizeNotTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FinalMinNot";
            this.Text = "FinalMinNot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vizeNotTxt;
        private System.Windows.Forms.TextBox gecmeNotTxt;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label minNotTxt;
    }
}