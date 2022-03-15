using System;
namespace Proyecto1.Entities
{
    public abstract class Persona
    {
        public Persona()
        {

        }

        public Persona(string FirstName, string LastName, string email, DateTime birthday, string Gender, string phone )
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = email;
            this.Birthdate = Birthdate;
            this.Gender = Gender;
            this.Phone = Phone;   
        }

        public abstract string TomarAsistencia();

        public override string ToString()
        {
            return $"(Nombre: {this.FirstName} Apellido: {this.LastName})";
        }
        private string _firstname;
        private string _lastname;
        private string _email;
        private DateTime _birthdate;
        private string _gender;
        private string _phone;

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }

        }
        public DateTime Birthdate
        {
            get
            {
                return _birthdate;
            }
            set
            {
                _birthdate = value;
            }

        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }

        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

    }
}
