using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime birthDate;
        public DateTime BirthDate 
        { 
            get { return birthDate; }
            set { birthDate = value; }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private bool isMarried;
        public bool IsMarried 
        {
            get { return isMarried; }
            set { isMarried = value; }
        }

        private int noOfChildren;
        public int NoOfChildren
        {
            get { return noOfChildren; }
            set { noOfChildren = value; }
        }

        public Person (string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Height = height;
            this.IsMarried = isMarried;
            this.NoOfChildren = noOfChildren;

        }

       public string MakeTitle() 
        {
           return ($"{Name};{BirthDate.ToString("dd-MM-yyyy HH':'mm':'ss")};{Height};{IsMarried};{NoOfChildren}");
        }


    }
}
