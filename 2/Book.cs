using System.Text.Json.Serialization;

class Book
{
    // Завдання 2. Щоб не серіалізувати PublishingHouseId,
    // над цією властивістю додаємо атрибут [JsonIgnore].
    // Тоді при серіалізації вона буде пропущена.
    [JsonIgnore]
    public int PublishingHouseId { get; set; }

    public string Title { get; set; } = string.Empty;
    public PublishingHouse? PublishingHouse { get; set; }
}
