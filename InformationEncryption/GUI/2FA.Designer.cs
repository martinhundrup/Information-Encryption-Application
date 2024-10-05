namespace GUI
{
    partial class _2FA
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
            Pin_label = new Label();
            Back_button = new Button();
            Submit_button = new Button();
            Pin_textbox = new TextBox();
            SuspendLayout();
            // 
            // Pin_label
            // 
            Pin_label.Anchor = AnchorStyles.None;
            Pin_label.AutoSize = true;
            Pin_label.Location = new Point(149, 65);
            Pin_label.Margin = new Padding(2, 0, 2, 0);
            Pin_label.Name = "Pin_label";
            Pin_label.Size = new Size(154, 15);
            Pin_label.TabIndex = 9;
            Pin_label.Text = "Enter the 6-digit pin sent to ";
            Pin_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Back_button
            // 
            Back_button.Anchor = AnchorStyles.None;
            Back_button.ForeColor = SystemColors.ActiveCaptionText;
            Back_button.Location = new Point(291, 142);
            Back_button.Margin = new Padding(2);
            Back_button.Name = "Back_button";
            Back_button.Size = new Size(78, 25);
            Back_button.TabIndex = 8;
            Back_button.Text = "Go Back";
            Back_button.UseVisualStyleBackColor = true;
            Back_button.Click += Back_button_Click;
            // 
            // Submit_button
            // 
            Submit_button.Anchor = AnchorStyles.None;
            Submit_button.ForeColor = SystemColors.ActiveCaptionText;
            Submit_button.Location = new Point(162, 142);
            Submit_button.Margin = new Padding(2);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(78, 25);
            Submit_button.TabIndex = 7;
            Submit_button.Text = "Submit";
            Submit_button.UseVisualStyleBackColor = true;
            Submit_button.Click += Submit_button_Click;
            // 
            // Pin_textbox
            // 
            Pin_textbox.Anchor = AnchorStyles.None;
            Pin_textbox.Location = new Point(149, 82);
            Pin_textbox.Margin = new Padding(2);
            Pin_textbox.MaxLength = 6;
            Pin_textbox.Name = "Pin_textbox";
            Pin_textbox.Size = new Size(243, 23);
            Pin_textbox.TabIndex = 6;
            // 
            // _2FA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 217);
            Controls.Add(Pin_label);
            Controls.Add(Back_button);
            Controls.Add(Submit_button);
            Controls.Add(Pin_textbox);
            Margin = new Padding(2);
            MinimumSize = new Size(565, 256);
            Name = "_2FA";
            Text = "Information Encryptor - Authentication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Pin_label;
        private Button Back_button;
        private Button Submit_button;
        private TextBox Pin_textbox;
    }
}