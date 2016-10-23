namespace CSharp6NewFeatures
{
    partial class MainForm
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
            this.ActionBtn = new System.Windows.Forms.Button();
            this.String1TxtBox = new System.Windows.Forms.TextBox();
            this.String1Lbl = new System.Windows.Forms.Label();
            this.String2TxtBox = new System.Windows.Forms.TextBox();
            this.String2Lbl = new System.Windows.Forms.Label();
            this.String3Lbl = new System.Windows.Forms.Label();
            this.String3TxtBox = new System.Windows.Forms.TextBox();
            this.ResultStringTxtBox = new System.Windows.Forms.TextBox();
            this.ResultStringLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActionBtn
            // 
            this.ActionBtn.Location = new System.Drawing.Point(504, 220);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(276, 33);
            this.ActionBtn.TabIndex = 0;
            this.ActionBtn.Text = "Push me for string interpolation!";
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // String1TxtBox
            // 
            this.String1TxtBox.Location = new System.Drawing.Point(75, 63);
            this.String1TxtBox.Name = "String1TxtBox";
            this.String1TxtBox.Size = new System.Drawing.Size(199, 22);
            this.String1TxtBox.TabIndex = 1;
            // 
            // String1Lbl
            // 
            this.String1Lbl.AutoSize = true;
            this.String1Lbl.Location = new System.Drawing.Point(72, 40);
            this.String1Lbl.Name = "String1Lbl";
            this.String1Lbl.Size = new System.Drawing.Size(76, 17);
            this.String1Lbl.TabIndex = 2;
            this.String1Lbl.Text = "First String";
            // 
            // String2TxtBox
            // 
            this.String2TxtBox.Location = new System.Drawing.Point(363, 63);
            this.String2TxtBox.Name = "String2TxtBox";
            this.String2TxtBox.Size = new System.Drawing.Size(166, 22);
            this.String2TxtBox.TabIndex = 3;
            // 
            // String2Lbl
            // 
            this.String2Lbl.AutoSize = true;
            this.String2Lbl.Location = new System.Drawing.Point(360, 40);
            this.String2Lbl.Name = "String2Lbl";
            this.String2Lbl.Size = new System.Drawing.Size(97, 17);
            this.String2Lbl.TabIndex = 4;
            this.String2Lbl.Text = "Second String";
            // 
            // String3Lbl
            // 
            this.String3Lbl.AutoSize = true;
            this.String3Lbl.Location = new System.Drawing.Point(611, 40);
            this.String3Lbl.Name = "String3Lbl";
            this.String3Lbl.Size = new System.Drawing.Size(97, 17);
            this.String3Lbl.TabIndex = 6;
            this.String3Lbl.Text = "Second String";
            // 
            // String3TxtBox
            // 
            this.String3TxtBox.Location = new System.Drawing.Point(614, 63);
            this.String3TxtBox.Name = "String3TxtBox";
            this.String3TxtBox.Size = new System.Drawing.Size(166, 22);
            this.String3TxtBox.TabIndex = 5;
            // 
            // ResultStringTxtBox
            // 
            this.ResultStringTxtBox.Location = new System.Drawing.Point(75, 192);
            this.ResultStringTxtBox.Name = "ResultStringTxtBox";
            this.ResultStringTxtBox.Size = new System.Drawing.Size(705, 22);
            this.ResultStringTxtBox.TabIndex = 7;
            // 
            // ResultStringLbl
            // 
            this.ResultStringLbl.AutoSize = true;
            this.ResultStringLbl.Location = new System.Drawing.Point(72, 172);
            this.ResultStringLbl.Name = "ResultStringLbl";
            this.ResultStringLbl.Size = new System.Drawing.Size(89, 17);
            this.ResultStringLbl.TabIndex = 8;
            this.ResultStringLbl.Text = "Result String";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 411);
            this.Controls.Add(this.ResultStringLbl);
            this.Controls.Add(this.ResultStringTxtBox);
            this.Controls.Add(this.String3Lbl);
            this.Controls.Add(this.String3TxtBox);
            this.Controls.Add(this.String2Lbl);
            this.Controls.Add(this.String2TxtBox);
            this.Controls.Add(this.String1Lbl);
            this.Controls.Add(this.String1TxtBox);
            this.Controls.Add(this.ActionBtn);
            this.Name = "MainForm";
            this.Text = "Meddling with C# 6 new features";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.TextBox String1TxtBox;
        private System.Windows.Forms.Label String1Lbl;
        private System.Windows.Forms.TextBox String2TxtBox;
        private System.Windows.Forms.Label String2Lbl;
        private System.Windows.Forms.Label String3Lbl;
        private System.Windows.Forms.TextBox String3TxtBox;
        private System.Windows.Forms.TextBox ResultStringTxtBox;
        private System.Windows.Forms.Label ResultStringLbl;
    }
}

