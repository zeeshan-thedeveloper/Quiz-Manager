namespace Base_project
{
    partial class QuizQuestionListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuizTitle = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelListoptionHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBoxListItemQuestion = new System.Windows.Forms.RichTextBox();
            this.labelQuizSubject = new System.Windows.Forms.Label();
            this.buttonSaved = new System.Windows.Forms.Button();
            this.labelRowId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuizTitle
            // 
            this.labelQuizTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizTitle.Location = new System.Drawing.Point(120, 3);
            this.labelQuizTitle.Name = "labelQuizTitle";
            this.labelQuizTitle.Size = new System.Drawing.Size(96, 23);
            this.labelQuizTitle.TabIndex = 0;
            this.labelQuizTitle.Text = "label1";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(460, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(460, 140);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxListItemQuestion);
            this.groupBox1.Location = new System.Drawing.Point(58, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // flowLayoutPanelListoptionHolder
            // 
            this.flowLayoutPanelListoptionHolder.AutoScroll = true;
            this.flowLayoutPanelListoptionHolder.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanelListoptionHolder.Name = "flowLayoutPanelListoptionHolder";
            this.flowLayoutPanelListoptionHolder.Size = new System.Drawing.Size(364, 75);
            this.flowLayoutPanelListoptionHolder.TabIndex = 1;
            // 
            // richTextBoxListItemQuestion
            // 
            this.richTextBoxListItemQuestion.Location = new System.Drawing.Point(15, 19);
            this.richTextBoxListItemQuestion.Name = "richTextBoxListItemQuestion";
            this.richTextBoxListItemQuestion.Size = new System.Drawing.Size(464, 70);
            this.richTextBoxListItemQuestion.TabIndex = 0;
            this.richTextBoxListItemQuestion.Text = "";
            // 
            // labelQuizSubject
            // 
            this.labelQuizSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizSubject.Location = new System.Drawing.Point(3, 3);
            this.labelQuizSubject.Name = "labelQuizSubject";
            this.labelQuizSubject.Size = new System.Drawing.Size(100, 23);
            this.labelQuizSubject.TabIndex = 4;
            this.labelQuizSubject.Text = "label1";
            // 
            // buttonSaved
            // 
            this.buttonSaved.Enabled = false;
            this.buttonSaved.Location = new System.Drawing.Point(460, 198);
            this.buttonSaved.Name = "buttonSaved";
            this.buttonSaved.Size = new System.Drawing.Size(101, 23);
            this.buttonSaved.TabIndex = 5;
            this.buttonSaved.Text = "Save";
            this.buttonSaved.UseVisualStyleBackColor = true;
            this.buttonSaved.Click += new System.EventHandler(this.buttonSaved_Click);
            // 
            // labelRowId
            // 
            this.labelRowId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRowId.Location = new System.Drawing.Point(3, 146);
            this.labelRowId.Name = "labelRowId";
            this.labelRowId.Size = new System.Drawing.Size(57, 23);
            this.labelRowId.TabIndex = 6;
            this.labelRowId.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanelListoptionHolder);
            this.groupBox2.Location = new System.Drawing.Point(58, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answers";
            // 
            // QuizQuestionListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelRowId);
            this.Controls.Add(this.buttonSaved);
            this.Controls.Add(this.labelQuizSubject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelQuizTitle);
            this.Name = "QuizQuestionListItem";
            this.Size = new System.Drawing.Size(550, 242);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuizTitle;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListoptionHolder;
        private System.Windows.Forms.RichTextBox richTextBoxListItemQuestion;
        private System.Windows.Forms.Label labelQuizSubject;
        private System.Windows.Forms.Button buttonSaved;
        private System.Windows.Forms.Label labelRowId;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
