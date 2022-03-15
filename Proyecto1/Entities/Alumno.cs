using System;

namespace Proyecto1.Entities
{
    public class Alumno: Persona
    {
        public Alumno()
        {

        }

        public Alumno(string Studentid, string FirstName, string LastName, string Email, DateTime Birthday, string Gender, string Phone)
            :base(FirstName, LastName, Email, Birthday, Gender, Phone)
        {
            this.Studentid = Studentid;
        }
        private string _studentid;
        public string Studentid
        {
            get
            {
                return _studentid;
            }
            set
            {
                _studentid = value;
            }
        }

        public override string TomarAsistencia()
        {
            throw new NotImplementedException();
        }
    }

}