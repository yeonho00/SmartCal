namespace SCal
{
    partial class 휴대폰메뉴Form
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
            this.필터 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.공시지원금 = new System.Windows.Forms.RadioButton();
            this.출고가 = new System.Windows.Forms.RadioButton();
            this.내장메모리 = new System.Windows.Forms.RadioButton();
            this.램 = new System.Windows.Forms.RadioButton();
            this.두께 = new System.Windows.Forms.RadioButton();
            this.무게 = new System.Windows.Forms.RadioButton();
            this.크기 = new System.Windows.Forms.RadioButton();
            this.이름 = new System.Windows.Forms.RadioButton();
            this.등록수 = new System.Windows.Forms.RadioButton();
            this.배터리 = new System.Windows.Forms.RadioButton();
            this.검색창 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.정렬 = new System.Windows.Forms.GroupBox();
            this.정렬기준 = new System.Windows.Forms.ComboBox();
            this.필터.SuspendLayout();
            this.정렬.SuspendLayout();
            this.SuspendLayout();
            // 
            // 필터
            // 
            this.필터.Controls.Add(this.comboBox2);
            this.필터.Controls.Add(this.comboBox1);
            this.필터.Location = new System.Drawing.Point(12, 40);
            this.필터.Name = "필터";
            this.필터.Size = new System.Drawing.Size(175, 90);
            this.필터.TabIndex = 6;
            this.필터.TabStop = false;
            this.필터.Text = "필터";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "사용X",
            "제조사"});
            this.comboBox1.Location = new System.Drawing.Point(27, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 공시지원금
            // 
            this.공시지원금.AutoSize = true;
            this.공시지원금.Location = new System.Drawing.Point(83, 120);
            this.공시지원금.Name = "공시지원금";
            this.공시지원금.Size = new System.Drawing.Size(83, 16);
            this.공시지원금.TabIndex = 12;
            this.공시지원금.TabStop = true;
            this.공시지원금.Text = "공시지원금";
            this.공시지원금.UseVisualStyleBackColor = true;
            this.공시지원금.CheckedChanged += new System.EventHandler(this.공시지원금_CheckedChanged);
            // 
            // 출고가
            // 
            this.출고가.AutoSize = true;
            this.출고가.Location = new System.Drawing.Point(83, 142);
            this.출고가.Name = "출고가";
            this.출고가.Size = new System.Drawing.Size(59, 16);
            this.출고가.TabIndex = 11;
            this.출고가.TabStop = true;
            this.출고가.Text = "출고가";
            this.출고가.UseVisualStyleBackColor = true;
            this.출고가.CheckedChanged += new System.EventHandler(this.출고가_CheckedChanged);
            // 
            // 내장메모리
            // 
            this.내장메모리.AutoSize = true;
            this.내장메모리.Location = new System.Drawing.Point(83, 98);
            this.내장메모리.Name = "내장메모리";
            this.내장메모리.Size = new System.Drawing.Size(83, 16);
            this.내장메모리.TabIndex = 10;
            this.내장메모리.TabStop = true;
            this.내장메모리.Text = "내장메모리";
            this.내장메모리.UseVisualStyleBackColor = true;
            this.내장메모리.CheckedChanged += new System.EventHandler(this.내장메모리_CheckedChanged);
            // 
            // 램
            // 
            this.램.AutoSize = true;
            this.램.Location = new System.Drawing.Point(21, 54);
            this.램.Name = "램";
            this.램.Size = new System.Drawing.Size(50, 16);
            this.램.TabIndex = 1;
            this.램.TabStop = true;
            this.램.Text = "RAM";
            this.램.UseVisualStyleBackColor = true;
            this.램.CheckedChanged += new System.EventHandler(this.램_CheckedChanged);
            // 
            // 두께
            // 
            this.두께.AutoSize = true;
            this.두께.Location = new System.Drawing.Point(21, 76);
            this.두께.Name = "두께";
            this.두께.Size = new System.Drawing.Size(47, 16);
            this.두께.TabIndex = 2;
            this.두께.TabStop = true;
            this.두께.Text = "두께";
            this.두께.UseVisualStyleBackColor = true;
            this.두께.CheckedChanged += new System.EventHandler(this.두께_CheckedChanged);
            // 
            // 무게
            // 
            this.무게.AutoSize = true;
            this.무게.Location = new System.Drawing.Point(21, 98);
            this.무게.Name = "무게";
            this.무게.Size = new System.Drawing.Size(47, 16);
            this.무게.TabIndex = 3;
            this.무게.TabStop = true;
            this.무게.Text = "무게";
            this.무게.UseVisualStyleBackColor = true;
            this.무게.CheckedChanged += new System.EventHandler(this.무게_CheckedChanged);
            // 
            // 크기
            // 
            this.크기.AutoSize = true;
            this.크기.Location = new System.Drawing.Point(21, 120);
            this.크기.Name = "크기";
            this.크기.Size = new System.Drawing.Size(47, 16);
            this.크기.TabIndex = 4;
            this.크기.TabStop = true;
            this.크기.Text = "크기";
            this.크기.UseVisualStyleBackColor = true;
            this.크기.CheckedChanged += new System.EventHandler(this.크기_CheckedChanged);
            // 
            // 이름
            // 
            this.이름.AutoSize = true;
            this.이름.Location = new System.Drawing.Point(21, 142);
            this.이름.Name = "이름";
            this.이름.Size = new System.Drawing.Size(47, 16);
            this.이름.TabIndex = 5;
            this.이름.TabStop = true;
            this.이름.Text = "이름";
            this.이름.UseVisualStyleBackColor = true;
            this.이름.CheckedChanged += new System.EventHandler(this.이름_CheckedChanged);
            // 
            // 등록수
            // 
            this.등록수.AutoSize = true;
            this.등록수.Location = new System.Drawing.Point(83, 76);
            this.등록수.Name = "등록수";
            this.등록수.Size = new System.Drawing.Size(59, 16);
            this.등록수.TabIndex = 6;
            this.등록수.TabStop = true;
            this.등록수.Text = "등록수";
            this.등록수.UseVisualStyleBackColor = true;
            this.등록수.CheckedChanged += new System.EventHandler(this.조회수_CheckedChanged);
            // 
            // 배터리
            // 
            this.배터리.AutoSize = true;
            this.배터리.Location = new System.Drawing.Point(83, 54);
            this.배터리.Name = "배터리";
            this.배터리.Size = new System.Drawing.Size(59, 16);
            this.배터리.TabIndex = 7;
            this.배터리.TabStop = true;
            this.배터리.Text = "배터리";
            this.배터리.UseVisualStyleBackColor = true;
            this.배터리.CheckedChanged += new System.EventHandler(this.배터리_CheckedChanged);
            // 
            // 검색창
            // 
            this.검색창.Location = new System.Drawing.Point(59, 12);
            this.검색창.Name = "검색창";
            this.검색창.Size = new System.Drawing.Size(115, 21);
            this.검색창.TabIndex = 13;
            this.검색창.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.검색창_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "검색 : ";
            // 
            // 정렬
            // 
            this.정렬.Controls.Add(this.정렬기준);
            this.정렬.Controls.Add(this.램);
            this.정렬.Controls.Add(this.무게);
            this.정렬.Controls.Add(this.두께);
            this.정렬.Controls.Add(this.크기);
            this.정렬.Controls.Add(this.공시지원금);
            this.정렬.Controls.Add(this.출고가);
            this.정렬.Controls.Add(this.이름);
            this.정렬.Controls.Add(this.등록수);
            this.정렬.Controls.Add(this.배터리);
            this.정렬.Controls.Add(this.내장메모리);
            this.정렬.Location = new System.Drawing.Point(12, 140);
            this.정렬.Name = "정렬";
            this.정렬.Size = new System.Drawing.Size(176, 190);
            this.정렬.TabIndex = 15;
            this.정렬.TabStop = false;
            this.정렬.Text = "정렬";
            // 
            // 정렬기준
            // 
            this.정렬기준.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.정렬기준.FormattingEnabled = true;
            this.정렬기준.Items.AddRange(new object[] {
            "오름차순",
            "내림차순"});
            this.정렬기준.Location = new System.Drawing.Point(27, 21);
            this.정렬기준.Name = "정렬기준";
            this.정렬기준.Size = new System.Drawing.Size(121, 20);
            this.정렬기준.TabIndex = 10;
            this.정렬기준.SelectedIndexChanged += new System.EventHandler(this.정렬기준_SelectedIndexChanged);
            // 
            // 휴대폰메뉴Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 340);
            this.Controls.Add(this.정렬);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.검색창);
            this.Controls.Add(this.필터);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "휴대폰메뉴Form";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.휴대폰메뉴Form_Load);
            this.필터.ResumeLayout(false);
            this.정렬.ResumeLayout(false);
            this.정렬.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox 필터;
        private System.Windows.Forms.RadioButton 공시지원금;
        private System.Windows.Forms.RadioButton 출고가;
        private System.Windows.Forms.RadioButton 내장메모리;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton 램;
        private System.Windows.Forms.RadioButton 두께;
        private System.Windows.Forms.RadioButton 무게;
        private System.Windows.Forms.RadioButton 크기;
        private System.Windows.Forms.RadioButton 이름;
        private System.Windows.Forms.RadioButton 등록수;
        private System.Windows.Forms.RadioButton 배터리;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox 정렬;
        public System.Windows.Forms.ComboBox 정렬기준;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox 검색창;
    }
}