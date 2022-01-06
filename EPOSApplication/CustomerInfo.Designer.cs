namespace EPOSApplication
{
    partial class CustomerInfo
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerInfoPanel = new System.Windows.Forms.Panel();
            this.emailValueTextBox = new System.Windows.Forms.TextBox();
            this.phoneValueTextBox = new System.Windows.Forms.TextBox();
            this.nameValueTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.cardButton = new System.Windows.Forms.RadioButton();
            this.paypalRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.customerInfoPanel.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.LimeGreen;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmButton.Location = new System.Drawing.Point(46, 413);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(134, 47);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "CONFIRM";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(193, 413);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 47);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // customerInfoPanel
            // 
            this.customerInfoPanel.Controls.Add(this.emailValueTextBox);
            this.customerInfoPanel.Controls.Add(this.phoneValueTextBox);
            this.customerInfoPanel.Controls.Add(this.nameValueTextBox);
            this.customerInfoPanel.Controls.Add(this.emailLabel);
            this.customerInfoPanel.Controls.Add(this.phoneLabel);
            this.customerInfoPanel.Controls.Add(this.nameLabel);
            this.customerInfoPanel.Location = new System.Drawing.Point(25, 26);
            this.customerInfoPanel.Name = "customerInfoPanel";
            this.customerInfoPanel.Size = new System.Drawing.Size(323, 202);
            this.customerInfoPanel.TabIndex = 3;
            // 
            // emailValueTextBox
            // 
            this.emailValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValueTextBox.Location = new System.Drawing.Point(134, 131);
            this.emailValueTextBox.Name = "emailValueTextBox";
            this.emailValueTextBox.Size = new System.Drawing.Size(152, 24);
            this.emailValueTextBox.TabIndex = 6;
            // 
            // phoneValueTextBox
            // 
            this.phoneValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneValueTextBox.Location = new System.Drawing.Point(134, 87);
            this.phoneValueTextBox.Name = "phoneValueTextBox";
            this.phoneValueTextBox.Size = new System.Drawing.Size(152, 24);
            this.phoneValueTextBox.TabIndex = 5;
            // 
            // nameValueTextBox
            // 
            this.nameValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValueTextBox.Location = new System.Drawing.Point(134, 44);
            this.nameValueTextBox.Name = "nameValueTextBox";
            this.nameValueTextBox.Size = new System.Drawing.Size(152, 24);
            this.nameValueTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailLabel.Location = new System.Drawing.Point(31, 130);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(50, 18);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneLabel.Location = new System.Drawing.Point(30, 87);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(61, 18);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(29, 44);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.cashRadioButton);
            this.paymentGroupBox.Controls.Add(this.paypalRadioButton);
            this.paymentGroupBox.Controls.Add(this.cardButton);
            this.paymentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paymentGroupBox.Location = new System.Drawing.Point(25, 263);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(323, 125);
            this.paymentGroupBox.TabIndex = 4;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Method";
            // 
            // cardButton
            // 
            this.cardButton.AutoSize = true;
            this.cardButton.Checked = true;
            this.cardButton.Location = new System.Drawing.Point(34, 33);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(159, 22);
            this.cardButton.TabIndex = 0;
            this.cardButton.TabStop = true;
            this.cardButton.Text = "Credit/Debit Card";
            this.cardButton.UseVisualStyleBackColor = true;
            // 
            // paypalRadioButton
            // 
            this.paypalRadioButton.AutoSize = true;
            this.paypalRadioButton.Location = new System.Drawing.Point(34, 61);
            this.paypalRadioButton.Name = "paypalRadioButton";
            this.paypalRadioButton.Size = new System.Drawing.Size(81, 22);
            this.paypalRadioButton.TabIndex = 1;
            this.paypalRadioButton.TabStop = true;
            this.paypalRadioButton.Text = "PayPal";
            this.paypalRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(34, 90);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(68, 22);
            this.cashRadioButton.TabIndex = 2;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(382, 531);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.customerInfoPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Name = "CustomerInfo";
            this.Text = "Add Customer Details";
            this.customerInfoPanel.ResumeLayout(false);
            this.customerInfoPanel.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel customerInfoPanel;
        private System.Windows.Forms.TextBox emailValueTextBox;
        private System.Windows.Forms.TextBox phoneValueTextBox;
        private System.Windows.Forms.TextBox nameValueTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton paypalRadioButton;
        private System.Windows.Forms.RadioButton cardButton;
    }
}