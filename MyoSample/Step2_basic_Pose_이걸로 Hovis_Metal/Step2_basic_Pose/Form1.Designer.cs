﻿namespace Step2_basic_Pose
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBaud = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnTurn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(198, 10);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(364, 118);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtBaud);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Location = new System.Drawing.Point(6, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 120);
            this.groupBox1.TabIndex = 385;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 70);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 12);
            this.label28.TabIndex = 6;
            this.label28.Text = "Baud";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(5, 91);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(175, 26);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 12);
            this.label27.TabIndex = 6;
            this.label27.Text = "Port";
            // 
            // txtBaud
            // 
            this.txtBaud.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBaud.Location = new System.Drawing.Point(44, 68);
            this.txtBaud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBaud.Name = "txtBaud";
            this.txtBaud.Size = new System.Drawing.Size(56, 20);
            this.txtBaud.TabIndex = 185;
            this.txtBaud.Text = "115200";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPort.Location = new System.Drawing.Point(44, 42);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(56, 20);
            this.txtPort.TabIndex = 185;
            this.txtPort.Text = "10";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(654, 10);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(74, 34);
            this.btnUp.TabIndex = 386;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(654, 49);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 34);
            this.btnStop.TabIndex = 386;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(654, 87);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(74, 34);
            this.btnDown.TabIndex = 386;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(576, 49);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(74, 34);
            this.btnLeft.TabIndex = 386;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(733, 49);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(74, 34);
            this.btnRight.TabIndex = 386;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnTurn
            // 
            this.btnTurn.Location = new System.Drawing.Point(567, 95);
            this.btnTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(66, 18);
            this.btnTurn.TabIndex = 387;
            this.btnTurn.Text = "Turn";
            this.btnTurn.UseVisualStyleBackColor = true;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 137);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtBaud;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnTurn;
    }
}

