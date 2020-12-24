namespace CreatingSingInSignUpForm
{
    partial class ErrorInfoDialog
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
            this.labelerrorInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelerrorInfo
            // 
            this.labelerrorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerrorInfo.ForeColor = System.Drawing.Color.Red;
            this.labelerrorInfo.Location = new System.Drawing.Point(12, -1);
            this.labelerrorInfo.Name = "labelerrorInfo";
            this.labelerrorInfo.Size = new System.Drawing.Size(411, 79);
            this.labelerrorInfo.TabIndex = 0;
            this.labelerrorInfo.Text = "label1";
            this.labelerrorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelerrorInfo);
            this.Name = "ErrorInfoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ErrorInfoDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelerrorInfo;
        private System.Windows.Forms.Button button1;
    }
}