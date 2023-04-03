namespace DrawPic
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
            this.btndraw100 = new System.Windows.Forms.Button();
            this.btnDraw3 = new System.Windows.Forms.Button();
            this.btnerase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNcir = new System.Windows.Forms.Label();
            this.lblNdir = new System.Windows.Forms.Label();
            this.lblNtotal = new System.Windows.Forms.Label();
            this.lblNtri = new System.Windows.Forms.Label();
            this.lblNsta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndraw100
            // 
            this.btndraw100.Location = new System.Drawing.Point(713, 100);
            this.btndraw100.Name = "btndraw100";
            this.btndraw100.Size = new System.Drawing.Size(75, 65);
            this.btndraw100.TabIndex = 1;
            this.btndraw100.Text = "100개 그리기";
            this.btndraw100.UseVisualStyleBackColor = true;
            this.btndraw100.Click += new System.EventHandler(this.btndraw100_Click);
            // 
            // btnDraw3
            // 
            this.btnDraw3.Location = new System.Drawing.Point(713, 10);
            this.btnDraw3.Name = "btnDraw3";
            this.btnDraw3.Size = new System.Drawing.Size(75, 65);
            this.btnDraw3.TabIndex = 2;
            this.btnDraw3.Text = "3개 그리기";
            this.btnDraw3.UseVisualStyleBackColor = true;
            this.btnDraw3.Click += new System.EventHandler(this.btnDraw3_Click);
            // 
            // btnerase
            // 
            this.btnerase.Location = new System.Drawing.Point(713, 385);
            this.btnerase.Name = "btnerase";
            this.btnerase.Size = new System.Drawing.Size(75, 65);
            this.btnerase.TabIndex = 3;
            this.btnerase.Text = "지우기";
            this.btnerase.UseVisualStyleBackColor = true;
            this.btnerase.Click += new System.EventHandler(this.btnerase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 600);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblNcir
            // 
            this.lblNcir.AutoSize = true;
            this.lblNcir.Location = new System.Drawing.Point(718, 198);
            this.lblNcir.Name = "lblNcir";
            this.lblNcir.Size = new System.Drawing.Size(38, 12);
            this.lblNcir.TabIndex = 5;
            this.lblNcir.Text = "label1";
            // 
            // lblNdir
            // 
            this.lblNdir.AutoSize = true;
            this.lblNdir.Location = new System.Drawing.Point(718, 230);
            this.lblNdir.Name = "lblNdir";
            this.lblNdir.Size = new System.Drawing.Size(38, 12);
            this.lblNdir.TabIndex = 6;
            this.lblNdir.Text = "label2";
            // 
            // lblNtotal
            // 
            this.lblNtotal.AutoSize = true;
            this.lblNtotal.Location = new System.Drawing.Point(718, 338);
            this.lblNtotal.Name = "lblNtotal";
            this.lblNtotal.Size = new System.Drawing.Size(38, 12);
            this.lblNtotal.TabIndex = 7;
            this.lblNtotal.Text = "label3";
            // 
            // lblNtri
            // 
            this.lblNtri.AutoSize = true;
            this.lblNtri.Location = new System.Drawing.Point(718, 268);
            this.lblNtri.Name = "lblNtri";
            this.lblNtri.Size = new System.Drawing.Size(38, 12);
            this.lblNtri.TabIndex = 8;
            this.lblNtri.Text = "label3";
            // 
            // lblNsta
            // 
            this.lblNsta.AutoSize = true;
            this.lblNsta.Location = new System.Drawing.Point(718, 304);
            this.lblNsta.Name = "lblNsta";
            this.lblNsta.Size = new System.Drawing.Size(38, 12);
            this.lblNsta.TabIndex = 9;
            this.lblNsta.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 624);
            this.Controls.Add(this.lblNsta);
            this.Controls.Add(this.lblNtri);
            this.Controls.Add(this.lblNtotal);
            this.Controls.Add(this.lblNdir);
            this.Controls.Add(this.lblNcir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnerase);
            this.Controls.Add(this.btnDraw3);
            this.Controls.Add(this.btndraw100);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndraw100;
        private System.Windows.Forms.Button btnDraw3;
        private System.Windows.Forms.Button btnerase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNcir;
        private System.Windows.Forms.Label lblNdir;
        private System.Windows.Forms.Label lblNtotal;
        private System.Windows.Forms.Label lblNtri;
        private System.Windows.Forms.Label lblNsta;
    }
}

