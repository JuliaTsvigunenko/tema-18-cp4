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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите:");
                Console.WriteLine("1. Абитуриент");
                Console.WriteLine("2. Студент");
                Console.WriteLine("3. Преподаватель");
                Console.WriteLine("4. Конец!");

                Console.Write("Введите номер действия: ");
                int people = Convert.ToInt32(Console.ReadLine());

                switch (people)
                {

                    case 1 : personas.Add(Applicant.InPut()); break;

                    case 2: personas.Add(Student.InPut()); break;

                    case 3: personas.Add(Teacher.InPut()); break;

                    case 4: flag=false;
                        break;

                    default:
                        Console.WriteLine("Неверно :(   Пожалуйста, попробуйте снова.");
                        break;
                }


               



                


                
            }


            
            // Вывод информации о персонах
            Console.WriteLine("\nИнформация о персонах:");
            foreach (var person in personas)
            {
                person.Info();
                Console.WriteLine($"Возраст: {person.Age()} лет\n");
            }

            // Поиск персон по возрасту
            Console.WriteLine("Поиск персон по возрасту:");
            Console.Write("Минимальный возраст: ");
            int minAge = int.Parse(Console.ReadLine());
            Console.Write("Максимальный возраст: ");
            int maxAge = int.Parse(Console.ReadLine());
            foreach (var person in personas)
            {
                int age = person.Age();
                if (age >= minAge && age <= maxAge)
                {
                    person.Info();
                    Console.WriteLine($"Возраст: {age} лет\n");
                }
            }
















            Console.ReadKey();
        }

    } 

}
