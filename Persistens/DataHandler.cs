using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName
        { 
            get { return dataFileName; }
        }
        public DataHandler(string dataFileName)
        { 
            this.dataFileName = dataFileName;
        }
        public void SavePerson(Person person)
        {
            StreamWriter writer = new StreamWriter(dataFileName);
            writer.WriteLine(person.MakeTitle());
            writer.Close();
          
        }
        public Person LoadPerson()
        {
            string[] line;
            StreamReader sr = new StreamReader("Data.txt");

            line = sr.ReadLine().Split(';');
            Person loadedperson = new(line[0], DateTime.Parse(line[1]), double.Parse(line[2]), bool.Parse(line[3]), int.Parse(line[4]));
      

            sr.Close();

            return loadedperson;
        }

    }
}
