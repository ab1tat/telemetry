namespace TeleModel.Model;

public abstract class Televi
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Timestamp { get; set; }
    public string DeviceId { get; set; } 
    public string ModuleSource
}   