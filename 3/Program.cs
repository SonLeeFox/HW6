// Завдання 3. Як змінити опис класів, щоб серіалізований об'єкт містив параметр Title з назвою "Name"?
// Відповідь: додати атрибут [JsonPropertyName("Name")] до властивості Title (див. Book.cs).

using System.Text.Encodings.Web;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Дані створюємо в коді: після перейменування ключ "Title" з вхідного файлу
// вже не відповідає властивості, тому тут показано лише серіалізацію.
PublishingHouse gymnasium = new PublishingHouse { Id = 2, Name = "ГІМНАЗІЯ", Adress = "Адреса 2" };
PublishingHouse oldLion = new PublishingHouse { Id = 1, Name = "Видавництво старого лева", Adress = "Адреса 1" };

List<Book> books = new List<Book>
{
    new Book { PublishingHouseId = 2, Title = "Підручник. Алгебра 8", PublishingHouse = gymnasium },
    new Book { PublishingHouseId = 1, Title = "Щоденник нейрохірурга", PublishingHouse = oldLion },
    new Book { PublishingHouseId = 2, Title = "Посібник. Алгебра 9", PublishingHouse = gymnasium }
};

JsonSerializerOptions options = new()
{
    WriteIndented = true,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
};

// У результаті замість "Title" буде ключ "Name"
Console.WriteLine(JsonSerializer.Serialize(books, options));
