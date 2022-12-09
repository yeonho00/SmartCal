using Oracle.DataAccess.Client;
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
    public partial class 즐겨찾기메뉴Form : Form
    {
        private 메인Form 메인form;
        private OracleDataAdapter DBAdapter;
        private DataSet ds;
        private DataRow[] dr;
        public string 보기모드, 정렬순서, 열이름, 단위;

        public 즐겨찾기메뉴Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;

            ds = new DataSet();
        }



        private void 두께_CheckedChanged(object sender, EventArgs e)
        {
            if (두께.Checked == true)
            {
                정렬순서 = "두께";
                열이름 = "두께";
                단위 = "mm";
                즐겨찾기정렬(열이름);
            }
        }
        private void 무게_CheckedChanged(object sender, EventArgs e)
        {
            if (무게.Checked == true)
            {
                정렬순서 = "무게";
                열이름 = "무게";
                단위 = "g";
                즐겨찾기정렬(열이름);
            }
        }
        private void 크기_CheckedChanged(object sender, EventArgs e)
        {
            if (크기.Checked == true)
            {
                정렬순서 = "크기";
                열이름 = "크기";
                단위 = "인치";
                즐겨찾기정렬(열이름);
            }
        }
        private void 이름_CheckedChanged(object sender, EventArgs e)
        {
            if (이름.Checked == true)
            {
                정렬순서 = "이름";
                열이름 = "기종이름";
                단위 = "";
                즐겨찾기정렬(열이름);
            }
        }
        private void 배터리_CheckedChanged(object sender, EventArgs e)
        {
            if (배터리.Checked == true)
            {
                정렬순서 = "배터리";
                열이름 = "배터리용량";
                단위 = "mAh";
                즐겨찾기정렬(열이름);
            }
        }
        private void 등록수_CheckedChanged(object sender, EventArgs e)
        {
            if (등록수.Checked == true)
            {
                정렬순서 = "등록수";
                열이름 = "등록수";
                단위 = "";
                즐겨찾기정렬(열이름);
            }
        }
        private void 내장메모리_CheckedChanged(object sender, EventArgs e)
        {
            if (내장메모리.Checked == true)
            {
                정렬순서 = "내장메모리";
                열이름 = "용량";
                단위 = "GB";
                즐겨찾기정렬(열이름);
            }
        }
        private void 공시지원금_CheckedChanged(object sender, EventArgs e)
        {
            if (공시지원금.Checked == true)
            {
                정렬순서 = "공시지원금";
                열이름 = "현재공시지원금";
                단위 = "원";
                즐겨찾기정렬(열이름);
            }
        }
        private void 출고가_CheckedChanged(object sender, EventArgs e)
        {
            if (출고가.Checked == true)
            {
                정렬순서 = "출고가";
                열이름 = "현재출고가";
                단위 = "원";
                즐겨찾기정렬(열이름);
            }

        }
        private void 등록일자_CheckedChanged(object sender, EventArgs e)
        {
            if (등록일자.Checked == true)
            {
                정렬순서 = "등록일자";
                열이름 = "등록일자";
                단위 = "";
                즐겨찾기정렬(열이름);
            }
        }

        private void 정렬기준_SelectedIndexChanged(object sender, EventArgs e)
        {
            즐겨찾기정렬(열이름);
        }

        private void 램_CheckedChanged(object sender, EventArgs e)
        {
            if (램.Checked == true)
            {
                정렬순서 = "RAM";
                열이름 = "RAM";
                단위 = "GB";
                즐겨찾기정렬(열이름);
            }
        }

        private void 즐겨찾기메뉴Form_Load(object sender, EventArgs e)
        {
            램.Checked = true;
            정렬기준.SelectedIndex = 0;
        }

        public void 즐겨찾기정렬(string str, int i=1)
        {
            try
            {
                string s, sql;

                if (정렬기준.SelectedItem.ToString().Equals("오름차순"))
                    s = "asc";
                else
                    s = "desc";

                sql = "select a.기종번호, a.기종사진, a.기종이름, a.두께, a.RAM, a.무게, a.크기, a.배터리용량, c.등록수, c.용량, c.현재공시지원금, c.현재출고가, b.등록일자, c.공시지원금변화치, c.출고가변화치 ";
                sql += "from 기종 a, 즐겨찾기 b, 내장메모리 c ";
                sql += "where b.기종번호=c.기종번호 and b.용량=c.용량 and a.기종번호=c.기종번호 and b.회원번호='" + 메인form.메뉴목록form.회원번호 + "' ";
                sql += "order by " + str + " " + s;
                DBAdapter = new OracleDataAdapter(sql, 메인form.connectionString);

                ds.Clear();
                DBAdapter.Fill(ds, "즐겨찾기목록");
                메인form.즐겨찾기form.현재페이지 = i;
                메인form.즐겨찾기form.ds = ds;
                메인form.즐겨찾기form.페이지계산();
                메인form.즐겨찾기form.즐겨찾기목록출력(정렬순서, 열이름, 단위);

                메인form.즐겨찾기form.Focus();
            }
            catch (DataException DE)
            {
                //MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                //MessageBox.Show(DE.Message);
            }
        }

    }
}
