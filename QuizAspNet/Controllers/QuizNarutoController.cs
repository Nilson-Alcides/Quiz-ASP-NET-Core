using Microsoft.AspNetCore.Mvc;
using QuizAspNet.Models;

namespace QuizAspNet.Controllers
{
    public class QuizNarutoController : Controller
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
                        Titulo = "Quiz sobre anime Naruto",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "Qual é o nome do clã de Naruto?",
                                RespostaCorreta = "Clã Uzumaki",
                                Alternativas = new List<string> { "Clã Uchiha", "Clã Uzumaki", "Clã Hyuga", "Clã Senju",  }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Qual técnica Naruto aprende com Jiraiya durante o treinamento?",
                                RespostaCorreta = "Rasengan",
                                Alternativas = new List<string> { "Chidori", "Amaterasu", "Sharingan", "Rasengan" }
                            },
                            new Acervo
                            {
                                Id = 3,
                                Pergunta = "Quem derrotou Pain durante o ataque a Konoha?",
                                RespostaCorreta = "Naruto Uzumaki",
                                Alternativas = new List<string> { "Kakashi Hatake", "Sakura Haruno", "Naruto Uzumaki", "Sasuke Uchiha" }
                            },
                            new Acervo
                            {
                                Id = 4,
                                Pergunta = "Qual o objetivo da Akatsuki ao capturar as Bestas com Caudas?",
                                RespostaCorreta = "Criar a paz mundial",
                                Alternativas = new List<string> { "Dominar o mundo", "Fazer experimentos científicos", "Vingar-se da Vila da Folha", "Criar a paz mundial" }
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
                        Titulo = "Quiz sobre anime Naruto",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "Qual é o nome do clã de Naruto?",
                                RespostaCorreta = "Clã Uzumaki",
                                Alternativas = new List<string> { "Clã Uchiha", "Clã Uzumaki", "Clã Hyuga", "Clã Senju",  }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "Qual técnica Naruto aprende com Jiraiya durante o treinamento?",
                                RespostaCorreta = "Rasengan",
                                Alternativas = new List<string> { "Chidori", "Amaterasu", "Sharingan", "Rasengan" }
                            },
                            new Acervo
                            {
                                Id = 3,
                                Pergunta = "Quem derrotou Pain durante o ataque a Konoha?",
                                RespostaCorreta = "Naruto Uzumaki",
                                Alternativas = new List<string> { "Kakashi Hatake", "Sakura Haruno", "Naruto Uzumaki", "Sasuke Uchiha" }
                            },
                            new Acervo
                            {
                                Id = 4,
                                Pergunta = "Qual o objetivo da Akatsuki ao capturar as Bestas com Caudas?",
                                RespostaCorreta = "Criar a paz mundial",
                                Alternativas = new List<string> { "Dominar o mundo", "Fazer experimentos científicos", "Vingar-se da Vila da Folha", "Criar a paz mundial" }
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
