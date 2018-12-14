namespace RunCommand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextEntry = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.oCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextEntry
            // 
            this.TextEntry.AutoCompleteCustomSource.AddRange(new string[] {
            "C",
            "CALC",
            "CHROME",
            "CLEAN",
            "DOS",
            "DOSCONFIG",
            "EDM",
            "EXCEL",
            "FINAL",
            "FIREFOX",
            "HELP",
            "LADDER",
            "MLOK",
            "NOTE",
            "PROGRESS",
            "SATS",
            "SCAN",
            "SDU",
            "TIME",
            "TOBE",
            "ULTI",
            "VIS",
            "WORD"});
            this.TextEntry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextEntry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextEntry.Location = new System.Drawing.Point(12, 12);
            this.TextEntry.Name = "TextEntry";
            this.TextEntry.Size = new System.Drawing.Size(131, 20);
            this.TextEntry.TabIndex = 0;
            this.TextEntry.TextChanged += new System.EventHandler(this.TextEntry_TextChanged);
            // 
            // RunButton
            // 
            this.RunButton.AutoSize = true;
            this.RunButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RunButton.Location = new System.Drawing.Point(104, 38);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(39, 23);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // oCancelButton
            // 
            this.oCancelButton.AutoSize = true;
            this.oCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.oCancelButton.Location = new System.Drawing.Point(48, 38);
            this.oCancelButton.Name = "oCancelButton";
            this.oCancelButton.Size = new System.Drawing.Size(50, 23);
            this.oCancelButton.TabIndex = 2;
            this.oCancelButton.Text = "Cancel";
            this.oCancelButton.UseVisualStyleBackColor = true;
            this.oCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.RunButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.oCancelButton;
            this.ClientSize = new System.Drawing.Size(154, 71);
            this.Controls.Add(this.oCancelButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.TextEntry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextEntry;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button oCancelButton;
    }
}

