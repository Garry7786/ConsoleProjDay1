﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGurwinderDay1
{
    public class Box
    {
        private int l, b, h; // instance variable
        // Constructor is a special function which has same name as of the class name and it is used to initialize an object of the class
        public Box()//:this(1,1,1) // default constructor
        {
            l = 1;
            b = 1;
            h = 1;
        }
        public Box(int len,int b,int h) // paramterized constructor
        {
            // local variable
            l = len;
            this.b = b;
            this.h = h;
        }
        public Box(Box box) // copy constructor
        {
            l = box.l;
            b = box.b;
            h = box.h;
        }
        public int Length //Property Unit Used to access property out side the class - Read and Write , Readonly, Writeonly 
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
            }
        }
        public int Breadth
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public int Height
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }
        public int Area()
        {
            return l * b;
        }
        public int Vol()
        {
            return l * b * h;
        }
        public bool IsEqual(Box box)
        {
            return this.Vol() == box.Vol();

        }
    }
}
//OOP - Technique to learn real life in the world of computer. to solve real life
//object - any person any place any thing 
//paradigms 1. Class - It has theoratical description. It does not physicaly exist in the world. It is just an Idea. 
//2. Object - Anything which has description and can be describe. 
//Relation between class and object - Class gives theoraical description about an object or it tells what type of an object is.
//Object - It is a real life representative of the class.
//3. Encapsulation - It is a process to wrap the information about an object which you want to create into a single unit. After encapsulation the
//encapsulated unit is known as Class. A class contain fowllowing information
//1. Properties - Property decide how an object look like.
//2. Functions- How an object work
//3. Events - What type of action taken by an object to perform a function.
//4. Event Handler - When we Associate of a function with an event then the associated function is known as event handler. 
//Grip is event handler of Hand and Writing is an event handler because when we want to write something we need to Grip Pen untill finish of writing 
//grip event handel by writing . 
//During encapsulation we will also decide which one member of the class should be public or private so to make a member private is known as data hiding.

