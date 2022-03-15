using System;

namespace Proyecto1.Entities
{
    public class Profesor: Persona
     {
         public Profesor()
        {

        }

        public Profesor(string Employeeid, string FirstName, string LastName, string Email, DateTime BirthDay, string Gender, string Phone)
            :base(FirstName,LastName,Email,BirthDay,Gender,Phone)
        {
            this.Employeeid = Employeeid;
        }
        private string _employeeid;
        public string Employeeid
        {
            get
            {
                return _employeeid;
            }
            set
            {
                _employeeid = value;
            }
        }

        public override string TomarAsistencia()
        {
            throw new NotImplementedException();
        }
    }
}