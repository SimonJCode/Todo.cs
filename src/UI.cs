using System;
using System.Collections.Generic;


namespace src
{

    public class UI
    {
        
        List<string> mainMenuItems = new List<string>(){"Visa ToDo's", "Lägg till ny ToDo", "Arkivera klarmarkerade ToDo's", "Visa Arkiverade ToDo's", "Avsluta"};
        List<string> addTodoMenuItems = new List<string>(){"ToDo med checklista", "ToDo med deadline"};
        public void StartScreen(){
            Console.Clear();
            Console.WriteLine("\nVälkommen till ToDo!\nToDo hjälper dig att planera din vardag.\nAnvänd NumPaden på ditt tangentbord för att navigera i menyerna.\n\nTryck på valfri knapp för att komma igång!");
            Console.ReadKey();
        }
        public void mainMenu(){
            Console.Clear();
            Console.WriteLine("Använd NumPad för att navigera menyn.\n");
            int menuPos = 1;
            foreach(string item in mainMenuItems){
                Console.WriteLine("[" + menuPos + "] " + item);
                menuPos++;
            }
        }
        public void addTodoMenu(){
            Console.Clear();
            int menuPos = 1;
            foreach(string item in addTodoMenuItems){
                Console.WriteLine("[" + menuPos + "] " + item);
                menuPos++;
            }
        }
        public void ColoredText(string value, string color){
        switch(color){
            case "Green":
            Console.ForegroundColor = ConsoleColor.Green;
            break;
            case "Red":
            Console.ForegroundColor = ConsoleColor.Red;
            break;
            //Add more colors here if needed.
            default:
            break;
        }
        Console.Write(value);
        Console.ResetColor();
        }
    }
        
}

