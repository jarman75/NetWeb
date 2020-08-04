using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DAL.DataModels
{
    public class Coche
    {
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public int? NumeroPuertas { get; set; }
        public string TipoCombustible { get; set; }
        public double? PrecioAlquilerDia { get; set; }
    }
}
