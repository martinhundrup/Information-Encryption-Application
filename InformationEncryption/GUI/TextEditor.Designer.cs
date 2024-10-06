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
            menuToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(0, 24);
            textBox.Name = "textBox";
            textBox.Size = new Size(800, 426);
            textBox.TabIndex = 0;
            textBox.Text = "";
            // 
            // menuToolStrip
            // 
            menuToolStrip.Items.AddRange(new ToolStripItem[] { File_ToolStripItem });
            menuToolStrip.Location = new Point(0, 0);
            menuToolStrip.Name = "menuToolStrip";
            menuToolStrip.Size = new Size(800, 24);
            menuToolStrip.TabIndex = 1;
            menuToolStrip.Text = "menuStrip1";
            // 
            // File_ToolStripItem
            // 
            File_ToolStripItem.DropDownItems.AddRange(new ToolStripItem[] { Save_ToolStripItem });
            File_ToolStripItem.Name = "File_ToolStripItem";
            File_ToolStripItem.Size = new Size(37, 20);
            File_ToolStripItem.Text = "File";
            // 
            // Save_ToolStripItem
            // 
            Save_ToolStripItem.Name = "Save_ToolStripItem";
            Save_ToolStripItem.Size = new Size(180, 22);
            Save_ToolStripItem.Text = "Save";
            Save_ToolStripItem.Click += Save_ToolStripItem_Click;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox);
            Controls.Add(menuToolStrip);
            MainMenuStrip = menuToolStrip;
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
    }
}