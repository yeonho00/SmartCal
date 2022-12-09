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
    public partial class 휴대폰찾기Form : Form
    {
        메인Form 메인form;
        private OracleDataAdapter DBAdapter;
        private DataSet ds;
        private DataRow dr;
        private string commandString;
        private DataTable 기종제조사용량Table;
        private int SelectedRowIndex;

        public 휴대폰찾기Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;
            ds = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            메인form.계산기form.휴대폰정보받기(dr);
            메인form.계산기보기();
            메인form.계산기메뉴form.comboBox2.Enabled = true;
            메인form.계산기메뉴form.comboBox2.SelectedIndex = 0;
        }

        public void 휴대폰찾기()
        {
            try
            {
                commandString = "select b.제조사이름, a.기종이름, c.용량, a.배터리용량, c.등록수, a.기종사진, a.디스플레이종류, a.해상도, a.크기, a.무게, a.두께, a.CPU, a.RAM, c.현재공시지원금, c.현재출고가, a.기종사진 ";
                commandString += "from 기종 a, 제조사 b, 내장메모리 c ";
                commandString += "where a.제조사번호=b.제조사번호 and a.기종번호=c.기종번호";
                DBAdapter = new OracleDataAdapter(commandString, 메인form.connectionString);

                ds.Clear();
                //DS.Tables["기종제조사용량"].Clear();
                DBAdapter.Fill(ds, "기종제조사용량");
                DBGrid.DataSource = ds.Tables["기종제조사용량"].DefaultView;
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

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "기종제조사용량");
                기종제조사용량Table = DS.Tables["기종제조사용량"];
                if (e.RowIndex < 0)
                {
                    // DBGrid 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메세지도 띄우지 않습니다.
                    return;
                }
                else if (e.RowIndex > 기종제조사용량Table.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                dr = 기종제조사용량Table.Rows[e.RowIndex];

                제조사1.Text = dr["제조사이름"].ToString();
                CPU1.Text = dr["CPU"].ToString();
                RAM1.Text = dr["RAM"].ToString() + "GB";
                배터리1.Text = dr["배터리용량"].ToString() + "mAh";
                내장메모리1.Text = dr["용량"].ToString() + "GB";
                두께1.Text = dr["두께"].ToString() + "mm";
                무게1.Text = dr["무게"].ToString() + "g";
                크기1.Text = dr["크기"].ToString() + "인치";
                해상도1.Text = dr["해상도"].ToString();
                공시지원금1.Text = dr["현재공시지원금"].ToString() + "원";
                출고가1.Text = dr["현재출고가"].ToString() + "원";

                button1.Enabled = true;
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }
    }
}
