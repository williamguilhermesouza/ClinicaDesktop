using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDesktop {
    public enum Sex {
        M,
        F,
    }

    public enum Color {
        Branco,
        Preto,
        Pardo,
    }

    public enum CivilState {
        Solteiro,
        Casado,
        Divorciado,
        UniãoEstável,
    }

    public enum Scholarship {
        Fundamental,
        Médio,
        Superior,
        Pós
    }

    public enum MuscularPattern {
        Apical,
        Diafragmático,
        Misto,
        Paradoxal
    }

    public enum VentilatoryRythm {
        Regular,
        Irregular
    }

    public enum ToraxMobility {
        Preservada,
        Diminuida
    }

    public enum PulmonarExpansion {
        Preservada,
        Diminuida
    }

    public enum Cough {
        Ausente,
        Improdutiva,
        Produtiva,
        Eficaz,
        Ineficaz
    }

    public enum Ventilation {
        Nasal,
        Oral,
        Traqueostomia
    }

    public abstract class FormsList {
        public static string[] religionList = { "Católico", "Evangélico", "Espiríta", "Budista" };
        public static string[] toraxFormatList = { "Normal", "Tonel", "Carinatum", "Scavatum", "Sinus" };
        public static string[] oxigenationList = {"Ar ambiente"};
        public static string[] signalsList = { "Tiragem", "Batimento da Asa do Nariz", "Cianose" };
        public static string[] symptomsList = { "Dispnéia", "Tontura", "Dor" };
        public static string[] secretionList = { "Mucóide", "Mucopurulenta", "Purulenta", "Hemática" };

    }

    
}
