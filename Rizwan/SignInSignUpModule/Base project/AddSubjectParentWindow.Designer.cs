namespace Base_project
{
    partial class AddSubjectParentWindow
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
            this.listBoxListOfAddedSubjects = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxSubjectName = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateSubject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxListOfAddedSubjects
            // 
            this.listBoxListOfAddedSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxListOfAddedSubjects.FormattingEnabled = true;
            this.listBoxListOfAddedSubjects.ItemHeight = 31;
            this.listBoxListOfAddedSubjects.Location = new System.Drawing.Point(37, 97);
            this.listBoxListOfAddedSubjects.Name = "listBoxListOfAddedSubjects";
            this.listBoxListOfAddedSubjects.Size = new System.Drawing.Size(391, 407);
            this.listBoxListOfAddedSubjects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new Subjects";
            // 
            // richTextBoxSubjectName
            // 
            this.richTextBoxSubjectName.Location = new System.Drawing.Point(625, 242);
            this.richTextBoxSubjectName.Name = "richTextBoxSubjectName";
            this.richTextBoxSubjectName.Size = new System.Drawing.Size(308, 45);
            this.richTextBoxSubjectName.TabIndex = 2;
            this.richTextBoxSubjectName.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject Name";
            // 
            // buttonCreateSubject
            // 
            this.buttonCreateSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSubject.Location = new System.Drawing.Point(701, 375);
            this.buttonCreateSubject.Name = "buttonCreateSubject";
            this.buttonCreateSubject.Size = new System.Drawing.Size(175, 73);
            this.buttonCreateSubject.TabIndex = 4;
            this.buttonCreateSubject.Text = "Create";
            this.buttonCreateSubject.UseVisualStyleBackColor = true;
            this.buttonCreateSubject.Click += new System.EventHandler(this.buttonCreateSubject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Availble Subjects";
            // 
            // AddSubjectParentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxSubjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxListOfAddedSubjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddSubjectParentWindow";
            this.Text = "AddSubjectParentWindow";
            this.Load += new System.EventHandler(this.AddSubjectParentWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListOfAddedSubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateSubject;
        private System.Windows.Forms.Label label3;
    }
}