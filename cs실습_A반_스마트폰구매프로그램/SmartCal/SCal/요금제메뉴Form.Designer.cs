namespace SCal
{
    partial class 요금제메뉴Form
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
            this.정렬 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.요금제이름 = new System.Windows.Forms.ComboBox();
            this.요금제종류 = new System.Windows.Forms.ComboBox();
            this.통신사 = new System.Windows.Forms.ComboBox();
            this.정렬.SuspendLayout();
            this.SuspendLayout();
            // 
            // 정렬
            // 
            this.정렬.Controls.Add(this.label3);
            this.정렬.Controls.Add(this.label2);
            this.정렬.Controls.Add(this.label1);
            this.정렬.Controls.Add(this.요금제이름);
            this.정렬.Controls.Add(this.요금제종류);
            this.정렬.Controls.Add(this.통신사);
            this.정렬.Location = new System.Drawing.Point(13, 35);
            this.정렬.Name = "정렬";
            this.정렬.Size = new System.Drawing.Size(175, 264);
            this.정렬.TabIndex = 8;
            this.정렬.TabStop = false;
            this.정렬.Text = "요금제";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "요금제 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "요금제 종류";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "통신사";
            // 
            // 요금제이름
            // 
            this.요금제이름.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.요금제이름.Enabled = false;
            this.요금제이름.FormattingEnabled = true;
            this.요금제이름.Items.AddRange(new object[] {
            "요금제1",
            "요금재2",
            "요금제3",
            "요금제4"});
            this.요금제이름.Location = new System.Drawing.Point(27, 198);
            this.요금제이름.Name = "요금제이름";
            this.요금제이름.Size = new System.Drawing.Size(121, 20);
            this.요금제이름.TabIndex = 13;
            this.요금제이름.SelectedIndexChanged += new System.EventHandler(this.요금제이름_SelectedIndexChanged);
            // 
            // 요금제종류
            // 
            this.요금제종류.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.요금제종류.Enabled = false;
            this.요금제종류.FormattingEnabled = true;
            this.요금제종류.Items.AddRange(new object[] {
            "종류1",
            "종류2",
            "종류3"});
            this.요금제종류.Location = new System.Drawing.Point(27, 127);
            this.요금제종류.Name = "요금제종류";
            this.요금제종류.Size = new System.Drawing.Size(121, 20);
            this.요금제종류.TabIndex = 12;
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
            this.통신사.Location = new System.Drawing.Point(27, 56);
            this.통신사.Name = "통신사";
            this.통신사.Size = new System.Drawing.Size(121, 20);
            this.통신사.TabIndex = 11;
            this.통신사.SelectedIndexChanged += new System.EventHandler(this.통신사_SelectedIndexChanged);
            // 
            // 요금제메뉴Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 340);
            this.Controls.Add(this.정렬);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "요금제메뉴Form";
            this.Text = "요금제메뉴Form";
            this.Load += new System.EventHandler(this.요금제메뉴Form_Load);
            this.정렬.ResumeLayout(false);
            this.정렬.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 정렬;
        private System.Windows.Forms.ComboBox 통신사;
        private System.Windows.Forms.ComboBox 요금제이름;
        private System.Windows.Forms.ComboBox 요금제종류;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}