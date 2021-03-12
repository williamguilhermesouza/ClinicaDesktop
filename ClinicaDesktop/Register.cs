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
            sex.DataSource = Enum.GetValues(typeof(Sex));
            color.DataSource = Enum.GetValues(typeof(Color));
            civilState.DataSource = Enum.GetValues(typeof(CivilState));
            pattern.DataSource = Enum.GetValues(typeof(MuscularPattern));
            rhythm.DataSource = Enum.GetValues(typeof(VentilatoryRythm));
            toraxMobility.DataSource = Enum.GetValues(typeof(ToraxMobility));
            scholarity.DataSource = Enum.GetValues(typeof(Scholarship));
            pulmonar.DataSource = Enum.GetValues(typeof(PulmonarExpansion));
            cough.DataSource = Enum.GetValues(typeof(Cough));
            ventilation.DataSource = Enum.GetValues(typeof(Ventilation));
            religion.DataSource = FormsList.religionList;
            torax.DataSource = FormsList.toraxFormatList;
            signals.DataSource = FormsList.signalsList;
            symptoms.DataSource = FormsList.symptomsList;
            secretion.DataSource = FormsList.secretionList;
            ventilationMode.DataSource = FormsList.oxigenationList;
        }

        public Register(MainWindow form, Patient patient) {
            MainForm = form;
            InitializeComponent();
            sex.DataSource = Enum.GetValues(typeof(Sex));
            color.DataSource = Enum.GetValues(typeof(Color));
            civilState.DataSource = Enum.GetValues(typeof(CivilState));
            pattern.DataSource = Enum.GetValues(typeof(MuscularPattern));
            rhythm.DataSource = Enum.GetValues(typeof(VentilatoryRythm));
            toraxMobility.DataSource = Enum.GetValues(typeof(ToraxMobility));
            scholarity.DataSource = Enum.GetValues(typeof(Scholarship));
            pulmonar.DataSource = Enum.GetValues(typeof(PulmonarExpansion));
            cough.DataSource = Enum.GetValues(typeof(Cough));
            ventilation.DataSource = Enum.GetValues(typeof(Ventilation));
            religion.DataSource = FormsList.religionList;
            torax.DataSource = FormsList.toraxFormatList;
            signals.DataSource = FormsList.signalsList;
            symptoms.DataSource = FormsList.symptomsList;
            secretion.DataSource = FormsList.secretionList;
            ventilationMode.DataSource = FormsList.oxigenationList;

            completeName.Text = patient.CompleteName;
            address.Text = patient.Address;
            district.Text = patient.District;
            city.Text = patient.City;
            birthDate.Value = patient.BirthDate;
            sex.Text = patient.Sex.ToString();
            color.Text = patient.Color.ToString();
            civilState.Text = patient.CivilEstate.ToString();
            religion.Text = patient.Religion;
            scholarity.Text = patient.Scholarity.ToString();
            profession.Text = patient.Profession;
            naturality.Text = patient.Naturality;
            weight.Value = Decimal.Parse(patient.Weight.ToString());
            height.Value = Decimal.Parse(patient.Height.ToString());
            phoneNumber.Text = patient.PhoneNumber;
            email.Text = patient.Email;
            history.Text = patient.History;
            associateDisease.Text = patient.AssociateDisease;
            pregressDisease.Text = patient.PreexistentDisease;
            habits.Text = patient.Habits;
            diagnosis.Text = patient.Diagnosis;
            complain.Text = patient.Complain;
            medication.Text = patient.Medication;
            mobility.Text = patient.Mobility;
            conscious.Text = patient.ConsciousState;
            skin.Text = patient.Skin;
            access.Text = patient.Air;
            torax.Text = patient.ToraxFormat;
            ventilation.Text = patient.VentilationType.ToString();
            pattern.Text = patient.MuscularPattern.ToString();
            abdomen.Text = patient.Abdomen;
            signals.Text = patient.Signals;
            symptoms.Text = patient.Symptoms;
            toraxMobility.Text = patient.ToraxMobility.ToString();
            hearing.Text = patient.PulmonarHearing;
            fr.Value = Convert.ToDecimal(patient.Fr);
            fc.Value = Convert.ToDecimal(patient.Fc);
            sp02.Value = Convert.ToDecimal(patient.Sp);
            pa.Value = Convert.ToDecimal(patient.Pa);
            temperature.Value = Convert.ToDecimal(patient.Temperature);
            pulmonar.Text = patient.PulmonarExpansion.ToString();
            cough.Text = patient.Cough.ToString();
            secretion.Text = patient.Secretion;
            tonus.Text = patient.Tonus;
            reflexes.Text = patient.Reflexes;
            strength.Text = patient.Strength;
            sensibility.Text = patient.Sensibility;
            motor.Text = patient.MotorControl;
            complementary.Text = patient.Complementary;
            functionalDiagnosis.Text = patient.FunctionalDiagnosis;
            problem.Text = patient.Problem;
            target.Text = patient.Target;
            conduct.Text = patient.Conduct;
            currentDisease.Text = patient.CurrentDisease;

        }

        private void saveButton_Click(object sender, EventArgs e) {
            try {

                Patient patient = new Patient(completeName.Text, address.Text, district.Text, city.Text, birthDate.Value,
                                            (Sex) sex.SelectedIndex, (Color) color.SelectedIndex, (CivilState) civilState.SelectedIndex, religion.Text, (Scholarship) scholarity.SelectedIndex, profession.Text,
                                            naturality.Text, Decimal.ToDouble(weight.Value), Decimal.ToDouble(height.Value), phoneNumber.Text, email.Text, currentDisease.Text,
                                            associateDisease.Text, pregressDisease.Text, history.Text, habits.Text, diagnosis.Text,
                                            complain.Text, medication.Text, mobility.Text, conscious.Text, skin.Text,  access.Text,
                                            torax.Text, (Ventilation) ventilation.SelectedIndex, (MuscularPattern) pattern.SelectedIndex, (VentilatoryRythm) rhythm.SelectedIndex, abdomen.Text,
                                            signals.Text, symptoms.Text, (ToraxMobility) toraxMobility.SelectedIndex, (PulmonarExpansion) pulmonar.SelectedIndex, Decimal.ToDouble(fr.Value), Decimal.ToDouble(fc.Value),
                                            Decimal.ToDouble(sp02.Value), Decimal.ToDouble(pa.Value), Decimal.ToDouble(temperature.Value),  hearing.Text, (Cough) cough.SelectedIndex, secretion.Text, tonus.Text,
                                            reflexes.Text, strength.Text, sensibility.Text, motor.Text, complementary.Text,
                                            functionalDiagnosis.Text, problem.Text, target.Text, conduct.Text, new List <EvolutionRegister>());
                MainForm.PatientsList.Add(patient);
                List<string> listaNome = MainForm.PatientsList.Select(x => x.CompleteName).ToList();
                MainForm.searchBox.DataSource = listaNome;
            } catch {
                MessageBox.Show("Cadastro de paciente inválido!!!");
                return;
            }

            
            Serialization.WriteToXmlFile<List<Patient>>("Patients.xml", MainForm.PatientsList, false);

            this.Close();
        }

        private void cleanButton_Click(object sender, EventArgs e) {
            completeName.Text = "";
            address.Text = "";
            district.Text = "";
            city.Text = "";
            birthDate.Value = DateTime.Now;
            sex.Text = "";
            color.Text = "";
            civilState.Text = "";
            religion.Text = "";
            scholarity.Text = "";
            profession.Text = "";
            naturality.Text = "";
            weight.Value = 0;
            height.Value = 0;
            phoneNumber.Text = "";
            email.Text = "";
            associateDisease.Text = "";
            pregressDisease.Text = "";
            history.Text = "";
            habits.Text = "";
            diagnosis.Text = "";
            complain.Text = "";
            medication.Text = "";
            mobility.Text = "";
            conscious.Text = "";
            skin.Text = "";
            access.Text = "";
            torax.Text = "";
            ventilation.Text = "";
            pattern.Text = "";
            abdomen.Text = "";
            signals.Text = "";
            symptoms.Text = "";
            toraxMobility.Text = "";
            hearing.Text = "";
            fr.Value = 0;
            fc.Value = 0;
            sp02.Value = 0;
            pa.Value = 0;
            temperature.Value = 0;
            pulmonar.Text = "";
            cough.Text = "";
            secretion.Text = "";
            tonus.Text = "";
            reflexes.Text = "";
            strength.Text = "";
            sensibility.Text = "";
            motor.Text = "";
            complementary.Text = "";
            functionalDiagnosis.Text = "";
            problem.Text = "";
            target.Text = "";
            conduct.Text = "";

        }
    }
}
