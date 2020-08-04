using Example.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.DAL
{
    public static class DataContext
    {


        private static List<Coche> Coches = new List<Coche>
            {
                new Coche{Id= Guid.NewGuid(), Marca = "Renault", Modelo = "Zoe", Matricula = "RTS-1234", NumeroPuertas = 3, PrecioAlquilerDia = 20, TipoCombustible="Electricidad"},
                new Coche{Id= Guid.NewGuid(), Marca = "Seat", Modelo = "León", Matricula = "KTS-1935", NumeroPuertas = 5, PrecioAlquilerDia = 35, TipoCombustible="Diesel"},
                new Coche{Id= Guid.NewGuid(), Marca = "BMW", Modelo = "i8", Matricula = "JTS-1239", NumeroPuertas = 3, PrecioAlquilerDia = 75, TipoCombustible="Gasolina"},
                new Coche{Id= Guid.NewGuid(), Marca = "Seat", Modelo = "Ibiza", Matricula = "LHN-7537", NumeroPuertas = 5, PrecioAlquilerDia = 30, TipoCombustible="Gasolina"},
            };

        public static Coche GetCoche(Guid id)
        {
            return Coches.FirstOrDefault(x => x.Id == id);
        }

        public static void AddCoche(Coche item)
        {
            Coches.Add(item);
        }

        public static void UpdateCoche(Coche item)
        {
            var coche = Coches.FirstOrDefault(x => x.Id == item.Id);
            coche = item;
        }
        public static void DeleteCoche(Guid id)
        {
            var coche = Coches.FirstOrDefault(x => x.Id == id);
            Coches.Remove(coche);

        }

        public static IEnumerable<Coche> GetCoches()
        {

            return Coches;
        }

        public static void SaveChanges()
        {
            //simula el guardar cambios
        }

        
    }
}
