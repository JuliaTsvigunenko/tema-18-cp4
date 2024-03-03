using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // производный класс Студент
    class Student : Persona
    {


        /// <summary>
        /// факультет
        /// </summary>
        private string faculty;

        /// <summary>
        /// курс
        /// </summary>
        private int course;


        /// <summary>
        /// Свойства
        /// </summary>

        public string Faculty { get { return faculty; } set { faculty = value; } }
        public int Course { get { return course; } set { course = value; } }


        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="bh"></param>
        /// <param name="faculty"></param>
        /// <param name="course"></param>
        public Student(string name, string surname, DateTime bh, string faculty, int course) : base(name, surname, bh)
        {
            this.faculty = faculty;
            this.course = course;
        }


        /// <summary>
        /// метод для вывода информации о персоне (переопределенный)
        /// </summary>
        public override void Info()
        {
            Console.WriteLine("Студент:");
            base.Info();
            Console.WriteLine($"Факультет:{faculty}\nКурс:{course}");
        }







    }
}
