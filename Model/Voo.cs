using System;
using System.ComponentModel.DataAnnotations;

namespace ProjAndreAirLinesAPI_V1._0.Model
{
    public class Voo
    {
        public int Id { get; set; }
        public Aeroporto AeroportoDestino { get; set; }
        public Aeroporto AeroportoOrigem { get; set; }
        public Aeronave Aernave { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime HorarioEmbarque { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime HorarioDesembarque { get; set; }
        public Passageiro Passageiro { get; set; }
    }
}
