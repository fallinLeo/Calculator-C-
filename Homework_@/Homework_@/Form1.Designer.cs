namespace Homework__
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
            this.components = new System.ComponentModel.Container();
            this.Box = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.F_ast = new System.Windows.Forms.RadioButton();
            this.S_low = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Box.Location = new System.Drawing.Point(28, 21);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(50, 50);
            this.Box.TabIndex = 3;
            this.Box.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_ast
            // 
            this.F_ast.AutoSize = true;
            this.F_ast.Location = new System.Drawing.Point(715, 34);
            this.F_ast.Name = "F_ast";
            this.F_ast.Size = new System.Drawing.Size(47, 16);
            this.F_ast.TabIndex = 4;
            this.F_ast.Text = "Fast";
            this.F_ast.UseVisualStyleBackColor = true;
            this.F_ast.CheckedChanged += new System.EventHandler(this.F_ast_CheckedChanged);
            // 
            // S_low
            // 
            this.S_low.AutoSize = true;
            this.S_low.Location = new System.Drawing.Point(715, 12);
            this.S_low.Name = "S_low";
            this.S_low.Size = new System.Drawing.Size(51, 16);
            this.S_low.TabIndex = 5;
            this.S_low.Text = "Slow";
            this.S_low.UseVisualStyleBackColor = true;
            this.S_low.CheckedChanged += new System.EventHandler(this.S_low_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.S_low);
            this.Controls.Add(this.F_ast);
            this.Controls.Add(this.Box);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton F_ast;
        private System.Windows.Forms.RadioButton S_low;
    }
}

