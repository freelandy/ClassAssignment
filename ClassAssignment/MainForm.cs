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
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            SetTag(this);
            //MainForm_Resize(new object(), new EventArgs());//x,y可在实例化时赋值,最后这句是新加的，在MDI时有用

            // 读取班级信息
            this.BindClass();

            // 读取原有学生信息
            this.BindStudent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel工作簿(*.xls,*.xlsx)|*.xls;*.xlsx";
            dlg.Multiselect = false;
            dlg.InitialDirectory = Environment.CurrentDirectory;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                this.txtFileName.Text = dlg.FileName;
            }


        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("导入数据需要几分钟时间，原有数据将被清空。\n是否确认？","提示信息",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }

            // 读取excel，插入数据库，然后再说别的
            Repository.Student repoStudent = new Student();

            // 清空原有记录
            repoStudent.Clear();

            int cnt = 0;
            DataTable dt = ExcelHelper.ExcelToDataTableFormPath(this.txtFileName.Text, true, 0); //学生数据须为第一张sheet
            foreach(DataRow dr in dt.Rows)
            {
                Repository.Entity.Student s = new Repository.Entity.Student();
                s.bddd = dr["bddd"] == null ? "" : dr["bddd"].ToString();
                s.bdrq = dr["bdrq"] == null ? DateTime.Today : DateTime.Parse(dr["bdrq"].ToString());
                s.csrq = dr["csrq"] == null ? DateTime.Today : DateTime.Parse(dr["csrq"].ToString());
                s.czbyxx = dr["czbyxx"] == null ? "" : dr["czbyxx"].ToString();
                s.dq = dr["dq"] == null ? "" : dr["dq"].ToString();
                s.fqxm = dr["fqxm"] == null ? "" : dr["fqxm"].ToString();
                s.gzlqsj = dr["gzlqsj"] == null ? DateTime.Today : DateTime.Parse(dr["gzlqsj"].ToString());
                s.gzlqxxdm = dr["gzlqxxdm"] == null ? "" : dr["gzlqxxdm"].ToString();
                s.gzlqxx = dr["gzlqxx"] == null ? "" : dr["gzlqxx"].ToString();
                s.hkxz = dr["hkxz"] == null ? "" : dr["hkxz"].ToString();
                s.hx = dr["hx"] == null ? 0 : float.Parse(dr["hx"].ToString());
                s.jtcs = dr["jtcs"] == null ? "" : dr["jtcs"].ToString();
                s.kslb = dr["kslb"] == null ? "" : dr["kslb"].ToString();
                s.kstz = dr["kstz"] == null ? "" : dr["kstz"].ToString();
                s.ksyz = dr["ksyz"] == null ? "" : dr["ksyz"].ToString();
                s.ksztdm = dr["ksztdm"] == null ? "" : dr["ksztdm"].ToString();
                s.lxdh = dr["lxdh"] == null ? "" : dr["lxdh"].ToString();
                s.mqxm = dr["mqxm"] == null ? "" : dr["mqxm"].ToString();
                s.mz = dr["mz"] == null ? "" : dr["mz"].ToString();
                //s.sfbd = dr["sfbd"] == null ? "" : dr["sfbd"].ToString();
                //s.sfwk = dr["sfwk"] == null ? "" : dr["sfwk"].ToString();
                s.sfzh = dr["sfzh"] == null ? "" : dr["sfzh"].ToString();
                s.sx = dr["sx"] == null ? 0 : float.Parse(dr["sx"].ToString());
                s.txdz = dr["txdz"] == null ? "" : dr["txdz"].ToString();
                s.tzf = dr["tzf"] == null ? 0 : float.Parse(dr["tzf"].ToString());
                s.wl = dr["wl"] == null ? 0 : float.Parse(dr["wl"].ToString());
                s.wy = dr["wy"] == null ? 0 : float.Parse(dr["wy"].ToString());
                s.xb = dr["xb"] == null ? "" : dr["xb"].ToString();
                s.xjh = dr["xjh"] == null ? "" : dr["xjh"].ToString();
                s.xm = dr["xm"] == null ? "" : dr["xm"].ToString();
                s.xq = dr["xq"] == null ? "" : dr["xq"].ToString();
                s.yw = dr["yw"] == null ? 0 : float.Parse(dr["yw"].ToString());
                s.yzbm = dr["yzbm"] == null ? "" : dr["yzbm"].ToString();
                s.zf = dr["zf"] == null ? 0 : float.Parse(dr["zf"].ToString());
                s.zkksh = dr["zkksh"] == null ? "" : dr["zkksh"].ToString();
                s.zz = dr["zz"] == null ? 0 : float.Parse(dr["zz"].ToString());
                s.zzmm = dr["zzmm"] == null ? "" : dr["zzmm"].ToString();

                try
                {
                    repoStudent.Add(s);
                    cnt++;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("数据导入错误。\n第" + (cnt + 1).ToString() + "行。\n" + ex.Message + "\n请查看出错数据并尝试重新导入。");
                    return;
                }
            }

            MessageBox.Show("导入完成。共导入" + cnt + "条记录。");

            this.BindStudent();
            this.lblTotalStudents.Text = ((List<Repository.Entity.Student>)this.dgStudent.DataSource).Count.ToString();
        }

        private void DgStudent_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.dgStudent.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.dgStudent.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.dgStudent.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void ChkNoClass_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chkNoClass.Checked)
            {
                Repository.ClassAssignment repoClassAssignment = new Repository.ClassAssignment();
                List<Repository.Entity.Student> cs = repoClassAssignment.GetNoClassStudents("");
                this.dgStudent.DataSource = cs;
            }
            else
            {
                this.BindStudent();
            }
        }


        private void BindClassStudent(int cid)
        {
            this.dgClassStudent.AutoGenerateColumns = false;

            Repository.ClassAssignment repoClassAssignment = new Repository.ClassAssignment();
            List<Repository.Entity.Student> cs = repoClassAssignment.GetClassStudents(cid);
            this.dgClassStudent.DataSource = cs;

            this.lblTotal.Text = cs.Count.ToString();
            this.lblBoys.Text = cs.Where(x => x.xb == "男").ToList<Repository.Entity.Student>().Count.ToString();
            this.lblGirls.Text = cs.Where(x => x.xb == "女").ToList<Repository.Entity.Student>().Count.ToString();
            this.lblAverage.Text = cs.Count>0?cs.Average(x => x.zf).ToString():"0";

        }

        private void BindClass()
        {
            this.dgClass.AutoGenerateColumns = false;

            Class repoClass = new Class();
            List<Repository.Entity.Class> classes = repoClass.GetList("");
            this.dgClass.DataSource = classes;
            
            
        }

        private void BindStudent()
        {
            this.dgStudent.AutoGenerateColumns = false;

            Repository.Student repoStudent = new Student();
            List<Repository.Entity.Student> students = repoStudent.GetList("");

            this.dgStudent.DataSource = students;

            this.lblTotalStudents.Text = students.Count.ToString();


        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            Repository.Entity.Class cls = new Repository.Entity.Class();
            cls.bjmc = this.txtBjmc.Text;
            cls.bjlb = this.cbBjlb.Text;
            cls.bzrxm = this.txtBzrxm.Text;

            Repository.Class repoClass = new Class();
            repoClass.Add(cls);

            this.ClearFields();
            this.BindClass();
        }

        private void BtnDeleteClass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除选中的班级？删除班级后，该班级的分班信息也将被删除。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            // get selected id
            int id = 0;
            int.TryParse(this.dgClass.SelectedRows[0].Cells[0].Value.ToString(), out id);

            Repository.Class repoClass = new Class();
            repoClass.Delete(id);

            this.ClearFields();
            this.BindClass();
        }


        private void ClearFields()
        {
            this.txtBjmc.Text = "";
            this.txtBzrxm.Text = "";
            this.cbBjlb.Text = "";
        }

        private void DgClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // 将信息填入文本框中
                this.txtBjmc.Text = this.dgClass.Rows[e.RowIndex].Cells["bjmc"].Value.ToString();
                this.cbBjlb.Text = this.dgClass.Rows[e.RowIndex].Cells["bjlb"].Value.ToString();
                this.txtBzrxm.Text = this.dgClass.Rows[e.RowIndex].Cells["bzrxm"].Value.ToString();

                // 更新班级学生信息
                int cID = 0;
                int.TryParse(this.dgClass.Rows[e.RowIndex].Cells["class_id"].Value.ToString(), out cID);
                this.BindClassStudent(cID);

            }
        }

        private void BtnEditClass_Click(object sender, EventArgs e)
        {
            // get selected id
            int id = 0;
            if (this.dgClass.SelectedRows.Count > 0)
            {
                int.TryParse(this.dgClass.SelectedRows[0].Cells[0].Value.ToString(), out id);
            }

            Repository.Entity.Class cls = new Repository.Entity.Class();
            cls.ID = id;
            cls.bjmc = this.txtBjmc.Text;
            cls.bjlb = this.cbBjlb.Text;
            cls.bzrxm = this.txtBzrxm.Text;

            Repository.Class repoClass = new Class();
            repoClass.Update(cls);

            this.BindClass();
        }

        private void BtnSetLiberalArts_Click(object sender, EventArgs e)
        {
            Repository.Student repoStudent = new Student();

            // get selected student id
            int id = 0;
            if (this.dgStudent.SelectedRows.Count > 0)
            {
                int.TryParse(this.dgStudent.SelectedRows[0].Cells["id"].Value.ToString(), out id);
            }

            repoStudent.SetLiberalArts(id, true);

            this.BindStudent();
        }

        private void DgStudent_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string sfwk = this.dgStudent.Rows[e.RowIndex].Cells["sfwk"].Value == null?"":this.dgStudent.Rows[e.RowIndex].Cells["sfwk"].Value.ToString().Trim();
                if (sfwk == "文科")
                {
                    this.dgStudent.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }

        private void BtnSetScience_Click(object sender, EventArgs e)
        {
            Repository.Student repoStudent = new Student();

            // get selected student id
            int id = 0;
            if (this.dgStudent.SelectedRows.Count > 0)
            {
                int.TryParse(this.dgStudent.SelectedRows[0].Cells["id"].Value.ToString(), out id);
            }

            repoStudent.SetLiberalArts(id, false);

            this.BindStudent();
        }

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            if(this.cbXZBjlb.SelectedItem == null)
            {
                MessageBox.Show("请选择自动分班类别。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AssignForm assignForm = new AssignForm();
            assignForm.ClassType = this.cbXZBjlb.SelectedItem.ToString();
            assignForm.ShowDialog();
        }

        private void DgClassStudent_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
            //    e.RowBounds.Location.Y,
            //    this.dgClassStudent.RowHeadersWidth - 4,
            //    e.RowBounds.Height);
            //TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
            //    this.dgClassStudent.RowHeadersDefaultCellStyle.Font,
            //    rectangle,
            //    this.dgClassStudent.RowHeadersDefaultCellStyle.ForeColor,
            //    TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            this.dgClassStudent.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确认清空所有分班信息？","提示信息",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                // 清空原有分班信息
                Repository.ClassAssignment repoClassAssignment = new Repository.ClassAssignment();
                repoClassAssignment.Clear();
            }
        }

        private void ChkLiberalArts_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chkLiberalArts.Checked)
            {
                List<Repository.Entity.Student> students = (List<Repository.Entity.Student>)this.dgStudent.DataSource;

                if(students != null)
                {
                    List<Repository.Entity.Student> liberalStudents = students.Where(x => x.sfwk == "文科").ToList();
                    this.dgStudent.DataSource = liberalStudents;
                } 
            }
            else
            {
                this.BindStudent();
            }
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            ManualForm manualForm = new ManualForm();

            // 获得调出学生和班级
            int id = 0;
            int.TryParse(this.dgClassStudent.SelectedRows[0].Cells["s_id"].Value.ToString(), out id);
            Repository.Student repoStudent = new Student();
            Repository.Entity.Student s = repoStudent.GetList("ID=" + id)[0];

            manualForm.OldStudent = s;

            int.TryParse(this.dgClass.SelectedRows[0].Cells[0].Value.ToString(), out id);
            Repository.Class repoClass = new Class();
            Repository.Entity.Class c = repoClass.GetList("ID=" + id)[0];

            manualForm.OldClass = c;

            manualForm.ShowDialog();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.dgClassStudent.DataSource == null)
            {
                MessageBox.Show("请选择一个班级。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // 导出当前班级
            DataTable dt = new DataTable();
            dt.Columns.Add("编号");
            dt.Columns.Add("姓名");
            dt.Columns.Add("性别");
            dt.Columns.Add("民族");
            dt.Columns.Add("总分");

            List<Repository.Entity.Student> students = (List<Repository.Entity.Student>)this.dgClassStudent.DataSource;
            for(int i=0;i<students.Count;i++)
            {
                DataRow dr = dt.NewRow();
                dr["编号"] = i + 1;
                dr["姓名"] = students[i].xm;
                dr["性别"] = students[i].xb;
                dr["民族"] = students[i].mz;
                dr["总分"] = students[i].zf;

                dt.Rows.Add(dr);
            }

            // 保存文件名
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.DefaultExt = "xls";
            dlg.FileName = this.dgClass.SelectedRows[0].Cells["bjmc"].Value.ToString();

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                byte[] fileStream = ExcelHelper.GetDataTableToByte(dt, true);

                System.IO.FileStream fs = new System.IO.FileStream(dlg.FileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                try
                {
                    fs.Write(fileStream, 0, fileStream.Length);
                    MessageBox.Show("导出完成！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出出错。出错信息为：\n" + ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string where = "";
            if(this.txtSearchBkksh.Text.Trim() != "")
            {
                where += "zkksh='" + this.txtSearchBkksh.Text.Trim().ToUpper() + "' ";
            }
            else if(this.txtSearchXm.Text.Trim() != "")
            {
                where += "xm like '%" + this.txtSearchXm.Text.Trim() + "%'";
            }

            Repository.Student repoStudent = new Student();
            List<Repository.Entity.Student> students = repoStudent.GetList(where);

            this.dgStudent.DataSource = students;
        }
    }
}
