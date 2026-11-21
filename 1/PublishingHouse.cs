// Клас для вкладеного JSON-об'єкта "PublishingHouse".
// Імена властивостей збігаються з ключами у файлі (зокрема "Adress").
class PublishingHouse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
}
