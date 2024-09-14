using Microsoft.AspNetCore.Mvc;
using QuizAspNet.Models;

namespace QuizAspNet.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            // Criando um exemplo de pessoa
            var pessoa = new Pessoa
            {
                Id = 1,
                Nome = "João",
                Idade = 25,
                Quizzes = new List<Quiz>
                {
                    new Quiz
                    {
                        Id = 1,
                        Titulo = "Quiz de Conhecimentos Gerais",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "Qual é a capital da França?",
                                RespostaCorreta = "Paris",
                                Alternativas = new List<string> { "Paris", "Londres", "Berlim", "Madri" }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Qual é o maior oceano do mundo?",
                                RespostaCorreta = "Oceano Pacífico",
                                Alternativas = new List<string> { "Oceano Atlântico", "Oceano Pacífico", "Oceano Índico", "Oceano Ártico" }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Qual brasil esta em qual continente?",
                                RespostaCorreta = "Continente americano",
                                Alternativas = new List<string> { "Continente americano", "Continente asiático", "Continente europeu", "Continente africano" }
                            }
                        }
                    }
                }
            };

            ViewBag.Pessoa = pessoa;
            ViewBag.Quiz = pessoa.Quizzes[0];

            return View();
        }

       
    }
}


