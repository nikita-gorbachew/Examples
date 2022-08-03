Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "полина")
{
    Console.WriteLine("Ура, это же ПОЛИНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}