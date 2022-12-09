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
    public partial class 즐겨찾기Form : Form
    {
        private 메인Form 메인form;
        public DataSet ds;
        private DataRow[] dr;
        private OracleConnection odpConn = new OracleConnection();

        private string[] 기종번호;
        private int[] 용량, 등록수;
        private Label[] 공시지원금, 공시변화치, 출고가, 출고변화치, 데이터, 기준;
        private PictureBox[] 사진;
        private GroupBox[] 이름;

        private void 즐겨찾기Form_MouseWheel(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (현재페이지 > 1)
            {
                현재페이지--;
                페이지출력();
                즐겨찾기목록출력(메인form.즐겨찾기메뉴form.정렬순서, 메인form.즐겨찾기메뉴form.열이름, 메인form.즐겨찾기메뉴form.단위);
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
                즐겨찾기목록출력(메인form.즐겨찾기메뉴form.정렬순서, 메인form.즐겨찾기메뉴form.열이름, 메인form.즐겨찾기메뉴form.단위);
            }
            if (현재페이지 == 마지막페이지)
                button2.Visible = false;
            button1.Visible = true;
        }

        private void 즐겨찾기제외ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            즐겨찾기delete(0);
        }
        private void 즐겨찾기제외ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            즐겨찾기delete(1);
        }
        private void 즐겨찾기제외ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            즐겨찾기delete(2);
        }
        private void 즐겨찾기제외ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            즐겨찾기delete(3);
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

                메인form.즐겨찾기메뉴form.즐겨찾기정렬(메인form.즐겨찾기메뉴form.열이름, 현재페이지);

                MessageBox.Show("즐겨찾기에서 제외되었습니다.", "즐겨찾기", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int 현재페이지, 마지막페이지, cnt;

        public 즐겨찾기Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;
            ds = new DataSet();

            기종번호 = new string[4];
            용량 = new int[4];
            등록수 = new int[4];

            사진 = new PictureBox[4];
            사진[0] = pictureBox1;
            사진[1] = pictureBox2;
            사진[2] = pictureBox3;
            사진[3] = pictureBox4;

            이름 = new GroupBox[4];
            이름[0] = 이름1;
            이름[1] = 이름2;
            이름[2] = 이름3;
            이름[3] = 이름4;

            공시지원금 = new Label[4];
            공시지원금[0] = 공시지원금1;
            공시지원금[1] = 공시지원금2;
            공시지원금[2] = 공시지원금3;
            공시지원금[3] = 공시지원금4;

            공시변화치 = new Label[4];
            공시변화치[0] = 공시변화치1;
            공시변화치[1] = 공시변화치2;
            공시변화치[2] = 공시변화치3;
            공시변화치[3] = 공시변화치4;

            출고가 = new Label[4];
            출고가[0] = 출고가1;
            출고가[1] = 출고가2;
            출고가[2] = 출고가3;
            출고가[3] = 출고가4;

            출고변화치 = new Label[4];
            출고변화치[0] = 출고변화치1;
            출고변화치[1] = 출고변화치2;
            출고변화치[2] = 출고변화치3;
            출고변화치[3] = 출고변화치4;

            데이터 = new Label[4];
            데이터[0] = 데이터1;
            데이터[1] = 데이터2;
            데이터[2] = 데이터3;
            데이터[3] = 데이터4;

            기준 = new Label[4];
            기준[0] = 기준1;
            기준[1] = 기준2;
            기준[2] = 기준3;
            기준[3] = 기준4;
        }

        public void 페이지계산()
        {
            cnt = ds.Tables["즐겨찾기목록"].Rows.Count;
            if (cnt % 4 > 0) 마지막페이지 = cnt / 4 + 1;
            else 마지막페이지 = cnt / 4;
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

        public void 즐겨찾기목록출력(string 라디오버튼이름, string str, string 단위)
        {
            dr = ds.Tables["즐겨찾기목록"].Select();
            int last;
            if (현재페이지 == 마지막페이지)
            {
                last = cnt % 4;
            }
            else
                last = 4;

            for (int i = 0; i < 4; i++)
            {
                if (i < last || last == 0)
                {
                    /*
                    string str1 = "기종번호='" + dr[((현재페이지 - 1) * 6 + i)]["기종번호"].ToString();
                    str1 += "' and 용량=" + dr[(현재페이지 - 1) * 6 + i]["용량"].ToString();
                    dr2 = ds2.Tables["즐겨찾기"].Select(str1);
                    */

                    이름[i].Visible = true;

                    int 출변 = int.Parse(dr[((현재페이지 - 1) * 4 + i)]["출고가변화치"].ToString());
                    int 공변 = int.Parse(dr[((현재페이지 - 1) * 4 + i)]["공시지원금변화치"].ToString());

                    이름[i].Text = dr[((현재페이지 - 1) * 4 + i)]["기종이름"].ToString();
                    기준[i].Text = 라디오버튼이름;
                    데이터[i].Text = dr[((현재페이지 - 1) * 4 + i)][str].ToString() + 단위;
                    공시지원금[i].Text = dr[((현재페이지 - 1) * 4 + i)]["현재공시지원금"].ToString() + "원";
                    공시변화치[i].Text = dr[((현재페이지 - 1) * 4 + i)]["공시지원금변화치"].ToString() + "원";
                    출고가[i].Text = dr[((현재페이지 - 1) * 4 + i)]["현재출고가"].ToString() + "원";

                    if (공변 > 0)
                        공시변화치[i].ForeColor = Color.FromArgb(230, 30, 30);
                    else if (공변 < 0)
                        공시변화치[i].ForeColor = Color.FromArgb(30, 30, 230);
                    else
                        공시변화치[i].ForeColor = Color.FromArgb(0, 0, 0);

                    if (출변 > 0)
                        출고변화치[i].ForeColor = Color.FromArgb(230, 30, 30);
                    else if(출변 < 0)
                        출고변화치[i].ForeColor = Color.FromArgb(30, 30, 230);
                    else
                        출고변화치[i].ForeColor = Color.FromArgb(0, 0, 0);

                    출고변화치[i].Text = 출변 + "원";
                    공시변화치[i].Text = 공변 + "원";
                    사진[i].ImageLocation = @"핸드폰사진final\" + dr[((현재페이지 - 1) * 4 + i)]["기종사진"].ToString();

                    기종번호[i] = dr[((현재페이지 - 1) * 4 + i)]["기종번호"].ToString();
                    용량[i] = int.Parse(dr[((현재페이지 - 1) * 4 + i)]["용량"].ToString());
                    등록수[i] = int.Parse(dr[((현재페이지 - 1) * 4 + i)]["등록수"].ToString());
                    /*

                    if (dr2.Length > 0)
                    {
                        Color c = Color.FromArgb(210, 210, 210);
                        이름[i].BackColor = c;
                        즐겨찾기배열[i] = true;
                    }
                    else
                    {
                        Color c = Color.FromArgb(240, 240, 240);
                        이름배열[i].BackColor = c;
                        즐겨찾기배열[i] = false;
                    }
                    */
                }
                else
                {
                    이름[i].Visible = false;
                }
            }
        }
    }
}
