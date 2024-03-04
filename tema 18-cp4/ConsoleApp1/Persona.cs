using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Персона абстрактный класс
    abstract class Persona
    {
        /// <summary>
        /// Свойство для доступа
        /// </summary>
        public string Name { get;  set;  }
        public string Surname { get; set; }
        public DateTime Bh { get; set; }


        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="bh">дата рождения</param>
        public Persona(string name, string surname, DateTime bh)
        {
            this.Name = name;
            this.Surname = surname;
            this.Bh = bh;
        }

        /// <summary>
        /// метод абстактный для вывода информации
        /// </summary>
        public virtual void Info()
        {
            Console.WriteLine($"{Name}\n{Surname}\n{Bh}");
        }


        /// <summary>
        /// Метод определения возраста
        /// </summary>
        /// <returns></returns>

        //public int Age()
        //{
        //    DateTime now = DateTime.Now;
        //    int age = now.Year - Bh.Year;
        //    if (now < Bh.AddYears(age)) age--;
        //    return age;
        //}

        public int Age()
        {
            return DateTime.Now.Year - Bh.Year;
        }

    }
}
