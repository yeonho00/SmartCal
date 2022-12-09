namespace SCal
{
    partial class 계산기메뉴Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.요금제이름 = new System.Windows.Forms.ComboBox();
            this.요금제종류 = new System.Windows.Forms.ComboBox();
            this.통신사 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "휴대폰";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "휴대폰찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.요금제이름);
            this.groupBox2.Controls.Add(this.요금제종류);
            this.groupBox2.Controls.Add(this.통신사);
            this.groupBox2.Location = new System.Drawing.Point(13, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "요금제";
            // 
            // 요금제이름
            // 
            this.요금제이름.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.요금제이름.Enabled = false;
            this.요금제이름.FormattingEnabled = true;
            this.요금제이름.Items.AddRange(new object[] {
            "SAMSUNG",
            "LG",
            "Apple"});
            this.요금제이름.Location = new System.Drawing.Point(28, 72);
            this.요금제이름.Name = "요금제이름";
            this.요금제이름.Size = new System.Drawing.Size(121, 20);
            this.요금제이름.TabIndex = 6;
            this.요금제이름.SelectedIndexChanged += new System.EventHandler(this.요금제이름_SelectedIndexChanged);
            // 
            // 요금제종류
            // 
            this.요금제종류.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.요금제종류.Enabled = false;
            this.요금제종류.FormattingEnabled = true;
            this.요금제종류.Items.AddRange(new object[] {
            "SAMSUNG",
            "LG",
            "Apple"});
            this.요금제종류.Location = new System.Drawing.Point(28, 46);
            this.요금제종류.Name = "요금제종류";
            this.요금제종류.Size = new System.Drawing.Size(121, 20);
            this.요금제종류.TabIndex = 5;
            this.요금제종류.SelectedIndexChanged += new System.EventHandler(this.요금제종류_SelectedIndexChanged);
            // 
            // 통신사
            // 
            this.통신사.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.통신사.FormattingEnabled = true;
            this.통신사.Items.AddRange(new object[] {
            "SKT",
            "KT",
            "LGU+"});
            this.통신사.Location = new System.Drawing.Point(28, 20);
            this.통신사.Name = "통신사";
            this.통신사.Size = new System.Drawing.Size(121, 20);
            this.통신사.TabIndex = 4;
            this.통신사.SelectedIndexChanged += new System.EventHandler(this.통신사_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(14, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "할인방식";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "선택약정할인",
            "공시지원금"});
            this.comboBox1.Location = new System.Drawing.Point(27, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(14, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "월납부금액 계산";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "할부12개월",
            "할부24개월"});
            this.comboBox2.Location = new System.Drawing.Point(28, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // 계산기메뉴Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "계산기메뉴Form";
            this.Text = "계산기메뉴Form";
            this.Load += new System.EventHandler(this.계산기메뉴Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox 통신사;
        private System.Windows.Forms.ComboBox 요금제이름;
        private System.Windows.Forms.ComboBox 요금제종류;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox2;
    }
}