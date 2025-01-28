using Microsoft.AspNetCore.Mvc;
using GerenciadorCobrancas.Models;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorCobrancas.Controllers;

public class CobrancaController : Controller
{
    // Dados em memória
    private static List<Cobranca> _cobrancas = new List<Cobranca>
    {
        new Cobranca { Id = 1, Cliente = "Ana Maria", Documento = "12345", Valor = 1000.50m, Vencimento = DateTime.Now.AddDays(5), Situacao = "Pendente" },
        new Cobranca { Id = 2, Cliente = "João Silva", Documento = "67890", Valor = 500.75m, Vencimento = DateTime.Now.AddDays(-2), Situacao = "Paga" },
        new Cobranca { Id = 3, Cliente = "Carlos Souza", Documento = "11223", Valor = 750.00m, Vencimento = DateTime.Now.AddDays(10), Situacao = "Pendente" }
    };

    // Lista todas as cobranças
    public IActionResult Index()
    {
        return View(_cobrancas);
    }

    // Exibe o formulário para criar uma nova cobrança
    public IActionResult Create()
    {
        return View();
    }

    // Adiciona uma nova cobrança
    [HttpPost]
    public IActionResult Create(Cobranca cobranca)
    {
        cobranca.Id = _cobrancas.Max(c => c.Id) + 1; // Gera um ID único
        _cobrancas.Add(cobranca);
        return RedirectToAction(nameof(Index));
    }

    // Remove uma cobrança
    public IActionResult Delete(int id)
    {
        var cobranca = _cobrancas.FirstOrDefault(c => c.Id == id);
        if (cobranca != null)
        {
            _cobrancas.Remove(cobranca);
        }
        return RedirectToAction(nameof(Index));
    }
}
