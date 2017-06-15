using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student
{
    //To understand everything here you will need to watch these 2 tutorials and make them yourself.
    // Tutorial 1 : https://www.youtube.com/watch?v=uYXQH2QFmqk
    // Tutorial 2 : https://www.youtube.com/watch?v=iGR425gMKeA


    private string _name;
    private int _age;
    private string _course = "C#";

    public string _city { get; set; }
    public string _Gender { get; set; }
    public string _email { get; set; }
    public string _address { get; set; }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Your name can not be null or empty");
            }
            _name = value;
        }
        get
        {
            // if _name is Null or Empty return "No Name" else _name
            return string.IsNullOrEmpty(_name) ? "No name" : _name;
        }
    }

    public int age
    {
        set
        {
            if (value < 0)
            {
                throw new Exception("Your age can't be a negative number");
            }
            _age = value;
        }
        get
        {
            return _age;
        }

    }
    public string course
    {
        get
        {
            return _course;
        }
    }

 

    public string currentCourse
    {
        get
        {
            return _course;
        }
    }


}



public class _03Properties : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Student C1 = new Student();
        C1.Name = "Nolan";
        C1.age = 22;

        Debug.Log("name = " + C1.Name);
        Debug.Log("age = " + C1.age);
        Debug.Log("Course = " + C1.course);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
