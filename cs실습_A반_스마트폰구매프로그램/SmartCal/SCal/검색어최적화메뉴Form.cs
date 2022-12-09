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
    public partial class 검색어최적화메뉴Form : Form
    {
        public 메인Form 메인form;
        public 검색어최적화메뉴Form(메인Form form)
        {
            InitializeComponent();
            메인form = form;
        }
    }
}
