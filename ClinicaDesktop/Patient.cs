using System.Collections.Generic;
using System;

namespace ClinicaDesktop {
    public class Patient {
        public string CompleteName { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public  DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public Color Color { get; set; }
        public CivilState CivilEstate { get; set; }
        public string Religion { get; set; }
        public Scholarship Scholarity { get; set; }

        public string Profession { get; set; }
        public string Naturality { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CurrentDisease { get; set; }
        public string AssociateDisease { get; set; }
        public string PreexistentDisease { get; set; }
        public string History { get; set; }
        public string Habits { get; set; }
        public string Diagnosis { get; set; }
        public string Complain { get; set; }
        public string Medication { get; set; }
        public string Mobility { get; set; }
        public string ConsciousState { get; set; }
        public string Skin { get; set; }
        public string Air { get; set; }
        public string ToraxFormat { get; set; }
        public Ventilation VentilationType { get; set; }
        public MuscularPattern MuscularPattern { get; set; }
        public VentilatoryRythm VentilatoryRythm { get; set; }
        public string Abdomen { get; set; }
        public string Signals { get; set; }
        public string Symptoms { get; set; }
        public ToraxMobility ToraxMobility { get; set; }
        public PulmonarExpansion PulmonarExpansion { get; set; }
        public double Fr { get; set; }
        public double Fc { get; set; }
        public double Sp { get; set; }
        public double Pa { get; set; }
        public double Temperature { get; set; }
        public string PulmonarHearing { get; set; }
        public Cough Cough { get; set; }
        public string Secretion { get; set; }
        public string Tonus { get; set; }
        public string Reflexes { get; set; }
        public string Strength { get; set; }
        public string Sensibility { get; set; }
        public string MotorControl { get; set; }
        public string Complementary { get; set; }
        public string FunctionalDiagnosis { get; set; }
        public string Problem { get; set; }
        public string Target { get; set; }
        public string Conduct { get; set; }
        public List<EvolutionRegister> Evolutions { get; set; }

        public Patient() { }

        public Patient(string completeName,string address, string district, string city, DateTime birthDate, 
            Sex sex, Color color, CivilState civilState, string religion, Scholarship scholarity, string profession,
            string naturality, double weight, double height, string phoneNumber, string email, string currentDisease,
            string associateDisease, string preexistentDisease,  string history, string habits,string diagnosis,
            string complain, string medication, string mobility, string consciousState, string skin, string air,
            string toraxFormat, Ventilation ventilationType, MuscularPattern muscularPattern, VentilatoryRythm ventilatoryRythm, string abdomen,
            string signals, string symptoms, ToraxMobility toraxMobility, PulmonarExpansion pulmonarExpansion, double fr, double fc, double sp,
            double pa, double temperature, string pulmonarHearing, Cough cough, string secretion, string tonus,
            string reflexes, string strength, string sensibility, string motorControl, string complementary, 
            string functionalDiagnosis, string problem, string target, string conduct, List<EvolutionRegister> evolutions) {
            CompleteName = completeName;
            Address = address;
            District = district;
            City = city;
            BirthDate = birthDate;
            Sex = sex;
            Color = color;
            CivilEstate = civilState;
            Religion = religion;
            Scholarity = scholarity;
            Profession = profession;
            Naturality = naturality;
            Weight = weight;
            Height = height;
            PhoneNumber = phoneNumber;
            Email = email;
            CurrentDisease = currentDisease;
            AssociateDisease = associateDisease;
            PreexistentDisease = preexistentDisease;
            History = history;
            Habits = habits;
            Diagnosis = diagnosis;
            Complain = complain;
            Medication = medication;
            Mobility = mobility;
            ConsciousState = consciousState;
            Skin = skin;
            Air = air;
            ToraxFormat = toraxFormat;
            VentilationType = ventilationType;
            MuscularPattern = muscularPattern;
            VentilatoryRythm = ventilatoryRythm;
            Abdomen = abdomen;
            Signals = signals;
            Symptoms = symptoms;
            ToraxMobility = toraxMobility;
            PulmonarExpansion = pulmonarExpansion;
            Fr = fr;
            Fc = fc;
            Sp = sp;
            Pa = pa;
            Temperature = temperature;
            PulmonarHearing = pulmonarHearing;
            Cough = cough;
            Secretion = secretion;
            Tonus = tonus;
            Reflexes = reflexes;
            Strength = strength;
            Sensibility = sensibility;
            MotorControl = motorControl;
            Complementary = complementary;
            FunctionalDiagnosis = functionalDiagnosis;
            Problem = problem;
            Target = target;
            Conduct = conduct;
            Evolutions = evolutions;

        }


    }
}
