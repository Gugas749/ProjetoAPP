using System.ComponentModel.DataAnnotations;

namespace iTasks.Model
{
    public class Utilizador
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //public Utilizador(string nome, string username, string password)
        //{
        //    this.Nome = nome;
        //    this.Username = username;
        //    this.Password = password;
        //}
    }
}