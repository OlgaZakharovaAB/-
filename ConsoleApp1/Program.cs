using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string name;
    public string surname;
    public int age;
    private int id;

    

    class Class
    {
        public int grade;
        public string letter;
        private int class_id;
        private List<Student> members = new List<Student>();

        public int Class_Id()
        {
            return class_id;
        }
        public void Class_Id(int class_iid)
        {
            class_id = class_iid;
        }
    }
}