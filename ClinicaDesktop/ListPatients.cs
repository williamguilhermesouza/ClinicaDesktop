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
    public partial class ListPatients : Form {
        MainWindow MainForm;
        public ListPatients(MainWindow form) {
            this.MainForm = form;
            List<string> listaNome = MainForm.PatientsList.Select(x => x.CompleteName).ToList();
            InitializeComponent();
            patientsList.DataSource = listaNome;

        }

        private void evolution_Click(object sender, EventArgs e) {
            string current = patientsList.SelectedItem.ToString();
            Patient patient = this.MainForm.PatientsList.Find(p => p.CompleteName == current);
            EvolutionList evolutionList = new EvolutionList(this.MainForm, patient);
            evolutionList.Show();
        }

        private void register_Click(object sender, EventArgs e) {
            string current = patientsList.SelectedItem.ToString();
            Patient patient = this.MainForm.PatientsList.Find(p => p.CompleteName == current);
            Register register = new Register(this.MainForm, patient);
            register.Show();
        }

        private void delete_Click(object sender, EventArgs e) {
            string current = patientsList.SelectedItem.ToString();
            MainForm.PatientsList.Remove(MainForm.PatientsList.Where(x => x.CompleteName == current).FirstOrDefault());
            List<string> listaNome = MainForm.PatientsList.Select(x => x.CompleteName).ToList();
            patientsList.DataSource = listaNome;
            Serialization.WriteToXmlFile<List<Patient>>("Patients.xml", MainForm.PatientsList, false);
        }
    }
}
