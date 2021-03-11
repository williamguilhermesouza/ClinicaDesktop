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
    public partial class Evolution : Form {
        Patient Paciente;
        EvolutionList List;
        MainWindow MainForm;
        public Evolution(MainWindow form, Patient patient, EvolutionList list) {
            MainForm = form;
            List = list;
            Paciente = patient;
            this.Name = patient.CompleteName;
            InitializeComponent();
            date.Text = DateTime.Now.ToString();
        }

        public Evolution(MainWindow form, Patient patient, EvolutionList list, EvolutionRegister evol) {
            MainForm = form;
            List = list;
            Paciente = patient;
            this.Name = patient.CompleteName;
            InitializeComponent();
            observations.Text = evol.Observation;
            date.Text = evol.Date.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            EvolutionRegister register = new EvolutionRegister(observations.Text, System.DateTime.Now);
            this.Paciente.Evolutions.Add(register);
            List<string> listaEvolucoes = Paciente.Evolutions.Select(x => x.Date.ToString()).ToList();
            List.evolutions.DataSource = listaEvolucoes;
            Serialization.WriteToXmlFile<List<Patient>>("Patients.xml", MainForm.PatientsList, false);
            this.Close();
        }
    }
}
