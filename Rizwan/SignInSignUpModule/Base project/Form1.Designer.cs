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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlTeacherOptions = new System.Windows.Forms.TabControl();
            this.tabPageCreateQuiz = new System.Windows.Forms.TabPage();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonOpenQuiz = new System.Windows.Forms.Button();
            this.buttonCreateNewQuiz = new System.Windows.Forms.Button();
            this.tabPageServer = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPagePrint = new System.Windows.Forms.TabPage();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.menuStrip1.SuspendLayout();
            this.tabControlTeacherOptions.SuspendLayout();
            this.tabPageCreateQuiz.SuspendLayout();
            this.tabPageServer.SuspendLayout();
            this.tabPagePrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tabControlTeacherOptions
            // 
            this.tabControlTeacherOptions.Controls.Add(this.tabPageCreateQuiz);
            this.tabControlTeacherOptions.Controls.Add(this.tabPageServer);
            this.tabControlTeacherOptions.Controls.Add(this.tabPagePrint);
            this.tabControlTeacherOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlTeacherOptions.Location = new System.Drawing.Point(0, 24);
            this.tabControlTeacherOptions.Name = "tabControlTeacherOptions";
            this.tabControlTeacherOptions.SelectedIndex = 0;
            this.tabControlTeacherOptions.Size = new System.Drawing.Size(164, 725);
            this.tabControlTeacherOptions.TabIndex = 3;
            // 
            // tabPageCreateQuiz
            // 
            this.tabPageCreateQuiz.Controls.Add(this.buttonAnalytics);
            this.tabPageCreateQuiz.Controls.Add(this.buttonAddSubject);
            this.tabPageCreateQuiz.Controls.Add(this.buttonOpenQuiz);
            this.tabPageCreateQuiz.Controls.Add(this.buttonCreateNewQuiz);
            this.tabPageCreateQuiz.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateQuiz.Name = "tabPageCreateQuiz";
            this.tabPageCreateQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateQuiz.Size = new System.Drawing.Size(156, 699);
            this.tabPageCreateQuiz.TabIndex = 0;
            this.tabPageCreateQuiz.Text = "Create Quiz";
            this.tabPageCreateQuiz.UseVisualStyleBackColor = true;
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalytics.Location = new System.Drawing.Point(6, 528);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(141, 95);
            this.buttonAnalytics.TabIndex = 3;
            this.buttonAnalytics.Text = "Analytics";
            this.buttonAnalytics.UseVisualStyleBackColor = true;
            this.buttonAnalytics.Click += new System.EventHandler(this.buttonAnalytics_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubject.Location = new System.Drawing.Point(6, 75);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(141, 95);
            this.buttonAddSubject.TabIndex = 2;
            this.buttonAddSubject.Text = "Add Subject";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // buttonOpenQuiz
            // 
            this.buttonOpenQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenQuiz.Location = new System.Drawing.Point(8, 377);
            this.buttonOpenQuiz.Name = "buttonOpenQuiz";
            this.buttonOpenQuiz.Size = new System.Drawing.Size(141, 95);
            this.buttonOpenQuiz.TabIndex = 1;
            this.buttonOpenQuiz.Text = "Open Quiz";
            this.buttonOpenQuiz.UseVisualStyleBackColor = true;
            this.buttonOpenQuiz.Click += new System.EventHandler(this.buttonOpenQuiz_Click);
            // 
            // buttonCreateNewQuiz
            // 
            this.buttonCreateNewQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewQuiz.Location = new System.Drawing.Point(6, 226);
            this.buttonCreateNewQuiz.Name = "buttonCreateNewQuiz";
            this.buttonCreateNewQuiz.Size = new System.Drawing.Size(141, 95);
            this.buttonCreateNewQuiz.TabIndex = 0;
            this.buttonCreateNewQuiz.Text = "Create New Quiz";
            this.buttonCreateNewQuiz.UseVisualStyleBackColor = true;
            this.buttonCreateNewQuiz.Click += new System.EventHandler(this.buttonCreateNewQuiz_Click);
            // 
            // tabPageServer
            // 
            this.tabPageServer.Controls.Add(this.button5);
            this.tabPageServer.Controls.Add(this.button6);
            this.tabPageServer.Location = new System.Drawing.Point(4, 22);
            this.tabPageServer.Name = "tabPageServer";
            this.tabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServer.Size = new System.Drawing.Size(156, 699);
            this.tabPageServer.TabIndex = 1;
            this.tabPageServer.Text = "Server";
            this.tabPageServer.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 88);
            this.button5.TabIndex = 8;
            this.button5.Text = "Upload to Fire Base";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(3, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 88);
            this.button6.TabIndex = 7;
            this.button6.Text = "Download";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPagePrint
            // 
            this.tabPagePrint.Controls.Add(this.buttonPrint);
            this.tabPagePrint.Controls.Add(this.button8);
            this.tabPagePrint.Controls.Add(this.button7);
            this.tabPagePrint.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrint.Name = "tabPagePrint";
            this.tabPagePrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrint.Size = new System.Drawing.Size(156, 699);
            this.tabPagePrint.TabIndex = 2;
            this.tabPagePrint.Text = "Print";
            this.tabPagePrint.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(8, 317);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(141, 95);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(5, 131);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 30);
            this.button8.TabIndex = 9;
            this.button8.Text = "Print Random Quiz";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 30);
            this.button7.TabIndex = 8;
            this.button7.Text = "Print Current Quiz";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(164, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1206, 56);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1314, 80);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(56, 669);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(164, 80);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(56, 669);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(220, 693);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1094, 56);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControlTeacherOptions);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlTeacherOptions.ResumeLayout(false);
            this.tabPageCreateQuiz.ResumeLayout(false);
            this.tabPageServer.ResumeLayout(false);
            this.tabPagePrint.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlTeacherOptions;
        private System.Windows.Forms.TabPage tabPageCreateQuiz;
        private System.Windows.Forms.Button buttonOpenQuiz;
        private System.Windows.Forms.Button buttonCreateNewQuiz;
        private System.Windows.Forms.TabPage tabPageServer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPagePrint;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonPrint;
    }
}

