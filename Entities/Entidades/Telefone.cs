
using Models.Entidades.Enum;

namespace Models.Entidades
{
    class Telefone
    {

        public int Id { get; set; }
        public string Numero { get; set; }
        public TipoTelefone Tipo { get; set; }
    }
}
