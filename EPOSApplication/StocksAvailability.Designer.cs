namespace EPOSApplication
{
    partial class StocksAvailability
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
            this.stocksAvailabilityListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // stocksAvailabilityListBox
            // 
            this.stocksAvailabilityListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.stocksAvailabilityListBox.ForeColor = System.Drawing.Color.White;
            this.stocksAvailabilityListBox.FormattingEnabled = true;
            this.stocksAvailabilityListBox.ItemHeight = 16;
            this.stocksAvailabilityListBox.Location = new System.Drawing.Point(12, 12);
            this.stocksAvailabilityListBox.Name = "stocksAvailabilityListBox";
            this.stocksAvailabilityListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.stocksAvailabilityListBox.Size = new System.Drawing.Size(527, 436);
            this.stocksAvailabilityListBox.TabIndex = 0;
            // 
            // StocksAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 453);
            this.Controls.Add(this.stocksAvailabilityListBox);
            this.Name = "StocksAvailability";
            this.Text = "StocksAvailability";
            this.Load += new System.EventHandler(this.StocksAvailability_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox stocksAvailabilityListBox;
    }
}