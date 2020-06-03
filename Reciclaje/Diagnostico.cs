using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaExperto.ParteProlog;

namespace Reciclaje
{
    public partial class Diagnostico : Form
    {
        List<String> enfermedades;
        String enfermedad;
        int asma = 0, gripe = 0, tuber = 0, bronqui = 0, corona = 0;

        private void dilatacionTorax_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void conclucion_TextChanged(object sender, EventArgs e)
        {

        }

        public Diagnostico()
        {
            InitializeComponent();
            PrologEngine.Start("enfermedades.pl");
            conclucion.Multiline = true;
            conclucion.ScrollBars = ScrollBars.Both;
        }

        public void DetectarEnfermedad(string sintoma)
        {
            var resultados = QueryProcessor.ProcessForResults("enfermedad(X,"+sintoma+").");

            resultados.ForEach(resultado =>
            {
                enfermedad = resultado["X"];

                if (enfermedad.Equals("asma"))
                    enfermedad = "Asma";

                if (enfermedad.Equals("gripe"))
                    enfermedad = "Gripe";

                if (enfermedad.Equals("tuberculosis"))
                    enfermedad = "Tuberculosis";

                if (enfermedad.Equals("bronquitis_aguda"))
                    enfermedad = "Bronquitis aguda";

                if (enfermedad.Equals("coronavirus"))
                    enfermedad = "COVID-19";

                enfermedades.Add(enfermedad);
            });
        }

        public void HacerDiagnostico(String sintoma, String enfermedad)
        {
            foreach (String x in enfermedades)
            {
                conclucion.Text = conclucion.Text + "Por " + sintoma + " usted puede tener " + x + "\r\n" + "\r\n";
            }

            enfermedades = new List<String>();
        }
        private void examinar_Click(object sender, EventArgs e)
        {
            enfermedades = new List<String>();

            conclucion.Text = "";

            if (tosSangre.Checked == true)
            {
                DetectarEnfermedad("tos_con_sangre");

                HacerDiagnostico("tos con sangre", enfermedad);
            }

            if (dificultadRespirar.Checked == true)
            {
                DetectarEnfermedad("dificultad_para_respirar");

                HacerDiagnostico("dificuldad para respirar", enfermedad);

            }

            if (fiebre.Checked == true)
            {
                DetectarEnfermedad("fiebre");

                HacerDiagnostico("fiebre", enfermedad);
            }

            if (dilatacionTorax.Checked == true)
            {
                DetectarEnfermedad("dilatacion_al_torax");

                HacerDiagnostico("dilatación de tórax", enfermedad);
            }

            if (tosFlema.Checked == true)
            {
                DetectarEnfermedad("tos_con_flema");

                HacerDiagnostico("tos con flema", enfermedad);
            }

            if (escalofrios.Checked == true)
            {
                DetectarEnfermedad("escalofrios");

                HacerDiagnostico("escalofrios", enfermedad);
            }

            if(dolorCabeza.Checked == true)
            {
                DetectarEnfermedad("dolor_de_cabeza");

                HacerDiagnostico("dolor de cabeza", enfermedad);
            }

            if(dolorGarganta.Checked == true)
            {
                DetectarEnfermedad("dolor_de_garganta");

                HacerDiagnostico("dolor de garganta", enfermedad);
            }

            if(dolorPecho.Checked == true)
            {
                DetectarEnfermedad("dolor_de_pecho");

                HacerDiagnostico("dolor de pecho", enfermedad);
            }

            if(perdidaApetito.Checked == true)
            {
                DetectarEnfermedad("perdida_de_apetito");

                HacerDiagnostico("perdida de apetito", enfermedad);
            }

            if(dolorCuerpo.Checked == true)
            {
                DetectarEnfermedad("dolor_de_cuerpo");

                HacerDiagnostico("dolor de cuerpo", enfermedad);
            }

            if(inflamacionCuello.Checked == true)
            {
                DetectarEnfermedad("inflamacion_del_cuello");

                HacerDiagnostico("inflamación de cuello", enfermedad);
            }

            if(vomito.Checked == true)
            {
                DetectarEnfermedad("vomito");

                HacerDiagnostico("vomito", enfermedad);
            }

            if(insuficienciaCardiaca.Checked == true)
            {
                DetectarEnfermedad("insuficiencia_cardiaca");

                HacerDiagnostico("insuficiencia cardíaca", enfermedad);
            }

            if(tosSeca.Checked == true)
            {
                DetectarEnfermedad("tos_seca");

                HacerDiagnostico("tos seca", enfermedad);
            }

            if(secrecionNasal.Checked == true)
            {
                DetectarEnfermedad("secrecion_nasal");

                HacerDiagnostico("secreción nasal", enfermedad);
            }

            conclucion.Text = conclucion.Text + "Tome precauciones y cuídese";
        }
    }
}
