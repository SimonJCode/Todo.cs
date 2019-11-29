using System;
using System.Collections.Generic;

namespace src
{
    public abstract class ToDo
    {
        
        public int todoId{ get; set; }
        public string name{ get; set; }
        public string description{ get; set; }
        public string dateCreated{ get; set; }
        public bool active{ get; set; }
        
    }

}