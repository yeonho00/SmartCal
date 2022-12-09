namespace SCal
{
    partial class 메뉴목록Form
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
            this.휴대폰버튼 = new System.Windows.Forms.Button();
            this.요금제버튼 = new System.Windows.Forms.Button();
            this.계산기버튼 = new System.Windows.Forms.Button();
            this.즐겨찾기버튼 = new System.Windows.Forms.Button();
            this.용어사전버튼 = new System.Windows.Forms.Button();
            this.회원정보버튼 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.회원분류 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 휴대폰버튼
            // 
            this.휴대폰버튼.Location = new System.Drawing.Point(15, 37);
            this.휴대폰버튼.Name = "휴대폰버튼";
            this.휴대폰버튼.Size = new System.Drawing.Size(79, 40);
            this.휴대폰버튼.TabIndex = 0;
            this.휴대폰버튼.Text = "휴대폰";
            this.휴대폰버튼.UseVisualStyleBackColor = true;
            this.휴대폰버튼.Click += new System.EventHandler(this.휴대폰버튼_Click);
            // 
            // 요금제버튼
            // 
            this.요금제버튼.Location = new System.Drawing.Point(106, 37);
            this.요금제버튼.Name = "요금제버튼";
            this.요금제버튼.Size = new System.Drawing.Size(79, 40);
            this.요금제버튼.TabIndex = 1;
            this.요금제버튼.Text = "요금제";
            this.요금제버튼.UseVisualStyleBackColor = true;
            this.요금제버튼.Click += new System.EventHandler(this.요금제버튼_Click);
            // 
            // 계산기버튼
            // 
            this.계산기버튼.Location = new System.Drawing.Point(15, 83);
            this.계산기버튼.Name = "계산기버튼";
            this.계산기버튼.Size = new System.Drawing.Size(79, 40);
            this.계산기버튼.TabIndex = 2;
            this.계산기버튼.Text = "계산기";
            this.계산기버튼.UseVisualStyleBackColor = true;
            this.계산기버튼.Click += new System.EventHandler(this.계산기버튼_Click);
            // 
            // 즐겨찾기버튼
            // 
            this.즐겨찾기버튼.Location = new System.Drawing.Point(106, 83);
            this.즐겨찾기버튼.Name = "즐겨찾기버튼";
            this.즐겨찾기버튼.Size = new System.Drawing.Size(79, 40);
            this.즐겨찾기버튼.TabIndex = 3;
            this.즐겨찾기버튼.Text = "즐겨찾기";
            this.즐겨찾기버튼.UseVisualStyleBackColor = true;
            this.즐겨찾기버튼.Click += new System.EventHandler(this.즐겨찾기버튼_Click);
            // 
            // 용어사전버튼
            // 
            this.용어사전버튼.Location = new System.Drawing.Point(15, 129);
            this.용어사전버튼.Name = "용어사전버튼";
            this.용어사전버튼.Size = new System.Drawing.Size(79, 40);
            this.용어사전버튼.TabIndex = 4;
            this.용어사전버튼.Text = "용어사전";
            this.용어사전버튼.UseVisualStyleBackColor = true;
            // 
            // 회원정보버튼
            // 
            this.회원정보버튼.Location = new System.Drawing.Point(106, 129);
            this.회원정보버튼.Name = "회원정보버튼";
            this.회원정보버튼.Size = new System.Drawing.Size(79, 40);
            this.회원정보버튼.TabIndex = 5;
            this.회원정보버튼.Text = "회원정보";
            this.회원정보버튼.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "회원분류 :";
            // 
            // 회원분류
            // 
            this.회원분류.AutoSize = true;
            this.회원분류.Location = new System.Drawing.Point(87, 13);
            this.회원분류.Name = "회원분류";
            this.회원분류.Size = new System.Drawing.Size(29, 12);
            this.회원분류.TabIndex = 7;
            this.회원분류.Text = "일반";
            // 
            // 메뉴목록Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 180);
            this.Controls.Add(this.회원분류);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.회원정보버튼);
            this.Controls.Add(this.용어사전버튼);
            this.Controls.Add(this.즐겨찾기버튼);
            this.Controls.Add(this.계산기버튼);
            this.Controls.Add(this.요금제버튼);
            this.Controls.Add(this.휴대폰버튼);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "메뉴목록Form";
            this.Text = "일반회원메인Form";
            this.Load += new System.EventHandler(this.메뉴목록Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 휴대폰버튼;
        private System.Windows.Forms.Button 요금제버튼;
        private System.Windows.Forms.Button 계산기버튼;
        private System.Windows.Forms.Button 즐겨찾기버튼;
        private System.Windows.Forms.Button 용어사전버튼;
        private System.Windows.Forms.Button 회원정보버튼;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 회원분류;
    }
}