using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class Pupil
    {
        private string FirstName;
        private string LastName;
        private int Id;

        public Pupil(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public static void AddPupil(Pupil pupil, List<Pupil> pupilList)
        {
            pupilList.Add(pupil);
        }

      
        
    }
}
