// TODO console app for basic training

void PrintTODOs(List<string> todos)
{
    Console.WriteLine("List of added TODOs:");
    for (int i = 1; i <= todos.Count; i++)
    {
        Console.WriteLine($"{i}. {todos[i-1]}");
    }
}

List<string> todos = new List<string>();

bool exit = false;

Console.WriteLine("Yello!");

while (!exit)
{
    Console.WriteLine("------------------------");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.Write("Type S/A/R/E and hit ENTER: ");
    string optionChoice = Console.ReadLine().ToUpper();

    switch (optionChoice)
    {
        case "S":
            if (todos.Count > 0)
            { 
                PrintTODOs(todos);
            } else
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            break;
        case "A":
            bool newTodoAdded = false;
            while (!newTodoAdded)
            {
                Console.WriteLine("Enter the TODO description:");
                string todo = Console.ReadLine();
                if (!todos.Contains(todo) && todo != "")
                {
                    todos.Add(todo);
                    newTodoAdded = true;
                    Console.WriteLine($"TODO successfully added: {todo}");
                }
                else if (todo == "")
                {
                    Console.WriteLine("The description cannot be empty.");
                }
                else 
                {
                    Console.WriteLine("The description must be unique.");
                }
            }

            break;
        case "R":
            if (todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                break;
            }
            PrintTODOs(todos);
            Console.WriteLine("Select the index of the TODO you want to remove:");
            int index;
            bool validIndex = int.TryParse(Console.ReadLine(), out index);
            if (validIndex && index <= todos.Count && index > 0)
            {
                string todo = todos[index - 1];
                todos.Remove(todos[index-1]);
                Console.WriteLine($"TODO removed: {todo}");
            } else
            {
                Console.WriteLine("Invalid index.");
            }
            break;
        case "E":
            exit = true;
            break;
        default:
            Console.WriteLine("Incorrect input. Let's try again.");
            break;
    }
}

Console.WriteLine("Bye!");
