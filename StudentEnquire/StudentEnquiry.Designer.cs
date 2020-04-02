namespace Week8
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
            this.cbxDeps = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDegrees = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.cbxHeard = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which department are you interested in?";
            // 
            // cbxDeps
            // 
            this.cbxDeps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeps.FormattingEnabled = true;
            this.cbxDeps.Location = new System.Drawing.Point(42, 75);
            this.cbxDeps.Name = "cbxDeps";
            this.cbxDeps.Size = new System.Drawing.Size(399, 24);
            this.cbxDeps.TabIndex = 1;
            this.cbxDeps.SelectedIndexChanged += new System.EventHandler(this.cbxDeps_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "What degree programs are you interested in?";
            // 
            // lstDegrees
            // 
            this.lstDegrees.FormattingEnabled = true;
            this.lstDegrees.ItemHeight = 16;
            this.lstDegrees.Location = new System.Drawing.Point(42, 165);
            this.lstDegrees.Name = "lstDegrees";
            this.lstDegrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDegrees.Size = new System.Drawing.Size(399, 84);
            this.lstDegrees.Sorted = true;
            this.lstDegrees.TabIndex = 4;
            this.lstDegrees.SelectedValueChanged += new System.EventHandler(this.lstDegrees_SelectedValueChanged);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(366, 252);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(75, 17);
            this.lblSelected.TabIndex = 5;
            this.lblSelected.Text = "0 Selected";
            // 
            // cbxHeard
            // 
            this.cbxHeard.FormattingEnabled = true;
            this.cbxHeard.Location = new System.Drawing.Point(42, 325);
            this.cbxHeard.Name = "cbxHeard";
            this.cbxHeard.Size = new System.Drawing.Size(399, 24);
            this.cbxHeard.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "How did you hear about us?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(201, 372);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 27);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 429);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxHeard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstDegrees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDeps);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Enquiry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDeps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDegrees;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ComboBox cbxHeard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
    }
}

