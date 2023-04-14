namespace BaiTapLon_ThiTracNghiem
{
    partial class Form_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welcome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnVaoThi = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTime = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH THI TRẮC NGHIỆM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(198, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 35);
            this.txtName.TabIndex = 3;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(198, 193);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(177, 35);
            this.txtTime.TabIndex = 4;
            this.txtTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtTime_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "phút";
            // 
            // BtnVaoThi
            // 
            this.BtnVaoThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVaoThi.ForeColor = System.Drawing.Color.Red;
            this.BtnVaoThi.Location = new System.Drawing.Point(245, 275);
            this.BtnVaoThi.Name = "BtnVaoThi";
            this.BtnVaoThi.Size = new System.Drawing.Size(142, 56);
            this.BtnVaoThi.TabIndex = 6;
            this.BtnVaoThi.Text = "VÀO THI";
            this.BtnVaoThi.UseVisualStyleBackColor = true;
            this.BtnVaoThi.Click += new System.EventHandler(this.BtnVaoThi_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            this.errorProviderName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderName.Icon")));
            // 
            // errorProviderTime
            // 
            this.errorProviderTime.ContainerControl = this;
            this.errorProviderTime.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderTime.Icon")));
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 343);
            this.Controls.Add(this.BtnVaoThi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Welcome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình thi trắc nghiệm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Welcome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnVaoThi;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderTime;
    }
}