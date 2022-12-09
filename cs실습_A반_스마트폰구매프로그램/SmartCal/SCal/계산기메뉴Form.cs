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
    public partial class 계산기메뉴Form : Form
    {
        private 휴대폰찾기Form 휴대폰찾기form;
        private 메인Form 메인form;
        private DataSet ds;
        private DataRow[] dr;
        private OracleDataAdapter DBAdapter;
        private int cnt;

        public 계산기메뉴Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;
            ds = new DataSet();
        }

        private void 계산기메뉴Form_Load(object sender, EventArgs e)
        {

        }

        private void 제조사_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void 통신사_SelectedIndexChanged(object sender, EventArgs e)
        {
            요금제종류.Enabled = true;
            요금제종류.Items.Clear();
            요금제탐색();

            for (int i = 0; i < cnt; i++)
            {
                if (!요금제종류.Items.Contains(dr[i]["요금제종류이름"].ToString()))
                {
                    요금제종류.Items.Add(dr[i]["요금제종류이름"].ToString());
                }
            }
            요금제종류.SelectedIndex = 0;
        }

        private void 요금제종류_SelectedIndexChanged(object sender, EventArgs e)
        {
            요금제이름탐색();

            요금제이름.Enabled = true;
            요금제이름.Items.Clear();

            for (int i = 0; i < cnt; i++)
            {
                if (!요금제이름.Items.Contains(dr[i]["요금제이름"].ToString()))
                {
                    요금제이름.Items.Add(dr[i]["요금제이름"].ToString());
                }
            }
            요금제이름.SelectedIndex = 0;

        }

        private void 요금제이름_SelectedIndexChanged(object sender, EventArgs e)
        {
            메인form.계산기form.요금제정보작성(dr, 요금제이름.SelectedIndex);
            할인버튼활성화();
            try { 메인form.계산기form.할인정보받기(comboBox1.SelectedItem.ToString()); }
            catch { }
            계산버튼활성화();
            메인form.계산기form.label20.Text = "";
        }

        private void 요금제이름탐색()
        {
            dr = ds.Tables["요금제정보"].Select("요금제종류이름='" + 요금제종류.SelectedItem.ToString() + "'");
            cnt = dr.Length;
        }

        private void 요금제탐색()
        {
            try
            {
                string sql;

                sql = "select c.통신사이름, b.요금제종류이름, a.요금제이름, a.요금제가격, a.데이터, a.음성, a.문자, a.추가혜택 ";
                sql += "from 요금제 a, 요금제종류 b, 통신사 c ";
                sql += "where c.통신사번호=b.통신사번호 and a.요금제종류번호=b.요금제종류번호 ";
                sql += "and c.통신사이름='" + 통신사.SelectedItem.ToString() + "'";
                DBAdapter = new OracleDataAdapter(sql, 메인form.connectionString);

                ds.Clear();
                DBAdapter.Fill(ds, "요금제정보");
                dr = ds.Tables["요금제정보"].Select();
                cnt = dr.Length;
                /*
                메인form.휴대폰_세부form.ds = ds;
                메인form.휴대폰_세부form.페이지계산();
                메인form.휴대폰_세부form.세부출력();

                메인form.휴대폰_심플form.현재페이지 = 1;
                메인form.휴대폰_심플form.ds = ds;
                메인form.휴대폰_심플form.페이지계산();
                메인form.휴대폰_심플form.심플출력(정렬순서, 열이름, 단위);
                */
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            메인form.휴대폰찾기form.휴대폰찾기();
            메인form.휴대폰찾기보기();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            메인form.계산기form.할인정보받기(comboBox1.SelectedItem.ToString());
            계산버튼활성화();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            메인form.계산기form.월납부금액계산();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            메인form.계산기form.할부정보받기(comboBox2.SelectedItem.ToString());
            할인버튼활성화();
            try { 메인form.계산기form.할인정보받기(comboBox1.SelectedItem.ToString()); }
            catch { }
            계산버튼활성화();
            메인form.계산기form.label20.Text = "";
        }

        private void 계산버튼활성화()
        {
            if ((comboBox2.Enabled == true) && (comboBox1.Enabled == true) && (요금제이름.Enabled == true))
                button2.Enabled = true;
        }

        private void 할인버튼활성화()
        {
            if ((comboBox2.Enabled == true) && (요금제이름.Enabled == true))
            {
                comboBox1.Enabled = true;
            }
        }
    }
}
