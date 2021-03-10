
namespace ClinicaDesktop {
    partial class ListPatients {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPatients));
            this.patientsList = new System.Windows.Forms.ListBox();
            this.register = new System.Windows.Forms.Button();
            this.evolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientsList
            // 
            this.patientsList.FormattingEnabled = true;
            this.patientsList.Location = new System.Drawing.Point(54, 23);
            this.patientsList.Name = "patientsList";
            this.patientsList.Size = new System.Drawing.Size(436, 264);
            this.patientsList.TabIndex = 0;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(112, 328);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 1;
            this.register.Text = "Cadastro";
            this.register.UseVisualStyleBackColor = true;
            // 
            // evolution
            // 
            this.evolution.Location = new System.Drawing.Point(328, 328);
            this.evolution.Name = "evolution";
            this.evolution.Size = new System.Drawing.Size(75, 23);
            this.evolution.TabIndex = 2;
            this.evolution.Text = "Evolução";
            this.evolution.UseVisualStyleBackColor = true;
            // 
            // ListPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 399);
            this.Controls.Add(this.evolution);
            this.Controls.Add(this.register);
            this.Controls.Add(this.patientsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListPatients";
            this.Text = "Lista de Pacientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox patientsList;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button evolution;
    }
}