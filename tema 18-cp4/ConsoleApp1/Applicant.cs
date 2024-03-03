﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // производный класс Абитуриент 
    class Applicant : Persona
    {


        /// <summary>
        /// поле факультет
        /// </summary>
        private string faculty;

        /// <summary>
        /// Свойство для доступа
        /// </summary>
        public string Faculty { get { return faculty; } set { faculty = value; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="bh">дата рождения</param>
        /// <param name="faculty">факультет</param>
        public Applicant(string name, string surname, DateTime bh, string faculty) : base(name, surname, bh)
        {
            this.faculty = faculty;
        }

        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Факультет:{faculty}");
        }



        













    }
}
