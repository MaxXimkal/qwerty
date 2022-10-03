Console.Write("Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "максим")
{
    Console.Write("Здравствуйте, " + username + "!");
}
else
{
    Console.Write("Привет, " + username + ".");
}