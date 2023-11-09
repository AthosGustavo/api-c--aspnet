using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api_c__aspnet.Domain
{
    [Table("campanhas")]
    public class Campanha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private long id_campanha;
        private string nome_campanha;
        private DateOnly data_inicio;
        private DateOnly data_fim;
    }
}