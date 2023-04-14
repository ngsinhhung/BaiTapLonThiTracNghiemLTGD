namespace BaiTapLon_ThiTracNghiem
{
    partial class Form_Result
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
            this.lbTenThiSinh = new System.Windows.Forms.Label();
            this.lbCaption = new System.Windows.Forms.Label();
            this.lbTrueAnswer = new System.Windows.Forms.Label();
            this.lbFalseAnswer = new System.Windows.Forms.Label();
            this.lbScores = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTenThiSinh
            // 
            this.lbTenThiSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTenThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenThiSinh.Location = new System.Drawing.Point(0, 0);
            this.lbTenThiSinh.Name = "lbTenThiSinh";
            this.lbTenThiSinh.Size = new System.Drawing.Size(660, 49);
            this.lbTenThiSinh.TabIndex = 1;
            this.lbTenThiSinh.Text = "Thí sinh: ";
            this.lbTenThiSinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCaption
            // 
            this.lbCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaption.ForeColor = System.Drawing.Color.Red;
            this.lbCaption.Location = new System.Drawing.Point(0, 49);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(660, 81);
            this.lbCaption.TabIndex = 2;
            this.lbCaption.Text = "Bạn đã hoành thành bài thi";
            this.lbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTrueAnswer
            // 
            this.lbTrueAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTrueAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrueAnswer.Location = new System.Drawing.Point(0, 130);
            this.lbTrueAnswer.Name = "lbTrueAnswer";
            this.lbTrueAnswer.Size = new System.Drawing.Size(660, 49);
            this.lbTrueAnswer.TabIndex = 3;
            this.lbTrueAnswer.Text = "Số câu trả lời đúng: ";
            this.lbTrueAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFalseAnswer
            // 
            this.lbFalseAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFalseAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFalseAnswer.Location = new System.Drawing.Point(0, 179);
            this.lbFalseAnswer.Name = "lbFalseAnswer";
            this.lbFalseAnswer.Size = new System.Drawing.Size(660, 49);
            this.lbFalseAnswer.TabIndex = 4;
            this.lbFalseAnswer.Text = "Số câu trả lời sai: ";
            this.lbFalseAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScores
            // 
            this.lbScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScores.Location = new System.Drawing.Point(0, 228);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(660, 49);
            this.lbScores.TabIndex = 5;
            this.lbScores.Text = "Tổng điểm: ";
            this.lbScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(236, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 50);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Hoàn thành";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 363);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbScores);
            this.Controls.Add(this.lbFalseAnswer);
            this.Controls.Add(this.lbTrueAnswer);
            this.Controls.Add(this.lbCaption);
            this.Controls.Add(this.lbTenThiSinh);
            this.Name = "Form_Result";
            this.ShowIcon = false;
            this.Text = "Chương trinh thi trắc nghiệm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Result_FormClosed);
            this.Load += new System.EventHandler(this.Form_Result_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTenThiSinh;
        private System.Windows.Forms.Label lbCaption;
        private System.Windows.Forms.Label lbTrueAnswer;
        private System.Windows.Forms.Label lbFalseAnswer;
        private System.Windows.Forms.Label lbScores;
        private System.Windows.Forms.Button btnSubmit;
    }
}