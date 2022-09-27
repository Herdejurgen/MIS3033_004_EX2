using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MIS3033_004_EX2
{
    public class Student
    {
        public string ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public static List<Student> stulist = new List<Student>();
        public Student()
        {

        }
        public Student(string ID, string name, int age, double weight)
        {
            this.ID = ID;
            this.name = name;
            this.age = age;
            this.weight = weight;
        }
        public int AgeLevel()
        {
            if (this.age < 20)
            {
                return 1;
            }
            else if(age>=20 && age < 35)
            {
                return 2;
            }
            else if (age >= 35)
            {
                return 3;
            }
            else { return 0; }            
        }
        public override string ToString()
        {
            string s = $"{this.name} ({this.ID}) Age {this.age} (Level {this.AgeLevel()}), Weight: {this.weight} lbs";
            return s;
        }        
    }
}
