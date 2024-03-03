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
        /// Поля ФИО, дата рождения
        /// </summary>
        private string name;
        private string surname;
        private DateTime bh;


        /// <summary>
        /// Свойство для доступа
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public DateTime Bh { get { return bh; } set { bh = value; } }


        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="bh">дата рождения</param>
        public Persona(string name, string surname, DateTime bh)
        {
            this.name = name;
            this.surname = surname;
            this.bh = bh;
        }

        /// <summary>
        /// метод абстактный для вывода информации
        /// </summary>
        public virtual void Info()
        {
            Console.WriteLine($"{Name}\n{surname}\n{bh}");
        }


        /// <summary>
        /// Метод определения возраста
        /// </summary>
        /// <returns></returns>
        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - bh.Year;
            if (now < bh.AddYears(age)) age--;
            return age;
        }





    }
}
