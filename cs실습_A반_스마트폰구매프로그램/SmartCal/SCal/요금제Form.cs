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
    public partial class 요금제Form : Form
    {
        private 메인Form 메인form;

        public 요금제Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;
        }

        public void 요금제정보작성(DataRow[] dr, int i)
        {
            요금제종류.Text = dr[i]["요금제종류이름"].ToString();
            이름.Text = dr[i]["요금제이름"].ToString();
            데이터.Text = dr[i]["데이터"].ToString();
            음성.Text = dr[i]["음성"].ToString();
            문자.Text = dr[i]["문자"].ToString();
            추가혜택.Text = dr[i]["추가혜택"].ToString();
            가격.Text = dr[i]["요금제가격"].ToString() + "원";
        }
    }
}
