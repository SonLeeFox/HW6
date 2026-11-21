// Завдання 1. Створити відповідні класи та десеріалізувати вміст файлу.

using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

const string path = "books.json";

try
{
    // Читаємо весь текст файлу
    string json = File.ReadAllText(path);

    // Файл містить масив, тому десеріалізуємо його у список книг
    List<Book>? books = JsonSerializer.Deserialize<List<Book>>(json);

    if (books is null || books.Count == 0)
    {
        Console.WriteLine("Файл не містить жодної книги.");
        return;
    }

    // Виводимо результат, щоб переконатися, що дані прочитано
    foreach (Book book in books)
    {
        Console.WriteLine($"{book.Title} | {book.PublishingHouse?.Name ?? "невідомо"}, {book.PublishingHouse?.Adress ?? "невідомо"}");
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine($"Файл {path} не знайдено.");
}
catch (JsonException ex)
{
    Console.WriteLine($"Некоректний формат JSON: {ex.Message}");
}
