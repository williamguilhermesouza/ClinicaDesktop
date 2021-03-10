namespace ClinicaDesktop {
    public class Patient {
        private string CompleteName;
        private string Sex;
        private string CivilEstate;
        private string Email;
        private string Address;
        private string BirthDate;
        private string Profession;
        private string PhoneNumber;
        private string Weight;
        private string Height;
        private string Complain;
        private string CurrentDisease;
        private string PreexistentDisease;
        private string AssociateDisease;
        private string History;
        private string Habits;
        private string Medication;
        private string State;
        private string Pa;
        private string Fc;
        private string Fr;
        private string Sp;
        private string Observation;

        public Patient() { }

        public Patient(string completeName, string sex, string civilState, string email, string address, string birthDate,
            string profession, string phoneNumber, string weight, string height, string complain, string currentDisease,
            string preexistentDisease, string associateDisease, string history, string habits, string medication, string state,
            string pa, string fc, string fr, string sp, string observation) {
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
        }

        public string getName() {
            return CompleteName;
        }

    }
}
