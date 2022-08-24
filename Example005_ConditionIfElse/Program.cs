Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Nice to meat you");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
