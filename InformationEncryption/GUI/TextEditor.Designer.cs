namespace GUI
{
    partial class TextEditor
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
            textBox = new RichTextBox();
            menuToolStrip = new MenuStrip();
            File_ToolStripItem = new ToolStripMenuItem();
            Save_ToolStripItem = new ToolStripMenuItem();
            Open_ToolStripItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            name_label = new Label();
            name_textbox = new TextBox();
            created_label = new Label();
            modified_label = new Label();
            menuToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(0, 76);
            textBox.Margin = new Padding(4, 5, 4, 5);
            textBox.Name = "textBox";
            textBox.Size = new Size(1176, 665);
            textBox.TabIndex = 0;
            textBox.Text = "";
            // 
            // menuToolStrip
            // 
            menuToolStrip.ImageScalingSize = new Size(24, 24);
            menuToolStrip.Items.AddRange(new ToolStripItem[] { File_ToolStripItem });
            menuToolStrip.Location = new Point(0, 0);
            menuToolStrip.Name = "menuToolStrip";
            menuToolStrip.Padding = new Padding(9, 3, 0, 3);
            menuToolStrip.Size = new Size(1178, 35);
            menuToolStrip.TabIndex = 1;
            menuToolStrip.Text = "menuStrip1";
            // 
            // File_ToolStripItem
            // 
            File_ToolStripItem.DropDownItems.AddRange(new ToolStripItem[] { Save_ToolStripItem, Open_ToolStripItem, newToolStripMenuItem });
            File_ToolStripItem.Name = "File_ToolStripItem";
            File_ToolStripItem.Size = new Size(54, 29);
            File_ToolStripItem.Text = "File";
            // 
            // Save_ToolStripItem
            // 
            Save_ToolStripItem.Name = "Save_ToolStripItem";
            Save_ToolStripItem.Size = new Size(270, 34);
            Save_ToolStripItem.Text = "Save";
            Save_ToolStripItem.Click += Save_ToolStripItem_Click;
            // 
            // Open_ToolStripItem
            // 
            Open_ToolStripItem.Name = "Open_ToolStripItem";
            Open_ToolStripItem.Size = new Size(270, 34);
            Open_ToolStripItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(270, 34);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(12, 46);
            name_label.Name = "name_label";
            name_label.Size = new Size(63, 25);
            name_label.TabIndex = 2;
            name_label.Text = "Name:";
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(81, 43);
            name_textbox.MaxLength = 20;
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(452, 31);
            name_textbox.TabIndex = 3;
            // 
            // created_label
            // 
            created_label.AutoSize = true;
            created_label.Location = new Point(539, 49);
            created_label.Name = "created_label";
            created_label.Size = new Size(270, 25);
            created_label.TabIndex = 4;
            created_label.Text = "Created: 10/20/2024 2:30:45 PM";
            // 
            // modified_label
            // 
            modified_label.AutoSize = true;
            modified_label.Location = new Point(829, 49);
            modified_label.Name = "modified_label";
            modified_label.Size = new Size(223, 25);
            modified_label.TabIndex = 5;
            modified_label.Text = "Last Modified: 10/20/2024";
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(modified_label);
            Controls.Add(created_label);
            Controls.Add(name_textbox);
            Controls.Add(name_label);
            Controls.Add(textBox);
            Controls.Add(menuToolStrip);
            MainMenuStrip = menuToolStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TextEditor";
            Text = "TextEditor";
            menuToolStrip.ResumeLayout(false);
            menuToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textBox;
        private MenuStrip menuToolStrip;
        private ToolStripMenuItem File_ToolStripItem;
        private ToolStripMenuItem Save_ToolStripItem;
        private Label name_label;
        private TextBox name_textbox;
        private Label created_label;
        private Label modified_label;
        private ToolStripMenuItem Open_ToolStripItem;
        private ToolStripMenuItem newToolStripMenuItem;
    }
}