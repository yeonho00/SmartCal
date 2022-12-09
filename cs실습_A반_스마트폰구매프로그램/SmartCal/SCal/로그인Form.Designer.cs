namespace SCal
{
    partial class 로그인Form
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbPw = new System.Windows.Forms.Label();
            this.아이디 = new System.Windows.Forms.TextBox();
            this.비밀번호 = new System.Windows.Forms.TextBox();
            this.로그인버튼 = new System.Windows.Forms.Button();
            this.회원가입버튼 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(25, 40);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(41, 12);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "아이디";
            // 
            // lbPw
            // 
            this.lbPw.AutoSize = true;
            this.lbPw.Location = new System.Drawing.Point(25, 85);
            this.lbPw.Name = "lbPw";
            this.lbPw.Size = new System.Drawing.Size(53, 12);
            this.lbPw.TabIndex = 1;
            this.lbPw.Text = "비밀번호";
            // 
            // 아이디
            // 
            this.아이디.Location = new System.Drawing.Point(87, 36);
            this.아이디.Name = "아이디";
            this.아이디.Size = new System.Drawing.Size(100, 21);
            this.아이디.TabIndex = 3;
            // 
            // 비밀번호
            // 
            this.비밀번호.Location = new System.Drawing.Point(87, 81);
            this.비밀번호.Name = "비밀번호";
            this.비밀번호.Size = new System.Drawing.Size(100, 21);
            this.비밀번호.TabIndex = 4;
            this.비밀번호.UseSystemPasswordChar = true;
            // 
            // 로그인버튼
            // 
            this.로그인버튼.Location = new System.Drawing.Point(209, 31);
            this.로그인버튼.Name = "로그인버튼";
            this.로그인버튼.Size = new System.Drawing.Size(75, 47);
            this.로그인버튼.TabIndex = 5;
            this.로그인버튼.Text = "로그인";
            this.로그인버튼.UseVisualStyleBackColor = true;
            this.로그인버튼.Click += new System.EventHandler(this.로그인버튼_Click);
            // 
            // 회원가입버튼
            // 
            this.회원가입버튼.Location = new System.Drawing.Point(209, 84);
            this.회원가입버튼.Name = "회원가입버튼";
            this.회원가입버튼.Size = new System.Drawing.Size(75, 23);
            this.회원가입버튼.TabIndex = 6;
            this.회원가입버튼.Text = "회원가입";
            this.회원가입버튼.UseVisualStyleBackColor = true;
            // 
            // 로그인Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 133);
            this.Controls.Add(this.회원가입버튼);
            this.Controls.Add(this.로그인버튼);
            this.Controls.Add(this.비밀번호);
            this.Controls.Add(this.아이디);
            this.Controls.Add(this.lbPw);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "로그인Form";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.로그인Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbPw;
        private System.Windows.Forms.TextBox 아이디;
        private System.Windows.Forms.TextBox 비밀번호;
        private System.Windows.Forms.Button 로그인버튼;
        private System.Windows.Forms.Button 회원가입버튼;
    }
}