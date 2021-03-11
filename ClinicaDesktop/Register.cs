using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDesktop {
    public partial class Register : Form {
        MainWindow MainForm;
        public Register(MainWindow form) {
            MainForm = form;
            InitializeComponent();
        }

        public Register(MainWindow form, Patient patient) {
            MainForm = form;
            InitializeComponent();

            completeName.Text = patient.CompleteName;
            sex.Text = patient.Sex;
            civilEstate.Text = patient.CivilEstate;
            email.Text = patient.Email;
            address.Text = patient.Address;
            birthDate.Text = patient.BirthDate;
            profession.Text = patient.Profession;
            phoneNumber.Text = patient.PhoneNumber;
            weight.Text = patient.Weight;
            height.Text = patient.Height;
            complain.Text = patient.Complain;
            currentDisease.Text = patient.CurrentDisease;
            preDisease.Text = patient.PreexistentDisease;
            history.Text = patient.History;
            associateDisease.Text = patient.AssociateDisease;
            habits.Text = patient.Habits;
            medication.Text = patient.Medication;
            state.Text = patient.State;
            pa.Text = patient.Pa;
            fc.Text = patient.Fc;
            fr.Text = patient.Fr;
            sp.Text = patient.Sp;
            observation.Text = patient.Observation;
        }

        private void saveButton_Click(object sender, EventArgs e) {
            Patient patient = new Patient(completeName.Text, sex.Text, civilEstate.Text, email.Text, address.Text, birthDate.Text,
                profession.Text, phoneNumber.Text, weight.Text, height.Text, complain.Text, currentDisease.Text, preDisease.Text, associateDisease.Text,
                history.Text, habits.Text, medication.Text, state.Text, pa.Text, fc.Text, fr.Text, sp.Text, observation.Text, new List<EvolutionRegister>());

            MainForm.PatientsList.Add(patient);
            Serialization.WriteToXmlFile<List<Patient>>("Patients.xml", MainForm.PatientsList, false);

            this.Close();
        }
    }
}
