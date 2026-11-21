using System.Text.Json.Serialization;

class Book
{
    public int PublishingHouseId { get; set; }

    // Завдання 3. Щоб у серіалізованому об'єкті параметр Title мав назву "Name",
    // над властивістю додаємо атрибут [JsonPropertyName("Name")].
    // Назва властивості в коді (Title) при цьому не змінюється.
    [JsonPropertyName("Name")]
    public string Title { get; set; } = string.Empty;

    public PublishingHouse? PublishingHouse { get; set; }
}
