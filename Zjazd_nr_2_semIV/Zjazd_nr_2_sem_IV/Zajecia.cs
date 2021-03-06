﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Zjazd_nr_2
{ 
   [Table("Laborki")]
    public class Zajecia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Nazwa_Przedmiotu")]
        [MinLength(1)]

        public string Nazwa { get; set; }
        public string Sala { get; set; }
        public DateTime Godzina { get; set; }
        public int IloscObecnych { get; set; }

    }
}
