namespace Task1
{
    partial class FBracketParser
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
            this.tBInputBox = new System.Windows.Forms.TextBox();
            this.bCheck = new System.Windows.Forms.Button();
            this.lIsCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBInputBox
            // 
            this.tBInputBox.Location = new System.Drawing.Point(12, 12);
            this.tBInputBox.Name = "tBInputBox";
            this.tBInputBox.Size = new System.Drawing.Size(277, 20);
            this.tBInputBox.TabIndex = 0;
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(12, 38);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(106, 29);
            this.bCheck.TabIndex = 1;
            this.bCheck.Text = "Check";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // lIsCorrect
            // 
            this.lIsCorrect.AutoSize = true;
            this.lIsCorrect.Location = new System.Drawing.Point(124, 46);
            this.lIsCorrect.Name = "lIsCorrect";
            this.lIsCorrect.Size = new System.Drawing.Size(0, 13);
            this.lIsCorrect.TabIndex = 2;
            // 
            // FBracketParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 71);
            this.Controls.Add(this.lIsCorrect);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.tBInputBox);
            this.Name = "FBracketParser";
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBInputBox;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.Label lIsCorrect;
    }
}

