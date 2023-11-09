using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_c__aspnet.Domain
{
    [Table("item_nota_fiscal")]
    public class ItemNotaFiscal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private long id_item_nota;
        private long id_nota_fiscal;
        private int qtd_produto;
    }
}