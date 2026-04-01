using System;
using TeleModel.Model;

var repo = new TeleRepo();

// Simulando o CRUD
Console.WriteLine("--- CRUD de Telemetria Iniciado ---");

// 1. CREATE
repo.Add("Sistema Iniciado");
repo.Add("Tentativa de login detectada");

// 2. READ
Console.WriteLine("\nListando Logs:");
repo.GetAll().ForEach(l => Console.WriteLine($"{l.Id}: {l.Timestamp} - {l.Message}"));

// 3. UPDATE
repo.Update(2, "Alerta: Login falhou 3 vezes");

// 4. DELETE
repo.Remove(1);

Console.WriteLine("\nApós Update e Delete:");
repo.GetAll().ForEach(l => Console.WriteLine($"{l.Id}: {l.Message}"));