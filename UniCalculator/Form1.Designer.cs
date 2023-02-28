
namespace UniCalculator
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
            this.showDonemOrt = new System.Windows.Forms.Button();
            this.showFinalMinNot = new System.Windows.Forms.Button();
            this.showTekDers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ne yapmak istersiniz ? ";
            // 
            // showDonemOrt
            // 
            this.showDonemOrt.Location = new System.Drawing.Point(75, 147);
            this.showDonemOrt.Name = "showDonemOrt";
            this.showDonemOrt.Size = new System.Drawing.Size(180, 23);
            this.showDonemOrt.TabIndex = 1;
            this.showDonemOrt.Text = "Dönem Ortalaması Hesapla";
            this.showDonemOrt.UseVisualStyleBackColor = true;
            this.showDonemOrt.Click += new System.EventHandler(this.showDonemOrt_Click);
            // 
            // showFinalMinNot
            // 
            this.showFinalMinNot.Location = new System.Drawing.Point(75, 188);
            this.showFinalMinNot.Name = "showFinalMinNot";
            this.showFinalMinNot.Size = new System.Drawing.Size(180, 23);
            this.showFinalMinNot.TabIndex = 2;
            this.showFinalMinNot.Text = "Final için Minimum Not Hesapla";
            this.showFinalMinNot.UseVisualStyleBackColor = true;
            this.showFinalMinNot.Click += new System.EventHandler(this.showFinalMinNot_Click);
            // 
            // showTekDers
            // 
            this.showTekDers.Location = new System.Drawing.Point(75, 110);
            this.showTekDers.Name = "showTekDers";
            this.showTekDers.Size = new System.Drawing.Size(180, 23);
            this.showTekDers.TabIndex = 3;
            this.showTekDers.Text = "Tek Ders Ortalaması Hesapla";
            this.showTekDers.UseVisualStyleBackColor = true;
            this.showTekDers.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(333, 296);
            this.Controls.Add(this.showTekDers);
            this.Controls.Add(this.showFinalMinNot);
            this.Controls.Add(this.showDonemOrt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "UniCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showDonemOrt;
        private System.Windows.Forms.Button showFinalMinNot;
        private System.Windows.Forms.Button showTekDers;
    }
}

