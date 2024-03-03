using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // производный класс Учитель
    class Teacher : Persona
    {


        /// <summary>
        /// стаж
        /// </summary>
        private double experience;

        /// <summary>
        /// должность
        /// </summary>
        private string post;

        public double Experience { get { return experience; } set { experience = value; } }
        public string Post { get { return post; } set { post = value; } }


        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="bh"></param>
        /// <param name="faculty">факультет</param>
        /// <param name="course">курс</param>
        /// <param name="experience">стаж</param>
        /// <param name="post">должность</param>
        public Teacher(string name, string surname, DateTime bh, string faculty, int course, double experience, string post) : base(name, surname, bh)
        {
            this.experience = experience;
            this.post = post;
        }

        public override void Info()
        {
            Console.WriteLine("Преподаватель:");
            base.Info();
            Console.WriteLine($"Стаж:{experience}\nДолжность:{post}");
        }




    }
}
