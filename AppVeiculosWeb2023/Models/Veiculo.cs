﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppVeiculosWeb2023.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage =("Obrigatório informar o nome!"))]
        public string Nome { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar placa!"))]
        public string Placa { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o ano de fabricação!"))]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o ano do modelo!"))]
        public int AnoModelo { get; set; }
    }
}
