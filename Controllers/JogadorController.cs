using System;
using Eplayers_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eplayers_AspNetCore.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        
        Jogador jogadorModel = new Jogador();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogadores = jogadorModel.ReadAll();

            Equipe outraEquipe = new Equipe();
            ViewBag.outraEquipe = outraEquipe.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();
            novoJogador.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novoJogador.Nome      = form["Nome"];
            novoJogador.Email     = form["Senha"];
            novoJogador.Senha     = form["Senha"];

            jogadorModel.Create(novoJogador);
            ViewBag.Jogadores = jogadorModel.ReadAll();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("{id}")]
        public IActionResult Deletar(int id)
        {
            jogadorModel.Delete(id);
            ViewBag.Jogadores = jogadorModel.ReadAll();
            return LocalRedirect("~/Jogador/Listar");
        }
    }
}