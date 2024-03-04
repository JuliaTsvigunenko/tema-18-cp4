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

        private string faculty;

        public double Experience { get { return experience; } set { experience = value; } }
        public string Post { get { return post; } set { post = value; } }
        public string Faculty { get { return faculty; } set { faculty = value; } }


        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="bh"></param>
        /// <param name="faculty">факультет</param>
        /// <param name="experience">стаж</param>
        /// <param name="post">должность</param>
        public Teacher(string name, string surname, DateTime bh, string faculty, double experience, string post) : base(name, surname, bh)
        {
            this.faculty = faculty;
            this.experience = experience;
            this.post = post;
        }

        public override void Info()
        {
            Console.WriteLine("Преподаватель:");
            base.Info();
            Console.WriteLine($"Стаж:{experience}\nДолжность:{post}");
        }


        public static Teacher InPut()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime bh = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Введите стаж: ");
            double experience = Double.Parse(Console.ReadLine());
            Console.Write("Введите должность: ");
            string post = Console.ReadLine();
            return new Teacher (name, surname, bh, faculty, experience, post);
        }

    }
}
