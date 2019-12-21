namespace TestingApp
{
    partial class UserTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTestForm));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelBall = new System.Windows.Forms.Label();
            this.labelSubjectText = new System.Windows.Forms.Label();
            this.labelSubjectShow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuestDescr = new System.Windows.Forms.Label();
            this.labelCorrAnswer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(41, 526);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(156, 45);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Tag = "";
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(545, 526);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(156, 45);
            this.buttonComplete.TabIndex = 0;
            this.buttonComplete.Text = "Complete Test";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(292, 526);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(156, 45);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Tag = "";
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(717, 406);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 1;
            // 
            // labelBall
            // 
            this.labelBall.AutoSize = true;
            this.labelBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBall.Location = new System.Drawing.Point(747, 452);
            this.labelBall.Name = "labelBall";
            this.labelBall.Size = new System.Drawing.Size(0, 31);
            this.labelBall.TabIndex = 1;
            // 
            // labelSubjectText
            // 
            this.labelSubjectText.AutoSize = true;
            this.labelSubjectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubjectText.Location = new System.Drawing.Point(38, 122);
            this.labelSubjectText.Name = "labelSubjectText";
            this.labelSubjectText.Size = new System.Drawing.Size(80, 24);
            this.labelSubjectText.TabIndex = 2;
            this.labelSubjectText.Text = "Subject";
            // 
            // labelSubjectShow
            // 
            this.labelSubjectShow.AutoSize = true;
            this.labelSubjectShow.Location = new System.Drawing.Point(38, 145);
            this.labelSubjectShow.Name = "labelSubjectShow";
            this.labelSubjectShow.Size = new System.Drawing.Size(0, 13);
            this.labelSubjectShow.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Question Description";
            // 
            // labelQuestDescr
            // 
            this.labelQuestDescr.AutoSize = true;
            this.labelQuestDescr.Location = new System.Drawing.Point(38, 205);
            this.labelQuestDescr.Name = "labelQuestDescr";
            this.labelQuestDescr.Size = new System.Drawing.Size(0, 13);
            this.labelQuestDescr.TabIndex = 2;
            // 
            // labelCorrAnswer
            // 
            this.labelCorrAnswer.AutoSize = true;
            this.labelCorrAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorrAnswer.Location = new System.Drawing.Point(556, 172);
            this.labelCorrAnswer.Name = "labelCorrAnswer";
            this.labelCorrAnswer.Size = new System.Drawing.Size(57, 30);
            this.labelCorrAnswer.TabIndex = 3;
            this.labelCorrAnswer.Text = "Correct \r\nAnswer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UserTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(844, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCorrAnswer);
            this.Controls.Add(this.labelQuestDescr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSubjectShow);
            this.Controls.Add(this.labelSubjectText);
            this.Controls.Add(this.labelBall);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BeSmarter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelBall;
        private System.Windows.Forms.Label labelSubjectText;
        private System.Windows.Forms.Label labelSubjectShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuestDescr;
        private System.Windows.Forms.Label labelCorrAnswer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}