using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCal
{
    public partial class 메뉴목록Form : Form
    {
        private 메인Form 메인form;
        public string 회원번호;

        public 메뉴목록Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;
        }

        private void 휴대폰버튼_Click(object sender, EventArgs e)
        {
            메인form.휴대폰심플보기();
            메인form.휴대폰세부보기();
            메인form.휴대폰메뉴보기();
        }

        private void 계산기버튼_Click(object sender, EventArgs e)
        {
            메인form.휴대폰찾기보기();
            메인form.계산기보기();
            메인form.계산기메뉴보기();
        }

        private void 즐겨찾기버튼_Click(object sender, EventArgs e)
        {
            메인form.즐겨찾기보기();
            메인form.즐겨찾기메뉴보기();
        }

        private void 요금제버튼_Click(object sender, EventArgs e)
        {
            메인form.요금제보기();
            메인form.요금제메뉴보기();
        }

        private void 메뉴목록Form_Load(object sender, EventArgs e)
        {
            메인form.dRows = 메인form.로그인form.DS.Tables["회원"].Select();
            회원분류.Text = 메인form.dRows[0]["회원종류이름"].ToString();
            회원번호 = 메인form.dRows[0]["회원번호"].ToString();

            메인form.검색어최적화ToolStripMenuItem_Click(sender, e);
            계산기버튼_Click(sender, e);
            즐겨찾기버튼_Click(sender, e);
            요금제버튼_Click(sender, e);
            휴대폰버튼_Click(sender, e);
        }


    }
}
