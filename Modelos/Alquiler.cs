using System;
using System.Collections.Generic;
using VideoClubExamen.Modelos;

namespace VideoclubExamen.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public decimal MontoBase { get; set; } // <-- Agregá esta línea

        public int SocioId { get; set; }
        public Socio? Socio { get; set; }

        public ICollection<AlquilerPelicula> AlquilerPeliculas { get; set; } = new List<AlquilerPelicula>();
    }
}