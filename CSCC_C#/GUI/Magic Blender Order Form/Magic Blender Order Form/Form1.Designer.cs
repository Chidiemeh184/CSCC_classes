namespace Magic_Blender_Order_Form
{
    partial class magicBlenderForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfBlendersLabel = new System.Windows.Forms.Label();
            this.blenderTextBox = new System.Windows.Forms.TextBox();
            this.orderNowButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(107, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(107, 119);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(181, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(181, 116);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(227, 22);
            this.addressTextBox.TabIndex = 3;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(35, 180);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 17);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City: ";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(80, 175);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(126, 22);
            this.cityTextBox.TabIndex = 5;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(240, 180);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(291, 175);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(46, 22);
            this.stateTextBox.TabIndex = 7;
            this.stateTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(372, 180);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(71, 17);
            this.zipCodeLabel.TabIndex = 8;
            this.zipCodeLabel.Text = "Zip code: ";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(449, 175);
            this.zipCodeTextBox.MaxLength = 5;
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(52, 22);
            this.zipCodeTextBox.TabIndex = 9;
            // 
            // numberOfBlendersLabel
            // 
            this.numberOfBlendersLabel.AutoSize = true;
            this.numberOfBlendersLabel.Location = new System.Drawing.Point(200, 235);
            this.numberOfBlendersLabel.Name = "numberOfBlendersLabel";
            this.numberOfBlendersLabel.Size = new System.Drawing.Size(137, 17);
            this.numberOfBlendersLabel.TabIndex = 10;
            this.numberOfBlendersLabel.Text = "Number of blenders:";
            // 
            // blenderTextBox
            // 
            this.blenderTextBox.Location = new System.Drawing.Point(343, 235);
            this.blenderTextBox.MaxLength = 4;
            this.blenderTextBox.Name = "blenderTextBox";
            this.blenderTextBox.Size = new System.Drawing.Size(43, 22);
            this.blenderTextBox.TabIndex = 11;
            this.blenderTextBox.TextChanged += new System.EventHandler(this.blenderTextBox_TextChanged);
            // 
            // orderNowButton
            // 
            this.orderNowButton.Location = new System.Drawing.Point(131, 287);
            this.orderNowButton.Name = "orderNowButton";
            this.orderNowButton.Size = new System.Drawing.Size(89, 26);
            this.orderNowButton.TabIndex = 12;
            this.orderNowButton.Text = "Order Now";
            this.orderNowButton.UseVisualStyleBackColor = true;
            this.orderNowButton.Click += new System.EventHandler(this.orderNowButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(131, 339);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(89, 26);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(253, 287);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outputLabel.Size = new System.Drawing.Size(0, 17);
            this.outputLabel.TabIndex = 14;
            // 
            // magicBlenderForm
            // 
            this.AcceptButton = this.orderNowButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(595, 474);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.orderNowButton);
            this.Controls.Add(this.blenderTextBox);
            this.Controls.Add(this.numberOfBlendersLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "magicBlenderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Blender Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label numberOfBlendersLabel;
        private System.Windows.Forms.TextBox blenderTextBox;
        private System.Windows.Forms.Button orderNowButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

