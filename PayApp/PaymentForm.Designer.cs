namespace PayApp
{
    partial class FormPayment
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
            this.rdoCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCardType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCard = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxExpM = new System.Windows.Forms.ComboBox();
            this.cbxExpY = new System.Windows.Forms.ComboBox();
            this.ckbDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCustomer);
            this.groupBox1.Controls.Add(this.rdoCard);
            this.groupBox1.Location = new System.Drawing.Point(25, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // rdoCustomer
            // 
            this.rdoCustomer.AutoSize = true;
            this.rdoCustomer.Location = new System.Drawing.Point(279, 31);
            this.rdoCustomer.Name = "rdoCustomer";
            this.rdoCustomer.Size = new System.Drawing.Size(111, 21);
            this.rdoCustomer.TabIndex = 1;
            this.rdoCustomer.TabStop = true;
            this.rdoCustomer.Text = "Bill Customer";
            this.rdoCustomer.UseVisualStyleBackColor = true;
            this.rdoCustomer.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rdoCard
            // 
            this.rdoCard.AutoSize = true;
            this.rdoCard.Checked = true;
            this.rdoCard.Location = new System.Drawing.Point(7, 31);
            this.rdoCard.Name = "rdoCard";
            this.rdoCard.Size = new System.Drawing.Size(100, 21);
            this.rdoCard.TabIndex = 0;
            this.rdoCard.TabStop = true;
            this.rdoCard.Text = "Credit Card";
            this.rdoCard.UseVisualStyleBackColor = true;
            this.rdoCard.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit card type";
            // 
            // lstCardType
            // 
            this.lstCardType.FormattingEnabled = true;
            this.lstCardType.ItemHeight = 16;
            this.lstCardType.Location = new System.Drawing.Point(167, 139);
            this.lstCardType.Name = "lstCardType";
            this.lstCardType.Size = new System.Drawing.Size(279, 100);
            this.lstCardType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card number:";
            // 
            // txbCard
            // 
            this.txbCard.Location = new System.Drawing.Point(167, 282);
            this.txbCard.Name = "txbCard";
            this.txbCard.Size = new System.Drawing.Size(279, 22);
            this.txbCard.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expiration date:";
            // 
            // cbxExpM
            // 
            this.cbxExpM.FormattingEnabled = true;
            this.cbxExpM.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbxExpM.Location = new System.Drawing.Point(167, 320);
            this.cbxExpM.Name = "cbxExpM";
            this.cbxExpM.Size = new System.Drawing.Size(132, 24);
            this.cbxExpM.TabIndex = 6;
            this.cbxExpM.Text = "Select a Month...";
            // 
            // cbxExpY
            // 
            this.cbxExpY.FormattingEnabled = true;
            this.cbxExpY.Location = new System.Drawing.Point(318, 320);
            this.cbxExpY.Name = "cbxExpY";
            this.cbxExpY.Size = new System.Drawing.Size(128, 24);
            this.cbxExpY.TabIndex = 7;
            this.cbxExpY.Text = "Select a Year...";
            // 
            // ckbDefault
            // 
            this.ckbDefault.AutoSize = true;
            this.ckbDefault.Location = new System.Drawing.Point(25, 378);
            this.ckbDefault.Name = "ckbDefault";
            this.ckbDefault.Size = new System.Drawing.Size(208, 21);
            this.ckbDefault.TabIndex = 8;
            this.ckbDefault.Text = "Set as default billing method";
            this.ckbDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(239, 404);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 26);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(367, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 26);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 442);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ckbDefault);
            this.Controls.Add(this.cbxExpY);
            this.Controls.Add(this.cbxExpM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCardType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCustomer;
        private System.Windows.Forms.RadioButton rdoCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCardType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxExpM;
        private System.Windows.Forms.ComboBox cbxExpY;
        private System.Windows.Forms.CheckBox ckbDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}