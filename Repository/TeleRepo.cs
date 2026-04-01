using System.Collections.Generic;
using System.Linq;
using TeleModel.Model;

public class TeleRepo
{
    private List<Televi> _repo = new();
    private int _nextId = 1;

    // CREATE
    public void Add(string msg) => _repo.Add(new Televi { Id = _nextId++, Timestamp = DateTime.Now, Message = msg });

    // READ
    public List<Televi> GetAll() => _repo;

    // UPDATE
    public void Update(int id, string newMsg)
    {
        var log = _repo.FirstOrDefault(l => l.Id == id);
        if (log != null) log.Message = newMsg;
    }

    // DELETE
    public void Remove(int id) => _repo.RemoveAll(l => l.Id == id);
}