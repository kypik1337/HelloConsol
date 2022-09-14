Console.WriteLine(" Write your Name");
string username = Console.ReadLine();
if(username.ToLower() == "artem") //ToLower (делает из прописных букв заглавные т.е помогает решить проблему с конкретикою)
    {
        Console.WriteLine("Hi Brooooooo!!!");
    }
else
   { 
        Console.WriteLine("Who are you, ");
        Console.WriteLine(username);
   }
