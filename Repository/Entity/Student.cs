using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Student
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { set; get; }

        /// <summary>
        /// 中考考生号
        /// </summary>
        public string zkksh { set; get; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string xm { set; get; }

        /// <summary>
        /// 考生类别
        /// </summary>
        public string kslb{ set; get; }

        /// <summary>
        /// 性别
        /// </summary>
        public string xb { set; get; }

        /// <summary>
        /// 民族
        /// </summary>
        public string mz { set; get; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime csrq { set; get; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public string zzmm { set; get; }

        /// <summary>
        /// 考生特长
        /// </summary>
        public string kstz { set; get; }

        /// <summary>
        /// 初中毕业学校
        /// </summary>
        public string czbyxx { set; get; }

        /// <summary>
        /// 通讯地址
        /// </summary>
        public string txdz { set; get; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string lxdh { set; get; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string yzbm { set; get; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string sfzh { set; get; }

        /// <summary>
        /// 户口性质
        /// </summary>
        public string hkxz { set; get; }

        /// <summary>
        /// 家庭出身
        /// </summary>
        public string jtcs { set; get; }

        /// <summary>
        /// 地区
        /// </summary>
        public string dq { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string xq { set; get; }

        /// <summary>
        /// 考试语种
        /// </summary>
        public string ksyz { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string ksztdm { set; get; }

        /// <summary>
        /// 高中录取学校代码
        /// </summary>
        public string gzlqxxdm { set; get; }

        /// <summary>
        /// 高中录取学校
        /// </summary>
        public string gzlqxx { set; get; }

        /// <summary>
        /// 高中录取时间
        /// </summary>
        public DateTime gzlqsj { set; get; }

        /// <summary>
        /// 政治
        /// </summary>
        public float zz { set; get; }

        /// <summary>
        /// 语文
        /// </summary>
        public float yw { set; get; }

        /// <summary>
        /// 数学
        /// </summary>
        public float sx { set; get; }

        /// <summary>
        /// 物理
        /// </summary>
        public float wl { set; get; }

        /// <summary>
        /// 化学
        /// </summary>
        public float hx { set; get; }

        /// <summary>
        /// 外语
        /// </summary>
        public float wy { set; get; }

        /// <summary>
        /// 特长分
        /// </summary>
        public float tzf { set; get; }

        /// <summary>
        /// 总分
        /// </summary>
        public float zf { set; get; }

        /// <summary>
        /// 父亲姓名
        /// </summary>
        public string fqxm { set; get; }

        /// <summary>
        /// 母亲姓名
        /// </summary>
        public string mqxm { set; get; }

        /// <summary>
        /// 学籍号
        /// </summary>
        public string xjh { set; get; }

        /// <summary>
        /// 报道日期
        /// </summary>
        public DateTime bdrq { set; get; }

        /// <summary>
        /// 报道地点
        /// </summary>
        public string bddd { set; get; }

        /// <summary>
        /// 文科/理科
        /// </summary>
        public string sfwk { set; get; }

        /// <summary>
        /// 未报到/已报到
        /// </summary>
        public string sfbd { set; get; }
    }
}
