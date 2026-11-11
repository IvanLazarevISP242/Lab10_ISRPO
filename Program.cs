Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
} else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}

string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Hero margarita = new Hero("Маргарита", 80);

margarita.TakeDamage(30);
margarita.Heal(15);
margarita.GainExperience(50);

bool margaritaAlive = margarita.IsAlive();
Console.WriteLine($"Маргарита жива: {margaritaAlive}");

Console.WriteLine(margarita.GetInfo());

Product laptop = new Product("Ноутбук", 55000, 10);
Product mouse = new Product("Компьютерная мышь", 1500, 25);

laptop.Sell(3);
laptop.Restock(5);
laptop.Restock(-10);

Console.WriteLine(laptop.GetProductInfo());
Console.WriteLine($"Стоимость 2 ноутбуков: {laptop.CalculateTotalCost(2)} руб.");

Console.WriteLine();

Console.WriteLine(mouse.GetProductInfo());
