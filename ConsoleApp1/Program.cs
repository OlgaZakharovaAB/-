﻿using System;
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


}