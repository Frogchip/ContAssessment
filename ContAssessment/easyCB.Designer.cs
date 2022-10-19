
namespace ContAssessment
{
    partial class easyCB
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
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.lblans1 = new System.Windows.Forms.Label();
            this.lblans2 = new System.Windows.Forms.Label();
            this.lblans3 = new System.Windows.Forms.Label();
            this.lblans4 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(12, 72);
            this.cb1.Margin = new System.Windows.Forms.Padding(2);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 14);
            this.cb1.TabIndex = 0;
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(12, 164);
            this.cb2.Margin = new System.Windows.Forms.Padding(2);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(15, 14);
            this.cb2.TabIndex = 1;
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(12, 271);
            this.cb3.Margin = new System.Windows.Forms.Padding(2);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(15, 14);
            this.cb3.TabIndex = 2;
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(12, 369);
            this.cb4.Margin = new System.Windows.Forms.Padding(2);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(15, 14);
            this.cb4.TabIndex = 3;
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // lblans1
            // 
            this.lblans1.AutoSize = true;
            this.lblans1.Location = new System.Drawing.Point(32, 73);
            this.lblans1.Name = "lblans1";
            this.lblans1.Size = new System.Drawing.Size(35, 13);
            this.lblans1.TabIndex = 4;
            this.lblans1.Text = "label1";
            // 
            // lblans2
            // 
            this.lblans2.AutoSize = true;
            this.lblans2.Location = new System.Drawing.Point(32, 164);
            this.lblans2.Name = "lblans2";
            this.lblans2.Size = new System.Drawing.Size(35, 13);
            this.lblans2.TabIndex = 5;
            this.lblans2.Text = "label2";
            // 
            // lblans3
            // 
            this.lblans3.AutoSize = true;
            this.lblans3.Location = new System.Drawing.Point(32, 271);
            this.lblans3.Name = "lblans3";
            this.lblans3.Size = new System.Drawing.Size(35, 13);
            this.lblans3.TabIndex = 6;
            this.lblans3.Text = "label3";
            // 
            // lblans4
            // 
            this.lblans4.AutoSize = true;
            this.lblans4.Location = new System.Drawing.Point(32, 369);
            this.lblans4.Name = "lblans4";
            this.lblans4.Size = new System.Drawing.Size(35, 13);
            this.lblans4.TabIndex = 7;
            this.lblans4.Text = "label4";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 24);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "label5";
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
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(642, 34);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 25);
            this.lblTime.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(308, 369);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // easyCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 453);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblans4);
            this.Controls.Add(this.lblans3);
            this.Controls.Add(this.lblans2);
            this.Controls.Add(this.lblans1);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "easyCB";
            this.Text = "easyCB";
            this.Load += new System.EventHandler(this.easyCB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.Label lblans1;
        private System.Windows.Forms.Label lblans2;
        private System.Windows.Forms.Label lblans3;
        private System.Windows.Forms.Label lblans4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSubmit;
    }
}