using System.Collections.Generic;
using System.Linq;
using MoMaWeb.Service;

namespace MoMaWeb.ServiceImpl
{
    public class StudentRepostory : IRepostory<Student>
    {
        List<Student> list = new List<Student>(){
                new Student(){
                    id = 1,
                    name = "lidong",
                    age = "3"
                }
            };
        public Student Add(Student s)
        {
            var id = list.Max(x => x.id) + 1;
            s.id = id;
            list.Add(s);
            return s;
        }

        public IEnumerable<Student> GetList()
        {
            return list;
        }
    }
}