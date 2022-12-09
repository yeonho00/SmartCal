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


//모든 폼들의 부모
namespace SCal
{
    public partial class 메인Form : Form
    {
        private int x, y;
        public string connectionString;
        public string commandString;
        public OracleDataAdapter DBAdapter;
        public OracleDataAdapter BufAdapter;
        public OracleCommandBuilder myCommandBuilder;
        public DataSet DS;
        public DataTable dtable;
        public DataRow[] dRows;

        public 로그인Form 로그인form;
        public 메뉴목록Form 메뉴목록form;

        public 휴대폰메뉴Form 휴대폰메뉴form;
        public 즐겨찾기메뉴Form 즐겨찾기메뉴form;
        public 계산기메뉴Form 계산기메뉴form;
        public 요금제메뉴Form 요금제메뉴form;
        public 검색어최적화메뉴Form 검색어최적화메뉴form;

        public 휴대폰_세부Form 휴대폰_세부form;
        public 휴대폰_심플Form 휴대폰_심플form;
        public 즐겨찾기Form 즐겨찾기form;
        public 계산기Form 계산기form;
        public 요금제Form 요금제form;
        public 휴대폰찾기Form 휴대폰찾기form;
        public 검색어최적화Form 검색어최적화form;

        public 메인Form(로그인Form form)
        {
            InitializeComponent();
            x = 5;
            y = 5;
            connectionString = "User Id=scal; Password=scal; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            //connectionString = "User Id=scal; Password=scal; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            로그인form = form;
            DS = new DataSet();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dRows = 로그인form.DS.Tables["회원"].Select();
            if (dRows[0]["회원종류이름"].ToString() == "일반")
            {
                menuStrip1.Visible = false;
                this.Height = this.Size.Height - 24;
            }

            //휴대폰찾기();
            메뉴목록보기();
        }


        public void 메뉴목록보기()
        {
            if (메뉴목록form == null || 메뉴목록form.IsDisposed)
            {
                메뉴목록form = new 메뉴목록Form(this);
                메뉴목록form.MdiParent = this;
                메뉴목록form.Show();
                메뉴목록form.Location = new Point(x, y);
            }
            메뉴목록form.Focus();
        }

        public void 즐겨찾기메뉴보기()
        {
            if (즐겨찾기메뉴form == null || 즐겨찾기메뉴form.IsDisposed)
            {
                즐겨찾기메뉴form = new 즐겨찾기메뉴Form(this);
                즐겨찾기메뉴form.MdiParent = this;
                즐겨찾기메뉴form.Show();
                즐겨찾기메뉴form.Location = new Point(x, y + 메뉴목록form.Size.Height + y);
            }
            즐겨찾기메뉴form.Focus();
        }
        public void 휴대폰메뉴보기()
        {
            if (휴대폰메뉴form == null || 휴대폰메뉴form.IsDisposed)
            {
                휴대폰메뉴form = new 휴대폰메뉴Form(this);
                휴대폰메뉴form.MdiParent = this;
                휴대폰메뉴form.Show();
                휴대폰메뉴form.Location = new Point(x, y + 메뉴목록form.Size.Height + y);
            }
            휴대폰메뉴form.Focus();
            휴대폰메뉴form.보기모드 = "세부";
        }
        public void 계산기메뉴보기()
        {
            if (계산기메뉴form == null || 계산기메뉴form.IsDisposed)
            {
                계산기메뉴form = new 계산기메뉴Form(this);
                계산기메뉴form.MdiParent = this;
                계산기메뉴form.Show();
                계산기메뉴form.Location = new Point(x, y + 메뉴목록form.Size.Height + y);
            }
            계산기메뉴form.Focus();
        }
        public void 요금제메뉴보기()
        {
            if (요금제메뉴form == null || 요금제메뉴form.IsDisposed)
            {
                요금제메뉴form = new 요금제메뉴Form(this);
                요금제메뉴form.MdiParent = this;
                요금제메뉴form.Show();
                요금제메뉴form.Location = new Point(x, y + 메뉴목록form.Size.Height + y);
            }
            요금제메뉴form.Focus();
        }

