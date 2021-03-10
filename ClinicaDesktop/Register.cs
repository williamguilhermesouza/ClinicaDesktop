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

        private void saveButton_Click(object sender, EventArgs e) {
            Patient patient = new Patient(completeName.Text, sex.Text, civilEstate.Text, email.Text, address.Text, birthDate.Text,
                profession.Text, phoneNumber.Text, weight.Text, height.Text, complain.Text, currentDisease.Text, preDisease.Text, associateDisease.Text,
                history.Text, habits.Text, medication.Text, state.Text, pa.Text, fc.Text, fr.Text, sp.Text, observation.Text);

            MainForm.PatientsList.Add(patient);
            Serialization.WriteToXmlFile<List<Patient>>("Patients.xml", MainForm.PatientsList, false);

            this.Close();
        }
    }
}
