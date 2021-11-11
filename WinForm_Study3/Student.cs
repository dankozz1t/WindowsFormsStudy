using System;

namespace GoToCSharpStud
{
    [Serializable]
    public class StudentCard
    {
        public string Series { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"Студенческий билет: {Series} - {Number}";
        }
    }

    [Serializable]
    public class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard StudentCard { get; set; }


        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.StudentCard = new StudentCard
            {
                Series = this.StudentCard.Series,
                Number = this.StudentCard.Number
            };
            return temp;
        }

        /// <summary>
        /// Метод сравнения двух студентов по фамилии
        /// </summary>
        /// <param name="obj">Это второй студент</param>
        /// <returns>0 - Если равны. 1 - если первый больше, -1 - если второй больше</returns>
        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }

        public string ShortName()
        {
            return $"{LastName} {FirstName}";
        }

        public override string ToString()
        {
            return $"ФИО : {LastName} {FirstName}\nДата рождения : {BirthDay.ToShortDateString()}\n{StudentCard}\n";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public int CompareTo(Student other)
        {
            return LastName.CompareTo(other.LastName);
        }

    }
}