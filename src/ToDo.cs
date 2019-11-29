using System;
using System.Collections.Generic;

namespace src
{
    public abstract class ToDo
    {

        public List<ToDo> todolist = new List<ToDo>();
        

        public abstract void addTodo(ToDo i);   

        
        
        public int todoId{ get; set; }
        public string name{ get; set; }
        public string description{ get; set; }
        public string dateCreated{ get; set; }
        public bool active{ get; set; }
        
    }

}