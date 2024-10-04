namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username_textbox = new TextBox();
            Password_textbox = new TextBox();
            Login_button = new Button();
            Clear = new Button();
            Password_label = new Label();
            Username_label = new Label();
            SuspendLayout();
            // 
            // Username_textbox
            // 
            Username_textbox.Anchor = AnchorStyles.None;
            Username_textbox.Location = new Point(224, 69);
            Username_textbox.Name = "Username_textbox";
            Username_textbox.Size = new Size(346, 31);
            Username_textbox.TabIndex = 0;
            // 
            // Password_textbox
            // 
            Password_textbox.Anchor = AnchorStyles.None;
            Password_textbox.Location = new Point(224, 162);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.Size = new Size(346, 31);
            Password_textbox.TabIndex = 1;
            // 
            // Login_button
            // 
            Login_button.Anchor = AnchorStyles.None;
            Login_button.Location = new Point(250, 229);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(112, 34);
            Login_button.TabIndex = 2;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.None;
            Clear.Location = new Point(434, 229);
            Clear.Name = "Clear";
            Clear.Size = new Size(112, 34);
            Clear.TabIndex = 3;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            // 
            // Password_label
            // 
            Password_label.Anchor = AnchorStyles.None;
            Password_label.AutoSize = true;
            Password_label.Location = new Point(131, 168);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(87, 25);
            Password_label.TabIndex = 4;
            Password_label.Text = "Password";
            // 
            // Username_label
            // 
            Username_label.Anchor = AnchorStyles.None;
            Username_label.AutoSize = true;
            Username_label.Location = new Point(131, 75);
            Username_label.Name = "Username_label";
            Username_label.Size = new Size(54, 25);
            Username_label.TabIndex = 5;
            Username_label.Text = "Email";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 344);
            Controls.Add(Username_label);
            Controls.Add(Password_label);
            Controls.Add(Clear);
            Controls.Add(Login_button);
            Controls.Add(Password_textbox);
            Controls.Add(Username_textbox);
            MinimumSize = new Size(800, 400);
            Name = "Login";
            Text = "Information Encyptor - Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username_textbox;
        private TextBox Password_textbox;
        private Button Login_button;
        private Button Clear;
        private Label Password_label;
        private Label Username_label;
    }
}
