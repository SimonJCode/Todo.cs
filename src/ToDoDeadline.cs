using System;

namespace src
{

    public class ToDoDeadline : ToDo
    {

        public string deadline{get; set;}

         public ToDoDeadline(string Name, string Descriptrion, string Deadline, int ID)
        {
            name = Name;
            description = Descriptrion;
            dateCreated = DateTime.Now.ToString("yyyy-MM-dd");
            deadline = Deadline;
            active = true;
            todoId = ID;
        }


        public override void addTodo(ToDo i)
        {
            
        }
    }

}