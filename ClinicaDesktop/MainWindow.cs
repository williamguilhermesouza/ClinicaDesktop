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
    public partial class MainWindow : Form {
        public List<Patient> PatientsList;
        public MainWindow() {
            PatientsList = Serialization.TryReadFromXmlFile<List<Patient>>("Patients.xml");
            if (PatientsList == null) PatientsList = new List<Patient>();
            InitializeComponent();
        }


        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e) {
            Register register = new Register(this);
            register.Show();
        }

        private void listarPacientesToolStripMenuItem_Click(object sender, EventArgs e) {
            ListPatients list = new ListPatients(this);
            list.Show();
        }
    }
}
