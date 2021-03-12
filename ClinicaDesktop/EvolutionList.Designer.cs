
namespace ClinicaDesktop {
    partial class EvolutionList {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvolutionList));
            this.evolutions = new System.Windows.Forms.ListBox();
            this.open = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // evolutions
            // 
            this.evolutions.FormattingEnabled = true;
            this.evolutions.Location = new System.Drawing.Point(41, 22);
            this.evolutions.Name = "evolutions";
            this.evolutions.Size = new System.Drawing.Size(389, 199);
            this.evolutions.TabIndex = 0;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(80, 270);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(109, 23);
            this.open.TabIndex = 1;
            this.open.Text = "Abrir Evolução";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.button1_Click);
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(270, 270);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(109, 23);
            this.novo.TabIndex = 2;
            this.novo.Text = "Nova Evolução";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.button2_Click);
            // 
            // EvolutionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 339);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.open);
            this.Controls.Add(this.evolutions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(494, 378);
            this.MinimumSize = new System.Drawing.Size(494, 378);
            this.Name = "EvolutionList";
            this.Text = "EvolutionList";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox evolutions;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button novo;
    }
}