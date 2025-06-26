using System.ComponentModel.DataAnnotations;

namespace iTasks.Model
{
    public class TarefaGestor
    {
        [Key]
        public int Id { get; set; }
        public int IdGestor { get; set; }
        public string Descricao { get; set; } //Encrypted
        public bool Terminado { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Gestor: {IdGestor} | {CaesarCipher.Decrypt(Descricao, 10)} | Terminada: {Terminado}";
        }
    }
}