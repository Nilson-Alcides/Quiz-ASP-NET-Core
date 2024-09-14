using Microsoft.AspNetCore.Mvc;
using QuizAspNet.Models;

namespace QuizAspNet.Controllers
{
    public class QuizGeraisController : Controller
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
                                Pergunta = "Qual é a capital da Minas Gerais?",
                                RespostaCorreta = "Belo Horizonte",
                                Alternativas = new List<string> { "Belo Horizonte", "Juiz de fora", "Lavras", "Mariana" }
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
                                RespostaCorreta = "Continente Americano",
                                Alternativas = new List<string> { "Continente Americano", "Continente Asiático", "Continente Europeu", "Continente Africano" }
                            }
                        }
                    }
                }
            };

            ViewBag.Pessoa = pessoa;
            ViewBag.Quiz = pessoa.Quizzes[0];

            return View();
        }

        [HttpPost]
        public IActionResult Resultado(List<string> respostas)
        {
            // Obtendo o quiz e as questões
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

            var quiz = pessoa.Quizzes[0];
            var questoes = quiz.Questoes;

            // Calculando o número de respostas corretas
            int corretas = 0;

            for (int i = 0; i < questoes.Count; i++)
            {
                if (respostas[i] == questoes[i].RespostaCorreta)
                {
                    corretas++;
                }
            }

            // Passando informações para a View usando ViewBag
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Corretas = corretas;
            ViewBag.Total = questoes.Count;
            ViewBag.Respostas = respostas;
            ViewBag.Quiz = quiz;

            return View();
        }
    }
}


