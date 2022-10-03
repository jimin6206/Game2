namespace C_Sharp_4_jm
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground6 = new System.Windows.Forms.PictureBox();
            this.ground5 = new System.Windows.Forms.PictureBox();
            this.ground4 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.ground3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ground6
            // 
            this.ground6.BackColor = System.Drawing.Color.Transparent;
            this.ground6.Image = global::C_Sharp_4_jm.Properties.Resources.ground4;
            this.ground6.Location = new System.Drawing.Point(918, 804);
            this.ground6.Name = "ground6";
            this.ground6.Size = new System.Drawing.Size(543, 71);
            this.ground6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground6.TabIndex = 5;
            this.ground6.TabStop = false;
            this.ground6.Tag = "ground";
            // 
            // ground5
            // 
            this.ground5.BackColor = System.Drawing.Color.Transparent;
            this.ground5.Image = global::C_Sharp_4_jm.Properties.Resources.ground5;
            this.ground5.Location = new System.Drawing.Point(310, 387);
            this.ground5.Margin = new System.Windows.Forms.Padding(4);
            this.ground5.Name = "ground5";
            this.ground5.Size = new System.Drawing.Size(588, 96);
            this.ground5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground5.TabIndex = 4;
            this.ground5.TabStop = false;
            this.ground5.Tag = "ground";
            // 
            // ground4
            // 
            this.ground4.BackColor = System.Drawing.Color.Transparent;
            this.ground4.Image = global::C_Sharp_4_jm.Properties.Resources.ground5;
            this.ground4.Location = new System.Drawing.Point(1058, 532);
            this.ground4.Margin = new System.Windows.Forms.Padding(4);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(317, 86);
            this.ground4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground4.TabIndex = 3;
            this.ground4.TabStop = false;
            this.ground4.Tag = "ground";
            // 
            // ground2
            // 
            this.ground2.BackColor = System.Drawing.Color.Transparent;
            this.ground2.Image = global::C_Sharp_4_jm.Properties.Resources.ground5;
            this.ground2.Location = new System.Drawing.Point(494, 660);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(447, 94);
            this.ground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground2.TabIndex = 1;
            this.ground2.TabStop = false;
            this.ground2.Tag = "ground";
            // 
            // ground1
            // 
            this.ground1.BackColor = System.Drawing.Color.Transparent;
            this.ground1.Image = global::C_Sharp_4_jm.Properties.Resources.ground4;
            this.ground1.Location = new System.Drawing.Point(3, 812);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(467, 63);
            this.ground1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground1.TabIndex = 0;
            this.ground1.TabStop = false;
            this.ground1.Tag = "ground";
            // 
            // ground3
            // 
            this.ground3.BackColor = System.Drawing.Color.Transparent;
            this.ground3.Image = global::C_Sharp_4_jm.Properties.Resources.ground2;
            this.ground3.Location = new System.Drawing.Point(100, 466);
            this.ground3.Margin = new System.Windows.Forms.Padding(4);
            this.ground3.Name = "ground3";
            this.ground3.Size = new System.Drawing.Size(97, 57);
            this.ground3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground3.TabIndex = 2;
            this.ground3.TabStop = false;
            this.ground3.Tag = "ground";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 873);
            this.Controls.Add(this.ground6);
            this.Controls.Add(this.ground5);
            this.Controls.Add(this.ground4);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.ground3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpKey);
            ((System.ComponentModel.ISupportInitialize)(this.ground6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer GameTimer;
        public System.Windows.Forms.PictureBox ground1;
        public System.Windows.Forms.PictureBox ground2;
        public System.Windows.Forms.PictureBox ground3;
        public System.Windows.Forms.PictureBox ground4;
        public System.Windows.Forms.PictureBox ground5;
        public System.Windows.Forms.PictureBox ground6;
    }
}

