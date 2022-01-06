namespace EPOSApplication
{
    partial class SearchOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchOrderlabel = new System.Windows.Forms.Label();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.searchButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchTextBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(231, 37);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(111, 35);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBoxToolTip.SetToolTip(this.searchTextBox, "Please enter either a date or an order ID");
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(348, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 35);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButtonToolTip.SetToolTip(this.searchButton, "Press to search for order details");
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click1);
            // 
            // searchOrderlabel
            // 
            this.searchOrderlabel.AutoSize = true;
            this.searchOrderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOrderlabel.ForeColor = System.Drawing.Color.White;
            this.searchOrderlabel.Location = new System.Drawing.Point(222, 9);
            this.searchOrderlabel.Name = "searchOrderlabel";
            this.searchOrderlabel.Size = new System.Drawing.Size(230, 20);
            this.searchOrderlabel.TabIndex = 2;
            this.searchOrderlabel.Text = "Search by Order ID / Date";
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.searchResultsListBox.ForeColor = System.Drawing.Color.White;
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 16;
            this.searchResultsListBox.Location = new System.Drawing.Point(13, 114);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.searchResultsListBox.Size = new System.Drawing.Size(650, 324);
            this.searchResultsListBox.TabIndex = 3;
            this.searchResultsListBox.Visible = false;
            
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.ForeColor = System.Drawing.Color.White;
            this.searchResultsLabel.Location = new System.Drawing.Point(276, 86);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(123, 18);
            this.searchResultsLabel.TabIndex = 4;
            this.searchResultsLabel.Text = "Search Results";
            this.searchResultsLabel.Visible = false;
            // 
            // searchButtonToolTip
            // 
            this.searchButtonToolTip.IsBalloon = true;
            // 
            // searchTextBoxToolTip
            // 
            this.searchTextBoxToolTip.IsBalloon = true;
            // 
            // SearchOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(675, 453);
            this.Controls.Add(this.searchResultsLabel);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.searchOrderlabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "SearchOrderForm";
            this.Text = "Search Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchOrderlabel;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Label searchResultsLabel;
        private System.Windows.Forms.ToolTip searchTextBoxToolTip;
        private System.Windows.Forms.ToolTip searchButtonToolTip;
    }
}