using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace ClassAssignment
{
    public partial class AssignForm : Form
    {
        public string ClassType { set; get; }

        Repository.ClassAssignment repoClassAssignment = new Repository.ClassAssignment();
        Repository.Class repoClass = new Class();
        Repository.Student repoStudent = new Student();

        List<Repository.Entity.Class> cls = new List<Repository.Entity.Class>();
        List<Repository.Entity.Student> allStu = new List<Repository.Entity.Student>();
        List<Repository.Entity.Student> stu = new List<Repository.Entity.Student>();

        int method = 1;

        public AssignForm()
        {
            InitializeComponent();
        }

        private void AssignForm_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            SetTag(this);


            this.cls = repoClass.GetList("bjlb='" + this.ClassType + "'");
            this.allStu = repoStudent.GetList("");
            this.allStu.Sort((x, y) => -x.zf.CompareTo(y.zf));

            // 填充信息
            this.lblBjlb.Text = this.ClassType;
            this.lblBjsl.Text = this.cls.Count.ToString();

            int totalStudent = 0;
            int startIdx = 0;
            int endIdx = 0;
            switch (this.ClassType)
            {
                case "民族创新班":
                    stu = allStu.Where(x => x.sfwk != "文科").ToList();
                    totalStudent = 20; // 理科总分前20名
                    startIdx = 0;
                    endIdx = startIdx + totalStudent - 1;
                    stu = stu.Skip(startIdx).ToList().Take(totalStudent).ToList();
                    break;
                case "新疆实验班":
                    stu = allStu.Where(x => x.sfwk != "文科").ToList();
                    startIdx = 20;
                    totalStudent = 2 * (stu.Count - 20) / 5; // 理科去除前20名的2/5
                    endIdx = startIdx + totalStudent - 1;
                    stu = stu.Skip(startIdx).ToList().Take(totalStudent).ToList();
                    break;
                case "新疆普通班":
                    stu = allStu.Where(x => x.sfwk != "文科").ToList();
                    startIdx = 20 + 2 * (stu.Count - 20) / 5; // 理科剩下的人
                    endIdx = stu.Count - 1;
                    totalStudent = endIdx - startIdx + 1;
                    stu = stu.Skip(startIdx).ToList().Take(totalStudent).ToList();
                    break;
                case "文科班":
                    stu = allStu.Where(x => x.sfwk == "文科").ToList();
                    totalStudent = stu.Count;
                    startIdx = 0;
                    endIdx = startIdx + totalStudent - 1;
                    stu = stu.Skip(startIdx).ToList().Take(totalStudent).ToList();
                    break;

            }

            

            this.lblXszs.Text = totalStudent.ToString();
            this.lblQsxs.Text = "姓名: " + allStu[startIdx].xm.ToString() + "     总分: " + allStu[startIdx].zf.ToString();
            this.lblJsxs.Text = "姓名: " + allStu[endIdx].xm.ToString() + "     总分: " + allStu[endIdx].zf.ToString();

        }

        #region resize form controls
        private float X;
        private float Y;
        private void SetTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    SetTag(con);
                }
            }
        }
        private void SetControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);
                }
            }

        }

        void MainForm_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            SetControls(newx, newy, this);
            this.Text = this.Width.ToString() + " " + this.Height.ToString();
        }
        #endregion

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("自动分班需要几分钟，请确认已清空原有分班信息。\n是否继续？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            // 开始分班
            repoClassAssignment.AutoAssign(this.stu, this.cls, this.method);

            MessageBox.Show("完成！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RbtnEqual_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtnEqual.Checked)
            {
                this.method = 0;
            }
        }

        private void RbtnSnake_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtnSnake.Checked)
            {
                this.method = 1;
            }
        }

        private void RbtnRandom_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtnRandom.Checked)
            {
                this.method = 2;
            }
        }

        private void lnkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
