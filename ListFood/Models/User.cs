namespace ListFood.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Email { get; set; }
        public Genero? Genero { get; set; }
    }

    public enum Genero
    {
        Masculino, Feminino, Outros
    }
}
