namespace ProjetoGilsonDaniel_RollSP.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Quiz> Quizzes { get; set; }
    }
}
