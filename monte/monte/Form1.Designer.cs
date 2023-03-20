namespace monte
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRatioReal = new System.Windows.Forms.Label();
            this.lblIN = new System.Windows.Forms.Label();
            this.lblOUT = new System.Windows.Forms.Label();
            this.lblRatioMonte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(713, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 61);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRatioReal
            // 
            this.lblRatioReal.AutoSize = true;
            this.lblRatioReal.Location = new System.Drawing.Point(720, 105);
            this.lblRatioReal.Name = "lblRatioReal";
            this.lblRatioReal.Size = new System.Drawing.Size(71, 12);
            this.lblRatioReal.TabIndex = 2;
            this.lblRatioReal.Text = "lblRatioReal";
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Location = new System.Drawing.Point(721, 135);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(30, 12);
            this.lblIN.TabIndex = 3;
            this.lblIN.Text = "lblIN";
            // 
            // lblOUT
            // 
            this.lblOUT.AutoSize = true;
            this.lblOUT.Location = new System.Drawing.Point(721, 177);
            this.lblOUT.Name = "lblOUT";
            this.lblOUT.Size = new System.Drawing.Size(43, 12);
            this.lblOUT.TabIndex = 4;
            this.lblOUT.Text = "lblOUT";
            // 
            // lblRatioMonte
            // 
            this.lblRatioMonte.AutoSize = true;
            this.lblRatioMonte.Location = new System.Drawing.Point(720, 218);
            this.lblRatioMonte.Name = "lblRatioMonte";
            this.lblRatioMonte.Size = new System.Drawing.Size(81, 12);
            this.lblRatioMonte.TabIndex = 5;
            this.lblRatioMonte.Text = "lblRatioMonte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 539);
            this.Controls.Add(this.lblRatioMonte);
            this.Controls.Add(this.lblOUT);
            this.Controls.Add(this.lblIN);
            this.Controls.Add(this.lblRatioReal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRatioReal;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.Label lblOUT;
        private System.Windows.Forms.Label lblRatioMonte;
    }
}

