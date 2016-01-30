namespace MajorListDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.majorListBox = new System.Windows.Forms.ListBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // majorListBox
            // 
            this.majorListBox.FormattingEnabled = true;
            this.majorListBox.Items.AddRange(new object[] {
            "Accounting",
            "Biology",
            "Chemistry",
            "English",
            "Math",
            "Psychology"});
            this.majorListBox.Location = new System.Drawing.Point(40, 12);
            this.majorListBox.MultiColumn = true;
            this.majorListBox.Name = "majorListBox";
            this.majorListBox.Size = new System.Drawing.Size(189, 108);
            this.majorListBox.TabIndex = 0;
            this.majorListBox.SelectedIndexChanged += new System.EventHandler(this.majorListBox_SelectedIndexChanged);
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(84, 150);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(0, 13);
            this.majorLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.majorListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox majorListBox;
        private System.Windows.Forms.Label majorLabel;

    }
}

