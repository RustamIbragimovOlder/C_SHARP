Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "женя")
{
    Console.WriteLine("Ура! Это Женя!! Привет!!! Чем занимаешься?");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}