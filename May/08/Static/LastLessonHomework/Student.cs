using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastLessonHomework
{
    public class Student
    {
        public string _name;
        private string _surname;
        private string _email;

        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
                if (_name != null)
                    this._email = string.Format("{0}.{1}@gmail.com", _name.ToLower(), _surname.ToLower());
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                if (_surname != null)
                    this._email = string.Format("{0}.{1}@gmail.com", _name.ToLower(), _surname.ToLower());
            }
        }
    }
}
