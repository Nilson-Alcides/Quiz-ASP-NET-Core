using Microsoft.AspNetCore.Mvc;
using QuizAspNet.Models;

namespace QuizAspNet.Controllers
{
    public class QuizEsporteController : Controller
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
                        Titulo = "Quiz de time de futebol",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "Qual time tem mais títulos do Campeonato Brasileiro??",
                                RespostaCorreta = "Palmeiras",
                                Alternativas = new List<string> { "São Paulo", "Palmeiras", "Santos", "Corinthians",  }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Quem é o maior artilheiro da história do Campeonato Brasileiro??",
                                RespostaCorreta = "Roberto Dinamite",
                                Alternativas = new List<string> { "Zico", "Roberto Dinamite", "Romário", "Pelé"}
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Quantas vezes o Brasil ganhou a copa?",
                                RespostaCorreta = "5 Vezes",
                                Alternativas = new List<string> { "5 Vezes", "7 Vezes", "3 Vezes", "5 Vezes" }
                            },                            
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Em que ano o Brasil conquistou sua primeira Copa do Mundo?",
                                RespostaCorreta = "1958",
                                Alternativas = new List<string> { "1950", "1958", "1962", "1970" }
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
                        Titulo = "Quiz de time de futebol",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "Qual time tem mais títulos do Campeonato Brasileiro??",
                                RespostaCorreta = "Palmeiras",
                                Alternativas = new List<string> { "São Paulo", "Palmeiras", "Santos", "Corinthians",  }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Quem é o maior artilheiro da história do Campeonato Brasileiro??",
                                RespostaCorreta = "Roberto Dinamite",
                                Alternativas = new List<string> { "Zico", "Roberto Dinamite", "Romário", "Pelé"}
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Quantas vezes o Brasil ganhou a copa?",
                                RespostaCorreta = "5 Vezes",
                                Alternativas = new List<string> { "5 Vezes", "7 Vezes", "3 Vezes", "5 Vezes" }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Em que ano o Brasil conquistou sua primeira Copa do Mundo?",
                                RespostaCorreta = "1958",
                                Alternativas = new List<string> { "1950", "1958", "1962", "1970" }
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
