namespace Урок5
{
    partial class Form1
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
            richTextBox1 = new RichTextBox();
            btnSaveAs = new Button();
            btnOpen = new Button();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(38, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(651, 189);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnSaveAs
            // 
            btnSaveAs.Location = new Point(595, 253);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(94, 29);
            btnSaveAs.TabIndex = 1;
            btnSaveAs.Text = "Save As ...";
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(38, 253);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(318, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(btnSaveAs);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnSaveAs;
        private Button btnOpen;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
