namespace Base_project
{
    partial class GetQuizTopicNameWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTopicNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAlreadyCreatedTopics = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provide Topic Name";
            // 
            // textBoxTopicNam
            // 
            this.textBoxTopicNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTopicNam.Location = new System.Drawing.Point(225, 209);
            this.textBoxTopicNam.Name = "textBoxTopicNam";
            this.textBoxTopicNam.Size = new System.Drawing.Size(244, 27);
            this.textBoxTopicNam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Topic Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(521, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(527, 12);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(216, 28);
            this.comboBoxSubjects.TabIndex = 4;
            this.comboBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubjects_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subjects";
            // 
            // comboBoxAlreadyCreatedTopics
            // 
            this.comboBoxAlreadyCreatedTopics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlreadyCreatedTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlreadyCreatedTopics.FormattingEnabled = true;
            this.comboBoxAlreadyCreatedTopics.Location = new System.Drawing.Point(527, 79);
            this.comboBoxAlreadyCreatedTopics.Name = "comboBoxAlreadyCreatedTopics";
            this.comboBoxAlreadyCreatedTopics.Size = new System.Drawing.Size(216, 28);
            this.comboBoxAlreadyCreatedTopics.TabIndex = 6;
            this.comboBoxAlreadyCreatedTopics.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlreadyCreatedTopics_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Already created topics";
            // 
            // GetQuizTopicNameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 279);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAlreadyCreatedTopics);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTopicNam);
            this.Controls.Add(this.label1);
            this.Name = "GetQuizTopicNameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GetQuizTopicNameWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closedForm_Click);
            this.Load += new System.EventHandler(this.GetQuizTopicNameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTopicNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAlreadyCreatedTopics;
        private System.Windows.Forms.Label label4;
    }
}