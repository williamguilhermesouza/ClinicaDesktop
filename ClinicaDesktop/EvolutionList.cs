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
    public partial class EvolutionList : Form {
        MainWindow MainForm;
        Patient Paciente;
        public EvolutionList(MainWindow form, Patient patient) {
            this.MainForm = form;
            List<string> listaEvolucoes = patient.Evolutions.Select(x => x.Date.ToString()).ToList();
            InitializeComponent();
            evolutions.DataSource = listaEvolucoes;
            Paciente = patient;
            this.Text = patient.CompleteName;
        }

        private void button2_Click(object sender, EventArgs e) {
            Evolution evolution = new Evolution(MainForm, this.Paciente, this);
            evolution.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                string selected = evolutions.SelectedItem.ToString();
                EvolutionRegister register = this.Paciente.Evolutions.Find(x => x.Date.ToString() == selected);
                Evolution evolution = new Evolution(MainForm, this.Paciente, this, register);
                evolution.Show();
            } catch {
                MessageBox.Show("Selecione uma evolução");
            }
            
        }
    }
}
