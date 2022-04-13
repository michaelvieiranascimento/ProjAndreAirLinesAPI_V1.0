using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjAndreAirLinesAPI_V1._0.Model
{
    public class Passageiro
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        [Column("Nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateNasc { get; set; }
        public string Email { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
