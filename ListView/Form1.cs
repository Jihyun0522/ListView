using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        string strName;
        string strAge;
        string strWork; // 나이, 이름, 직업 저장

        public Form1()
        {
            InitializeComponent();
        }

        private bool TextCheck()
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("이름을 넣어주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            if (this.txtAge.Text == "")
            {
                MessageBox.Show("나이를 넣어주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAge.Focus();
                return false;
            }
            if (this.txtWork.Text == "")
            {
                MessageBox.Show("직업을 넣어주세요", "알림",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWork.Focus();
                return false;
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                strName = this.txtName.Text;
                strAge = this.txtAge.Text;
                strWork = this.txtWork.Text;
                ListViewItem lvi = new ListViewItem(new string[] { strName, strAge, strWork } ); //리스트뷰에 들어갈 항목 생성
                this.lvView.Items.Add(lvi);
                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.txtWork.Text = "";
                this.txtName.Focus();
            }
        }

        private void LvView_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = this.lvView.SelectedItems[0];
            string name = lvi.SubItems[0].Text;
            string age = lvi.SubItems[1].Text;
            string work = lvi.SubItems[2].Text;

            MessageBox.Show("이름 : " + name + "\n나이 : " + age + "\n직업 : " + work, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

}
