using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDesktop {
    public class EvolutionRegister {

        public EvolutionRegister() { }
        public string Observation { get; set; }
        public DateTime Date { get; set; }

        public EvolutionRegister(string observation, DateTime date) {
            Observation = observation;
            Date = date;
        }
    }
}
