using System;
using System.Collections.Generic;
using System.Text;

namespace src
{

    public class ToDoRepository
    {
        public List<ToDo> todolist = new List<ToDo>();
        public List<ToDo> inactiveTodoList = new List<ToDo>();
        UI ui = new UI();
        int idCount = 1;            //Used to give ToDo an ID

        public void PrintToDo(){
            Console.Clear();
            if(todolist.Count == 0){
                Console.WriteLine("Det finns inga aktiva ToDos.\n");
            }
            foreach(ToDo todo in todolist){
                string status;
                string color;
                if(todo.active == true){
                    status = "Aktiv";
                    color = "Green";
                }
                else{
                    status = "Klarmarkerad";
                    color = "Red";
                }
                if(todo is ToDoChecklist tdc){
                Console.WriteLine($"Titel: {todo.name}\nBeskrivning: {todo.description}\nChecklista: ");
                for(int i = 0; i < tdc.checklist.Length; i++){
                    Console.WriteLine(tdc.checklist[i]);
                }
                Console.Write($"Datum skapad: {todo.dateCreated}\nToDo ID: {todo.todoId}\nStatus: ");
                ui.ColoredText(status, color);
                Console.WriteLine("\n");
                }
                else if(todo is ToDoDeadline tdd){
                Console.Write($"Titel: {todo.name}\nBeskrivning: {todo.description}\nDeadline: {tdd.deadline}\nDatum skapad: {todo.dateCreated}\nToDo ID: {todo.todoId}\nStatus: ");
                ui.ColoredText(status, color);  
                Console.WriteLine("\n");
                }        
            }
             Console.WriteLine("För att klarmarkera ToDo, skriv ToDons ID sedan Enter\nEller tryck bara Enter för att gå tillbaka.\n");
        }

        public void PrintInactiveToDo(){
            Console.Clear();
            if(inactiveTodoList.Count == 0){
                Console.WriteLine("Det finns inga arkiverade ToDos.");
            }
            foreach(ToDo todo in inactiveTodoList){
                if(todo is ToDoChecklist tdc){
                Console.WriteLine($"Titel: {todo.name}\nBeskrivning: {todo.description}\n Checklista: ");
                for(int i = 0; i < tdc.checklist.Length; i++){
                    Console.WriteLine(tdc.checklist[i]);
                }
                Console.Write($"Datum skapad: {todo.dateCreated}\nToDo ID: {todo.todoId}\nStatus: ");
                ui.ColoredText("Arkiverad", "Red");
                Console.WriteLine("\n");
                }
                else if(todo is ToDoDeadline tdd){
                Console.Write($"Titel: {todo.name}\nBeskrivning: {todo.description}\nDeadline: {tdd.deadline}\nDatum skapad: {todo.dateCreated}\nToDo ID: {todo.todoId}\nStatus: ");    
                ui.ColoredText("Arkiverad", "Red");
                Console.WriteLine("\n");
                }        
            }
        }

        public void SetToDoFinshed(int id){
            if(id != 0){
                int index = todolist.FindIndex(obj => obj.todoId == id);
                if(index != -1){
                todolist[index].active = false;
                Console.WriteLine($"ToDo med id {id}, klarmarkerad");
                }
                else{
                Console.WriteLine("ToDo med detta ID finns inte.");
                }
            }
        }

        public void ArchiveInactiveToDo(){
            foreach(ToDo todo in todolist){
                if(todo.active == false){
                    inactiveTodoList.Add(todo);
                }
            }
            todolist.RemoveAll(obj => obj.active == false);
        }

        public void CreateToDo(int id){

            if(id == 1){
            Console.WriteLine("\nGe din ToDo en titel: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nGe din ToDo en beskrivning: ");
            string description = Console.ReadLine();
            Console.WriteLine("\nHur många punkter ska checklistan ha?(skriv ett nummer): ");
            int iC;
            string itemCount = Console.ReadLine();
            bool isInt = int.TryParse(itemCount, out iC);
                if(isInt){
                    List<string> check = new List<string>();
                        for(int i = 0; i < iC; i++){
                            Console.WriteLine("Punkt " + (i + 1) + ": ");
                            string checkItem = Console.ReadLine();
                            check.Add($"{i+1}. {checkItem}");
                        }
            string[] checkArray = check.ToArray();
            ToDoChecklist tdc = new ToDoChecklist(name, description, checkArray, idCount);
            idCount++;
            todolist.Add(tdc);
            Console.WriteLine("ToDo Skapad!");
            }
                else{
                    Console.WriteLine("Inte ett giltigt nummer.");
                }
            }
            else{
            Console.WriteLine("\nGe din ToDo en titel: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nGe din ToDo en beskrivning: ");
            string description = Console.ReadLine();
            Console.WriteLine("\nGe din ToDo en deadline: ");
            string deadline = Console.ReadLine(); 

            ToDoDeadline tdd = new ToDoDeadline(name, description, deadline, idCount);
            idCount++;
            todolist.Add(tdd);
            Console.WriteLine("ToDo Skapad!");
            }
        }

    }

}