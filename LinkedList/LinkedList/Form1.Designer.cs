namespace LinkedList
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
            this.btnmake = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnPrepand = new System.Windows.Forms.Button();
            this.btnappend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmake
            // 
            this.btnmake.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmake.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnmake.Location = new System.Drawing.Point(516, 12);
            this.btnmake.Name = "btnmake";
            this.btnmake.Size = new System.Drawing.Size(117, 86);
            this.btnmake.TabIndex = 0;
            this.btnmake.Text = "btnmake";
            this.btnmake.UseVisualStyleBackColor = true;
            this.btnmake.Click += new System.EventHandler(this.btnmake_Click);
            // 
            // btnprint
            // 
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnprint.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnprint.Location = new System.Drawing.Point(671, 12);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(117, 86);
            this.btnprint.TabIndex = 1;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnPrepand
            // 
            this.btnPrepand.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrepand.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnPrepand.Location = new System.Drawing.Point(516, 128);
            this.btnPrepand.Name = "btnPrepand";
            this.btnPrepand.Size = new System.Drawing.Size(117, 86);
            this.btnPrepand.TabIndex = 2;
            this.btnPrepand.Text = "Prepand";
            this.btnPrepand.UseVisualStyleBackColor = true;
            this.btnPrepand.Click += new System.EventHandler(this.btnPrepand_Click);
            // 
            // btnappend
            // 
            this.btnappend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnappend.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnappend.Location = new System.Drawing.Point(516, 250);
            this.btnappend.Name = "btnappend";
            this.btnappend.Size = new System.Drawing.Size(117, 86);
            this.btnappend.TabIndex = 3;
            this.btnappend.Text = "append";
            this.btnappend.UseVisualStyleBackColor = true;
            this.btnappend.Click += new System.EventHandler(this.btnappend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnappend);
            this.Controls.Add(this.btnPrepand);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnmake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmake;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnPrepand;
        private System.Windows.Forms.Button btnappend;
    }
}

