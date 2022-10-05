using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroProdutosFinal.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        [StringLength(50, ErrorMessage = "O Nome deve ter no maximo 50 caracteres.")]
        public string NomeProduto { get; set; }

        [Range(0, 999,  ErrorMessage = "O valor de {0} deve estar entre {1} e {2}.")]
        public int Quantidade { get; set; }


        [Range( 1d, 50000d, ErrorMessage = "O valor {0} deve estar entre {1} e {2}")]
        public decimal Preco { get; set; }

        [NotMapped]
        public decimal Total { get => this.Quantidade * this.Preco; }
    }
}
