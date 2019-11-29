using System;
using System.Collections.Generic;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            ToDoRepository tr = new ToDoRepository();

            ui.StartScreen();
            bool running = true;

            while(running){
                ui.mainMenu();
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                string key = cki.Key.ToString();
            
            switch(key){
                case "NumPad1":
                    //print ToDo's
                    tr.PrintToDo();
                    string itemId = Console.ReadLine();
                        if(itemId == ""){
                            break;
                        }
                        else{
                            int setInactiveId = Int32.Parse(itemId);
                            tr.SetToDoFinshed(setInactiveId);
                        }
                    Console.ReadKey();
                    break;
                case "NumPad2":    
                    //Add ToDo
                    ui.addTodoMenu();
                    cki = Console.ReadKey();
                    string key2 = cki.Key.ToString();
                    switch(key2){
                        case "NumPad1":
                            tr.CreateToDo(1);
                            Console.ReadKey();
                            break;
                        case "NumPad2":
                            //add deadline
                            tr.CreateToDo(2);
                            Console.ReadKey();
                            break; 
                        default:
                            Console.WriteLine("\nInte ett giltigt alternativ.");
                            Console.ReadKey();
                            break;
                    }
                    break;
                case "NumPad3":    
                    //Archive ToDo's
                    tr.ArchiveInactiveToDo();
                    Console.WriteLine("\nKlarmarkerade ToDos arkiverade.");
                    Console.ReadKey();
                    break;
                case "NumPad4":    
                    tr.PrintInactiveToDo();
                    //Print archived ToDo's
                    Console.ReadKey();
                    break;
                case "NumPad5":    
                    //Exit app
                    return;           
                default:
                    Console.WriteLine("\nInte ett giltigt val.");
                    Console.ReadKey();
                    break;
            }
            }
        }
    }
}
