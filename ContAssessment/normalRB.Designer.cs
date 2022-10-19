
namespace ContAssessment
{
    partial class normalRB
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
            this.components = new System.ComponentModel.Container();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblans1 = new System.Windows.Forms.Label();
            this.lblans2 = new System.Windows.Forms.Label();
            this.lblans3 = new System.Windows.Forms.Label();
            this.lblans4 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(342, 415);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Submit";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblans1
            // 
            this.lblans1.AutoSize = true;
            this.lblans1.Location = new System.Drawing.Point(43, 71);
            this.lblans1.Name = "lblans1";
            this.lblans1.Size = new System.Drawing.Size(35, 13);
            this.lblans1.TabIndex = 1;
            this.lblans1.Text = "label1";
            this.lblans1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblans2
            // 
            this.lblans2.AutoSize = true;
            this.lblans2.Location = new System.Drawing.Point(43, 167);
            this.lblans2.Name = "lblans2";
            this.lblans2.Size = new System.Drawing.Size(35, 13);
            this.lblans2.TabIndex = 2;
            this.lblans2.Text = "label2";
            // 
            // lblans3
            // 
            this.lblans3.AutoSize = true;
            this.lblans3.Location = new System.Drawing.Point(43, 271);
            this.lblans3.Name = "lblans3";
            this.lblans3.Size = new System.Drawing.Size(35, 13);
            this.lblans3.TabIndex = 3;
            this.lblans3.Text = "label3";
            // 
            // lblans4
            // 
            this.lblans4.AutoSize = true;
            this.lblans4.Location = new System.Drawing.Point(43, 363);
            this.lblans4.Name = "lblans4";
            this.lblans4.Size = new System.Drawing.Size(35, 13);
            this.lblans4.TabIndex = 4;
            this.lblans4.Text = "label4";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(11, 71);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 6;
            this.rb1.TabStop = true;
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(11, 167);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 7;
            this.rb2.TabStop = true;
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(11, 271);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(14, 13);
            this.rb3.TabIndex = 8;
            this.rb3.TabStop = true;
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(12, 363);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(14, 13);
            this.rb4.TabIndex = 9;
            this.rb4.TabStop = true;
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(43, 19);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(578, 90);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 42);
            this.lblTime.TabIndex = 11;
            // 
            // normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lblans4);
            this.Controls.Add(this.lblans3);
            this.Controls.Add(this.lblans2);
            this.Controls.Add(this.lblans1);
            this.Controls.Add(this.btnCheck);
            this.Name = "normal";
            this.Text = "normal";
            this.Load += new System.EventHandler(this.normal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblans1;
        private System.Windows.Forms.Label lblans2;
        private System.Windows.Forms.Label lblans3;
        private System.Windows.Forms.Label lblans4;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}