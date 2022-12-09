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
    public partial class 계산기Form : Form
    {
        private 메인Form 메인form;
        private int 출고, 월정액, 할인, 공시, 출고할부, 할부개월;

        public 계산기Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;
        }

        public void 요금제정보작성(DataRow[] dr, int i)
        {
            요금제.Visible = true;
            월정액 = int.Parse(dr[i]["요금제가격"].ToString());

            요금제.Text = dr[i]["요금제이름"].ToString();
            데이터.Text = dr[i]["데이터"].ToString();
            음성.Text = dr[i]["음성"].ToString();
            문자.Text = dr[i]["문자"].ToString();
            가격.Text = 월정액.ToString() + "원";

            button2.Text = 월정액.ToString() + "원";
        }

        private void 계산기Form_Load(object sender, EventArgs e)
        {
            휴대폰.Visible = false;
            요금제.Visible = false;
        }

        public void 휴대폰정보받기(DataRow dr)
        {
            휴대폰.Visible = true;
            출고 = int.Parse(dr["현재출고가"].ToString());
            공시 = int.Parse(dr["현재공시지원금"].ToString());

            휴대폰.Text = dr["기종이름"].ToString();
            제조사1.Text = dr["제조사이름"].ToString();
            CPU1.Text = dr["CPU"].ToString();
            RAM1.Text = dr["RAM"].ToString() + "GB";
            배터리1.Text = dr["배터리용량"].ToString() + "mAh";
            내장메모리1.Text = dr["용량"].ToString() + "GB";
            두께1.Text = dr["두께"].ToString() + "mm";
            무게1.Text = dr["무게"].ToString() + "g";
            크기1.Text = dr["크기"].ToString() + "인치";
            해상도1.Text = dr["해상도"].ToString();
            공시지원금1.Text = 공시.ToString() + "원";
            출고가1.Text = 출고.ToString() + "원";
            pictureBox1.ImageLocation = @"핸드폰사진final\" + dr["기종사진"].ToString();
        }
        public void 할부정보받기(string str)
        {
            if (str.Equals("할부12개월"))
            {
                할부개월 = 12;
                출고할부 = 출고 / 할부개월;
            }
            else
            {
                할부개월 = 24;
                출고할부 = 출고 / 할부개월;
            }
            button1.Text = 출고할부.ToString() + "원";
        }

        public void 할인정보받기(string str)
        {
            if (str.Equals("선택약정할인"))
            {
                할인 = 월정액 / 4;
            }
            else
            {
                할인 = 공시 / 할부개월;
            }
            button3.Text = 할인.ToString() + "원";
        }

        public void 월납부금액계산()
        {
            if (button1.Text.Equals("출고가할부금") || button2.Text.Equals("월정액") || button3.Text.Equals("할인금액"))
                MessageBox.Show("아직 계산할 수 없습니다.", "월납부금액", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                label20.Text = (출고할부 + 월정액 - 할인).ToString() + "원";
            }
        }
    }
}
