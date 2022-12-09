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
    public partial class 로그인Form : Form
    {
        public 로그인Form()
        {
            InitializeComponent();
            connectionString = "User Id=scal; Password=scal; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            //connectionString = "User Id=scal; Password=scal; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            DS = new DataSet();
            conn = new OracleConnection(connectionString);

        }

        OracleDataReader MR;
        OracleCommand comm;
        OracleConnection conn;

        private OracleDataAdapter DBAdapter;
        public DataSet DS;
        public string connectionString;
        public string commandString;
        private 메인Form 메인form;

        private void 로그인버튼_Click(object sender, EventArgs e)
        {
            try
            {
                commandString = "select a.회원번호, b.회원종류이름, a.회원이름, a.회원아이디, a.회원비밀번호 ";
                commandString += "from 회원 a, 회원종류 b ";
                commandString += "where a.회원종류번호=b.회원종류번호 and a.회원아이디='" + 아이디.Text + "' and a.회원비밀번호='" + 비밀번호.Text + "'";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);

                DS.Clear();
                DBAdapter.Fill(DS, "회원");

                if (DS.Tables["회원"].Rows.Count == 1)
                {
                    this.Visible = false;
                    메인보기();
                }
                else
                {
                    MessageBox.Show("존재하지 않는 회원입니다.");
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
                conn.Close();
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
                conn.Close();
            }
        }
        public void 메인보기()
        {
            if (메인form == null || 메인form.IsDisposed)
            {
                메인form = new 메인Form(this);
                메인form.Show();
            }
            메인form.Focus();
        }

        private void 로그인Form_Load(object sender, EventArgs e)
        {
        }
    }
}
