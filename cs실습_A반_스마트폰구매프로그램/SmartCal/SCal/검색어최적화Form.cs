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
    public partial class 검색어최적화Form : Form
    {
        메인Form 메인form;
        private OracleDataAdapter DBAdapter, DBAdapter2;
        private DataSet ds, ds2;
        private DataRow dr, dr2;
        private string commandString;
        private DataTable 검색기록Table, 검색어최적화Table;
        private OracleConnection odpConn = new OracleConnection();

        private string 수정전buff;

        public 검색어최적화Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;

            ds = new DataSet();
            ds2 = new DataSet();
        }
        public void 검색기록찾기()
        {
            try
            {
                commandString = "select * from 검색기록";
                DBAdapter = new OracleDataAdapter(commandString, 메인form.connectionString);

                ds.Clear();
                DBAdapter.Fill(ds, "검색기록");
                dataGridView1.DataSource = ds.Tables["검색기록"].DefaultView;
            }
            catch (DataException DE) { MessageBox.Show(DE.Message); }
            catch (Exception DE) { MessageBox.Show(DE.Message); }
        }
        public void 검색어최적화찾기()
        {
            try
            {
                commandString = "select * from 검색어최적화";
                DBAdapter2 = new OracleDataAdapter(commandString, 메인form.connectionString);

                ds2.Clear();
                DBAdapter2.Fill(ds2, "검색어최적화");
                dataGridView2.DataSource = ds2.Tables["검색어최적화"].DefaultView;
            }
            catch (DataException DE) { MessageBox.Show(DE.Message); }
            catch (Exception DE) { MessageBox.Show(DE.Message); }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "검색기록");
                검색기록Table = DS.Tables["검색기록"];
                if (e.RowIndex < 0)
                {
                    // DBGrid 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메세지도 띄우지 않습니다.
                    return;
                }
                else if (e.RowIndex > 검색기록Table.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                dr = 검색기록Table.Rows[e.RowIndex];

                textBox1.Text = dr["검색단어"].ToString();
            }
            catch (DataException DE) { MessageBox.Show(DE.Message); }
            catch (Exception DE) { MessageBox.Show(DE.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(공백확인()) return;

                odpConn.ConnectionString = 메인form.connectionString;
                odpConn.Open();

                string sql = "insert into 검색어최적화 values(:수정전검색어, :수정후검색어)";
                OracleCommand OraCmd = new OracleCommand(sql, odpConn);

                OraCmd.Parameters.Add("수정전검색어", OracleDbType.Varchar2, 40).Value = textBox1.Text;
                OraCmd.Parameters.Add("수정후검색어", OracleDbType.Varchar2, 40).Value = textBox2.Text;
                OraCmd.ExecuteNonQuery();
                odpConn.Close();

                검색기록찾기();
                검색어최적화찾기();

                MessageBox.Show("최적화될 검색어가 추가되었습니다.", "최적화", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DataException DE) { }
            catch (Exception DE) { MessageBox.Show("이미 등록된 검색어입니다.", "최적화", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool 공백확인()
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("수정 후 검색어를 입력하지 않았습니다.", "최적화 추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return true;
            }
            else if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("수정 전 검색어를 입력하지 않았습니다.", "최적화 추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return true;
            }
            return false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DBAdapter2.Fill(DS, "검색어최적화");
                검색어최적화Table = DS.Tables["검색어최적화"];
                if (e.RowIndex < 0)
                {
                    // DBGrid 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메세지도 띄우지 않습니다.
                    return;
                }
                else if (e.RowIndex > 검색어최적화Table.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                dr2 = 검색어최적화Table.Rows[e.RowIndex];

                수정전buff = dr2["수정전검색어"].ToString();
            }
            catch (DataException DE) { MessageBox.Show(DE.Message); }
            catch (Exception DE) { MessageBox.Show(DE.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                odpConn.ConnectionString = 메인form.connectionString;
                odpConn.Open();

                string sql = "delete from 검색어최적화 where 수정전검색어=:수정전검색어";
                OracleCommand OraCmd = new OracleCommand(sql, odpConn);

                OraCmd.Parameters.Add("수정전검색어", OracleDbType.Varchar2, 40).Value = 수정전buff;
                OraCmd.ExecuteNonQuery();
                odpConn.Close();

                검색어최적화찾기();

                MessageBox.Show("검색어의 최적화가 해제되었습니다.", "최적화", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DataException DE) { MessageBox.Show(DE.Message); }
            catch (Exception DE) { MessageBox.Show(DE.Message); }
        }
    }
}
