using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace Repository
{
    public class Student
    {
        protected static readonly IDbConnection db = new SQLiteConnection("Data Source=db.db; Integrated Security=True");

        public List<Entity.Student> GetList(string where)
        {
            string sql = "select * from [student]";

            if (where.Trim() != string.Empty)
            {
                sql += " where " + where;
            }

            List<Entity.Student> students = db.Query<Entity.Student>(sql).ToList<Entity.Student>();

            return students;
        }

        public int Add(Entity.Student s)
        {
            string sql = "insert into [student](zkksh,xm,kslb,xb,mz,csrq,zzmm,kstz,czbyxx,txdz,lxdh,yzbm,sfzh,hkxz,jtcs,dq,xq,ksyz,ksztdm,gzlqxxdm,gzlqxx,gzlqsj,zz,yw,sx,wl,hx,wy,tzf,zf,fqxm,mqxm,xjh,bdrq,bddd) ";
            sql += "values (@zkksh,@xm,@kslb,@xb,@mz,@csrq,@zzmm,@kstz,@czbyxx,@txdz,@lxdh,@yzbm,@sfzh,@hkxz,@jtcs,@dq,@xq,@ksyz,@ksztdm,@gzlqxxdm,@gzlqxx,@gzlqsj,@zz,@yw,@sx,@wl,@hx,@wy,@tzf,@zf,@fqxm,@mqxm,@xjh,@bdrq,@bddd)";

            int ret = db.Execute(sql, s);

            return ret;
        }

        public void Clear()
        {
            if(db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            using (var transaction = db.BeginTransaction())
            {
                db.Execute("delete from [Student];", transaction);
                db.Execute("update sqlite_sequence set seq=0 where name='Student';", transaction);
                db.Execute("delete from [classassignment]");
                transaction.Commit();
            }
        }

        public int SetLiberalArts(int id, bool flag)
        {
            // flag true: liberal arts
            string con = flag ? "文科" : "理科";
            string sql = "update [student] set sfwk='" + con + "' where ID=" + id.ToString();
            int ret = db.Execute(sql);

            return ret;
        }


        public int SetNoRegister(int id, bool flag)
        {
            // flag true: do not register
            string con = flag ? "未报道" : "已报道";
            string sql = "update [student] set sfbd='" + con + "' where ID=" + id.ToString();
            int ret = db.Execute(sql);

            return ret;
        }
    }
}
