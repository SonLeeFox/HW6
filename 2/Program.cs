// Завдання 2. Як змінити опис класів, щоб не серіалізувати параметр PublishingHouseId?
// Відповідь: додати атрибут [JsonIgnore] до властивості PublishingHouseId (див. Book.cs).

using System.Text.Encodings.Web;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

const string path = "books.json";

try
{
    string json = File.ReadAllText(path);
    List<Book>? books = JsonSerializer.Deserialize<List<Book>>(json);

    if (books is null || books.Count == 0)
    {
        Console.WriteLine("Файл не містить жодної книги.");
        return;
    }

    // WriteIndented - форматований вивід,
    // UnsafeRelaxedJsonEscaping - щоб українські літери не перетворювалися на \uXXXX
    JsonSerializerOptions options = new()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    // У результаті немає поля PublishingHouseId
    Console.WriteLine(JsonSerializer.Serialize(books, options));
}
catch (FileNotFoundException)
{
    Console.WriteLine($"Файл {path} не знайдено.");
}
catch (JsonException ex)
{
    Console.WriteLine($"Некоректний формат JSON: {ex.Message}");
}
