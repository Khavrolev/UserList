using System;
using System.Collections.Generic;
using System.Threading;

namespace UserList
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();

            users.Add(new User("Khavrolev", "Хавролев", true));
            users.Add(new User("Kuzsdf", "Анатолий", false));
            users.Add(new User("g4", "Василий", true));
            users.Add(new User("sdffs", "Артем", false));
            users.Add(new User("sdf", "Игорь", false));

            foreach (User user in users)
            {
                if (user.IsPremium)
                    Console.WriteLine($"Добрый день, {user.Name}");
                else
                {
                    Console.WriteLine($"Добрый день, {user.Name}, посмотрите рекламу");
                    ShowAds();
                }
            }

            Console.ReadKey();
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
