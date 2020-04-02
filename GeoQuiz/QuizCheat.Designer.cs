namespace GeoQuiz
{
    partial class FormCheating
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnLazy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAnswer);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(6, 11);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(279, 154);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Answer";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLazy
            // 
            this.btnLazy.Location = new System.Drawing.Point(228, 193);
            this.btnLazy.Name = "btnLazy";
            this.btnLazy.Size = new System.Drawing.Size(75, 29);
            this.btnLazy.TabIndex = 8;
            this.btnLazy.Text = "I\'m Lazy";
            this.btnLazy.UseVisualStyleBackColor = true;
            this.btnLazy.Click += new System.EventHandler(this.btnLazy_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 193);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormCheating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 234);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLazy);
            this.Controls.Add(this.btnClose);
            this.Name = "FormCheating";
            this.Text = "Cheater";
            this.Load += new System.EventHandler(this.FormCheating_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnLazy;
        private System.Windows.Forms.Button btnClose;
    }
}