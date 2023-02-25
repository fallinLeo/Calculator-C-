namespace Caculator
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
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_C = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Subtract = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(224, 260);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(95, 76);
            this.button_1.TabIndex = 1;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(329, 260);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(95, 76);
            this.button_2.TabIndex = 2;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(447, 260);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(95, 76);
            this.button_3.TabIndex = 3;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(224, 166);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(95, 76);
            this.button_4.TabIndex = 4;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(331, 166);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(95, 76);
            this.button_5.TabIndex = 5;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(447, 166);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(95, 76);
            this.button_6.TabIndex = 6;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(224, 66);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(95, 76);
            this.button_7.TabIndex = 7;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(331, 66);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(95, 76);
            this.button_8.TabIndex = 8;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(447, 66);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(95, 76);
            this.button_9.TabIndex = 9;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(224, 345);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(95, 76);
            this.button_C.TabIndex = 11;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(331, 345);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(95, 76);
            this.button_0.TabIndex = 12;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(447, 345);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(95, 76);
            this.button_equal.TabIndex = 13;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(629, 378);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(47, 43);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Subtract
            // 
            this.button_Subtract.Location = new System.Drawing.Point(691, 378);
            this.button_Subtract.Name = "button_Subtract";
            this.button_Subtract.Size = new System.Drawing.Size(47, 43);
            this.button_Subtract.TabIndex = 15;
            this.button_Subtract.Text = "-";
            this.button_Subtract.UseVisualStyleBackColor = true;
            this.button_Subtract.Click += new System.EventHandler(this.button_Subtract_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.Location = new System.Drawing.Point(629, 329);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(47, 43);
            this.button_Divide.TabIndex = 16;
            this.button_Divide.Text = "%";
            this.button_Divide.UseVisualStyleBackColor = true;
            // 
            // button_Multiply
            // 
            this.button_Multiply.Location = new System.Drawing.Point(691, 329);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(47, 43);
            this.button_Multiply.TabIndex = 17;
            this.button_Multiply.Text = "*";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(239, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "0";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("굴림", 30F);
            this.answer.Location = new System.Drawing.Point(44, 351);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(150, 40);
            this.answer.TabIndex = 19;
            this.answer.Text = "answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Subtract);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Subtract;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answer;
    }
}

