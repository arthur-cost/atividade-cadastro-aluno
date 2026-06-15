using Microsoft.AspNetCore.Mvc;
using projeto.Models;

namespace projeto.Controllers;

public class AlunoController : Controller
{
  [HttpGet]
  public IActionResult Cadastrar()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Cadastrar(Aluno aluno)
  {
    if (!ModelState.IsValid)
    {
      return View(aluno);
    }

    TempData["MensagemSucesso"] = "Aluno cadastrado com sucesso.";
    return RedirectToAction(nameof(Cadastrar));
  }
}