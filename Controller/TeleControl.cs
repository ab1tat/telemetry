/* Exemplo de como seria o LogController.cs
public class TeleControl
{
	private readonly TeleRepo _repo;

	public TeleControl(TeleRepo repo)
	{
		_repo = repo;
	}

	// O Controller recebe a "ordem" externa
	public void ExecutarDelecao(int id)
	{
		// [CISO] Aqui o Controller validaria a segurança antes de deletar
		Console.WriteLine($"[LOG] Usuário solicitou exclusão do ID {id}");

		_repo.Remove(id); // O Controller manda o Repository fazer o trabalho sujo
	}
}*/