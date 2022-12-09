using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace SCal
{
    public partial class 휴대폰메뉴Form : Form
    {
        메인Form 메인form;
        private OracleDataAdapter DBAdapter, DBAdapter2, DBAdapter3;
        private OracleConnection odpConn = new OracleConnection();
        private DataSet ds, ds2, ds3;
        private DataRow[] dr;
        public string 보기모드, 정렬순서, 열이름, 단위;
        private string[] words;
  

        public 휴대폰메뉴Form(메인Form from)
        {
            InitializeComponent();
            메인form = from;
            ds = new DataSet();
            ds2 = new DataSet();
            ds3 = new DataSet();
        }

        private void 정렬기준_SelectedIndexChanged(object sender, EventArgs e)
        {
            휴대폰정렬(열이름);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Enabled = false;
                휴대폰정렬(열이름);
                if (보기모드.Equals("심플"))
                    메인form.휴대폰_심플form.Focus();
                else
                    메인form.휴대폰_세부form.Focus();
            }
            else
            {
                comboBox2.Items.Add("SAMSUNG");
                comboBox2.Items.Add("LG");
                comboBox2.Items.Add("Apple");
                comboBox2.Enabled = true;
                comboBox2.SelectedIndex = 0;
            }
            
        }

        private void 휴대폰메뉴Form_Load(object sender, EventArgs e)
        {
            램.Checked = true;
            정렬기준.SelectedIndex = 0;
        }

        private void 램_CheckedChanged(object sender, EventArgs e)
        {
            if (램.Checked == true)
            {
                정렬순서 = "RAM";
                열이름 = "RAM";
                단위 = "GB";
                휴대폰정렬(열이름);
            }

        }

        public string 검색어최적화()
        {
            string sql, buff = "%";
            try
            {
                words = 검색창.Text.Split(' ');
                sql = "select 수정전검색어, 수정후검색어 ";
                sql += "from 검색어최적화 ";

                DBAdapter3 = new OracleDataAdapter(sql, 메인form.connectionString);
                ds3.Clear();
                DBAdapter3.Fill(ds, "검색어최적화");

                foreach (string word in words)
                {
                    dr = ds.Tables["검색어최적화"].Select("수정전검색어='" + word + "'");
                    if (dr.Length > 0)
                        buff += dr[0]["수정후검색어"].ToString() + "%";
                    else
                        buff += word + "%";
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
            return buff;
        }
        public void 휴대폰정렬(string str)
        {
            try
            {
                string s, sql, buff;

                buff = 검색어최적화();

                if (정렬기준.SelectedItem.ToString().Equals("오름차순"))
                    s = "asc";
                else
                    s = "desc";

                sql = "select a.기종번호, a.기종이름, b.제조사이름, a.배터리용량, c.등록수, a.기종사진, a.디스플레이종류, a.해상도, a.크기, a.무게, a.두께, a.CPU, a.RAM, c.용량, c.현재공시지원금, c.현재출고가 ";
                sql += "from 기종 a, 제조사 b, 내장메모리 c ";
                sql += "where a.제조사번호=b.제조사번호 and a.기종번호=c.기종번호 ";
                if (comboBox2.Enabled == true)
                    sql += "and b.제조사이름='" + comboBox2.SelectedItem.ToString() + "' ";
                if (!검색창.Text.Equals(""))
                    sql += "and 기종이름 like '" + buff + "' ";
                sql += "order by " + str + " " + s;
                DBAdapter = new OracleDataAdapter(sql, 메인form.connectionString);

                sql = "select a.회원번호, b.기종번호, b.용량 ";
                sql += "from 회원 a, 즐겨찾기 b ";
                sql += "where a.회원번호=b.회원번호 and a.회원번호='" + 메인form.메뉴목록form.회원번호 + "' ";
                DBAdapter2 = new OracleDataAdapter(sql, 메인form.connectionString);

                ds.Clear();
                ds2.Clear();

                DBAdapter.Fill(ds, "기종제조사용량");                
                if (ds.Tables["기종제조사용량"].Rows.Count == 0)
                {
                    MessageBox.Show("검색결과가 존재하지 않습니다.", "검색결과", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    검색창.Text = "";
                    휴대폰정렬(열이름);
                    return;
                }
                DBAdapter2.Fill(ds2, "즐겨찾기");

                메인form.휴대폰_세부form.현재페이지 = 1;
                메인form.휴대폰_세부form.ds = ds;
                메인form.휴대폰_세부form.ds2 = ds2;
                메인form.휴대폰_세부form.페이지계산();
                메인form.휴대폰_세부form.세부출력();

                메인form.휴대폰_심플form.현재페이지 = 1;
                메인form.휴대폰_심플form.ds = ds;
                메인form.휴대폰_심플form.ds2 = ds2;
                메인form.휴대폰_심플form.페이지계산();
                메인form.휴대폰_심플form.심플출력(정렬순서, 열이름, 단위);

                if (보기모드.Equals("심플"))
                    메인form.휴대폰_심플form.Focus();
                else
                    메인form.휴대폰_세부form.Focus();
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

        public void 검색어최적화확인()
        {

        }

        private void 배터리_CheckedChanged(object sender, EventArgs e)
        {
            if (배터리.Checked == true)
            {
                정렬순서 = "배터리";
                열이름 = "배터리용량";
                단위 = "mAh";
                휴대폰정렬(열이름);
            }
        }
        private void 두께_CheckedChanged(object sender, EventArgs e)
        {
            if (두께.Checked == true)
            {
                정렬순서 = "두께";
                열이름 = "두께";
                단위 = "mm";
                휴대폰정렬(열이름);
            }
        }
        private void 무게_CheckedChanged(object sender, EventArgs e)
        {
            if (무게.Checked == true)
            {
                정렬순서 = "무게";
                열이름 = "무게";
                단위 = "g";
                휴대폰정렬(열이름);
            }
        }
        private void 내장메모리_CheckedChanged(object sender, EventArgs e)
        {
            if (내장메모리.Checked == true)
            {
                정렬순서 = "내장메모리";
                열이름 = "용량";
                단위 = "GB";
                휴대폰정렬(열이름);
            }
        }
        private void 크기_CheckedChanged(object sender, EventArgs e)
        {
            if (크기.Checked == true)
            {
                정렬순서 = "크기";
                열이름 = "크기";
                단위 = "인치";
                휴대폰정렬(열이름);
            }
        }
        private void 공시지원금_CheckedChanged(object sender, EventArgs e)
        {
            if (공시지원금.Checked == true)
            {
                정렬순서 = "공시지원금";
                열이름 = "현재공시지원금";
                단위 = "원";
                휴대폰정렬(열이름);
            }
        }
        private void 이름_CheckedChanged(object sender, EventArgs e)
        {
            if (이름.Checked == true)
            {
                정렬순서 = "이름";
                열이름 = "기종이름";
                단위 = "";
                휴대폰정렬(열이름);
            }
        }
        private void 출고가_CheckedChanged(object sender, EventArgs e)
        {
            if (출고가.Checked == true)
            {
                정렬순서 = "출고가";
                열이름 = "현재출고가";
                단위 = "원";
                휴대폰정렬(열이름);
            }
        }
        private void 조회수_CheckedChanged(object sender, EventArgs e)
        {
            if (등록수.Checked == true)
            {
                정렬순서 = "등록수";
                열이름 = "등록수";
                단위 = "";
                휴대폰정렬(열이름);
            }
        }

        private void 검색창_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                휴대폰정렬(열이름);
            }
        }
        /*public void 검색(string 검색어)
        {
            try
            {
                string s, sql;

                if (정렬기준.SelectedItem.ToString().Equals("오름차순"))
                    s = "asc";
                else
                    s = "desc";

                sql = "select a.기종번호, a.기종이름, b.제조사이름, a.배터리용량, c.등록수, a.기종사진, a.디스플레이종류, a.해상도, a.크기, a.무게, a.두께, a.CPU, a.RAM, c.용량, c.현재공시지원금, c.현재출고가 ";
                sql += "from 기종 a, 제조사 b, 내장메모리 c ";
                sql += "where a.제조사번호=b.제조사번호 and a.기종번호=c.기종번호 ";
                if (comboBox2.Enabled == true)
                    sql += "and b.제조사이름='" + comboBox2.SelectedItem.ToString() + "' ";
                if (!검색창.Text.Equals(""))
                    sql += "and 기종이름 like '%" + 검색어 + "%' ";
                sql += "order by " + str + " " + s;
                DBAdapter = new OracleDataAdapter(sql, 메인form.connectionString);

                sql = "select a.회원번호, b.기종번호, b.용량 ";
                sql += "from 회원 a, 즐겨찾기 b ";
                sql += "where a.회원번호=b.회원번호 and a.회원번호='" + 메인form.메뉴목록form.회원번호 + "' ";
                DBAdapter2 = new OracleDataAdapter(sql, 메인form.connectionString);

                ds.Clear();
                ds2.Clear();

                DBAdapter.Fill(ds, "기종제조사용량");
                DBAdapter2.Fill(ds2, "즐겨찾기");
                메인form.휴대폰_세부form.현재페이지 = 1;
                메인form.휴대폰_세부form.ds = ds;
                메인form.휴대폰_세부form.ds2 = ds2;
                메인form.휴대폰_세부form.페이지계산();
                메인form.휴대폰_세부form.세부출력();

                메인form.휴대폰_심플form.현재페이지 = 1;
                메인form.휴대폰_심플form.ds = ds;
                메인form.휴대폰_심플form.ds2 = ds2;
                메인form.휴대폰_심플form.페이지계산();
                메인form.휴대폰_심플form.심플출력(정렬순서, 열이름, 단위);

                if (보기모드.Equals("심플"))
                    메인form.휴대폰_심플form.Focus();
                else
                    메인form.휴대폰_세부form.Focus();
            }
            catch (DataException DE)
            {
                //MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                //MessageBox.Show(DE.Message);
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            휴대폰정렬(열이름);
        }
    }
}
