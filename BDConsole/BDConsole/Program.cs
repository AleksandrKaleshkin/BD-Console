using System;
using System.Collections.Generic;
using System.Linq;

namespace BDConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в БД!");
            Console.WriteLine("Управление БД: \n1 - Добавть запись \n2 - Изменить запись \n3 - Удалить запись \n4 - Просмотр БД \n5 - Очистка БД");
            bool idNum;
            string id;
            PersonService personservice = new PersonService();
            while (true)
            {

                Console.WriteLine("Введите команду:");

                idNum = int.TryParse(Console.ReadLine(), out int idNum1);


                
                switch (idNum1)
                {
                    case 1:                    
                        Console.WriteLine("Введите имя человека:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите возраст человека:");
                        int age = int.Parse(Console.ReadLine());
                        personservice.AddPerson(name, age);
                        Console.WriteLine("Пользователь добавлен!");
                        break;

                    case 2:
                        Console.WriteLine("Введите ID записи, которую хотите изменить:");
                        id = Console.ReadLine();
                        idNum = int.TryParse(id, out var changeId);
                        Console.Write("Введите новое имя: ");
                        string newName = Console.ReadLine();
                        Console.Write("Введиете новый возраст: ");
                        int newAge = int.Parse(Console.ReadLine());
                        if (idNum == true)
                        {
                            personservice.ChangePerson(changeId, newName, newAge);
                            Console.WriteLine("Пользователь измене!");
                        }
                        else
                        {
                            Console.WriteLine("Неверно указаны данные ID");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Введите ID, которое хотите удалить:");
                        id = Console.ReadLine();
                        idNum = int.TryParse(id,out var delId);
                        if (idNum==true)
                        {
                            personservice.DelPerson(delId);
                            Console.WriteLine("Пользователь удален");
                        }
                        else
                        {
                            Console.WriteLine("Неверно указаны данные ID");
                        }

                        break;

                    case 4:
                        var persons =personservice.ShowPerson().ToList();
                        foreach (var person in persons)
                        {
                            Console.WriteLine($"ID: {person.ID} Имя: {person.Name} Возраст: {person.Age}");
                        }
                        break;

                    case 5:
                        personservice.DeleteAll();
                        Console.WriteLine("БД очищена");
                        break;

                    default:
                        Console.WriteLine("Неверный номер команды!");
                        break;
                }
            }


        }






        

  


        

    }
}
