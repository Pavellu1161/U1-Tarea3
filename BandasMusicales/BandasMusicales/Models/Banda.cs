﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandasMusicales.Models
{
    public class Banda
    {
        [Key]
        public int BandaId { get; set; }
        [Display(Name ="Nombre de la Banda")]
        public string BandaName { get; set; }
        [Display(Name = "Genero de la Banda")]
        public string BandaGenero { get; set; }
        [Display(Name = "Cantidad miembros de la Banda")]
        public int BandaCant { get; set; }
        [Display(Name = "Cantidad canciones de la Banda")]
        public int BandaCantCanciones { get; set; }
    }
}
