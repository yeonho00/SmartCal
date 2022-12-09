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
    public partial class 요금제메뉴Form : Form
    {
        private 메인Form 메인form;
        private DataSet ds;
        private DataRow[] dr;
        private OracleDataAdapter DBAdapter;
        private int cnt;

        public 요금제메뉴Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;
            ds = new DataSet();
        }

        private void 통신사_SelectedIndexChanged(object sender, EventArgs e)
        {
            요금제종류.Enabled = true;
            요금제종류.Items.Clear();
            요금제탐색();
            
            for (int i = 0; i < cnt; i++)
            {
                if (요금제종류검사(i))
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

            요금제이름탐색();
            for(int i = 0; i < cnt; i++)
            {
                if (요금제이름검사(i))
                {
                    요금제이름.Items.Add(dr[i]["요금제이름"].ToString());
                }
            }
            요금제이름.SelectedIndex = 0;
        }

        private void 요금제이름_SelectedIndexChanged(object sender, EventArgs e)
        {
            메인form.요금제form.요금제정보작성(dr, 요금제이름.SelectedIndex);
        }

        private bool 요금제종류검사(int i)
        {
            for (int j = 0; j < 요금제종류.Items.Count; j++)
            {
                if (!요금제종류.Items.Contains(dr[i]["요금제종류이름"].ToString()))
                    continue;
                else
                    return false;
            }
            return true;
        }

        private void 요금제이름탐색()
        {
            dr = ds.Tables["요금제정보"].Select("요금제종류이름='" + 요금제종류.SelectedItem.ToString() + "'");
            cnt = dr.Length;
        }

        private bool 요금제이름검사(int i)
        {
            for (int j = 0; j < 요금제이름.Items.Count; j++)
            {
                if (dr[i]["요금제이름"].ToString().Equals(요금제이름.Items.IndexOf(j).ToString()))
                    continue;
                else
                    return false;
            }
            return true;
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

        private void 요금제메뉴Form_Load(object sender, EventArgs e)
        {
            통신사.SelectedIndex = 0;
        }

    }
}
