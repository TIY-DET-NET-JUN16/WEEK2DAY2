namespace WinForms
{
    partial class Form1
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
            this.buttonClickable = new System.Windows.Forms.Button();
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.labelSecondNumber = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClickable
            // 
            this.buttonClickable.Location = new System.Drawing.Point(418, 99);
            this.buttonClickable.Name = "buttonClickable";
            this.buttonClickable.Size = new System.Drawing.Size(75, 23);
            this.buttonClickable.TabIndex = 2;
            this.buttonClickable.Text = "Add them";
            this.buttonClickable.UseVisualStyleBackColor = true;
            this.buttonClickable.Click += new System.EventHandler(this.buttonClickable_Click);
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Location = new System.Drawing.Point(107, 101);
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstNumber.TabIndex = 0;
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Location = new System.Drawing.Point(256, 101);
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondNumber.TabIndex = 1;
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.AutoSize = true;
            this.labelFirstNumber.Location = new System.Drawing.Point(107, 82);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(66, 13);
            this.labelFirstNumber.TabIndex = 3;
            this.labelFirstNumber.Text = "First Number";
            // 
            // labelSecondNumber
            // 
            this.labelSecondNumber.AutoSize = true;
            this.labelSecondNumber.Location = new System.Drawing.Point(253, 82);
            this.labelSecondNumber.Name = "labelSecondNumber";
            this.labelSecondNumber.Size = new System.Drawing.Size(84, 13);
            this.labelSecondNumber.TabIndex = 4;
            this.labelSecondNumber.Text = "Second Number";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(181, 145);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.fileToolStripMenuItem_DropDownClosed);
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.saveToolStripMenuItem_DropDownOpening);
            this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpened);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 407);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelSecondNumber);
            this.Controls.Add(this.labelFirstNumber);
            this.Controls.Add(this.textBoxSecondNumber);
            this.Controls.Add(this.textBoxFirstNumber);
            this.Controls.Add(this.buttonClickable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClickable;
        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.Label labelSecondNumber;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

