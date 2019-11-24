using Reciclaje.ParteProlog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reciclaje
{
    public partial class Form1 : Form
    {
        List<Residuo> listaResiduo = new List<Residuo>();
        List<Material> listaMaterial = new List<Material>();
        Residuo residuo;
        Material material;
        int posicion = 0, posicion2 = 0;
        string nombrePrologResiduo = "";
        string nombrePrologMaterial = "";
        string bote;
        string organico = "";

        public Form1()
        {
            InitializeComponent();
            PrologEngine.Start("reciclar.pl");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarListaResiduo();
            LlenarListaMaterial();

            imagenResiduo.Image = Image.FromFile("caja.jpg");
            nombreResiduo.Text = "Caja";
            nombrePrologResiduo = "caja";

            imagenMaterial.Image = Image.FromFile("carton.jpg");
            nombreMaterial.Text = "Carton";
            nombrePrologMaterial = "carton";

            imagenBote.Image = Image.FromFile("reciclaje.jpg");

            imagenOrganica.Image = Image.FromFile("reciclaje.jpg");
        }

        public void LlenarListaResiduo()//Lista de los Residuos
        {
            int i = 0;
            //          1:Nombre de la imagen  2:Texto del Residuo  3:Nombre usado en el archivo pl de Prolog
            residuo = new Residuo("caja.jpg", "Caja", "caja", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("vaso.jpg", "Vaso", "vaso", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("botella.jpg", " Botella", "botella", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("cascara.jpg", "Cascara", "cascara", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("papel_baño.jpg", "Papel de baño", "papel_bano", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("aceite.jpg", "Aceite", "aceite", i);
            listaResiduo.Add(residuo);
            i++;
        }

        public void LlenarListaMaterial()//Lista de los tipos de Materiales
        {
            int i = 0;
            //          1:Nombre de la imagen  2:Texto del Residuo  3:Nombre usado en el archivo pl de Prolog
            material = new Material("carton.jpg", "Carton", "carton", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("plastico.jpg", "Plastico", "plastico", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("vidrio.jpg", "Vidrio", "vidrio", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("resto.jpg", "Resto", "resto", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("sanitario.jpg", "Sanitario", "sanitario", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("liquido.jpg", "Liquido", "liquido", i);
            listaMaterial.Add(material);
            i++;
        }

        public void ReciclarResiduo()
        {
            var resultados = QueryProcessor.ProcessForResults("color(" + nombrePrologResiduo + "," + nombrePrologMaterial + ",Z).");
            
            resultados.ForEach(resultado =>
            {
                bote = resultado["Z"];
            });
        }

        public void EsOrganico()
        {
            var resultados = QueryProcessor.ProcessForResults("clase(W," + nombrePrologResiduo + "," + nombrePrologMaterial + ","+ bote +").");
            resultados.ForEach(resultado =>
            {
                organico = resultado["W"];
            });

            if (organico.Equals("organico"))
            {
                imagenOrganica.Image = Image.FromFile("organico.jpg");
                textoOrganica.Text = "La basura organica es...";
            }
            else if(organico.Equals("inorganico"))
            {
                imagenOrganica.Image = Image.FromFile("inorganico.png");
                textoOrganica.Text = "La basura inorganica es...";
            }
        }

        private void reciclar_Click(object sender, EventArgs e)
        {
            bote = "error";
            ReciclarResiduo();

            if (bote.Equals("azul"))
            {
                imagenBote.Image = Image.FromFile("azul.jpg");
                textoBote.Text = "El contenedor azul en donde se deben introducir todo tipo de papeles o cartón";
                EsOrganico();
            }
            else if (bote.Equals("amarillo"))
            {
                imagenBote.Image = Image.FromFile("amarillo.jpg");
                textoBote.Text = "El contenedor amarillo";
                EsOrganico();
            }
            else if (bote.Equals("verde"))
            {
                imagenBote.Image = Image.FromFile("verde.jpg");
                textoBote.Text = "El contenedor verde";
                EsOrganico();
            }
            else if (bote.Equals("marron"))
            {
                imagenBote.Image = Image.FromFile("marron.jpg");
                textoBote.Text = "El contenedor marron";
                EsOrganico();
            }
            else if (bote.Equals("gris"))
            {
                imagenBote.Image = Image.FromFile("gris.jpg");
                textoBote.Text = "El contenedor gris";
                EsOrganico();
            }
            else if (bote.Equals("punto_limpio"))
            {
                imagenBote.Image = Image.FromFile("punto_limpio.jpg");
                textoBote.Text = "El punto limpio";
                EsOrganico();
            }
            else
            {
                MessageBox.Show("Lo sentimos, tu residuo no puede ser reciclado.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adelante_Click(object sender, EventArgs e)
        {
            if (posicion < listaResiduo.Count-1)
            {
                posicion++;
                foreach (Residuo r in listaResiduo)
                {
                    if(r.Posicion == posicion)
                    {
                        imagenResiduo.Image = Image.FromFile(r.Imagen);
                        nombreResiduo.Text = r.Nombre;
                        nombrePrologResiduo = r.NombreProlog;
                        break;
                    }
                }
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {  
            if (posicion > 0)
            {
                posicion--;
                foreach (Residuo r in listaResiduo)
                {
                    if (r.Posicion == posicion)
                    {
                        imagenResiduo.Image = Image.FromFile(r.Imagen);
                        nombreResiduo.Text = r.Nombre;
                        nombrePrologResiduo = r.NombreProlog;
                        break;
                    }
                }
            }
        }

        private void nombreResiduo_Click(object sender, EventArgs e)
        {

        }

        private void imagenMaterial_Click(object sender, EventArgs e)
        {

        }

        private void adelanteMaterial_Click(object sender, EventArgs e)
        {
            if (posicion2 < listaMaterial.Count - 1)
            {
                posicion2++;
                foreach (Material r in listaMaterial)
                {
                    if (r.Posicion == posicion2)
                    {
                        imagenMaterial.Image = Image.FromFile(r.Imagen);
                        nombreMaterial.Text = r.Nombre;
                        nombrePrologMaterial = r.NombreProlog;
                        break;
                    }
                }
            }
        }

        private void atrasMaterial_Click(object sender, EventArgs e)
        {
            if (posicion2 > 0)
            {
                posicion2--;
                foreach (Material r in listaMaterial)
                {
                    if (r.Posicion == posicion2)
                    {
                        imagenMaterial.Image = Image.FromFile(r.Imagen);
                        nombreMaterial.Text = r.Nombre;
                        nombrePrologMaterial = r.NombreProlog;
                        break;
                    }
                }
            }
        }
    }
}
