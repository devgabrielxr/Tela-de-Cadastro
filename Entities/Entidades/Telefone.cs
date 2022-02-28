
using Models.Entidades.Enum;

namespace Models.Entidades
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public TipoTelefone Tipo { get; set; }
    }
}
