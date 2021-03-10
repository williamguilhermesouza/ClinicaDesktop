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
            List<string> listaNome = MainForm.PatientsList.Select(x => x.getName()).ToList();
            InitializeComponent();
            patientsList.DataSource = listaNome;

        }
    }
}
