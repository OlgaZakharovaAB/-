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

    public int Id()
    { 
        return id;
    }
    public void Id(int iid)
    {
        id = iid;
    }

    class School
    {
        public string name;
        public int number_of_classes;
        private int school_id;

        public int School_Id()
        {
            return school_id;
        }
        public void School_Id(int school_iid)
        {
            school_id = school_iid;
        }
    }
}