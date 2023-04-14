namespace BaiTapLon_ThiTracNghiem
{
    partial class Form_Question
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
            this.lbTenThiSinh = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.boxQuestion = new System.Windows.Forms.GroupBox();
            this.btnPreQues = new System.Windows.Forms.Button();
            this.btnNextQues = new System.Windows.Forms.Button();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.boxQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenThiSinh
            // 
            this.lbTenThiSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTenThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenThiSinh.Location = new System.Drawing.Point(0, 0);
            this.lbTenThiSinh.Name = "lbTenThiSinh";
            this.lbTenThiSinh.Size = new System.Drawing.Size(974, 49);
            this.lbTenThiSinh.TabIndex = 0;
            this.lbTenThiSinh.Text = "Thí sinh: ";
            this.lbTenThiSinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(0, 49);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(974, 49);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Thời gian:";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxQuestion
            // 
            this.boxQuestion.Controls.Add(this.btnPreQues);
            this.boxQuestion.Controls.Add(this.btnNextQues);
            this.boxQuestion.Controls.Add(this.radioD);
            this.boxQuestion.Controls.Add(this.radioC);
            this.boxQuestion.Controls.Add(this.radioB);
            this.boxQuestion.Controls.Add(this.radioA);
            this.boxQuestion.Controls.Add(this.lbQuestion);
            this.boxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxQuestion.Location = new System.Drawing.Point(6, 134);
            this.boxQuestion.Name = "boxQuestion";
            this.boxQuestion.Size = new System.Drawing.Size(969, 474);
            this.boxQuestion.TabIndex = 2;
            this.boxQuestion.TabStop = false;
            this.boxQuestion.Text = "Câu";
            // 
            // btnPreQues
            // 
            this.btnPreQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreQues.Location = new System.Drawing.Point(8, 417);
            this.btnPreQues.Name = "btnPreQues";
            this.btnPreQues.Size = new System.Drawing.Size(168, 40);
            this.btnPreQues.TabIndex = 6;
            this.btnPreQues.Text = "Câu trước";
            this.btnPreQues.UseVisualStyleBackColor = true;
            this.btnPreQues.Click += new System.EventHandler(this.btnPreQues_Click);
            // 
            // btnNextQues
            // 
            this.btnNextQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQues.Location = new System.Drawing.Point(788, 417);
            this.btnNextQues.Name = "btnNextQues";
            this.btnNextQues.Size = new System.Drawing.Size(168, 40);
            this.btnNextQues.TabIndex = 5;
            this.btnNextQues.Text = "Câu sau";
            this.btnNextQues.UseVisualStyleBackColor = true;
            this.btnNextQues.Click += new System.EventHandler(this.btnNextQues_Click);
            // 
            // radioD
            // 
            this.radioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioD.Location = new System.Drawing.Point(522, 265);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(447, 127);
            this.radioD.TabIndex = 4;
            this.radioD.TabStop = true;
            this.radioD.Text = "radioButton2";
            this.radioD.UseVisualStyleBackColor = true;
            this.radioD.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioC
            // 
            this.radioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioC.Location = new System.Drawing.Point(8, 265);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(481, 127);
            this.radioC.TabIndex = 3;
            this.radioC.TabStop = true;
            this.radioC.Text = "radioButton1";
            this.radioC.UseVisualStyleBackColor = true;
            this.radioC.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioB
            // 
            this.radioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB.Location = new System.Drawing.Point(522, 134);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(441, 125);
            this.radioB.TabIndex = 2;
            this.radioB.TabStop = true;
            this.radioB.Text = "radioButton1";
            this.radioB.UseVisualStyleBackColor = true;
            this.radioB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioA
            // 
            this.radioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioA.Location = new System.Drawing.Point(8, 134);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(481, 125);
            this.radioA.TabIndex = 1;
            this.radioA.TabStop = true;
            this.radioA.Text = "\"Máy bay không người lái tấn công dưới nước hạt nhân này có thể được triển khai t" +
    "ại bất kỳ bờ biển và bến cảng nào hoặc được tàu mặt nước kéo đi để hoạt động” - " +
    "KCNA nêu rõ. ";
            this.radioA.UseVisualStyleBackColor = true;
            this.radioA.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lbQuestion
            // 
            this.lbQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(3, 31);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(963, 95);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "\"Máy bay không người lái tấn công dưới nước hạt nhân này có thể được triển khai t" +
    "ại bất kỳ bờ biển và bến cảng nào hoặc được tàu mặt nước kéo đi để hoạt động” - " +
    "KCNA nêu rõ. ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Red;
            this.btnSubmit.Location = new System.Drawing.Point(417, 643);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 51);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "NỘP BÀI";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // Form_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 715);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.boxQuestion);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTenThiSinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Question";
            this.ShowIcon = false;
            this.Text = "Chương trình Thi trắc nghiệm";
            this.Load += new System.EventHandler(this.Form_Question_Load);
            this.boxQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTenThiSinh;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox boxQuestion;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Button btnPreQues;
        private System.Windows.Forms.Button btnNextQues;
    }
}

