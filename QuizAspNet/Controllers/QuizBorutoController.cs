using Microsoft.AspNetCore.Mvc;
using QuizAspNet.Models;

namespace QuizAspNet.Controllers
{
    public class QuizBorutoController : Controller
    {
        public IActionResult Index()
        {
            // Criando um exemplo de pessoa
            var pessoa = new Pessoa
            {
                Id = 1,
                Nome = "Visitante",
                Idade = 25,
                Quizzes = new List<Quiz>
                {
                     new Quiz
                    {
                        Id = 1,
                        Titulo = "Quiz sobre anime Boruto",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "Quem é o mentor de Boruto?",
                                RespostaCorreta = "Konohamaru Sarutobi",
                                Alternativas = new List<string> { "Sasuke Uchiha", "Konohamaru Sarutobi", "Kakashi Hatake", "Shikamaru Nara",  }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Quem é Mitsuki, companheiro de time de Boruto?",
                                RespostaCorreta = "Filho de Orochimaru",
                                Alternativas = new List<string> { "Um clone de Orochimaru", "Filho de Orochimaru", "Um ninja da Nuvem", "Um seguidor da Akatsuki" }
                            },
                            new Acervo
                            {
                                Id = 3,
                                Pergunta = "O que é o Jogan, o olho especial que Boruto possui?",
                                RespostaCorreta = "Um dojutsu que enxerga através de dimensões",
                                Alternativas = new List<string> { "Um dojutsu que controla o tempo", "Um dojutsu que concede força ilimitada", "Um dojutsu que enxerga através de dimensões", "Um dojutsu que é uma evolução do Sharingan" }
                            },
                            new Acervo
                            {
                                Id = 4,
                                Pergunta = "Qual é o nome da organização que busca controlar o poder das Bestas com Caudas em Boruto?",
                                RespostaCorreta = "Otsutsuki",
                                Alternativas = new List<string> { "Otsutsuki" ,"Akatsuki", "Hebi", "Kara"}
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
                Nome = "Visitante",
                Idade = 25,
                Quizzes = new List<Quiz>
                {
                    new Quiz
                    {
                        Id = 1,
                        Titulo = "Quiz sobre anime Boruto",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "Quem é o mentor de Boruto?",
                                RespostaCorreta = "Konohamaru Sarutobi",
                                Alternativas = new List<string> { "Sasuke Uchiha", "Konohamaru Sarutobi", "Kakashi Hatake", "Shikamaru Nara",  }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Quem é Mitsuki, companheiro de time de Boruto?",
                                RespostaCorreta = "Filho de Orochimaru",
                                Alternativas = new List<string> { "Um clone de Orochimaru", "Filho de Orochimaru", "Um ninja da Nuvem", "Um seguidor da Akatsuki" }
                            },
                            new Acervo
                            {
                                Id = 3,
                                Pergunta = "O que é o Jogan, o olho especial que Boruto possui?",
                                RespostaCorreta = "Um dojutsu que enxerga através de dimensões",
                                Alternativas = new List<string> { "Um dojutsu que controla o tempo", "Um dojutsu que concede força ilimitada", "Um dojutsu que enxerga através de dimensões", "Um dojutsu que é uma evolução do Sharingan" }
                            },
                            new Acervo
                            {
                                Id = 4,
                                Pergunta = "Qual é o nome da organização que busca controlar o poder das Bestas com Caudas em Boruto?",
                                RespostaCorreta = "Otsutsuki",
                                Alternativas = new List<string> { "Otsutsuki" ,"Akatsuki", "Hebi", "Kara"}
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
