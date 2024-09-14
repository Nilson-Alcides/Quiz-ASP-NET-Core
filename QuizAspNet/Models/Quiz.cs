namespace QuizAspNet.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<Acervo> Questoes { get; set; }
    }
}
