Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "обито")
{
    Console.WriteLine("Ура, это же Обито");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}