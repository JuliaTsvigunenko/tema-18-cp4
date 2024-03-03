using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Persona> personas = new List<Persona>();

            while (true)
            {
                Console.WriteLine("Выберите:");
                Console.WriteLine("1. Абитуриент");
                Console.WriteLine("2. Студент");
                Console.WriteLine("3. Преподаватель");
               

                Console.Write("Введите номер действия: ");
                string people = Console.ReadLine();

                switch (people)
                {

                    case "1":

                        Console.WriteLine("Добавление абитуриента:");
                        Console.Write("Имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Фамилия: ");
                        string surname = Console.ReadLine();
                        Console.Write("Дата рождения (гггг-мм-дд): ");
                        DateTime bh = DateTime.Parse(Console.ReadLine());
                        Console.Write("Факультет: ");
                        string faculty = Console.ReadLine();
                        personas.Add(new Applicant(name, surname, bh, faculty));
                        break;

                    case "2":
                        Console.WriteLine("Добавление студента:");
                        Console.Write("Имя: ");
                        name = Console.ReadLine();
                        Console.Write("Фамилия: ");
                        surname = Console.ReadLine();
                        Console.Write("Дата рождения (гггг-мм-дд): ");
                        bh = DateTime.Parse(Console.ReadLine());
                        Console.Write("Факультет: ");
                        faculty = Console.ReadLine();
                        Console.Write("Курс: ");
                        int course = int.Parse(Console.ReadLine());
                        personas.Add(new Student(name, surname, bh, faculty, course));
                        break;


                    case "3":
                        Console.WriteLine("Добавление преподавателя:");
                        Console.Write("Имя: ");
                        name = Console.ReadLine();
                        Console.Write("Фамилия: ");
                        surname = Console.ReadLine();
                        Console.Write("Дата рождения (гггг-мм-дд): ");
                        bh = DateTime.Parse(Console.ReadLine());
                        Console.Write("Факультет: ");
                        faculty = Console.ReadLine();
                        Console.Write("Должность: ");
                        string position = Console.ReadLine();
                        Console.Write("Стаж: ");
                        int experience = int.Parse(Console.ReadLine());
                        personas.Add(new Teacher(name, surname, bh, faculty, position, experience));
                        break;

                    case "4":

                    default:
                        Console.WriteLine("Неверно :(   Пожалуйста, попробуйте снова.");
                        break;
                }

                Console.ReadKey();
            }







            //EndInput:

            //// Вывод информации о персонах
            //Console.WriteLine("\nИнформация о персонах:");
            //foreach (var person in personas)
            //{
            //    person.Info();
            //    Console.WriteLine($"Возраст: {person.Age()} лет\n");
            //}

            //// Поиск персон по возрасту
            //Console.WriteLine("Поиск персон по возрасту:");
            //Console.Write("Минимальный возраст: ");
            //int minAge = int.Parse(Console.ReadLine());
            //Console.Write("Максимальный возраст: ");
            //int maxAge = int.Parse(Console.ReadLine());
            //foreach (var person in personas)
            //{
            //    int age = person.Age();
            //    if (age >= minAge && age <= maxAge)
            //    {
            //        person.Info();
            //        Console.WriteLine($"Возраст: {age} лет\n");
            //    }
            //}

















        }

    } 

}
