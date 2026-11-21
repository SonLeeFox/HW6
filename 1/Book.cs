// Клас для одного елемента масиву з файлу.
// Вкладений об'єкт "PublishingHouse" описується окремим класом
// і підключається як властивість відповідного типу.
class Book
{
    public int PublishingHouseId { get; set; }
    public string Title { get; set; } = string.Empty;
    public PublishingHouse? PublishingHouse { get; set; }
}
