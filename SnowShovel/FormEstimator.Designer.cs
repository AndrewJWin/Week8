namespace SnowShovel
{
    partial class FormEstimater
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dteAppointment = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCorner = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.txbEstimate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRequests = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(154, 42);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(402, 22);
            this.txbName.TabIndex = 0;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(154, 81);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(402, 22);
            this.txbAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Requested";
            // 
            // dteAppointment
            // 
            this.dteAppointment.Location = new System.Drawing.Point(154, 119);
            this.dteAppointment.Name = "dteAppointment";
            this.dteAppointment.Size = new System.Drawing.Size(402, 22);
            this.dteAppointment.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCorner);
            this.groupBox1.Controls.Add(this.rdoSingle);
            this.groupBox1.Location = new System.Drawing.Point(25, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Sidewalk";
            // 
            // rdoCorner
            // 
            this.rdoCorner.AutoSize = true;
            this.rdoCorner.Location = new System.Drawing.Point(6, 77);
            this.rdoCorner.Name = "rdoCorner";
            this.rdoCorner.Size = new System.Drawing.Size(72, 21);
            this.rdoCorner.TabIndex = 1;
            this.rdoCorner.TabStop = true;
            this.rdoCorner.Text = "Corner";
            this.rdoCorner.UseVisualStyleBackColor = true;
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(6, 34);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(68, 21);
            this.rdoSingle.TabIndex = 0;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Single";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(25, 394);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(159, 29);
            this.btnEstimate.TabIndex = 5;
            this.btnEstimate.Text = "Get Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // txbEstimate
            // 
            this.txbEstimate.Location = new System.Drawing.Point(417, 400);
            this.txbEstimate.Name = "txbEstimate";
            this.txbEstimate.Size = new System.Drawing.Size(139, 22);
            this.txbEstimate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estimate";
            // 
            // lblRequests
            // 
            this.lblRequests.AutoEllipsis = true;
            this.lblRequests.Location = new System.Drawing.Point(6, 18);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(223, 112);
            this.lblRequests.TabIndex = 0;
            this.lblRequests.Text = "No special requests entered";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRequests);
            this.groupBox2.Location = new System.Drawing.Point(321, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 133);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Special Requests";
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(362, 323);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(194, 29);
            this.btnAddRequest.TabIndex = 4;
            this.btnAddRequest.Text = "Add Special Requests";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // FormEstimater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txbEstimate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dteAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Name = "FormEstimater";
            this.Text = "Snow Shovel Estimate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dteAppointment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCorner;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.TextBox txbEstimate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddRequest;
    }
}

