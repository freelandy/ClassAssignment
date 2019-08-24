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
    public partial class SelectNewStudentForm : Form
    {
        public int NewClassID { set; get; }
        public Repository.Entity.Student OldStudent { set; get; }
        private List<Repository.Entity.Student> recomendedStudents;

        public SelectNewStudentForm()
        {
            InitializeComponent();
        }


        private void BindStudent()
        {
            Repository.ClassAssignment repoClassAssignment = new Repository.ClassAssignment();
            List<Repository.Entity.Student> students = repoClassAssignment.GetClassStudents(this.NewClassID);

            this.dgStudent.DataSource = students;
        }

        private void BindRecommendedStudent()
        {
            Repository.ClassAssignment repoClassAssignment = new Repository.ClassAssignment();
            List<Repository.Entity.Student> students = repoClassAssignment.GetClassStudents(this.NewClassID);

            // 推荐规则
            // 1. 性别相同
            // 2. 总分与对调学生最接近的1个人
            List<Repository.Entity.Student> candidates = students.Where(x => x.xb == this.OldStudent.xb).ToList(); // 取性别相同学生
            float minDiff = Math.Abs(candidates[0].zf - this.OldStudent.zf);
            this.recomendedStudents.Insert(0, candidates[0]);
            for(int i=1;i<candidates.Count;i++)
            {
                if(Math.Abs(candidates[i].zf - this.OldStudent.zf) < minDiff)
                {
                    minDiff = Math.Abs(candidates[i].zf - this.OldStudent.zf);
                    this.recomendedStudents[0] = candidates[i];
                }
            }


            this.dgRecommendedStudent.DataSource = this.recomendedStudents;
        }

        private void SelectNewStudentForm_Load(object sender, EventArgs e)
        {
            // 设置信息
            Repository.Class repoClass = new Class();
            Repository.Entity.Class c = repoClass.GetList("ID=" + this.NewClassID.ToString())[0];

            this.lblNewClass.Text = c.bjmc + "（" + c.bjlb + "）";

            // 绑定全部学生
            this.BindStudent();

            // 绑定推荐学生
            this.BindRecommendedStudent();
        }
    }
}
