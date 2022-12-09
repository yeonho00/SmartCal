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
    public partial class 휴대폰_심플Form : Form
    {
        private 메인Form 메인form;
        private OracleConnection odpConn = new OracleConnection();

        public int 현재페이지, 마지막페이지, cnt;
        public DataSet ds, ds2;
        private DataRow[] dr, dr2;
        private OracleDataAdapter DBAdapter;
        private OracleDataAdapter DBAdapter2;

        private string[] 기종번호;
        private int[] 용량, 등록수;
        private GroupBox[] 이름배열;
        private Label[] 데이터배열;
        private Label[] 기준배열;
        private PictureBox[] 사진배열;
        private bool[] 즐겨찾기배열;


        public 휴대폰_심플Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;

            이름배열 = new GroupBox[6];
            이름배열[0] = 이름1;
            이름배열[1] = 이름2;
            이름배열[2] = 이름3;
            이름배열[3] = 이름4;
            이름배열[4] = 이름5;
            이름배열[5] = 이름6;

            데이터배열 = new Label[6];
            데이터배열[0] = 데이터1;
            데이터배열[1] = 데이터2;
            데이터배열[2] = 데이터3;
            데이터배열[3] = 데이터4;
            데이터배열[4] = 데이터5;
            데이터배열[5] = 데이터6;

            기준배열 = new Label[6];
            기준배열[0] = 기준1;
            기준배열[1] = 기준2;
            기준배열[2] = 기준3;
            기준배열[3] = 기준4;
            기준배열[4] = 기준5;
            기준배열[5] = 기준6;

            사진배열 = new PictureBox[6];
            사진배열[0] = pictureBox1;
            사진배열[1] = pictureBox2;
            사진배열[2] = pictureBox3;
            사진배열[3] = pictureBox4;
            사진배열[4] = pictureBox5;
            사진배열[5] = pictureBox6;

            즐겨찾기배열 = new bool[6];
            기종번호 = new string[6];
            등록수 = new int[6];
            용량 = new int[6];
        }

        private void 세부_Click(object sender, EventArgs e)
        {
            메인form.휴대폰세부보기();
            메인form.휴대폰메뉴form.보기모드 = "세부";
        }

        private void 휴대폰_심플Form_Load(object sender, EventArgs e)
        {

        }

        public void 페이지계산()
        {
            cnt = ds.Tables["기종제조사용량"].Rows.Count;
            if (cnt % 6 > 0) 마지막페이지 = cnt / 6 + 1;
            else 마지막페이지 = cnt / 6;
            button1.Visible = false;
            if (마지막페이지 <= 1 )
                button2.Visible = false;
            else
                button2.Visible = true;
            페이지출력();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (현재페이지 > 1)
            {
                현재페이지--;
                페이지출력();
                심플출력(메인form.휴대폰메뉴form.정렬순서, 메인form.휴대폰메뉴form.열이름, 메인form.휴대폰메뉴form.단위);
            }
            if (현재페이지 == 1)
                button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (현재페이지 < 마지막페이지)
            {
                현재페이지++;
                페이지출력();
                심플출력(메인form.휴대폰메뉴form.정렬순서, 메인form.휴대폰메뉴form.열이름, 메인form.휴대폰메뉴form.단위);
            }
            if (현재페이지 == 마지막페이지)
                button2.Visible = false;
            button1.Visible = true;
        }

        private void 즐겨찾기delete(int i)
        {
            if (MessageBox.Show("즐겨찾기 목록에서 제외하시겠습니까?", "즐겨찾기", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                odpConn.ConnectionString = 메인form.connectionString;
                odpConn.Open();
                string sql = "delete from 즐겨찾기 where 회원번호=:회원번호 and 기종번호=:기종번호 and 용량=:용량";
                OracleCommand OraCmd = new OracleCommand(sql, odpConn);

                OraCmd.Parameters.Add("회원번호", OracleDbType.Varchar2, 5).Value = 메인form.메뉴목록form.회원번호;
                OraCmd.Parameters.Add("기종번호", OracleDbType.Varchar2, 5).Value = 기종번호[i];
                OraCmd.Parameters.Add("용량", OracleDbType.Decimal).Value = 용량[i];
                OraCmd.ExecuteNonQuery();

                sql = "update 내장메모리 set 등록수=:등록수 where 기종번호=:기종번호 and 용량=:용량";
                OraCmd = new OracleCommand(sql, odpConn);
                OraCmd.Parameters.Add("등록수", OracleDbType.Decimal).Value = 등록수[i] - 1;
                OraCmd.Parameters.Add("기종번호", OracleDbType.Varchar2, 5).Value = 기종번호[i];
                OraCmd.Parameters.Add("용량", OracleDbType.Decimal).Value = 용량[i];

                OraCmd.ExecuteNonQuery();
                odpConn.Close();

                ds2재설정();
                ds재설정();
                심플출력(메인form.휴대폰메뉴form.정렬순서, 메인form.휴대폰메뉴form.열이름, 메인form.휴대폰메뉴form.단위);
                메인form.휴대폰_세부form.세부출력();

                MessageBox.Show("즐겨찾기에서 제외되었습니다.", "즐겨찾기", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 즐겨찾기insert(int i)
        {
            if (MessageBox.Show("즐겨찾기 목록에 추가하시겠습니까?", "즐겨찾기", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                odpConn.ConnectionString = 메인form.connectionString;
                odpConn.Open();
                string sql = "insert into 즐겨찾기(회원번호, 기종번호, 용량, 등록일자) values(:회원번호, :기종번호, :용량, :등록일자)";
                OracleCommand OraCmd = new OracleCommand(sql, odpConn);

                OraCmd.Parameters.Add("회원번호", OracleDbType.Varchar2, 5).Value = 메인form.메뉴목록form.회원번호;
                OraCmd.Parameters.Add("기종번호", OracleDbType.Varchar2, 5).Value = 기종번호[i];
                OraCmd.Parameters.Add("용량", OracleDbType.Decimal).Value = 용량[i];
                OraCmd.Parameters.Add("등록일자", OracleDbType.Date).Value = DateTime.Now;

                OraCmd.ExecuteNonQuery();

                sql = "update 내장메모리 set 등록수=:등록수 where 기종번호=:기종번호 and 용량=:용량";
                OraCmd = new OracleCommand(sql, odpConn);
                OraCmd.Parameters.Add("등록수", OracleDbType.Decimal).Value = 등록수[i] + 1;
                OraCmd.Parameters.Add("기종번호", OracleDbType.Varchar2, 5).Value = 기종번호[i];
                OraCmd.Parameters.Add("용량", OracleDbType.Decimal).Value = 용량[i];

                OraCmd.ExecuteNonQuery();
                odpConn.Close();

                ds2재설정();
                ds재설정();
                심플출력(메인form.휴대폰메뉴form.정렬순서, 메인form.휴대폰메뉴form.열이름, 메인form.휴대폰메뉴form.단위);
                메인form.휴대폰_세부form.세부출력();

                MessageBox.Show("즐겨찾기에 추가되었습니다.", "즐겨찾기", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ds2재설정()
        {
            string sql;
            sql = "select a.회원번호, b.기종번호, b.용량 ";
            sql += "from 회원 a, 즐겨찾기 b ";
            sql += "where a.회원번호=b.회원번호 and a.회원번호='" + 메인form.메뉴목록form.회원번호 + "' ";
            DBAdapter = new OracleDataAdapter(sql, 메인form.connectionString);
            ds2.Clear();
            DBAdapter.Fill(ds2, "즐겨찾기");
        }
        private void ds재설정()
        {
            string sql, s;
            if (메인form.휴대폰메뉴form.정렬기준.SelectedItem.ToString().Equals("오름차순"))
                s = "asc";
            else
                s = "desc";
            sql = "select a.기종번호, a.기종이름, b.제조사이름, a.배터리용량, c.등록수, a.기종사진, a.디스플레이종류, a.해상도, a.크기, a.무게, a.두께, a.CPU, a.RAM, c.용량, c.현재공시지원금, c.현재출고가, a.기종사진 ";
            sql += "from 기종 a, 제조사 b, 내장메모리 c ";
            sql += "where a.제조사번호=b.제조사번호 and a.기종번호=c.기종번호 ";
            if (메인form.휴대폰메뉴form.comboBox2.Enabled == true)
                sql += "and b.제조사이름='" + 메인form.휴대폰메뉴form.comboBox2.SelectedItem.ToString() + "' ";
            sql += "order by " + 메인form.휴대폰메뉴form.열이름 + " " + s;
            DBAdapter2 = new OracleDataAdapter(sql, 메인form.connectionString);
            ds.Clear();
            DBAdapter2.Fill(ds, "기종제조사용량");
        }
        private void 즐겨찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (즐겨찾기배열[0]) { 즐겨찾기delete(0); }
            else { 즐겨찾기insert(0); }
        }
        private void 즐겨찾기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (즐겨찾기배열[1]) { 즐겨찾기delete(1); }
            else { 즐겨찾기insert(1); }
        }
        private void 즐겨찾기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (즐겨찾기배열[2]) { 즐겨찾기delete(2); }
            else { 즐겨찾기insert(2); }
        }
        private void 즐겨찾기ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (즐겨찾기배열[3]) { 즐겨찾기delete(3); }
            else { 즐겨찾기insert(3); }
        }
        private void 즐겨찾기ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (즐겨찾기배열[4]) { 즐겨찾기delete(4); }
            else { 즐겨찾기insert(4); }
        }
        private void 즐겨찾기ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (즐겨찾기배열[5]) { 즐겨찾기delete(5); }
            else { 즐겨찾기insert(5); }
        }
        private void 휴대폰_심플Form_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                if (현재페이지 < 마지막페이지) button2_Click(sender, e);
            }
            else
            {
                if (현재페이지 > 1) button1_Click(sender, e);
            }
        }

        private void 페이지출력()
        {
            if (현재페이지 - 2 >= 1) 페이지1.Text = (현재페이지 - 2).ToString(); else 페이지1.Text = "";
            if (현재페이지 - 1 >= 1) 페이지2.Text = (현재페이지 - 1).ToString(); else 페이지2.Text = "";
            페이지3.Text = 현재페이지.ToString();
            if (현재페이지 + 1 <= 마지막페이지) 페이지4.Text = (현재페이지 + 1).ToString(); else 페이지4.Text = "";
            if (현재페이지 + 2 <= 마지막페이지) 페이지5.Text = (현재페이지 + 2).ToString(); else 페이지5.Text = "";
        }

        public void 심플출력(string 라디오버튼이름, string str, string 단위)
        {
            dr = ds.Tables["기종제조사용량"].Select();
            int last;
            if (현재페이지 == 마지막페이지)
            {
                last = cnt % 6;
            }
            else
                last = 6;

            for (int i = 0; i < 6; i++)
            {
                if (i < last || last == 0)
                {
                    string str1 = "기종번호='" + dr[((현재페이지 - 1) * 6 + i)]["기종번호"].ToString();
                    str1 += "' and 용량=" + dr[(현재페이지 - 1) * 6 + i]["용량"].ToString();
                    dr2 = ds2.Tables["즐겨찾기"].Select(str1);

                    이름배열[i].Visible = true;

                    이름배열[i].Text = dr[((현재페이지 - 1) * 6 + i)]["기종이름"].ToString();
                    기준배열[i].Text = 라디오버튼이름 + "-";
                    데이터배열[i].Text = dr[((현재페이지 - 1) * 6 + i)][str].ToString() + 단위;
                    사진배열[i].ImageLocation = @"핸드폰사진final\" + dr[((현재페이지 - 1) * 6 + i)]["기종사진"].ToString();

                    기종번호[i] = dr[((현재페이지 - 1) * 6 + i)]["기종번호"].ToString();
                    용량[i] = int.Parse( dr[((현재페이지 - 1) * 6 + i)]["용량"].ToString());
                    등록수[i] = int.Parse(dr[((현재페이지 - 1) * 6 + i)]["등록수"].ToString());

                    if (dr2.Length > 0)
                    {
                        Color c = Color.FromArgb(210, 210, 210);
                        이름배열[i].BackColor = c;
                        즐겨찾기배열[i] = true;
                    }
                    else
                    {
                        Color c = Color.FromArgb(240, 240, 240);
                        이름배열[i].BackColor = c;
                        즐겨찾기배열[i] = false;
                    }
                }
                else
                {
                    이름배열[i].Visible = false;
                }
            }
        }
    }
}
