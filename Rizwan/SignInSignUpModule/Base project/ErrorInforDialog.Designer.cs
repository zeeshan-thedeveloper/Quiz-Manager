namespace Base_project
{
    partial class ErrorInforDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorInforDialog));
            this.labelErrorMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErrorMsg
            // 
            this.labelErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMsg.Location = new System.Drawing.Point(1, 9);
            this.labelErrorMsg.Name = "labelErrorMsg";
            this.labelErrorMsg.Size = new System.Drawing.Size(319, 152);
            this.labelErrorMsg.TabIndex = 0;
            this.labelErrorMsg.Text = "label1";
            this.labelErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(326, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 181);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ErrorInforDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(505, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelErrorMsg);
            this.Name = "ErrorInforDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ErrorInforDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelErrorMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}