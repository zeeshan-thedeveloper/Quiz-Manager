namespace Base_project
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabPageCreateQuiz = new System.Windows.Forms.TabPage();
            this.buttonCreateNewQuiz = new System.Windows.Forms.Button();
            this.buttonOpenQuiz = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.tabControlTeacherOptions = new System.Windows.Forms.TabControl();
            this.tabPageCreateQuiz.SuspendLayout();
            this.tabControlTeacherOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(164, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1202, 56);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.Black;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(220, 689);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1090, 56);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Black;
            this.splitter3.Location = new System.Drawing.Point(164, 56);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(56, 689);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Black;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1310, 56);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(56, 689);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // tabPageCreateQuiz
            // 
            this.tabPageCreateQuiz.BackColor = System.Drawing.Color.Black;
            this.tabPageCreateQuiz.Controls.Add(this.buttonAddSubject);
            this.tabPageCreateQuiz.Controls.Add(this.buttonOpenQuiz);
            this.tabPageCreateQuiz.Controls.Add(this.buttonCreateNewQuiz);
            this.tabPageCreateQuiz.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateQuiz.Name = "tabPageCreateQuiz";
            this.tabPageCreateQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateQuiz.Size = new System.Drawing.Size(156, 719);
            this.tabPageCreateQuiz.TabIndex = 0;
            this.tabPageCreateQuiz.Text = "Create Quiz";
            // 
            // buttonCreateNewQuiz
            // 
            this.buttonCreateNewQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewQuiz.Location = new System.Drawing.Point(6, 302);
            this.buttonCreateNewQuiz.Name = "buttonCreateNewQuiz";
            this.buttonCreateNewQuiz.Size = new System.Drawing.Size(141, 95);
            this.buttonCreateNewQuiz.TabIndex = 0;
            this.buttonCreateNewQuiz.Text = "Create New Quiz";
            this.buttonCreateNewQuiz.UseVisualStyleBackColor = true;
            this.buttonCreateNewQuiz.Click += new System.EventHandler(this.buttonCreateNewQuiz_Click);
            // 
            // buttonOpenQuiz
            // 
            this.buttonOpenQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenQuiz.Location = new System.Drawing.Point(8, 453);
            this.buttonOpenQuiz.Name = "buttonOpenQuiz";
            this.buttonOpenQuiz.Size = new System.Drawing.Size(141, 95);
            this.buttonOpenQuiz.TabIndex = 1;
            this.buttonOpenQuiz.Text = "Open Quiz";
            this.buttonOpenQuiz.UseVisualStyleBackColor = true;
            this.buttonOpenQuiz.Click += new System.EventHandler(this.buttonOpenQuiz_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubject.Location = new System.Drawing.Point(6, 151);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(141, 95);
            this.buttonAddSubject.TabIndex = 2;
            this.buttonAddSubject.Text = "Add Subject";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // tabControlTeacherOptions
            // 
            this.tabControlTeacherOptions.Controls.Add(this.tabPageCreateQuiz);
            this.tabControlTeacherOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlTeacherOptions.Location = new System.Drawing.Point(0, 0);
            this.tabControlTeacherOptions.Name = "tabControlTeacherOptions";
            this.tabControlTeacherOptions.SelectedIndex = 0;
            this.tabControlTeacherOptions.Size = new System.Drawing.Size(164, 745);
            this.tabControlTeacherOptions.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControlTeacherOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageCreateQuiz.ResumeLayout(false);
            this.tabControlTeacherOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TabPage tabPageCreateQuiz;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonOpenQuiz;
        private System.Windows.Forms.Button buttonCreateNewQuiz;
        private System.Windows.Forms.TabControl tabControlTeacherOptions;
    }
}

