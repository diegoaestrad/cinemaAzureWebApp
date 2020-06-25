using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cinemaAzureWebApp.Models
{
    public class Cinema
    {

        [Key]

        [Column(TypeName = "smallint")]
        public int CinemaId { get; set; }
         [Required]

        [Column(TypeName = "varchar(50)")]
        public String CinemaName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String CinemaAddress { get; set; }

        [Column(TypeName = "smallint")]
        public int CinemaScreens { get; set; }

        [Column(TypeName = "smallint")]
        public int AmenitiesId { get; set; }
        
    }
}
