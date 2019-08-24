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
    public partial class ManualForm : Form
    {
        public Repository.Entity.Student NewStudent{set;get;}

        public Repository.Entity.Student OldStudent { set; get; }
        public Repository.Entity.Class OldClass { set; get; }

        public ManualForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindClass()
        {
            Repository.Class repoClass = new Class();
            List<Repository.Entity.Class> cls = repoClass.GetList("");

            this.cbDrbj.Items.Clear();
            this.cbDrbj.DisplayMember = "bjmc";
            this.cbDrbj.ValueMember = "id";
            foreach(Repository.Entity.Class c in cls)
            {
                if (c.ID != this.OldClass.ID)
                {
                    this.cbDrbj.Items.Add(c);
                }
            }
        }

        private void ManualForm_Load(object sender, EventArgs e)
        {
            // 设置信息
            this.lblBj.Text = this.OldClass.bjmc + "（" + this.OldClass.bjlb + "）";
            this.lblXb.Text = this.OldStudent.xb;
            this.lblZf.Text = this.OldStudent.zf.ToString();
            this.lblXm.Text = this.OldStudent.xm;

            // 绑定班级列表
            this.BindClass();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectNewStudentForm selectNewStudentForm = new SelectNewStudentForm();
            selectNewStudentForm.Owner = this;

            selectNewStudentForm.NewClassID = int.Parse(this.cbDrbj.SelectedItem.ToString());
            selectNewStudentForm.OldStudent = this.OldStudent;

            selectNewStudentForm.ShowDialog();
        }
    }
}
