namespace QuizAspNet.Models
{
    public class Acervo
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public string RespostaCorreta { get; set; }
        public List<string> Alternativas { get; set; }  
    }
}
