namespace Base_project
{
    partial class OpenQuizParentWindow
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
            this.labelSubjectName = new System.Windows.Forms.Label();
            this.labelTopicName = new System.Windows.Forms.Label();
            this.richTextBoxContentdisplayer = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSaveAsPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSubjectName
            // 
            this.labelSubjectName.AutoSize = true;
            this.labelSubjectName.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectName.ForeColor = System.Drawing.Color.Yellow;
            this.labelSubjectName.Location = new System.Drawing.Point(857, 78);
            this.labelSubjectName.Name = "labelSubjectName";
            this.labelSubjectName.Size = new System.Drawing.Size(65, 22);
            this.labelSubjectName.TabIndex = 0;
            this.labelSubjectName.Text = "Subject";
            // 
            // labelTopicName
            // 
            this.labelTopicName.AutoSize = true;
            this.labelTopicName.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelTopicName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTopicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopicName.ForeColor = System.Drawing.Color.Yellow;
            this.labelTopicName.Location = new System.Drawing.Point(857, 140);
            this.labelTopicName.Name = "labelTopicName";
            this.labelTopicName.Size = new System.Drawing.Size(49, 22);
            this.labelTopicName.TabIndex = 1;
            this.labelTopicName.Text = "Topic";
            // 
            // richTextBoxContentdisplayer
            // 
            this.richTextBoxContentdisplayer.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxContentdisplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxContentdisplayer.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxContentdisplayer.Location = new System.Drawing.Point(16, 52);
            this.richTextBoxContentdisplayer.Name = "richTextBoxContentdisplayer";
            this.richTextBoxContentdisplayer.Size = new System.Drawing.Size(810, 462);
            this.richTextBoxContentdisplayer.TabIndex = 2;
            this.richTextBoxContentdisplayer.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quiz";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonPrint.Location = new System.Drawing.Point(870, 282);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(176, 72);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSaveAsPdf
            // 
            this.buttonSaveAsPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAsPdf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSaveAsPdf.Location = new System.Drawing.Point(870, 442);
            this.buttonSaveAsPdf.Name = "buttonSaveAsPdf";
            this.buttonSaveAsPdf.Size = new System.Drawing.Size(176, 72);
            this.buttonSaveAsPdf.TabIndex = 5;
            this.buttonSaveAsPdf.Text = "Save as PDF";
            this.buttonSaveAsPdf.UseVisualStyleBackColor = true;
            this.buttonSaveAsPdf.Click += new System.EventHandler(this.buttonSaveAsPdf_Click);
            // 
            // OpenQuizParentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1070, 526);
            this.Controls.Add(this.buttonSaveAsPdf);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxContentdisplayer);
            this.Controls.Add(this.labelTopicName);
            this.Controls.Add(this.labelSubjectName);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OpenQuizParentWindow";
            this.Text = "OpenQuizParentWindow";
            this.Load += new System.EventHandler(this.OpenQuizParentWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubjectName;
        private System.Windows.Forms.Label labelTopicName;
        private System.Windows.Forms.RichTextBox richTextBoxContentdisplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSaveAsPdf;
    }
}