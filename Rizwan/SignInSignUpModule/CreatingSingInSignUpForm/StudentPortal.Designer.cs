namespace CreatingSingInSignUpForm
{
    partial class FormStudentPortal
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
            this.labelCurrentStdName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentStdName
            // 
            this.labelCurrentStdName.Location = new System.Drawing.Point(2, 9);
            this.labelCurrentStdName.Name = "labelCurrentStdName";
            this.labelCurrentStdName.Size = new System.Drawing.Size(100, 23);
            this.labelCurrentStdName.TabIndex = 0;
            this.labelCurrentStdName.Text = "Name of Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Portal";
            // 
            // FormStudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentStdName);
            this.Name = "FormStudentPortal";
            this.Text = "StudentPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentStdName;
        private System.Windows.Forms.Label label1;
    }
}