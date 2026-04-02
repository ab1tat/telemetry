namespace TeleModel.Model;

/// Base de Telemetria do Ecossistema aBitat.
public abstract class Televi
{
    // CISO: Usar init garante que o ID não seja alterado após a criação do log
    public Guid Id { get; init; } = Guid.NewGuid();

    // CTO: Timestamp automático para precisão de monitoramento
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    // CIO: 'required' resolve o erro CS8618 e garante integridade dos dados
    public required string DeviceId { get; set; }

    public required string ModuleSource { get; set; }

    // Adicionado para resolver o erro CS0117/CS1061 que vimos no seu terminal
    public string? Message { get; set; }
}