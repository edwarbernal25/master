using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alquicar.Models.Utilities
{
    public class Parameter
    {
        private string v;
        private bool aire_vehiculo;
        private DateTime fechanacimiento_propietario;

        public string Name { get; set; }
        public string Value { get; set; }

        public Parameter(string n, string v)
        {
            Name = n;
            Value = v;
        }

        public Parameter(string v, bool aire_vehiculo)
        {
            this.v = v;
            this.aire_vehiculo = aire_vehiculo;
        }

        public Parameter(string v, DateTime fechanacimiento_propietario)
        {
            this.v = v;
            this.fechanacimiento_propietario = fechanacimiento_propietario;
        }
    }
}