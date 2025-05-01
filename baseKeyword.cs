using System;

namespace UseOfBase{
    class Program{
        public static void Main(){
            Teacher t1 = new Teacher(4,"Ravish Kumar",1980);
            t1.Subject="Philosophy";
            t1.Salary = 60000;
            t1.GetInfo();
            Student s1 = new Student(1,"Swikar Devkota",2000,13,21);
            s1.GetStudInfo();

        }
    }

    class Employee{
        protected int id;
        protected String name;
        protected int year = 1980;

        public virtual void GetInfo(){
            Console.WriteLine("Id: "+ id);
            Console.WriteLine("Name: "+ name);
            

        }
    }
    class Teacher : Employee{
        private String subject = "Not a teacher";
        private double salary;
        public Teacher(int id,String name,int year)
        {
            base.id = id;
            base.name = name;
            base.year = year;
        }
        public String Subject{
            set{
                subject=value;
                }
        }
        public double Salary{
            set{
                salary = value;
                }
        }

        public override void GetInfo(){
            base.GetInfo();
            Console.WriteLine("Teaches: "+subject);
            Console.WriteLine("Salary is: "+ salary);
            Console.WriteLine("Year "+ "Mr."+name+ " joined is "+year);

        }
    }
        class Student:Teacher{
            public int clas;
            public int rollNo;
            public Student(int id,String name,int year,int clas,int rollNo):base(id,name,year)
            {
                this.clas = clas;
                this.rollNo = rollNo;
            }
            public void GetStudInfo(){
                base.GetInfo();
                Console.WriteLine("Studies in class:"+clas);
                Console.WriteLine("Roll number is "+rollNo);
            }
        }


    
}