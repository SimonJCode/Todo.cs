using System;

namespace src
{

    public class ToDoChecklist : ToDo
    {

        public string[] checklist{ get; set; }

        public ToDoChecklist(){

        }
        public ToDoChecklist(string Name, string Descriptrion, string[] Checklist, int ID)
        {
            name = Name;
            description = Descriptrion;
            dateCreated = DateTime.Now.ToString("yyyy-MM-dd");
            checklist = Checklist;
            active = true;
            todoId = ID;
        }

    }

}