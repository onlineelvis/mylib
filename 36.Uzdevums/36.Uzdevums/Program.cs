using System;
using System.Collections.Generic;
using System.Linq;

namespace _36.Uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {

            ToDo td1 = new ToDo();

            td1.Name = "C#";
            td1.Description = "Make a ToDo list";
            td1.Done = false;
            
            ToDo td2 = new ToDo()
            {
                Name = "Java",
                Description = "Keep learnning",
                Done = false
            };
            ToDo td3 = new ToDo()
            {
                Name = "JavaScript",
                Description = "You need to know this one as well",
                Done = false
            };

            List<ToDo> ToDoList = new List<ToDo>();
            ToDoList.Add(td1);
            ToDoList.Add(td2);
            ToDoList.Add(td3);

            foreach (var item in ToDoList)
            {
                Console.WriteLine($"{item.MarkAsDone(item.Done)} - {item.Name} - {item.Description}"); 
            }
            
        }
    }
}
