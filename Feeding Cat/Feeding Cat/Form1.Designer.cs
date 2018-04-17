namespace Feeding_Cat
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
            this.hangOut = new System.Windows.Forms.Button();
            this.feed = new System.Windows.Forms.Button();
            this.catTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hangOut
            // 
            this.hangOut.Location = new System.Drawing.Point(297, 258);
            this.hangOut.Name = "hangOut";
            this.hangOut.Size = new System.Drawing.Size(75, 51);
            this.hangOut.TabIndex = 0;
            this.hangOut.Text = "hang out";
            this.hangOut.UseVisualStyleBackColor = true;
            this.hangOut.Click += new System.EventHandler(this.hangOut_Click);
            // 
            // feed
            // 
            this.feed.Location = new System.Drawing.Point(531, 257);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(75, 52);
            this.feed.TabIndex = 1;
            this.feed.Text = "feed";
            this.feed.UseVisualStyleBackColor = true;
            this.feed.Click += new System.EventHandler(this.button2_Click);
            // 
            // catTextBox1
            // 
            this.catTextBox1.Location = new System.Drawing.Point(307, 83);
            this.catTextBox1.Name = "catTextBox1";
            this.catTextBox1.Size = new System.Drawing.Size(298, 86);
            this.catTextBox1.TabIndex = 2;
            this.catTextBox1.Text = "";
            this.catTextBox1.TextChanged += new System.EventHandler(this.catTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 404);
            this.Controls.Add(this.catTextBox1);
            this.Controls.Add(this.feed);
            this.Controls.Add(this.hangOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hangOut;
        private System.Windows.Forms.Button feed;
        private System.Windows.Forms.RichTextBox catTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

