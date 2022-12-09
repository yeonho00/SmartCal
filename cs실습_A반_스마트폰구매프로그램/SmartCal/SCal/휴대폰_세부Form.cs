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
    public partial class 휴대폰_세부Form : Form
    {
        //string ConnectionString = "User Id=scal; Password=scal; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
        private 메인Form 메인form;
        private OracleConnection odpConn = new OracleConnection();

        private DataRow[] dr, dr2;
        public DataSet ds, ds2;
        private OracleDataAdapter DBAdapter, DBAdapter2;

        private string[] 기종번호;
        private int[] 용량;
        private GroupBox[] 이름배열;
        private Label[] 제조사배열;
        private Label[] 배터리배열;
        private Label[] 등록수배열;
        private Label[] 디스플레이배열;
        private Label[] 해상도배열;
        private Label[] 크기배열;
        private Label[] 무게배열;
        private Label[] 두께배열;
        private Label[] CPU배열;
        private Label[] RAM배열;
        private Label[] 용량배열;
        private Label[] 출고가배열;
        private Label[] 공시지원금배열;
        private PictureBox[] 사진배열;
        private bool[] 즐겨찾기배열;
        public int 현재페이지, 마지막페이지, cnt;

        public 휴대폰_세부Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;

            현재페이지 = 1;
            ds = new DataSet();
            ds2 = new DataSet();
            즐겨찾기배열 = new bool[3];

            이름배열 = new GroupBox[3];
            이름배열[0] = groupBox1;
            이름배열[1] = groupBox2;
            이름배열[2] = groupBox3;

            제조사배열 = new Label[3];
            제조사배열[0] = 제조사1;
            제조사배열[1] = 제조사2;
            제조사배열[2] = 제조사3;

            배터리배열 = new Label[3];
            배터리배열[0] = 배터리1;
            배터리배열[1] = 배터리2;
            배터리배열[2] = 배터리3;

            등록수배열 = new Label[3];
            등록수배열[0] = 등록수1;
            등록수배열[1] = 등록수2;
            등록수배열[2] = 등록수3;

            디스플레이배열 = new Label[3];
            디스플레이배열[0] = 디스플레이1;
            디스플레이배열[1] = 디스플레이2;
            디스플레이배열[2] = 디스플레이3;

            해상도배열 = new Label[3];
            해상도배열[0] = 해상도1;
            해상도배열[1] = 해상도2;
            해상도배열[2] = 해상도3;

            크기배열 = new Label[3];
            크기배열[0] = 크기1;
            크기배열[1] = 크기2;
            크기배열[2] = 크기3;

            무게배열 = new Label[3];
            무게배열[0] = 무게1;
            무게배열[1] = 무게2;
            무게배열[2] = 무게3;

            두께배열 = new Label[3];
            두께배열[0] = 두께1;
            두께배열[1] = 두께2;
            두께배열[2] = 두께3;

            CPU배열 = new Label[3];
            CPU배열[0] = CPU1;
            CPU배열[1] = CPU2;
            CPU배열[2] = CPU3;

            RAM배열 = new Label[3];
            RAM배열[0] = RAM1;
            RAM배열[1] = RAM2;
            RAM배열[2] = RAM3;

            용량배열 = new Label[3];
            용량배열[0] = 내장메모리1;
            용량배열[1] = 내장메모리2;
            용량배열[2] = 내장메모리3;

            공시지원금배열 = new Label[3];
            공시지원금배열[0] = 공시지원금1;
            공시지원금배열[1] = 공시지원금2;
            공시지원금배열[2] = 공시지원금3;

            출고가배열 = new Label[3];
            출고가배열[0] = 출고가1;
            출고가배열[1] = 출고가2;
            출고가배열[2] = 출고가3;

            사진배열 = new PictureBox[3];
            사진배열[0] = pictureBox1;
            사진배열[1] = pictureBox2;
            사진배열[2] = pictureBox3;

            용량 = new int[3];
            기종번호 = new string[3];
        }

        private void 일반회원_휴대폰Form_Load(object sender, EventArgs e)
        {
            //메인form.dRows = 메인form.DS.Tables["기종제조사용량"].Select();
            //제조사1.Text = 메인form.dRows[4][2].ToString();
        }
        private void 심플_Click(object sender, EventArgs e)
        {
            메인form.휴대폰심플보기();
            메인form.휴대폰메뉴form.보기모드 = "심플";
        }

        public void 페이지계산()
        {
            cnt = ds.Tables["기종제조사용량"].Rows.Count;
            if (cnt % 3 > 0) 마지막페이지 = cnt / 3 + 1;
            else 마지막페이지 = cnt / 3;
            button1.Visible = false;
            if (마지막페이지 <= 1)
                button2.Visible = false;
            else
                button2.Visible = true;
            페이지출력();
        }
        private void 페이지출력()
        {
            if (현재페이지 - 2 >= 1) 페이지1.Text = (현재페이지 - 2).ToString(); else 페이지1.Text = "";
            if (현재페이지 - 1 >= 1) 페이지2.Text = (현재페이지 - 1).ToString(); else 페이지2.Text = "";
            페이지3.Text = 현재페이지.ToString();
            if (현재페이지 + 1 <= 마지막페이지) 페이지4.Text = (현재페이지 + 1).ToString(); else 페이지4.Text = "";
            if (현재페이지 + 2 <= 마지막페이지) 페이지5.Text = (현재페이지 + 2).ToString(); else 페이지5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (현재페이지 > 1)
            {
                현재페이지--;
                페이지출력();
                세부출력();
            }
            if (현재페이지 == 1)
                button1.Visible = false;
            button2.Visible = true;
        }

        private void 즐겨찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (즐겨찾기배열[0]) { 즐겨찾기delete(0); }
            else { 즐겨찾기insert(0); }
        }
        private void 즐겨찾기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (즐겨찾기배열[1]) { 즐겨찾기delete(1); }
            else { 즐겨찾기insert(1); }
        }
        private void 즐겨찾기ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (즐겨찾기배열[2]) { 즐겨찾기delete(2); }
            else { 즐겨찾기insert(2); }
        }

        private void 즐겨찾기delete(int i)
        {
            if (MessageBox.Show("즐겨찾기 목록에서 제외하시겠습니까?", "즐겨찾기", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)==DialogResult.Yes) {

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
                OraCmd.Parameters.Add("등록수", OracleDbType.Decimal).Value = int.Parse(등록수배열[i].Text) - 1;
                OraCmd.Parameters.Add("기종번호", OracleDbType.Varchar2, 5).Value = 기종번호[i];
                OraCmd.Parameters.Add("용량", OracleDbType.Decimal).Value = 용량[i];

                OraCmd.ExecuteNonQuery();
                odpConn.Close();

                메인form.휴대폰메뉴form.휴대폰정렬(메인form.휴대폰메뉴form.열이름);
                세부출력();
                메인form.휴대폰_심플form.심플출력(메인form.휴대폰메뉴form.정렬순서, 메인form.휴대폰메뉴form.열이름, 메인form.휴대폰메뉴form.단위);

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
                OraCmd.Parameters.Add("등록수", OracleDbType.Decimal).Value = int.Parse(등록수배열[i].Text) + 1;
                OraCmd.Parameters.Add("기종번호", OracleDbType.Varchar2, 5).Value = 기종번호[i];
                OraCmd.Parameters.Add("용량", OracleDbType.Decimal).Value = 용량[i];
                
                OraCmd.ExecuteNonQuery();
                odpConn.Close();

                //ds2재설정();
                //ds재설정();
                메인form.휴대폰메뉴form.휴대폰정렬(메인form.휴대폰메뉴form.열이름);
                세부출력();
                메인form.휴대폰_심플form.심플출력(메인form.휴대폰메뉴form.정렬순서, 메인form.휴대폰메뉴form.열이름, 메인form.휴대폰메뉴form.단위);

                MessageBox.Show("즐겨찾기에 추가되었습니다.", "즐겨찾기", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (현재페이지 < 마지막페이지)
            {
                현재페이지++;
                페이지출력();
                세부출력();
            }
            if (현재페이지 == 마지막페이지)
                button2.Visible = false;
            button1.Visible = true;
        }

        public void 세부출력()
        {
            dr = ds.Tables["기종제조사용량"].Select();

            int last;
            if (현재페이지 == 마지막페이지)
            {
                last = cnt % 3;
            }
            else
                last = 3;

            for (int i = 0; i < 3; i++)
//sql = "select a.기종번호, a.기종이름, b.제조사이름, a.배터리용량, a.조회수, a.기종사진, a.디스플레이종류, a.해상도, a.크기, a.무게, a.두께, a.CPU, a.RAM, c.용량 ";
            {
                if (i < last || last == 0)
                {
                    string str = "기종번호='" + dr[((현재페이지 - 1) * 3 + i)]["기종번호"].ToString();
                    str += "' and 용량=" + dr[(현재페이지 - 1) * 3 + i]["용량"].ToString();
                    dr2 = ds2.Tables["즐겨찾기"].Select(str);

                    이름배열[i].Visible = true;
                    이름배열[i].Text = dr[((현재페이지 - 1) * 3 + i)]["기종이름"].ToString();
                    사진배열[i].ImageLocation = @"핸드폰사진final\" + dr[((현재페이지 - 1) * 3 + i)]["기종사진"].ToString();
                    제조사배열[i].Text = dr[((현재페이지 - 1) * 3 + i)]["제조사이름"].ToString();
                    배터리배열[i].Text = dr[((현재페이지 - 1) * 3 + i)]["배터리용량"].ToString() + "mAh";
                    등록수배열[i].Text = dr[((현재페이지 - 1) * 3 + i)]["등록수"].ToString();
                    디스플레이배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["디스플레이종류"].ToString();
                    해상도배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["해상도"].ToString();
                    크기배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["크기"].ToString() + "인치";
                    무게배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["무게"].ToString() + "g";
                    두께배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["두께"].ToString() + "mm";
                    CPU배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["CPU"].ToString();
                    RAM배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["RAM"].ToString() + "GB";
                    용량배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["용량"].ToString() + "GB";
                    공시지원금배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["현재공시지원금"].ToString() + "원";
                    출고가배열[i].Text = dr[(현재페이지 - 1) * 3 + i]["현재출고가"].ToString() + "원";

                    용량[i] = int.Parse(dr[(현재페이지 - 1) * 3 + i]["용량"].ToString());
                    기종번호[i] = dr[(현재페이지 - 1) * 3 + i]["기종번호"].ToString();

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
        private void 휴대폰_세부Form_MouseWheel(object sender, MouseEventArgs e)
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
    }
}
