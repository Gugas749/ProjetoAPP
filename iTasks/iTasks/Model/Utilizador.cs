using System.ComponentModel.DataAnnotations;

namespace iTasks.Model
{
    public class Utilizador
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } //Encrypted
        public string Username { get; set; } //Encrypted
        public string Password { get; set; } //Encrypted

        //public Utilizador(string nome, string username, string password)
        //{
        //    this.Nome = nome;
        //    this.Username = username;
        //    this.Password = password;
        //}
    }
}