namespace PC_3WEEK
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
            this.htnToRit = new System.Windows.Forms.Button();
            this.btnFromBit = new System.Windows.Forms.Button();
            this.ON = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            this.Toggle = new System.Windows.Forms.Button();
            this.htnShiftUp = new System.Windows.Forms.Button();
            this.btnShiftDown = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.check_7 = new System.Windows.Forms.CheckBox();
            this.check_0 = new System.Windows.Forms.CheckBox();
            this.check_1 = new System.Windows.Forms.CheckBox();
            this.check_2 = new System.Windows.Forms.CheckBox();
            this.check_3 = new System.Windows.Forms.CheckBox();
            this.check_4 = new System.Windows.Forms.CheckBox();
            this.check_5 = new System.Windows.Forms.CheckBox();
            this.check_6 = new System.Windows.Forms.CheckBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.textIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // htnToRit
            // 
            this.htnToRit.Location = new System.Drawing.Point(156, 12);
            this.htnToRit.Name = "htnToRit";
            this.htnToRit.Size = new System.Drawing.Size(95, 35);
            this.htnToRit.TabIndex = 0;
            this.htnToRit.Text = ">>";
            this.htnToRit.UseVisualStyleBackColor = true;
            this.htnToRit.Click += new System.EventHandler(this.htnToRit_Click);
            // 
            // btnFromBit
            // 
            this.btnFromBit.Location = new System.Drawing.Point(156, 53);
            this.btnFromBit.Name = "btnFromBit";
            this.btnFromBit.Size = new System.Drawing.Size(95, 35);
            this.btnFromBit.TabIndex = 1;
            this.btnFromBit.Text = "<<";
            this.btnFromBit.UseVisualStyleBackColor = true;
            this.btnFromBit.Click += new System.EventHandler(this.btnFromBit_Click);
            // 
            // ON
            // 
            this.ON.Location = new System.Drawing.Point(156, 148);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(95, 35);
            this.ON.TabIndex = 2;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // OFF
            // 
            this.OFF.Location = new System.Drawing.Point(156, 189);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(95, 35);
            this.OFF.TabIndex = 3;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // Toggle
            // 
            this.Toggle.Location = new System.Drawing.Point(156, 230);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(95, 35);
            this.Toggle.TabIndex = 4;
            this.Toggle.Text = "Toggle";
            this.Toggle.UseVisualStyleBackColor = true;
            this.Toggle.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // htnShiftUp
            // 
            this.htnShiftUp.Location = new System.Drawing.Point(11, 356);
            this.htnShiftUp.Name = "htnShiftUp";
            this.htnShiftUp.Size = new System.Drawing.Size(95, 35);
            this.htnShiftUp.TabIndex = 5;
            this.htnShiftUp.Text = "ShiftUp";
            this.htnShiftUp.UseVisualStyleBackColor = true;
            this.htnShiftUp.Click += new System.EventHandler(this.htnShiftUp_Click);
            // 
            // btnShiftDown
            // 
            this.btnShiftDown.Location = new System.Drawing.Point(147, 351);
            this.btnShiftDown.Name = "btnShiftDown";
            this.btnShiftDown.Size = new System.Drawing.Size(104, 40);
            this.btnShiftDown.TabIndex = 6;
            this.btnShiftDown.Text = " ShiftDown";
            this.btnShiftDown.UseVisualStyleBackColor = true;
            this.btnShiftDown.Click += new System.EventHandler(this.btnShiftDown_Click);
            // 
            // check_7
            // 
            this.check_7.AutoSize = true;
            this.check_7.Location = new System.Drawing.Point(346, 31);
            this.check_7.Name = "check_7";
            this.check_7.Size = new System.Drawing.Size(30, 16);
            this.check_7.TabIndex = 7;
            this.check_7.Text = "7";
            this.check_7.UseVisualStyleBackColor = true;
            // 
            // check_0
            // 
            this.check_0.AutoSize = true;
            this.check_0.Location = new System.Drawing.Point(346, 375);
            this.check_0.Name = "check_0";
            this.check_0.Size = new System.Drawing.Size(30, 16);
            this.check_0.TabIndex = 8;
            this.check_0.Text = "0";
            this.check_0.UseVisualStyleBackColor = true;
            // 
            // check_1
            // 
            this.check_1.AutoSize = true;
            this.check_1.Location = new System.Drawing.Point(346, 326);
            this.check_1.Name = "check_1";
            this.check_1.Size = new System.Drawing.Size(30, 16);
            this.check_1.TabIndex = 9;
            this.check_1.Text = "1";
            this.check_1.UseVisualStyleBackColor = true;
            // 
            // check_2
            // 
            this.check_2.AutoSize = true;
            this.check_2.Location = new System.Drawing.Point(346, 274);
            this.check_2.Name = "check_2";
            this.check_2.Size = new System.Drawing.Size(30, 16);
            this.check_2.TabIndex = 10;
            this.check_2.Text = "2";
            this.check_2.UseVisualStyleBackColor = true;
            // 
            // check_3
            // 
            this.check_3.AutoSize = true;
            this.check_3.Location = new System.Drawing.Point(346, 230);
            this.check_3.Name = "check_3";
            this.check_3.Size = new System.Drawing.Size(30, 16);
            this.check_3.TabIndex = 11;
            this.check_3.Text = "3";
            this.check_3.UseVisualStyleBackColor = true;
            // 
            // check_4
            // 
            this.check_4.AutoSize = true;
            this.check_4.Location = new System.Drawing.Point(346, 189);
            this.check_4.Name = "check_4";
            this.check_4.Size = new System.Drawing.Size(30, 16);
            this.check_4.TabIndex = 12;
            this.check_4.Text = "4";
            this.check_4.UseVisualStyleBackColor = true;
            // 
            // check_5
            // 
            this.check_5.AutoSize = true;
            this.check_5.Location = new System.Drawing.Point(346, 137);
            this.check_5.Name = "check_5";
            this.check_5.Size = new System.Drawing.Size(30, 16);
            this.check_5.TabIndex = 13;
            this.check_5.Text = "5";
            this.check_5.UseVisualStyleBackColor = true;
            // 
            // check_6
            // 
            this.check_6.AutoSize = true;
            this.check_6.Location = new System.Drawing.Point(346, 72);
            this.check_6.Name = "check_6";
            this.check_6.Size = new System.Drawing.Size(30, 16);
            this.check_6.TabIndex = 14;
            this.check_6.Text = "6";
            this.check_6.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 15;
            // 
            // textIndex
            // 
            this.textIndex.Location = new System.Drawing.Point(6, 156);
            this.textIndex.Name = "textIndex";
            this.textIndex.Size = new System.Drawing.Size(100, 21);
            this.textIndex.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textIndex);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.check_6);
            this.Controls.Add(this.check_5);
            this.Controls.Add(this.check_4);
            this.Controls.Add(this.check_3);
            this.Controls.Add(this.check_2);
            this.Controls.Add(this.check_1);
            this.Controls.Add(this.check_0);
            this.Controls.Add(this.check_7);
            this.Controls.Add(this.btnShiftDown);
            this.Controls.Add(this.htnShiftUp);
            this.Controls.Add(this.Toggle);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.btnFromBit);
            this.Controls.Add(this.htnToRit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button htnToRit;
        private System.Windows.Forms.Button btnFromBit;
        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Button Toggle;
        private System.Windows.Forms.Button htnShiftUp;
        private System.Windows.Forms.Button btnShiftDown;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox check_7;
        private System.Windows.Forms.CheckBox check_0;
        private System.Windows.Forms.CheckBox check_1;
        private System.Windows.Forms.CheckBox check_2;
        private System.Windows.Forms.CheckBox check_3;
        private System.Windows.Forms.CheckBox check_4;
        private System.Windows.Forms.CheckBox check_5;
        private System.Windows.Forms.CheckBox check_6;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox textIndex;
    }
}

