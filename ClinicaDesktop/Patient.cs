using System.Collections.Generic;

namespace ClinicaDesktop {
    public class Patient {
        public string CompleteName { get; set; }
        public string Sex { get; set; }
        public string CivilEstate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string Profession { get; set; }
        public string PhoneNumber { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Complain { get; set; }
        public string CurrentDisease { get; set; }
        public string PreexistentDisease { get; set; }
        public string AssociateDisease { get; set; }
        public string History { get; set; }
        public string Habits { get; set; }
        public string Medication { get; set; }
        public string State { get; set; }
        public string Pa { get; set; }
        public string Fc { get; set; }
        public string Fr { get; set; }
        public string Sp { get; set; }
        public string Observation { get; set; }
        public List<EvolutionRegister> Evolutions { get; set; }

        public Patient() { }

        public Patient(string completeName, string sex, string civilState, string email, string address, string birthDate,
            string profession, string phoneNumber, string weight, string height, string complain, string currentDisease,
            string preexistentDisease, string associateDisease, string history, string habits, string medication, string state,
            string pa, string fc, string fr, string sp, string observation, List<EvolutionRegister> evolutions) {
            CompleteName = completeName;
            Sex = sex;
            CivilEstate = civilState;
            Email = email;
            Address = address;
            BirthDate = birthDate;
            Profession = profession;
            PhoneNumber = phoneNumber;
            Weight = weight;
            Height = height;
            Complain = complain;
            CurrentDisease = currentDisease;
            PreexistentDisease = preexistentDisease;
            AssociateDisease = associateDisease;
            History = history;
            Habits = habits;
            Medication = medication;
            State = state;
            Pa = pa;
            Fc = fc;
            Fr = fr;
            Sp = sp;
            Observation = observation;
            Evolutions = evolutions;
        }


    }
}