        public void 휴대폰세부보기()
        {
            if (휴대폰_세부form == null || 휴대폰_세부form.IsDisposed)
            {
                휴대폰_세부form = new 휴대폰_세부Form(this);
                휴대폰_세부form.MdiParent = this;
                휴대폰_세부form.Show();
                휴대폰_세부form.Location = new Point(x + x + 메뉴목록form.Size.Width, y);
            }
            휴대폰_세부form.Focus();
        }
        public void 휴대폰심플보기()
        {
            if (휴대폰_심플form == null || 휴대폰_심플form.IsDisposed)
            {
                휴대폰_심플form = new 휴대폰_심플Form(this);
                휴대폰_심플form.MdiParent = this;
                휴대폰_심플form.Show();
                휴대폰_심플form.Location = new Point(x + x + 메뉴목록form.Size.Width, y);
            }
            휴대폰_심플form.Focus();
        }
        public void 계산기보기()
        {
            if (계산기form == null || 계산기form.IsDisposed)
            {
                계산기form = new 계산기Form(this);
                계산기form.MdiParent = this;
                계산기form.Show();
                계산기form.Location = new Point(x + x + 메뉴목록form.Size.Width, y);
            }
            계산기form.Focus();
        }
        public void 즐겨찾기보기()
        {
            if (즐겨찾기form == null || 즐겨찾기form.IsDisposed)
            {
                즐겨찾기form = new 즐겨찾기Form(this);
                즐겨찾기form.MdiParent = this;
                즐겨찾기form.Show();
                즐겨찾기form.Location = new Point(x + x + 메뉴목록form.Size.Width, y);
            }
            즐겨찾기form.Focus();
        }
        public void 요금제보기()
        {
            if (요금제form == null || 요금제form.IsDisposed)
            {
                요금제form = new 요금제Form(this);
                요금제form.MdiParent = this;
                요금제form.Show();
                요금제form.Location = new Point(x + x + 메뉴목록form.Size.Width, y);
            }
            요금제form.Focus();
        }
        public void 휴대폰찾기보기()
        {
            if (휴대폰찾기form == null || 휴대폰찾기form.IsDisposed)
            {
                휴대폰찾기form = new 휴대폰찾기Form(this);
                휴대폰찾기form.MdiParent = this;
                휴대폰찾기form.Show();
                휴대폰찾기form.Location = new Point(x + x + 메뉴목록form.Size.Width, y);
            }
            휴대폰찾기form.Focus();

        }
        public void 검색어최적화보기()
        {
            if (검색어최적화form == null || 검색어최적화form.IsDisposed)
            {
                검색어최적화form = new 검색어최적화Form(this);
                검색어최적화form.MdiParent = this;
                검색어최적화form.Show();
                검색어최적화form.Location = new Point(x + x + 메뉴목록form.Size.Width, y);
            }
            검색어최적화form.검색기록찾기();
            검색어최적화form.검색어최적화찾기();
            검색어최적화form.Focus();
        }
        public void 검색어최적화메뉴보기()
        {
            if (검색어최적화메뉴form == null || 검색어최적화메뉴form.IsDisposed)
            {
                검색어최적화메뉴form = new 검색어최적화메뉴Form(this);
                검색어최적화메뉴form.MdiParent = this;
                검색어최적화메뉴form.Show();
                검색어최적화메뉴form.Location = new Point(x, y + 메뉴목록form.Size.Height + y);
            }
            검색어최적화메뉴form.Focus();
            
        }

        public void 검색어최적화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            검색어최적화보기();
            검색어최적화메뉴보기();
        }

        private void 메인Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            로그인form.Visible = true;
        }



    }
}
